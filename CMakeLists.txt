cmake_minimum_required(VERSION 3.24)
project(SharpAndreas LANGUAGES CXX)
if(NOT MSVC OR NOT CMAKE_SIZEOF_VOID_P EQUAL 4)
  message(FATAL_ERROR "Use MSVC with -A Win32")
endif()
set(PLUGIN_SDK "D:/plugin-sdk" CACHE PATH "Plugin SDK checkout")
set(DOTNET_HOST_PACK "" CACHE PATH "win-x86 native host pack directory")
if(NOT EXISTS "${DOTNET_HOST_PACK}/nethost.h")
  message(FATAL_ERROR "Set DOTNET_HOST_PACK to the win-x86 native host pack")
endif()
add_library(SharpAndreas SHARED native/Loader.cpp native/ScmBridge.cpp native/TaskBridge.cpp native/SdkBindings.g.cpp native/RuntimeServices.cpp native/WorldBridge.cpp native/PathBridge.cpp native/HudBridge.cpp native/ServicesBridge.cpp
  "${PLUGIN_SDK}/shared/GameVersion.cpp"
  "${PLUGIN_SDK}/shared/Patch.cpp"
  "${PLUGIN_SDK}/shared/DynAddress.cpp"
  "${PLUGIN_SDK}/hooking/Hooking.Patterns.cpp")
set_target_properties(SharpAndreas PROPERTIES SUFFIX ".asi")
file(GLOB SDK_IMPLEMENTATIONS CONFIGURE_DEPENDS "${PLUGIN_SDK}/plugin_sa/game_sa/*.cpp" "${PLUGIN_SDK}/shared/game/*.cpp")
add_library(PluginSdk STATIC ${SDK_IMPLEMENTATIONS})
target_compile_options(PluginSdk PRIVATE /MP4 /Gy)
set_source_files_properties("${PLUGIN_SDK}/plugin_sa/game_sa/CRoadBlocks.cpp" PROPERTIES COMPILE_OPTIONS "/FI${CMAKE_CURRENT_SOURCE_DIR}/native/SdkCompatibility.h")
target_link_libraries(SharpAndreas PRIVATE PluginSdk "${PLUGIN_SDK}/shared/bass/bass.lib" "${PLUGIN_SDK}/shared/dxsdk/d3dx9.lib")
add_executable(HostCheck native/Loader.cpp native/ScmBridge.cpp native/TaskBridge.cpp native/SdkCheck.cpp native/RuntimeServices.cpp native/WorldBridge.cpp native/PathBridge.cpp native/HudBridge.cpp native/ServicesBridge.cpp)
target_sources(HostCheck PRIVATE "${PLUGIN_SDK}/plugin_sa/game_sa/CTask.cpp" "${PLUGIN_SDK}/plugin_sa/game_sa/CTaskSimple.cpp" "${PLUGIN_SDK}/plugin_sa/game_sa/CTaskComplex.cpp" "${PLUGIN_SDK}/shared/DynAddress.cpp")
target_compile_definitions(HostCheck PRIVATE HOST_CHECK)
foreach(t SharpAndreas HostCheck PluginSdk)
  target_compile_features(${t} PRIVATE cxx_std_23)
  target_compile_options(${t} PRIVATE /bigobj)
  target_compile_definitions(${t} PRIVATE NETHOST_USE_AS_STATIC GTASA RW WIN32_LEAN_AND_MEAN NOMINMAX _CRT_SECURE_NO_WARNINGS)
  target_include_directories(${t} PRIVATE "${PLUGIN_SDK}/shared" "${PLUGIN_SDK}/shared/game" "${PLUGIN_SDK}/shared/dxsdk" "${PLUGIN_SDK}/plugin_sa/game_sa" "${PLUGIN_SDK}/plugin_sa/game_sa/enums" "${PLUGIN_SDK}/plugin_sa/game_sa/rw" "${DOTNET_HOST_PACK}")
  target_link_libraries(${t} PRIVATE "${DOTNET_HOST_PACK}/libnethost.lib" user32 version)
  set_property(TARGET ${t} PROPERTY MSVC_RUNTIME_LIBRARY "MultiThreaded$<$<CONFIG:Debug>:Debug>")
endforeach()


