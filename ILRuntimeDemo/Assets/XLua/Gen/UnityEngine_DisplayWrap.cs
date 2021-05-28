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
    public class UnityEngineDisplayWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Display);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 9, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Activate", _m_Activate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParams", _m_SetParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRenderingResolution", _m_SetRenderingResolution);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderingWidth", _g_get_renderingWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderingHeight", _g_get_renderingHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "systemWidth", _g_get_systemWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "systemHeight", _g_get_systemHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "colorBuffer", _g_get_colorBuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "depthBuffer", _g_get_depthBuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "active", _g_get_active);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "requiresBlitToBackbuffer", _g_get_requiresBlitToBackbuffer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "requiresSrgbBlitToBackbuffer", _g_get_requiresSrgbBlitToBackbuffer);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RelativeMouseAt", _m_RelativeMouseAt_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "onDisplaysUpdated", _e_onDisplaysUpdated);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "main", _g_get_main);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "displays", _g_get_displays);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "displays", _s_set_displays);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Display does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Activate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Activate(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _width = LuaAPI.xlua_tointeger(L, 2);
                    int _height = LuaAPI.xlua_tointeger(L, 3);
                    int _refreshRate = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Activate( _width, _height, _refreshRate );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Display.Activate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetParams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _width = LuaAPI.xlua_tointeger(L, 2);
                    int _height = LuaAPI.xlua_tointeger(L, 3);
                    int _x = LuaAPI.xlua_tointeger(L, 4);
                    int _y = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetParams( _width, _height, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRenderingResolution(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _w = LuaAPI.xlua_tointeger(L, 2);
                    int _h = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetRenderingResolution( _w, _h );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RelativeMouseAt_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _inputMouseCoordinates;translator.Get(L, 1, out _inputMouseCoordinates);
                    
                        var gen_ret = UnityEngine.Display.RelativeMouseAt( _inputMouseCoordinates );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderingWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderingWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderingHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderingHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_systemWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.systemWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_systemHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.systemHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colorBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.colorBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depthBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.depthBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_active(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.active);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_requiresBlitToBackbuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.requiresBlitToBackbuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_requiresSrgbBlitToBackbuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Display gen_to_be_invoked = (UnityEngine.Display)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.requiresSrgbBlitToBackbuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_main(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Display.main);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_displays(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Display.displays);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_displays(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    UnityEngine.Display.displays = (UnityEngine.Display[])translator.GetObject(L, 1, typeof(UnityEngine.Display[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_onDisplaysUpdated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                UnityEngine.Display.DisplaysUpdatedDelegate gen_delegate = translator.GetDelegate<UnityEngine.Display.DisplaysUpdatedDelegate>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need UnityEngine.Display.DisplaysUpdatedDelegate!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.Display.onDisplaysUpdated += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.Display.onDisplaysUpdated -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Display.onDisplaysUpdated!");
        }
        
    }
}
