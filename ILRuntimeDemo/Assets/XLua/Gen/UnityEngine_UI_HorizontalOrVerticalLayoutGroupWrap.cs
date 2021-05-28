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
    public class UnityEngineUIHorizontalOrVerticalLayoutGroupWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 8, 8);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "spacing", _g_get_spacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childForceExpandWidth", _g_get_childForceExpandWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childForceExpandHeight", _g_get_childForceExpandHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childControlWidth", _g_get_childControlWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childControlHeight", _g_get_childControlHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childScaleWidth", _g_get_childScaleWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childScaleHeight", _g_get_childScaleHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reverseArrangement", _g_get_reverseArrangement);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "spacing", _s_set_spacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childForceExpandWidth", _s_set_childForceExpandWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childForceExpandHeight", _s_set_childForceExpandHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childControlWidth", _s_set_childControlWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childControlHeight", _s_set_childControlHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childScaleWidth", _s_set_childScaleWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childScaleHeight", _s_set_childScaleHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reverseArrangement", _s_set_reverseArrangement);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.HorizontalOrVerticalLayoutGroup does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spacing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.spacing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childForceExpandWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.childForceExpandWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childForceExpandHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.childForceExpandHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childControlWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.childControlWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childControlHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.childControlHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childScaleWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.childScaleWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childScaleHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.childScaleHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reverseArrangement(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.reverseArrangement);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spacing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.spacing = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childForceExpandWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childForceExpandWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childForceExpandHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childForceExpandHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childControlWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childControlWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childControlHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childControlHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childScaleWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childScaleWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childScaleHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.childScaleHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reverseArrangement(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reverseArrangement = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
