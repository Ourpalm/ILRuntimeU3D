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
    public class UnityEngineRenderTargetSetupWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.RenderTargetSetup);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 9, 9);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "color", _g_get_color);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mipLevel", _g_get_mipLevel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cubemapFace", _g_get_cubemapFace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthSlice", _g_get_depthSlice);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorLoad", _g_get_colorLoad);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorStore", _g_get_colorStore);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthLoad", _g_get_depthLoad);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthStore", _g_get_depthStore);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "color", _s_set_color);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depth", _s_set_depth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mipLevel", _s_set_mipLevel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cubemapFace", _s_set_cubemapFace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthSlice", _s_set_depthSlice);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colorLoad", _s_set_colorLoad);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "colorStore", _s_set_colorStore);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthLoad", _s_set_depthLoad);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "depthStore", _s_set_depthStore);
            
			
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
				if(LuaAPI.lua_gettop(L) == 9 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5) && translator.Assignable<UnityEngine.Rendering.RenderBufferLoadAction[]>(L, 6) && translator.Assignable<UnityEngine.Rendering.RenderBufferStoreAction[]>(L, 7) && translator.Assignable<UnityEngine.Rendering.RenderBufferLoadAction>(L, 8) && translator.Assignable<UnityEngine.Rendering.RenderBufferStoreAction>(L, 9))
				{
					UnityEngine.RenderBuffer[] _color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					int _mip = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace _face;translator.Get(L, 5, out _face);
					UnityEngine.Rendering.RenderBufferLoadAction[] _colorLoad = (UnityEngine.Rendering.RenderBufferLoadAction[])translator.GetObject(L, 6, typeof(UnityEngine.Rendering.RenderBufferLoadAction[]));
					UnityEngine.Rendering.RenderBufferStoreAction[] _colorStore = (UnityEngine.Rendering.RenderBufferStoreAction[])translator.GetObject(L, 7, typeof(UnityEngine.Rendering.RenderBufferStoreAction[]));
					UnityEngine.Rendering.RenderBufferLoadAction _depthLoad;translator.Get(L, 8, out _depthLoad);
					UnityEngine.Rendering.RenderBufferStoreAction _depthStore;translator.Get(L, 9, out _depthStore);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth, _mip, _face, _colorLoad, _colorStore, _depthLoad, _depthStore);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3))
				{
					UnityEngine.RenderBuffer _color;translator.Get(L, 2, out _color);
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.RenderBuffer _color;translator.Get(L, 2, out _color);
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					int _mipLevel = LuaAPI.xlua_tointeger(L, 4);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth, _mipLevel);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5))
				{
					UnityEngine.RenderBuffer _color;translator.Get(L, 2, out _color);
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					int _mipLevel = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace _face;translator.Get(L, 5, out _face);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth, _mipLevel, _face);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && translator.Assignable<UnityEngine.RenderBuffer>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6))
				{
					UnityEngine.RenderBuffer _color;translator.Get(L, 2, out _color);
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					int _mipLevel = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace _face;translator.Get(L, 5, out _face);
					int _depthSlice = LuaAPI.xlua_tointeger(L, 6);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth, _mipLevel, _face, _depthSlice);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3))
				{
					UnityEngine.RenderBuffer[] _color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.RenderBuffer[] _color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					int _mipLevel = LuaAPI.xlua_tointeger(L, 4);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth, _mipLevel);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.RenderBuffer[]>(L, 2) && translator.Assignable<UnityEngine.RenderBuffer>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.CubemapFace>(L, 5))
				{
					UnityEngine.RenderBuffer[] _color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
					UnityEngine.RenderBuffer _depth;translator.Get(L, 3, out _depth);
					int _mip = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.CubemapFace _face;translator.Get(L, 5, out _face);
					
					var gen_ret = new UnityEngine.RenderTargetSetup(_color, _depth, _mip, _face);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(UnityEngine.RenderTargetSetup));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.RenderTargetSetup constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_color(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.color);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mipLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.mipLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cubemapFace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.cubemapFace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthSlice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.depthSlice);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorLoad(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.colorLoad);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorStore(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.colorStore);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthLoad(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.depthLoad);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthStore(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.depthStore);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_color(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.color = (UnityEngine.RenderBuffer[])translator.GetObject(L, 2, typeof(UnityEngine.RenderBuffer[]));
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                UnityEngine.RenderBuffer gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.depth = gen_value;
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mipLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.mipLevel = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cubemapFace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                UnityEngine.CubemapFace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.cubemapFace = gen_value;
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthSlice(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.depthSlice = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colorLoad(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.colorLoad = (UnityEngine.Rendering.RenderBufferLoadAction[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.RenderBufferLoadAction[]));
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colorStore(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.colorStore = (UnityEngine.Rendering.RenderBufferStoreAction[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.RenderBufferStoreAction[]));
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthLoad(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                UnityEngine.Rendering.RenderBufferLoadAction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.depthLoad = gen_value;
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_depthStore(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.RenderTargetSetup gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                UnityEngine.Rendering.RenderBufferStoreAction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.depthStore = gen_value;
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
