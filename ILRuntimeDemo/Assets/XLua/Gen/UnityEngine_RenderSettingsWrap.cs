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
    public class UnityEngineRenderSettingsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.RenderSettings);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 24, 24);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fog", _g_get_fog);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogStartDistance", _g_get_fogStartDistance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogEndDistance", _g_get_fogEndDistance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogMode", _g_get_fogMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogColor", _g_get_fogColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fogDensity", _g_get_fogDensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientMode", _g_get_ambientMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientSkyColor", _g_get_ambientSkyColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientEquatorColor", _g_get_ambientEquatorColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientGroundColor", _g_get_ambientGroundColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientIntensity", _g_get_ambientIntensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientLight", _g_get_ambientLight);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "subtractiveShadowColor", _g_get_subtractiveShadowColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "skybox", _g_get_skybox);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sun", _g_get_sun);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ambientProbe", _g_get_ambientProbe);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "customReflection", _g_get_customReflection);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "reflectionIntensity", _g_get_reflectionIntensity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "reflectionBounces", _g_get_reflectionBounces);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultReflectionMode", _g_get_defaultReflectionMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultReflectionResolution", _g_get_defaultReflectionResolution);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "haloStrength", _g_get_haloStrength);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "flareStrength", _g_get_flareStrength);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "flareFadeSpeed", _g_get_flareFadeSpeed);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fog", _s_set_fog);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogStartDistance", _s_set_fogStartDistance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogEndDistance", _s_set_fogEndDistance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogMode", _s_set_fogMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogColor", _s_set_fogColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fogDensity", _s_set_fogDensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientMode", _s_set_ambientMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientSkyColor", _s_set_ambientSkyColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientEquatorColor", _s_set_ambientEquatorColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientGroundColor", _s_set_ambientGroundColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientIntensity", _s_set_ambientIntensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientLight", _s_set_ambientLight);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "subtractiveShadowColor", _s_set_subtractiveShadowColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "skybox", _s_set_skybox);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sun", _s_set_sun);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ambientProbe", _s_set_ambientProbe);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "customReflection", _s_set_customReflection);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "reflectionIntensity", _s_set_reflectionIntensity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "reflectionBounces", _s_set_reflectionBounces);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultReflectionMode", _s_set_defaultReflectionMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultReflectionResolution", _s_set_defaultReflectionResolution);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "haloStrength", _s_set_haloStrength);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "flareStrength", _s_set_flareStrength);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "flareFadeSpeed", _s_set_flareFadeSpeed);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.RenderSettings does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fog(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.RenderSettings.fog);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogStartDistance(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.fogStartDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogEndDistance(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.fogEndDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.fogMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.fogColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_fogDensity(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.fogDensity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.ambientMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientSkyColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientSkyColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientEquatorColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientEquatorColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientGroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientGroundColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientIntensity(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.ambientIntensity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientLight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.ambientLight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_subtractiveShadowColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.RenderSettings.subtractiveShadowColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_skybox(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.skybox);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sun(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.sun);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambientProbe(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.ambientProbe);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_customReflection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.customReflection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflectionIntensity(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.reflectionIntensity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflectionBounces(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.RenderSettings.reflectionBounces);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultReflectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.RenderSettings.defaultReflectionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultReflectionResolution(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.RenderSettings.defaultReflectionResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_haloStrength(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.haloStrength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_flareStrength(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.flareStrength);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_flareFadeSpeed(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.RenderSettings.flareFadeSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fog(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.fog = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogStartDistance(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.fogStartDistance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogEndDistance(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.fogEndDistance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.FogMode gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.fogMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.fogColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_fogDensity(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.fogDensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Rendering.AmbientMode gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.ambientMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientSkyColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.ambientSkyColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientEquatorColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.ambientEquatorColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientGroundColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.ambientGroundColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientIntensity(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.ambientIntensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientLight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.ambientLight = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_subtractiveShadowColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.subtractiveShadowColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_skybox(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    UnityEngine.RenderSettings.skybox = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sun(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    UnityEngine.RenderSettings.sun = (UnityEngine.Light)translator.GetObject(L, 1, typeof(UnityEngine.Light));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ambientProbe(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Rendering.SphericalHarmonicsL2 gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.ambientProbe = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_customReflection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    UnityEngine.RenderSettings.customReflection = (UnityEngine.Cubemap)translator.GetObject(L, 1, typeof(UnityEngine.Cubemap));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflectionIntensity(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.reflectionIntensity = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflectionBounces(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.reflectionBounces = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultReflectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Rendering.DefaultReflectionMode gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.RenderSettings.defaultReflectionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultReflectionResolution(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.defaultReflectionResolution = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_haloStrength(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.haloStrength = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_flareStrength(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.flareStrength = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_flareFadeSpeed(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.RenderSettings.flareFadeSpeed = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
