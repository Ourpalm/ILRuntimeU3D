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
    public class UnityEngineLightProbeProxyVolumeWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.LightProbeProxyVolume);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 13, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "boundsGlobal", _g_get_boundsGlobal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sizeCustom", _g_get_sizeCustom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "originCustom", _g_get_originCustom);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "probeDensity", _g_get_probeDensity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gridResolutionX", _g_get_gridResolutionX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gridResolutionY", _g_get_gridResolutionY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gridResolutionZ", _g_get_gridResolutionZ);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "boundingBoxMode", _g_get_boundingBoxMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "resolutionMode", _g_get_resolutionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "probePositionMode", _g_get_probePositionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "refreshMode", _g_get_refreshMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "qualityMode", _g_get_qualityMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dataFormat", _g_get_dataFormat);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "sizeCustom", _s_set_sizeCustom);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "originCustom", _s_set_originCustom);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "probeDensity", _s_set_probeDensity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gridResolutionX", _s_set_gridResolutionX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gridResolutionY", _s_set_gridResolutionY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gridResolutionZ", _s_set_gridResolutionZ);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "boundingBoxMode", _s_set_boundingBoxMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "resolutionMode", _s_set_resolutionMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "probePositionMode", _s_set_probePositionMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "refreshMode", _s_set_refreshMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "qualityMode", _s_set_qualityMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "dataFormat", _s_set_dataFormat);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isFeatureSupported", _g_get_isFeatureSupported);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.LightProbeProxyVolume();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LightProbeProxyVolume constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isFeatureSupported(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.LightProbeProxyVolume.isFeatureSupported);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_boundsGlobal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, gen_to_be_invoked.boundsGlobal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sizeCustom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.sizeCustom);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_originCustom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.originCustom);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_probeDensity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.probeDensity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gridResolutionX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.gridResolutionX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gridResolutionY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.gridResolutionY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gridResolutionZ(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.gridResolutionZ);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_boundingBoxMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.boundingBoxMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_resolutionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.resolutionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_probePositionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.probePositionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_refreshMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.refreshMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_qualityMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.qualityMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dataFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.dataFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sizeCustom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.sizeCustom = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_originCustom(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.originCustom = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_probeDensity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.probeDensity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gridResolutionX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gridResolutionX = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gridResolutionY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gridResolutionY = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gridResolutionZ(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gridResolutionZ = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_boundingBoxMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.LightProbeProxyVolume.BoundingBoxMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.boundingBoxMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_resolutionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.LightProbeProxyVolume.ResolutionMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.resolutionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_probePositionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.LightProbeProxyVolume.ProbePositionMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.probePositionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_refreshMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.LightProbeProxyVolume.RefreshMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.refreshMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_qualityMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.LightProbeProxyVolume.QualityMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.qualityMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_dataFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbeProxyVolume gen_to_be_invoked = (UnityEngine.LightProbeProxyVolume)translator.FastGetCSObj(L, 1);
                UnityEngine.LightProbeProxyVolume.DataFormat gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.dataFormat = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
