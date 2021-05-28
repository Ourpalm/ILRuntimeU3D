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
    public class UnityEngineLoggerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Logger);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 3, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsLogTypeAllowed", _m_IsLogTypeAllowed);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Log", _m_Log);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogWarning", _m_LogWarning);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogError", _m_LogError);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogException", _m_LogException);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LogFormat", _m_LogFormat);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "logHandler", _g_get_logHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "logEnabled", _g_get_logEnabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "filterLogType", _g_get_filterLogType);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "logHandler", _s_set_logHandler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "logEnabled", _s_set_logEnabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "filterLogType", _s_set_filterLogType);
            
			
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
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.ILogHandler>(L, 2))
				{
					UnityEngine.ILogHandler _logHandler = (UnityEngine.ILogHandler)translator.GetObject(L, 2, typeof(UnityEngine.ILogHandler));
					
					var gen_ret = new UnityEngine.Logger(_logHandler);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsLogTypeAllowed(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    
                        var gen_ret = gen_to_be_invoked.IsLogTypeAllowed( _logType );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Log(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _message = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.Log( _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.LogType>(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.Log( _logType, _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.Log( _tag, _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.LogType>(L, 2)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.Log( _logType, _message, _context );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.LogType>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)) 
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    string _tag = LuaAPI.lua_tostring(L, 3);
                    object _message = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.Log( _logType, _tag, _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.Log( _tag, _message, _context );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.LogType>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 4)&& translator.Assignable<UnityEngine.Object>(L, 5)) 
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    string _tag = LuaAPI.lua_tostring(L, 3);
                    object _message = translator.GetObject(L, 4, typeof(object));
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 5, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.Log( _logType, _tag, _message, _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.Log!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogWarning(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.LogWarning( _tag, _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.LogWarning( _tag, _message, _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogWarning!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogError(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.LogError( _tag, _message );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    object _message = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.LogError( _tag, _message, _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogError!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogException(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Exception>(L, 2)) 
                {
                    System.Exception _exception = (System.Exception)translator.GetObject(L, 2, typeof(System.Exception));
                    
                    gen_to_be_invoked.LogException( _exception );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Exception>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
                {
                    System.Exception _exception = (System.Exception)translator.GetObject(L, 2, typeof(System.Exception));
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                    gen_to_be_invoked.LogException( _exception, _context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogException!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LogFormat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 3&& translator.Assignable<UnityEngine.LogType>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<object>(L, 4))) 
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    string _format = LuaAPI.lua_tostring(L, 3);
                    object[] _args = translator.GetParams<object>(L, 4);
                    
                    gen_to_be_invoked.LogFormat( _logType, _format, _args );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 4&& translator.Assignable<UnityEngine.LogType>(L, 2)&& translator.Assignable<UnityEngine.Object>(L, 3)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<object>(L, 5))) 
                {
                    UnityEngine.LogType _logType;translator.Get(L, 2, out _logType);
                    UnityEngine.Object _context = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    string _format = LuaAPI.lua_tostring(L, 4);
                    object[] _args = translator.GetParams<object>(L, 5);
                    
                    gen_to_be_invoked.LogFormat( _logType, _context, _format, _args );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Logger.LogFormat!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                translator.PushAny(L, gen_to_be_invoked.logHandler);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_logEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.logEnabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_filterLogType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.filterLogType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logHandler(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.logHandler = (UnityEngine.ILogHandler)translator.GetObject(L, 2, typeof(UnityEngine.ILogHandler));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_logEnabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.logEnabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_filterLogType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Logger gen_to_be_invoked = (UnityEngine.Logger)translator.FastGetCSObj(L, 1);
                UnityEngine.LogType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.filterLogType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
