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
    public class UnityEngineAudioSettingsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AudioSettings);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 4, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDSPBufferSize", _m_GetDSPBufferSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSpatializerPluginNames", _m_GetSpatializerPluginNames_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSpatializerPluginName", _m_GetSpatializerPluginName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetSpatializerPluginName", _m_SetSpatializerPluginName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetConfiguration", _m_GetConfiguration_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Reset", _m_Reset_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "OnAudioConfigurationChanged", _e_OnAudioConfigurationChanged);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "driverCapabilities", _g_get_driverCapabilities);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "speakerMode", _g_get_speakerMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "dspTime", _g_get_dspTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "outputSampleRate", _g_get_outputSampleRate);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "speakerMode", _s_set_speakerMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "outputSampleRate", _s_set_outputSampleRate);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.AudioSettings();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AudioSettings constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDSPBufferSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _bufferLength;
                    int _numBuffers;
                    
                    UnityEngine.AudioSettings.GetDSPBufferSize( out _bufferLength, out _numBuffers );
                    LuaAPI.xlua_pushinteger(L, _bufferLength);
                        
                    LuaAPI.xlua_pushinteger(L, _numBuffers);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSpatializerPluginNames_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        var gen_ret = UnityEngine.AudioSettings.GetSpatializerPluginNames(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSpatializerPluginName_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        var gen_ret = UnityEngine.AudioSettings.GetSpatializerPluginName(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSpatializerPluginName_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _pluginName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.AudioSettings.SetSpatializerPluginName( _pluginName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConfiguration_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        var gen_ret = UnityEngine.AudioSettings.GetConfiguration(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Reset_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.AudioConfiguration _config;translator.Get(L, 1, out _config);
                    
                        var gen_ret = UnityEngine.AudioSettings.Reset( _config );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_driverCapabilities(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.AudioSettings.driverCapabilities);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_speakerMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.AudioSettings.speakerMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dspTime(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.AudioSettings.dspTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_outputSampleRate(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.AudioSettings.outputSampleRate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_speakerMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.AudioSpeakerMode gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.AudioSettings.speakerMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_outputSampleRate(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.AudioSettings.outputSampleRate = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnAudioConfigurationChanged(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                UnityEngine.AudioSettings.AudioConfigurationChangeHandler gen_delegate = translator.GetDelegate<UnityEngine.AudioSettings.AudioConfigurationChangeHandler>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need UnityEngine.AudioSettings.AudioConfigurationChangeHandler!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.AudioSettings.OnAudioConfigurationChanged += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.AudioSettings.OnAudioConfigurationChanged -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AudioSettings.OnAudioConfigurationChanged!");
        }
        
    }
}
