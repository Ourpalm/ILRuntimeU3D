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
    public class UnityEngineAudioClipWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AudioClip);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 9, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadAudioData", _m_LoadAudioData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadAudioData", _m_UnloadAudioData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetData", _m_GetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetData", _m_SetData);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", _g_get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "samples", _g_get_samples);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "channels", _g_get_channels);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frequency", _g_get_frequency);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loadType", _g_get_loadType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "preloadAudioData", _g_get_preloadAudioData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ambisonic", _g_get_ambisonic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loadInBackground", _g_get_loadInBackground);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loadState", _g_get_loadState);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Create", _m_Create_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.AudioClip does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadAudioData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.LoadAudioData(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadAudioData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.UnloadAudioData(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float[] _data = (float[])translator.GetObject(L, 2, typeof(float[]));
                    int _offsetSamples = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetData( _data, _offsetSamples );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float[] _data = (float[])translator.GetObject(L, 2, typeof(float[]));
                    int _offsetSamples = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.SetData( _data, _offsetSamples );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Create_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    int _lengthSamples = LuaAPI.xlua_tointeger(L, 2);
                    int _channels = LuaAPI.xlua_tointeger(L, 3);
                    int _frequency = LuaAPI.xlua_tointeger(L, 4);
                    bool _stream = LuaAPI.lua_toboolean(L, 5);
                    
                        var gen_ret = UnityEngine.AudioClip.Create( _name, _lengthSamples, _channels, _frequency, _stream );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.AudioClip.PCMReaderCallback>(L, 6)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    int _lengthSamples = LuaAPI.xlua_tointeger(L, 2);
                    int _channels = LuaAPI.xlua_tointeger(L, 3);
                    int _frequency = LuaAPI.xlua_tointeger(L, 4);
                    bool _stream = LuaAPI.lua_toboolean(L, 5);
                    UnityEngine.AudioClip.PCMReaderCallback _pcmreadercallback = translator.GetDelegate<UnityEngine.AudioClip.PCMReaderCallback>(L, 6);
                    
                        var gen_ret = UnityEngine.AudioClip.Create( _name, _lengthSamples, _channels, _frequency, _stream, _pcmreadercallback );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.AudioClip.PCMReaderCallback>(L, 6)&& translator.Assignable<UnityEngine.AudioClip.PCMSetPositionCallback>(L, 7)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    int _lengthSamples = LuaAPI.xlua_tointeger(L, 2);
                    int _channels = LuaAPI.xlua_tointeger(L, 3);
                    int _frequency = LuaAPI.xlua_tointeger(L, 4);
                    bool _stream = LuaAPI.lua_toboolean(L, 5);
                    UnityEngine.AudioClip.PCMReaderCallback _pcmreadercallback = translator.GetDelegate<UnityEngine.AudioClip.PCMReaderCallback>(L, 6);
                    UnityEngine.AudioClip.PCMSetPositionCallback _pcmsetpositioncallback = translator.GetDelegate<UnityEngine.AudioClip.PCMSetPositionCallback>(L, 7);
                    
                        var gen_ret = UnityEngine.AudioClip.Create( _name, _lengthSamples, _channels, _frequency, _stream, _pcmreadercallback, _pcmsetpositioncallback );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AudioClip.Create!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_samples(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.samples);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_channels(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.channels);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_frequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.frequency);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.loadType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_preloadAudioData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.preloadAudioData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ambisonic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ambisonic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadInBackground(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.loadInBackground);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_loadState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioClip gen_to_be_invoked = (UnityEngine.AudioClip)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.loadState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
