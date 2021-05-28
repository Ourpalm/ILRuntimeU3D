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
    public class UnityEngineUICanvasScalerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.CanvasScaler);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 10, 10);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "uiScaleMode", _g_get_uiScaleMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referencePixelsPerUnit", _g_get_referencePixelsPerUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scaleFactor", _g_get_scaleFactor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referenceResolution", _g_get_referenceResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "screenMatchMode", _g_get_screenMatchMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "matchWidthOrHeight", _g_get_matchWidthOrHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "physicalUnit", _g_get_physicalUnit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "fallbackScreenDPI", _g_get_fallbackScreenDPI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultSpriteDPI", _g_get_defaultSpriteDPI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dynamicPixelsPerUnit", _g_get_dynamicPixelsPerUnit);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "uiScaleMode", _s_set_uiScaleMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "referencePixelsPerUnit", _s_set_referencePixelsPerUnit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "scaleFactor", _s_set_scaleFactor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "referenceResolution", _s_set_referenceResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "screenMatchMode", _s_set_screenMatchMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "matchWidthOrHeight", _s_set_matchWidthOrHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "physicalUnit", _s_set_physicalUnit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "fallbackScreenDPI", _s_set_fallbackScreenDPI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultSpriteDPI", _s_set_defaultSpriteDPI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dynamicPixelsPerUnit", _s_set_dynamicPixelsPerUnit);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.CanvasScaler does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_uiScaleMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.uiScaleMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_referencePixelsPerUnit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.referencePixelsPerUnit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scaleFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.scaleFactor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_referenceResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.referenceResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_screenMatchMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.screenMatchMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_matchWidthOrHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.matchWidthOrHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_physicalUnit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.physicalUnit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fallbackScreenDPI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.fallbackScreenDPI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultSpriteDPI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.defaultSpriteDPI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dynamicPixelsPerUnit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.dynamicPixelsPerUnit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_uiScaleMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                UnityEngine.UI.CanvasScaler.ScaleMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.uiScaleMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_referencePixelsPerUnit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.referencePixelsPerUnit = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_scaleFactor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.scaleFactor = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_referenceResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.referenceResolution = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_screenMatchMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                UnityEngine.UI.CanvasScaler.ScreenMatchMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.screenMatchMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_matchWidthOrHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.matchWidthOrHeight = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_physicalUnit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                UnityEngine.UI.CanvasScaler.Unit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.physicalUnit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fallbackScreenDPI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.fallbackScreenDPI = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultSpriteDPI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultSpriteDPI = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dynamicPixelsPerUnit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.CanvasScaler gen_to_be_invoked = (UnityEngine.UI.CanvasScaler)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.dynamicPixelsPerUnit = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
