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
    public class UnityEngineLightingSettingsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.LightingSettings);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 45, 45);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "bakedGI", _g_get_bakedGI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeGI", _g_get_realtimeGI);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "realtimeEnvironmentLighting", _g_get_realtimeEnvironmentLighting);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoGenerate", _g_get_autoGenerate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mixedBakeMode", _g_get_mixedBakeMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "albedoBoost", _g_get_albedoBoost);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "indirectScale", _g_get_indirectScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapper", _g_get_lightmapper);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapMaxSize", _g_get_lightmapMaxSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapResolution", _g_get_lightmapResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightmapPadding", _g_get_lightmapPadding);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "compressLightmaps", _g_get_compressLightmaps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ao", _g_get_ao);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aoMaxDistance", _g_get_aoMaxDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aoExponentIndirect", _g_get_aoExponentIndirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "aoExponentDirect", _g_get_aoExponentDirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "extractAO", _g_get_extractAO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directionalityMode", _g_get_directionalityMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "exportTrainingData", _g_get_exportTrainingData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trainingDataDestination", _g_get_trainingDataDestination);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "indirectResolution", _g_get_indirectResolution);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalGather", _g_get_finalGather);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalGatherRayCount", _g_get_finalGatherRayCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "finalGatherFiltering", _g_get_finalGatherFiltering);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sampling", _g_get_sampling);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directSampleCount", _g_get_directSampleCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "indirectSampleCount", _g_get_indirectSampleCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxBounces", _g_get_maxBounces);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minBounces", _g_get_minBounces);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "prioritizeView", _g_get_prioritizeView);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringMode", _g_get_filteringMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "denoiserTypeDirect", _g_get_denoiserTypeDirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "denoiserTypeIndirect", _g_get_denoiserTypeIndirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "denoiserTypeAO", _g_get_denoiserTypeAO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filterTypeDirect", _g_get_filterTypeDirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filterTypeIndirect", _g_get_filterTypeIndirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filterTypeAO", _g_get_filterTypeAO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringGaussRadiusDirect", _g_get_filteringGaussRadiusDirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringGaussRadiusIndirect", _g_get_filteringGaussRadiusIndirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringGaussRadiusAO", _g_get_filteringGaussRadiusAO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringAtrousPositionSigmaDirect", _g_get_filteringAtrousPositionSigmaDirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringAtrousPositionSigmaIndirect", _g_get_filteringAtrousPositionSigmaIndirect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filteringAtrousPositionSigmaAO", _g_get_filteringAtrousPositionSigmaAO);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "environmentSampleCount", _g_get_environmentSampleCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lightProbeSampleCountMultiplier", _g_get_lightProbeSampleCountMultiplier);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bakedGI", _s_set_bakedGI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeGI", _s_set_realtimeGI);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "realtimeEnvironmentLighting", _s_set_realtimeEnvironmentLighting);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoGenerate", _s_set_autoGenerate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mixedBakeMode", _s_set_mixedBakeMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "albedoBoost", _s_set_albedoBoost);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "indirectScale", _s_set_indirectScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapper", _s_set_lightmapper);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapMaxSize", _s_set_lightmapMaxSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapResolution", _s_set_lightmapResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightmapPadding", _s_set_lightmapPadding);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "compressLightmaps", _s_set_compressLightmaps);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ao", _s_set_ao);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aoMaxDistance", _s_set_aoMaxDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aoExponentIndirect", _s_set_aoExponentIndirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "aoExponentDirect", _s_set_aoExponentDirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "extractAO", _s_set_extractAO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directionalityMode", _s_set_directionalityMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "exportTrainingData", _s_set_exportTrainingData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trainingDataDestination", _s_set_trainingDataDestination);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "indirectResolution", _s_set_indirectResolution);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "finalGather", _s_set_finalGather);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "finalGatherRayCount", _s_set_finalGatherRayCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "finalGatherFiltering", _s_set_finalGatherFiltering);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sampling", _s_set_sampling);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directSampleCount", _s_set_directSampleCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "indirectSampleCount", _s_set_indirectSampleCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxBounces", _s_set_maxBounces);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minBounces", _s_set_minBounces);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "prioritizeView", _s_set_prioritizeView);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringMode", _s_set_filteringMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "denoiserTypeDirect", _s_set_denoiserTypeDirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "denoiserTypeIndirect", _s_set_denoiserTypeIndirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "denoiserTypeAO", _s_set_denoiserTypeAO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filterTypeDirect", _s_set_filterTypeDirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filterTypeIndirect", _s_set_filterTypeIndirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filterTypeAO", _s_set_filterTypeAO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringGaussRadiusDirect", _s_set_filteringGaussRadiusDirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringGaussRadiusIndirect", _s_set_filteringGaussRadiusIndirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringGaussRadiusAO", _s_set_filteringGaussRadiusAO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringAtrousPositionSigmaDirect", _s_set_filteringAtrousPositionSigmaDirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringAtrousPositionSigmaIndirect", _s_set_filteringAtrousPositionSigmaIndirect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filteringAtrousPositionSigmaAO", _s_set_filteringAtrousPositionSigmaAO);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "environmentSampleCount", _s_set_environmentSampleCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lightProbeSampleCountMultiplier", _s_set_lightProbeSampleCountMultiplier);
            
			
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
					
					var gen_ret = new UnityEngine.LightingSettings();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LightingSettings constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bakedGI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.bakedGI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_realtimeGI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.realtimeGI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_realtimeEnvironmentLighting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.realtimeEnvironmentLighting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoGenerate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoGenerate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mixedBakeMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.mixedBakeMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_albedoBoost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.albedoBoost);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_indirectScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.indirectScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightmapper(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lightmapper);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightmapMaxSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lightmapMaxSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightmapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lightmapResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightmapPadding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.lightmapPadding);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_compressLightmaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.compressLightmaps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ao(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ao);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aoMaxDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aoMaxDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aoExponentIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aoExponentIndirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_aoExponentDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.aoExponentDirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_extractAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.extractAO);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directionalityMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directionalityMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_exportTrainingData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.exportTrainingData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trainingDataDestination(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.trainingDataDestination);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_indirectResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.indirectResolution);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalGather(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.finalGather);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalGatherRayCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.finalGatherRayCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_finalGatherFiltering(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.finalGatherFiltering);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sampling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sampling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directSampleCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.directSampleCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_indirectSampleCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.indirectSampleCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxBounces(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maxBounces);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minBounces(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.minBounces);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_prioritizeView(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.prioritizeView);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.filteringMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_denoiserTypeDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.denoiserTypeDirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_denoiserTypeIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.denoiserTypeIndirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_denoiserTypeAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.denoiserTypeAO);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filterTypeDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.filterTypeDirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filterTypeIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.filterTypeIndirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filterTypeAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.filterTypeAO);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringGaussRadiusDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.filteringGaussRadiusDirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringGaussRadiusIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.filteringGaussRadiusIndirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringGaussRadiusAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.filteringGaussRadiusAO);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringAtrousPositionSigmaDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.filteringAtrousPositionSigmaDirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringAtrousPositionSigmaIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.filteringAtrousPositionSigmaIndirect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filteringAtrousPositionSigmaAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.filteringAtrousPositionSigmaAO);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_environmentSampleCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.environmentSampleCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lightProbeSampleCountMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lightProbeSampleCountMultiplier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bakedGI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bakedGI = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_realtimeGI(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.realtimeGI = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_realtimeEnvironmentLighting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.realtimeEnvironmentLighting = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoGenerate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoGenerate = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mixedBakeMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.MixedLightingMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.mixedBakeMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_albedoBoost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.albedoBoost = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_indirectScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.indirectScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightmapper(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.Lightmapper gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.lightmapper = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightmapMaxSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lightmapMaxSize = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightmapResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lightmapResolution = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightmapPadding(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lightmapPadding = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_compressLightmaps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.compressLightmaps = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ao(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ao = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aoMaxDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aoMaxDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aoExponentIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aoExponentIndirect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_aoExponentDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.aoExponentDirect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_extractAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.extractAO = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directionalityMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightmapsMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.directionalityMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_exportTrainingData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.exportTrainingData = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trainingDataDestination(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trainingDataDestination = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_indirectResolution(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.indirectResolution = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalGather(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.finalGather = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalGatherRayCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.finalGatherRayCount = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_finalGatherFiltering(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.finalGatherFiltering = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sampling(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.Sampling gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.sampling = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directSampleCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.directSampleCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_indirectSampleCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.indirectSampleCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxBounces(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxBounces = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minBounces(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minBounces = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_prioritizeView(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.prioritizeView = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.FilterMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.filteringMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_denoiserTypeDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.DenoiserType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.denoiserTypeDirect = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_denoiserTypeIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.DenoiserType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.denoiserTypeIndirect = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_denoiserTypeAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.DenoiserType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.denoiserTypeAO = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filterTypeDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.FilterType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.filterTypeDirect = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filterTypeIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.FilterType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.filterTypeIndirect = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filterTypeAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                UnityEngine.LightingSettings.FilterType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.filterTypeAO = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringGaussRadiusDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filteringGaussRadiusDirect = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringGaussRadiusIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filteringGaussRadiusIndirect = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringGaussRadiusAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filteringGaussRadiusAO = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringAtrousPositionSigmaDirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filteringAtrousPositionSigmaDirect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringAtrousPositionSigmaIndirect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filteringAtrousPositionSigmaIndirect = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filteringAtrousPositionSigmaAO(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.filteringAtrousPositionSigmaAO = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_environmentSampleCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.environmentSampleCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lightProbeSampleCountMultiplier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightingSettings gen_to_be_invoked = (UnityEngine.LightingSettings)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lightProbeSampleCountMultiplier = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
