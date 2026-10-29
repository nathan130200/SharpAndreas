"""Extract MSVC x86 declarations/layouts with libclang; generation never guesses layouts."""
import argparse, json, os
from pathlib import Path
from clang import cindex

parser = argparse.ArgumentParser()
parser.add_argument('--sdk', default='D:/plugin-sdk')
parser.add_argument('--output', default='build/sdk-ast.json')
parser.add_argument('--definitions', action='store_true')
parser.add_argument('--msvc', default='C:/Program Files (x86)/Microsoft Visual Studio/2022/BuildTools/VC/Tools/MSVC/14.44.35207/include')
parser.add_argument('--windows-sdk', default='C:/Program Files (x86)/Windows Kits/10/Include/10.0.26100.0')
a = parser.parse_args()
sdk, output = Path(a.sdk).resolve(), Path(a.output).resolve()
output.parent.mkdir(parents=True, exist_ok=True)
headers = sorted((sdk/'plugin_sa/game_sa').glob('*.h'))
inputs = sorted((sdk/'plugin_sa/game_sa').glob('*.cpp')) + sorted((sdk/'shared/game').glob('*.cpp')) if a.definitions else headers
entry = output.with_suffix('.cpp')
entry.write_text('#include "Base.h"\n#undef VALIDATE_OFFSET\n#define VALIDATE_OFFSET(s,m,o) static_assert(__builtin_offsetof(s,m)==o)\n'+'\n'.join('#include "'+p.as_posix()+'"' for p in inputs))
args = ['-x','c++','-std=c++23','-target','i686-pc-windows-msvc','-fms-extensions','-fasm-blocks','-ferror-limit=0','-fms-compatibility-version=19.44','-D_ALLOW_COMPILER_AND_STL_VERSION_MISMATCH','-DGTASA','-DRW','-DNOASM','-D_CRT_SECURE_NO_WARNINGS','-Wno-invalid-token-paste']
for p in [sdk/'shared',sdk/'shared/game',sdk/'shared/dxsdk',sdk/'plugin_sa/game_sa',sdk/'plugin_sa/game_sa/enums',sdk/'plugin_sa/game_sa/rw',Path(a.msvc),*[Path(a.windows_sdk)/x for x in ['ucrt','shared','um','winrt']]]:
    args += ['-I',str(p)]
tu = cindex.Index.create().parse(str(entry), args=args, options=cindex.TranslationUnit.PARSE_DETAILED_PROCESSING_RECORD)
records, enums, functions = {}, {}, []
variables = []
sources = {}
def code(c):
    source = str(c.location.file)
    if source not in sources: sources[source]=Path(source).read_bytes()
    return sources[source][c.extent.start.offset:c.extent.end.offset].decode('utf-8',errors='replace')
def name(c):
    names=[]
    while c and c.kind != cindex.CursorKind.TRANSLATION_UNIT:
        if c.spelling: names.append(c.spelling)
        c=c.semantic_parent
    return '::'.join(reversed(names))
expanded_types=set()
def typeinfo(t):
    result={'name':t.spelling,'kind':t.kind.name,'canonical':t.get_canonical().spelling,'size':t.get_size()}
    if t.kind in (cindex.TypeKind.POINTER,cindex.TypeKind.LVALUEREFERENCE,cindex.TypeKind.RVALUEREFERENCE): result['pointee']=typeinfo(t.get_pointee())
    if t.kind==cindex.TypeKind.CONSTANTARRAY: result.update(element=typeinfo(t.element_type),count=t.element_count)
    d=t.get_declaration()
    if d and d.spelling: result['declaration']=name(d)
    if t.get_canonical().kind != t.kind: result['resolved']=typeinfo(t.get_canonical())
    if t.kind==cindex.TypeKind.FUNCTIONPROTO:
        result['result']=typeinfo(t.get_result()); result['arguments']=[typeinfo(x) for x in t.argument_types()]
        result['variadic']=t.is_function_variadic()
    if t.kind in (cindex.TypeKind.RECORD,cindex.TypeKind.ELABORATED) and d and d.is_definition() and ('<' in t.spelling or '(unnamed' in t.spelling or '(anonymous' in t.spelling) and t.spelling not in expanded_types:
        expanded_types.add(t.spelling)
        result['fields']=[{'kind':'field','name':m.spelling,'type':typeinfo(m.type),'offset_bits':m.get_field_offsetof(),'bit_width':m.get_bitfield_width() if m.is_bitfield() else 0,'public':m.access_specifier==cindex.AccessSpecifier.PUBLIC} for m in d.get_children() if m.kind==cindex.CursorKind.FIELD_DECL]
    return result
def visit(c):
    file=str(Path(str(c.location.file)).resolve()) if c.location.file else ''
    if file and not file.lower().startswith(str(sdk).lower()): return
    if c.kind in (cindex.CursorKind.CLASS_DECL,cindex.CursorKind.STRUCT_DECL,cindex.CursorKind.UNION_DECL) and c.is_definition() and c.spelling and file:
        qualified=name(c)
        if '<' in qualified: return
        members=[]
        for m in c.get_children():
            if m.kind==cindex.CursorKind.FIELD_DECL:
                members.append({'kind':'field','name':m.spelling,'type':typeinfo(m.type),'offset_bits':m.get_field_offsetof(),'bit_width':m.get_bitfield_width() if m.is_bitfield() else 0,'public':m.access_specifier==cindex.AccessSpecifier.PUBLIC})
            elif m.kind==cindex.CursorKind.VAR_DECL:
                members.append({'kind':'static_field','name':m.spelling,'type':typeinfo(m.type),'public':m.access_specifier==cindex.AccessSpecifier.PUBLIC})
            elif m.kind in (cindex.CursorKind.CXX_METHOD,cindex.CursorKind.CONSTRUCTOR,cindex.CursorKind.DESTRUCTOR):
                members.append({'kind':'method','name':m.spelling,'display':m.displayname,'public':m.access_specifier==cindex.AccessSpecifier.PUBLIC,'static':m.is_static_method() if m.kind==cindex.CursorKind.CXX_METHOD else False,'virtual':m.is_virtual_method() if m.kind==cindex.CursorKind.CXX_METHOD else False,'constructor':m.kind==cindex.CursorKind.CONSTRUCTOR,'destructor':m.kind==cindex.CursorKind.DESTRUCTOR,'return':typeinfo(m.result_type),'args':[{'name':p.spelling,'type':typeinfo(p.type)} for p in m.get_arguments()],'file':str(m.location.file),'line':m.location.line,'definition':m.is_definition(),'usr':m.get_usr()})
        records[qualified]={'name':qualified,'file':file,'size':c.type.get_size(),'align':c.type.get_align(),'members':members,'bases':[{'name':m.type.spelling,'public':m.access_specifier==cindex.AccessSpecifier.PUBLIC} for m in c.get_children() if m.kind==cindex.CursorKind.CXX_BASE_SPECIFIER]}
    elif c.kind==cindex.CursorKind.ENUM_DECL and c.is_definition() and c.spelling:
        enums[name(c)]={'name':name(c),'underlying':typeinfo(c.enum_type),'values':{m.spelling:m.enum_value for m in c.get_children() if m.kind==cindex.CursorKind.ENUM_CONSTANT_DECL}}
    elif c.kind in (cindex.CursorKind.CXX_METHOD,cindex.CursorKind.CONSTRUCTOR,cindex.CursorKind.DESTRUCTOR,cindex.CursorKind.FUNCTION_DECL) and c.is_definition() and file:
        functions.append({'name':c.spelling,'qualified':name(c),'owner':name(c.semantic_parent),'static':c.is_static_method() if c.kind==cindex.CursorKind.CXX_METHOD else c.kind==cindex.CursorKind.FUNCTION_DECL,'constructor':c.kind==cindex.CursorKind.CONSTRUCTOR,'destructor':c.kind==cindex.CursorKind.DESTRUCTOR,'args':[{'name':p.spelling,'type':typeinfo(p.type)} for p in c.get_arguments()],'return':typeinfo(c.result_type),'code':code(c),'usr':c.get_usr(),'public':c.access_specifier in (cindex.AccessSpecifier.PUBLIC,cindex.AccessSpecifier.INVALID)})
    elif c.kind==cindex.CursorKind.VAR_DECL and file and c.semantic_parent.kind in (cindex.CursorKind.CLASS_DECL,cindex.CursorKind.STRUCT_DECL) and c.is_definition():
        variables.append({'name':name(c),'type':typeinfo(c.type),'code':code(c)})
    for child in c.get_children(): visit(child)
visit(tu.cursor)
data={'sdk':str(sdk),'headers':[str(p) for p in headers],'diagnostics':[str(d) for d in tu.diagnostics if d.severity>=cindex.Diagnostic.Error],'records':records,'enums':enums,'functions':functions,'variables':variables}
output.write_text(json.dumps(data,indent=2),encoding='utf-8')
print(f'{len(headers)} headers; {len(records)} record types; {len(enums)} enums; {len(data["diagnostics"])} errors -> {output}')
for d in data['diagnostics'][:10]: print(d)

