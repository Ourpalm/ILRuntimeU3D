#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineMeshRendererWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.MeshRenderer);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 6, 5);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "additionalVertexStreams", _g_get_additionalVertexStreams);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enlightenVertexStream", _g_get_enlightenVertexStream);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "subMeshStartIndex", _g_get_subMeshStartIndex);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleInLightmap", _g_get_scaleInLightmap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "receiveGI", _g_get_receiveGI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stitchLightmapSeams", _g_get_stitchLightmapSeams);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "additionalVertexStreams", _s_set_additionalVertexStreams);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enlightenVertexStream", _s_set_enlightenVertexStream);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleInLightmap", _s_set_scaleInLightmap);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "receiveGI", _s_set_receiveGI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stitchLightmapSeams", _s_set_stitchLightmapSeams);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.MeshRenderer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MeshRenderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_additionalVertexStreams(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.additionalVertexStreams);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enlightenVertexStream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.enlightenVertexStream);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_subMeshStartIndex(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.subMeshStartIndex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleInLightmap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleInLightmap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_receiveGI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.receiveGI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stitchLightmapSeams(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.stitchLightmapSeams);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_additionalVertexStreams(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.additionalVertexStreams = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enlightenVertexStream(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enlightenVertexStream = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleInLightmap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleInLightmap = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_receiveGI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.ReceiveGI gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.receiveGI = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stitchLightmapSeams(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MeshRenderer gen_to_be_invoked = (UnityEngine.MeshRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stitchLightmapSeams = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
