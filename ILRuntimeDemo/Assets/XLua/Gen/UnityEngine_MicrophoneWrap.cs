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
    public class UnityEngineMicrophoneWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Microphone);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 6, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Start", _m_Start_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "End", _m_End_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRecording", _m_IsRecording_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetPosition", _m_GetPosition_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDeviceCaps", _m_GetDeviceCaps_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "devices", _g_get_devices);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Microphone();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Microphone constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Start_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _deviceName = LuaAPI.lua_tostring(L, 1);
                    bool _loop = LuaAPI.lua_toboolean(L, 2);
                    int _lengthSec = LuaAPI.xlua_tointeger(L, 3);
                    int _frequency = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Microphone.Start( _deviceName, _loop, _lengthSec, _frequency );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_End_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _deviceName = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Microphone.End( _deviceName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRecording_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _deviceName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Microphone.IsRecording( _deviceName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPosition_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _deviceName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Microphone.GetPosition( _deviceName );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDeviceCaps_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _deviceName = LuaAPI.lua_tostring(L, 1);
                    int _minFreq;
                    int _maxFreq;
                    
                    UnityEngine.Microphone.GetDeviceCaps( _deviceName, out _minFreq, out _maxFreq );
                    LuaAPI.xlua_pushinteger(L, _minFreq);
                        
                    LuaAPI.xlua_pushinteger(L, _maxFreq);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_devices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Microphone.devices);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
