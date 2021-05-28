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
    public class UnityEngineUIGraphicRegistryWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.GraphicRegistry);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterGraphicForCanvas", _m_RegisterGraphicForCanvas_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterRaycastGraphicForCanvas", _m_RegisterRaycastGraphicForCanvas_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnregisterGraphicForCanvas", _m_UnregisterGraphicForCanvas_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnregisterRaycastGraphicForCanvas", _m_UnregisterRaycastGraphicForCanvas_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGraphicsForCanvas", _m_GetGraphicsForCanvas_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRaycastableGraphicsForCanvas", _m_GetRaycastableGraphicsForCanvas_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "instance", _g_get_instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.GraphicRegistry does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterGraphicForCanvas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Canvas _c = (UnityEngine.Canvas)translator.GetObject(L, 1, typeof(UnityEngine.Canvas));
                    UnityEngine.UI.Graphic _graphic = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
                    
                    UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas( _c, _graphic );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterRaycastGraphicForCanvas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Canvas _c = (UnityEngine.Canvas)translator.GetObject(L, 1, typeof(UnityEngine.Canvas));
                    UnityEngine.UI.Graphic _graphic = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
                    
                    UnityEngine.UI.GraphicRegistry.RegisterRaycastGraphicForCanvas( _c, _graphic );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterGraphicForCanvas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Canvas _c = (UnityEngine.Canvas)translator.GetObject(L, 1, typeof(UnityEngine.Canvas));
                    UnityEngine.UI.Graphic _graphic = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
                    
                    UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas( _c, _graphic );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnregisterRaycastGraphicForCanvas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Canvas _c = (UnityEngine.Canvas)translator.GetObject(L, 1, typeof(UnityEngine.Canvas));
                    UnityEngine.UI.Graphic _graphic = (UnityEngine.UI.Graphic)translator.GetObject(L, 2, typeof(UnityEngine.UI.Graphic));
                    
                    UnityEngine.UI.GraphicRegistry.UnregisterRaycastGraphicForCanvas( _c, _graphic );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGraphicsForCanvas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Canvas _canvas = (UnityEngine.Canvas)translator.GetObject(L, 1, typeof(UnityEngine.Canvas));
                    
                        var gen_ret = UnityEngine.UI.GraphicRegistry.GetGraphicsForCanvas( _canvas );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRaycastableGraphicsForCanvas_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Canvas _canvas = (UnityEngine.Canvas)translator.GetObject(L, 1, typeof(UnityEngine.Canvas));
                    
                        var gen_ret = UnityEngine.UI.GraphicRegistry.GetRaycastableGraphicsForCanvas( _canvas );
                        translator.PushAny(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.UI.GraphicRegistry.instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
