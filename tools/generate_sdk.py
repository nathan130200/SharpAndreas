"""Generate typed memory views and normalized C ABI method thunks from x86 clang metadata."""
import json,re,hashlib
from pathlib import Path
root=Path(__file__).resolve().parents[1]
ast=json.loads((root/'build/sdk-ast.json').read_text(encoding='utf8'))
defs=json.loads((root/'build/sdk-definitions.json').read_text(encoding='utf8'))
sdk=Path(ast['sdk'])
def valid(n): return bool(re.fullmatch(r'[A-Za-z_]\w*(?:::[A-Za-z_]\w*)*',n))
def ident(n): return re.sub(r'\W','_',n.replace('::','__'))
def relevant(r):
    f=r['file'].replace('\\','/').lower()
    return ('/plugin_sa/game_sa/' in f or '/shared/game/' in f) and valid(r['name']) and r['size']>0 and not r['name'].startswith(('plugin::','injector::','safetyhook::','std::'))
records={n:r for n,r in ast['records'].items() if relevant(r)}
enums={n:e for n,e in ast['enums'].items() if valid(n) and not n.startswith(('plugin::','injector::','safetyhook::'))}
primitive={'void':'void','bool':'bool','char':'sbyte','signed char':'sbyte','unsigned char':'byte','short':'short','short int':'short','unsigned short':'ushort','unsigned short int':'ushort','int':'int','unsigned int':'uint','long':'int','long int':'int','unsigned long':'uint','unsigned long int':'uint','long long':'long','long long int':'long','unsigned long long':'ulong','unsigned long long int':'ulong','float':'float','double':'double','wchar_t':'ushort','char16_t':'ushort','char32_t':'uint'}
primitive['long double']='double'
cppscalar={'void':'void','bool':'int32_t','sbyte':'int8_t','byte':'uint8_t','short':'int16_t','ushort':'uint16_t','int':'int32_t','uint':'uint32_t','long':'int64_t','ulong':'uint64_t','float':'float','double':'double'}
def clean(n): return re.sub(r'\b(const|volatile|struct|class|enum)\b','',n).strip()
callbacks={}
extra_types={}
def scan(t):
    if not isinstance(t,dict):return
    if 'kind' in t and 'canonical' in t:
        n=clean(t['canonical'])
        if 'resolved' not in t and t['kind'] in ('RECORD','ELABORATED') and n not in records and n not in enums and n not in primitive and not n.startswith(('std::','plugin::','injector::','safetyhook::')):
            extra_types.setdefault(n,{'name':n,'file':'dependent type','size':max(0,t['size']),'members':t.get('fields',[]),'bases':[]})
            if t.get('fields'):extra_types[n]['members']=t['fields']
        if t['kind']=='FUNCTIONPROTO':callbacks.setdefault(t['canonical'],t)
    for value in t.values():
        if isinstance(value,dict):scan(value)
        elif isinstance(value,list):
            for item in value:
                if isinstance(item,dict):scan(item)
for r in list(records.values()):
    for member in r['members']:scan(member)
for f in defs['functions']:
    if f['owner'] in records:scan(f)
records.update(extra_types)
def managedname(n):
    plain=ident(n)
    return plain if valid(n) else plain[:70]+'_'+hashlib.sha256(n.encode()).hexdigest()[:10]
recordnames={n:managedname(n) for n in records}
def cbname(t):return 'Callback_'+hashlib.sha256(t['canonical'].encode()).hexdigest()[:12]
def desc(t):
    if 'resolved' in t:return desc(t['resolved'])
    k=t['kind']; n=clean(t['canonical']); d=t.get('declaration','')
    if d in enums:return ('enum',ident(d),d)
    if n in primitive:return ('scalar',primitive[n],n)
    if k=='FUNCTIONPROTO':return ('function','NativeFunctionPointer<'+cbname(t)+'>',t['name'])
    if n in records:return ('record',recordnames[n],n)
    if d in records:return ('record',recordnames[d],d)
    if k in ('LVALUEREFERENCE','RVALUEREFERENCE','POINTER'):
        p=t['pointee']
        if p['kind']=='FUNCTIONPROTO':return ('function','NativeFunctionPointer<'+cbname(p)+'>',p['name'])
        inner=desc(p)
        if inner[0]=='function':return inner
        if inner[0]=='record': return ('object_ref' if k!='POINTER' else 'object_ptr',inner[1],p['name'])
        if inner[0] in ('scalar','enum') and inner[1]!='void':return ('pointer','NativePointer<'+inner[1]+'>',p['name'])
        if inner[0] in ('array','object_array'):return inner
        return ('pointer','NativePointer<IntPtr>',p['name'])
    if k=='CONSTANTARRAY':
        inner=desc(t['element']); count=t['count']
        if inner[0]=='record':return ('object_array',f'NativeObjectArray<{inner[1]}>',count,t['element']['size'])
        if inner[0] in ('scalar','enum'):return ('array',f'NativeArray<{inner[1]}>',count)
        if inner[0] in ('object_ptr','object_ref','pointer','function'):return ('array','NativeArray<IntPtr>',count)
        if inner[0]=='array':return ('array',inner[1],count*inner[2])
    if n.startswith('std::array<'):
        match=re.fullmatch(r'std::array<(.+),\s*(\d+)>',n)
        if match:
            element=match.group(1);count=int(match.group(2))
            if element in records:return ('object_array','NativeObjectArray<'+recordnames[element]+'>',count,records[element]['size'])
            if element in primitive:return ('array','NativeArray<'+primitive[element]+'>',count)
    raise ValueError('unsupported type '+t['name'])
def transport(d): return ('int' if d[0]=='enum' or d[1]=='bool' else d[1]) if d[0] in ('scalar','enum') else 'IntPtr'
def cpptransport(d):return cppscalar[transport(d)] if transport(d)!='IntPtr' else 'void*'
def csexpr(d,n):
    if d[0]=='enum':return '(int)'+n
    if d[0]=='scalar':return '('+n+' ? 1 : 0)' if d[1]=='bool' else n
    if d[0]=='object_ptr':return n+'?.Pointer ?? IntPtr.Zero'
    return n+'.Pointer'
def cpparg(t,n):
    if 'resolved' in t:return cpparg(t['resolved'],n)
    k=t['kind']
    if k in ('LVALUEREFERENCE','RVALUEREFERENCE'):return '*reinterpret_cast<std::add_pointer_t<std::remove_reference_t<'+cpptype(t['canonical'])+'>> >('+n+')'
    d=desc(t)
    if d[0]=='record':return '*reinterpret_cast<std::add_pointer_t<'+cpptype(t['canonical'])+'> >('+n+')'
    if k=='POINTER':return 'reinterpret_cast<'+cpptype(t['canonical'])+'>('+n+')'
    return 'static_cast<'+cpptype(t['canonical'])+'>('+n+')'
def cpptype(name):
    convention='__stdcall' if 'stdcall' in name else '__fastcall' if 'fastcall' in name else ''
    name=re.sub(r'\s*__attribute__\(\(\w+\)\)','',name)
    if convention:name=name.replace('(*)','('+convention+' *)').replace('(&)','('+convention+' &)')
    return name
def csresult(d,n):
    if d[0]=='scalar':return n+' != 0' if d[1]=='bool' else n
    if d[0]=='enum':return '('+d[1]+')'+n
    if d[0]=='object_ptr':return n+' == IntPtr.Zero ? null : new '+d[1]+'('+n+')'
    if d[0] in ('object_ref','record','pointer','function'):return 'new '+d[1]+'('+n+')'
    if d[0]=='array':return 'new '+d[1]+'('+n+','+str(d[2])+')'
    raise ValueError('unsupported return '+str(d))
def publictype(d):return d[1]+('?' if d[0]=='object_ptr' else '')

sources='\n'.join(p.read_text(errors='replace') for p in (sdk/'plugin_sa/game_sa').glob('*.cpp'))
addresses={m.group(1):m.group(2) for m in re.finditer(r'\b(?:g?addrof)\(([^)]+)\)\s*=\s*(?:GLOBAL_)?ADDRESS_BY_VERSION\(\s*(0x[0-9A-Fa-f]+)',sources)}
definitions={f['usr']:f for f in ast['functions']+defs['functions']}
variables={v['name']:v for v in defs['variables']}
skipped=[];excluded=[]; native=[]; table=[]; bindings=[]; methods={n:[] for n in records}; properties={n:[] for n in records}
index=0; checkids={}
for owner,r in records.items():
    signatures=set()
    for m in r['members']:
        if m['kind']!='method' or not m['public']:continue
        f=definitions.get(m.get('usr',''))
        if not f:
            if Path(r['file']).is_file() and 'PLUGIN_NO_DEFAULT_CONSTRUCTION('+owner.split('::')[-1]+')' in Path(r['file']).read_text(errors='replace') and (m['constructor'] or m['destructor'] or m['name']=='operator='):
                excluded.append({'member':owner+'::'+m['display'],'reason':'explicitly deleted by Plugin-SDK'});continue
            skipped.append({'member':owner+'::'+m['display'],'reason':'no callable source definition'});continue
        try:
            args=[desc(p['type']) for p in f['args']]
            ret=('scalar','void','void') if f['constructor'] or f['destructor'] else desc(f['return'])
            if ret[0]=='object_array':raise ValueError('array return requires explicit binding')
            code=f['code']; addr=None; vslot=None
            match=re.search(r'GetVMT\(this,\s*(\d+)\)',code)
            if match:vslot=int(match.group(1))
            else:
                match=re.search(r'Call\w*\s*<[^;{}]*?\b(0x[0-9A-Fa-f]{4,})',code) or re.search(r'(0x[0-9A-Fa-f]{4,})\s*\)\s*\(',code)
                if match:addr=match.group(1)
                else:addr=addresses.get(f['qualified'])
            method='InitializeAt' if f['constructor'] else 'DestroyNative' if f['destructor'] else ident(m['name'])
            if f['name'].startswith('operator'):
                method={'operator new':'AllocateNative','operator delete':'FreeNative','operator=':'AssignNative','operator+':'AddNative','operator-':'SubtractNative','operator*':'MultiplyNative','operator/':'DivideNative','operator[]':'ElementNative','operator+=':'AddAssignNative','operator-=':'SubtractAssignNative','operator*=':'MultiplyAssignNative','operator/=':'DivideAssignNative'}.get(f['name'],'Operator_'+ident(f['name']))
            if method==ident(owner):method+='Method'
            signature=method+'('+','.join(publictype(d) for d in args)+')'
            if signature in signatures:method+='__'+hashlib.sha256(f['usr'].encode()).hexdigest()[:8]
            signatures.add(signature)
            index+=1; name='Sdk_'+str(index); static=f['static']; out=ret[0]=='record'
            if f['qualified']=='CClock::GetGameClockMinutesUntil':checkids['CHECK_CLOCK_MINUTES']=index
            if f['qualified'] in {'CPools::GetPed','CPools::GetVehicle','CPools::GetPedRef','CPools::GetVehicleRef','CGangs::SetGangWeapons'}:checkids['CHECK_'+f['qualified'].replace('::','_').upper()]=index
            nativeargs=[] if static else ['void* self']
            nativeargs += [cpptransport(d)+' a'+str(i) for i,d in enumerate(args)]
            if out:nativeargs+=['void* output']
            target='reinterpret_cast<void***>(self)[0]['+str(vslot)+']' if vslot is not None else (addr or 'nullptr')
            actualargs=[] if static else ['reinterpret_cast<'+owner+'*>(self)']
            actualargs += [cpparg(p['type'],'a'+str(i)) for i,p in enumerate(f['args'])]
            fnargs=[] if static else [owner+'*']
            fnargs += [cpptype(p['type']['canonical']) for p in f['args']]
            actualret='void' if f['constructor'] or f['destructor'] else cpptype(f['return']['canonical'])
            call='reinterpret_cast<Fn>('+target+')('+','.join(actualargs)+')'
            body='using Fn = '+actualret+'('+('__cdecl' if static else '__thiscall')+'*)('+','.join(fnargs)+');' if addr or vslot is not None else ''
            if not addr and vslot is None:
                invoke_args=','.join(actualargs if static else actualargs[1:])
                if f['constructor']:call='::new(self) '+owner+'('+invoke_args+')'
                elif f['destructor']:call='reinterpret_cast<'+owner+'*>(self)->'+f['name']+'()'
                else:call=(owner+'::' if static else 'reinterpret_cast<'+owner+'*>(self)->')+f['name']+'('+invoke_args+')'
            if out:body+='static_assert(std::is_trivially_destructible_v<'+actualret+'>); auto value='+call+'; std::memcpy(output,&value,sizeof(value));'
            elif ret[1]=='void':body+=call+';'
            elif f['return']['kind'] in ('LVALUEREFERENCE','RVALUEREFERENCE'):body+='return const_cast<void*>(static_cast<const void*>(&'+call+'));'
            elif ret[0] in ('object_ptr','pointer','function'):body+='return const_cast<void*>(reinterpret_cast<const void*>('+call+'));'
            else:body+='return static_cast<'+cpptransport(ret)+'>('+call+');'
            native.append(('void' if out else cpptransport(ret))+' __cdecl '+name+'('+','.join(nativeargs)+') {'+body+'}')
            table.append('(void*)&'+name)
            dargs=[] if static else ['IntPtr self']
            dargs += [transport(d)+' a'+str(i) for i,d in enumerate(args)]
            if out:dargs+=['IntPtr output']
            bindings.append('[UnmanagedFunctionPointer(CallingConvention.Cdecl)] internal delegate '+('void' if out else transport(ret))+' D'+str(index)+'('+','.join(dargs)+');')
            publicargs=[publictype(d)+' @'+(p['name'] or 'arg'+str(i)) for i,(d,p) in enumerate(zip(args,f['args']))]
            invoke=[] if static else ['Pointer']
            invoke += [csexpr(d,'@'+(p['name'] or 'arg'+str(i))) for i,(d,p) in enumerate(zip(args,f['args']))]
            csbody='Game.CheckThread(); '
            if out:
                csbody+='var result=NativeObject.AllocateStorage<'+ret[1]+' >('+str(f['return']['size'])+'); try { '
                invoke+=['result.Pointer'];csbody+='SdkBindings.Get<GeneratedDelegates.D'+str(index)+' >('+str(index)+')('+','.join(invoke)+'); return result; } catch { result.Dispose(); throw; }'
            else:
                inv='SdkBindings.Get<GeneratedDelegates.D'+str(index)+' >('+str(index)+')('+','.join(invoke)+')'
                csbody+=(inv+';') if ret[1]=='void' else ('var __sdkResult='+inv+'; return '+csresult(ret,'__sdkResult')+';')
            methods[owner].append('    public '+('static ' if static else '')+publictype(ret)+' @'+method+'('+','.join(publicargs)+') { '+csbody+' }')
        except ValueError as ex:skipped.append({'member':owner+'::'+m['display'],'reason':str(ex)})

def field_access(t,address):
    d=desc(t); get=None;set=None
    if d[0] in ('scalar','enum'):
        get='SdkMemory.Read<'+d[1]+' >('+address+')';set='SdkMemory.Write('+address+',value);'
    elif d[0]=='record':
        get='new '+d[1]+'('+address+')';set='SdkMemory.Copy(value.Pointer,'+address+','+str(t['size'])+');'
    elif d[0] in ('object_ptr','object_ref'):
        get=csresult(d,'SdkMemory.Read<IntPtr>('+address+')');set='SdkMemory.Write('+address+',value?.Pointer ?? IntPtr.Zero);'
    elif d[0] in ('pointer','function'):get='new '+d[1]+'(SdkMemory.Read<IntPtr>('+address+'))';set='SdkMemory.Write('+address+',value.Pointer);'
    elif d[0] in ('array','object_array'):
        get='new '+d[1]+'('+address+','+str(d[2])+(','+str(d[3]) if d[0]=='object_array' else '')+')'
    return d,get,set

property_names={}
def property_name(native):
    text=re.sub(r'^(?:m_|ms_|s_|g_)','',native)
    text=re.sub(r'^(?:avec|asz|ap|an|af|ab|av|vec|v|mat|quat|sz|dw|uc|us|rw|n|f|b|p|a|u|c|w)(?=[A-Z_])','',text)
    words=re.sub(r'([a-z0-9])([A-Z])',r'\1 \2',text).replace('_',' ').split()
    names={'Posn':'Position','Pos':'Position','Rotn':'Rotation','Rot':'Rotation','Vel':'Velocity','Dir':'Direction','Dist':'Distance','Coords':'Coordinates','Coord':'Coordinate','Anim':'Animation','Vars':'Variables','Var':'Variable','Num':'Count','Idx':'Index','Col':'Collision','Colour':'Color','Obj':'Object','Objs':'Objects','Rw':'RenderWare','Ptr':'Pointer','Ped':'Ped','Posns':'Positions'}
    names={key.lower():value for key,value in names.items()}
    result=''.join(names.get(word.lower(),word[:1].upper()+word[1:]) for word in words) or 'Value'
    return ident(result)
for owner,r in records.items():
    used={ident(owner), 'Pointer','NativeSize','Dispose'}
    used.update(ident(m['name']) for m in r['members'] if m['kind']=='method')
    for m in r['members']:
        if m['kind'] not in ('field','static_field') or not m['public'] or not m['name']:continue
        try:
            t=m['type'];static=m['kind']=='static_field'
            if static:
                var=variables.get(owner+'::'+m['name'])
                if not var:raise ValueError('SDK declares static storage but supplies no definition/address')
                match=(re.search(r'GLOBAL_ADDRESS_BY_VERSION\(\s*(0x[0-9A-Fa-f]+)',var['code']) or re.search(r'\)\s*(0x[0-9A-Fa-f]+)',var['code'])) if var else None
                if match:address='new IntPtr('+match.group(1)+')'
                else:
                    index+=1;name='Sdk_'+str(index)
                    native.append('void* __cdecl '+name+'() { return const_cast<void*>(static_cast<const void*>(&'+owner+'::'+m['name']+')); }')
                    table.append('(void*)&'+name)
                    address='SdkBindings.Address('+str(index)+')'
                if t['kind']=='LVALUEREFERENCE':t=t['pointee']
            else:
                if m['offset_bits']<0:raise ValueError('unknown field layout')
                address='Pointer+'+str(m['offset_bits']//8)
            if m.get('bit_width'):
                d=desc(t);width=m['bit_width'];offset=m['offset_bits']
                signed=d[1] in ('sbyte','short','int','long') or d[0]=='enum' and primitive.get(clean(enums[d[2]]['underlying']['canonical'])) in ('sbyte','short','int','long')
                val='SdkMemory.'+('ReadSignedBits' if signed else 'ReadBits')+'(Pointer,'+str(offset)+','+str(width)+')'
                get=val+' != 0' if d[1]=='bool' else '('+d[1]+')'+val
                set='SdkMemory.WriteBits(Pointer,'+str(offset)+','+str(width)+','+('(value ? 1UL : 0UL)' if d[1]=='bool' else 'unchecked((ulong)value)')+');'
            else:
                resolved=t
                while 'resolved' in resolved:resolved=resolved['resolved']
                direct_pointer=static and resolved['kind']=='POINTER' and match and not var['code'].split('=',1)[-1].strip().startswith('*')
                if direct_pointer:
                    d=desc(t);get=csresult(d,address);set=None
                else:d,get,set=field_access(t,address)
                if static and m['type']['kind']!='LVALUEREFERENCE':set=None
            if 'const ' in t['name']:set=None
            managed_property=property_name(m['name'])
            if managed_property in used:managed_property+='Value'
            suffix=2;candidate=managed_property
            while candidate in used:candidate=managed_property+str(suffix);suffix+=1
            managed_property=candidate;used.add(managed_property)
            property_names[owner+'::'+m['name']]=managed_property
            properties[owner].append('    [NativeMember("'+m['name']+'")]\n    public '+('static ' if static else '')+publictype(d)+' @'+managed_property+' { get => '+get+';'+(' set { '+set+' }' if set else '')+' }')
        except ValueError as ex:skipped.append({'member':owner+'::'+m['name'],'reason':str(ex)})

managed=root/'managed/SharpAndreas.Api/GeneratedSdk';managed.mkdir(exist_ok=True)
assert managed.resolve().is_relative_to(root.resolve())
for old in managed.glob('*.g.cs'):old.unlink()
for name,r in records.items():
    base=clean(r['bases'][0]['name']) if r['bases'] else ''
    base=recordnames[base] if base in records else 'NativeObject'
    cs='// Generated from installed Plugin-SDK; borrowed pointers require valid engine lifetimes.\n#nullable enable\n#pragma warning disable CS0108, CS0114\nnamespace SharpAndreas.Sdk;\npublic class '+recordnames[name]+' : '+base+'\n{\n'
    cs+='    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]\n    public const int NativeSize='+str(r['size'])+';\n    public '+recordnames[name]+'(System.IntPtr pointer) : base(pointer) {}\n'
    cs+='\n'.join(properties[name]+methods[name])+'\n}\n'
    (managed/(recordnames[name]+'.g.cs')).write_text(cs)
cs='// Generated from Plugin-SDK enum values.\nnamespace SharpAndreas.Sdk;\n'
for name,e in enums.items():
    underlying=primitive.get(clean(e['underlying']['canonical']),'int')
    if underlying=='bool':underlying='int'
    cs+='public enum '+ident(name)+' : '+underlying+'\n{\n'
    cs+=''.join('    @'+ident(k)+' = unchecked(('+underlying+')'+str(v)+'),\n' for k,v in e['values'].items())+'}\n'
(managed/'Enums.g.cs').write_text(cs)
(managed/'Delegates.g.cs').write_text('using System.Runtime.InteropServices;\nnamespace SharpAndreas.Sdk;\ninternal static class GeneratedDelegates {\n'+'\n'.join(bindings)+'\n}\n')
cs='using System.Runtime.InteropServices;\nnamespace SharpAndreas.Sdk;\n'
for t in callbacks.values():
    def callback_type(ty):
        d=desc(ty)
        if d[0]=='record':raise ValueError('callback uses a by-value C++ record')
        return d[1] if d[0] in ('scalar','enum') else 'IntPtr'
    try:
        if t.get('variadic'):raise ValueError('variadic callback requires an explicit adapter')
        ret=callback_type(t['result']);params=[]
        for i,ty in enumerate(t.get('arguments',[])):
            typ=callback_type(ty)
            params.append(('[MarshalAs(UnmanagedType.I1)] ' if typ=='bool' else '')+typ+' a'+str(i))
        convention='StdCall' if 'stdcall' in t['canonical'] else 'Cdecl'
        cs+='[UnmanagedFunctionPointer(CallingConvention.'+convention+')]\n'+('[return:MarshalAs(UnmanagedType.I1)]\n' if ret=='bool' else '')+'public delegate '+ret+' '+cbname(t)+'('+','.join(params)+');\n'
    except ValueError:cs+='[UnsupportedNativeSignature,UnmanagedFunctionPointer(CallingConvention.Cdecl)] public delegate void '+cbname(t)+'(); // Opaque signature: '+t['canonical']+'\n'
(managed/'Callbacks.g.cs').write_text(cs)
cpp='#include <list>\n#include <type_traits>\n#include <cstring>\n#include <cstdint>\n#include <new>\n#include "SdkBridge.h"\n'
cpp+='\n'.join('#include "'+Path(p).name+'"' for p in ast['headers'])+'\n'
cpp+='#include <cstddef>\n'
for name,r in records.items():
    if not valid(name) or r['size']<=0 or r['file']=='dependent type' or name in {'CShopping::PriceModifier','CShopping::ItemPrice','CShopping::StatModifiers'}:continue
    cpp+='static_assert(sizeof('+name+')=='+str(r['size'])+',"SDK class layout differs from generated C# metadata");\n'
    for member in r['members']:
        if member['kind']=='field' and member['public'] and valid(member['name']) and not member['bit_width'] and member['offset_bits']>=0:
            cpp+='static_assert(offsetof('+name+','+member['name']+')=='+str(member['offset_bits']//8)+',"SDK field offset differs from generated C# metadata");\n'
cpp+='\n'.join(native)+'\nvoid* __cdecl ResolveSdkBinding(int id) {\nstatic void* functions[] = {nullptr,'+','.join(table)+'};\nreturn id>0 && id<static_cast<int>(sizeof(functions)/sizeof(functions[0])) ? functions[id] : nullptr;\n}\n'
(root/'native/SdkBindings.g.cpp').write_text(cpp)
(root/'native/SdkCheckIds.g.h').write_text('\n'.join('#define '+k+' '+str(v) for k,v in checkids.items()))
report={'classes':len(records),'enums':len(enums),'methods':len(native),'fields':sum(map(len,properties.values())),'unbound_members':skipped,'parser_diagnostics':ast['diagnostics']}
report['excluded_members']=excluded
report['property_names']=property_names
(root/'SDK-COVERAGE.json').write_text(json.dumps(report,indent=2))
print({k:v for k,v in report.items() if k not in ('unbound_members','excluded_members','parser_diagnostics','property_names')},'unbound',len(skipped),'SDK-deleted',len(excluded))

