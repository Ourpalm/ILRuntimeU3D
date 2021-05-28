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
    public class UnityEngineRandomWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Random);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 7, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "InitState", _m_InitState_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Range", _m_Range_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ColorHSV", _m_ColorHSV_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "state", _g_get_state);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "value", _g_get_value);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "insideUnitSphere", _g_get_insideUnitSphere);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "insideUnitCircle", _g_get_insideUnitCircle);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "onUnitSphere", _g_get_onUnitSphere);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "rotation", _g_get_rotation);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "rotationUniform", _g_get_rotationUniform);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "state", _s_set_state);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Random does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitState_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _seed = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.Random.InitState( _seed );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Range_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _minInclusive = (float)LuaAPI.lua_tonumber(L, 1);
                    float _maxInclusive = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = UnityEngine.Random.Range( _minInclusive, _maxInclusive );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _minInclusive = LuaAPI.xlua_tointeger(L, 1);
                    int _maxExclusive = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.Random.Range( _minInclusive, _maxExclusive );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Random.Range!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ColorHSV_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        var gen_ret = UnityEngine.Random.ColorHSV(  );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _hueMin = (float)LuaAPI.lua_tonumber(L, 1);
                    float _hueMax = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = UnityEngine.Random.ColorHSV( _hueMin, _hueMax );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _hueMin = (float)LuaAPI.lua_tonumber(L, 1);
                    float _hueMax = (float)LuaAPI.lua_tonumber(L, 2);
                    float _saturationMin = (float)LuaAPI.lua_tonumber(L, 3);
                    float _saturationMax = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Random.ColorHSV( _hueMin, _hueMax, _saturationMin, _saturationMax );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    float _hueMin = (float)LuaAPI.lua_tonumber(L, 1);
                    float _hueMax = (float)LuaAPI.lua_tonumber(L, 2);
                    float _saturationMin = (float)LuaAPI.lua_tonumber(L, 3);
                    float _saturationMax = (float)LuaAPI.lua_tonumber(L, 4);
                    float _valueMin = (float)LuaAPI.lua_tonumber(L, 5);
                    float _valueMax = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Random.ColorHSV( _hueMin, _hueMax, _saturationMin, _saturationMax, _valueMin, _valueMax );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    float _hueMin = (float)LuaAPI.lua_tonumber(L, 1);
                    float _hueMax = (float)LuaAPI.lua_tonumber(L, 2);
                    float _saturationMin = (float)LuaAPI.lua_tonumber(L, 3);
                    float _saturationMax = (float)LuaAPI.lua_tonumber(L, 4);
                    float _valueMin = (float)LuaAPI.lua_tonumber(L, 5);
                    float _valueMax = (float)LuaAPI.lua_tonumber(L, 6);
                    float _alphaMin = (float)LuaAPI.lua_tonumber(L, 7);
                    float _alphaMax = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Random.ColorHSV( _hueMin, _hueMax, _saturationMin, _saturationMax, _valueMin, _valueMax, _alphaMin, _alphaMax );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Random.ColorHSV!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_state(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Random.state);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_value(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Random.value);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_insideUnitSphere(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineVector3(L, UnityEngine.Random.insideUnitSphere);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_insideUnitCircle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineVector2(L, UnityEngine.Random.insideUnitCircle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onUnitSphere(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineVector3(L, UnityEngine.Random.onUnitSphere);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineQuaternion(L, UnityEngine.Random.rotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationUniform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineQuaternion(L, UnityEngine.Random.rotationUniform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_state(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Random.State gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Random.state = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
