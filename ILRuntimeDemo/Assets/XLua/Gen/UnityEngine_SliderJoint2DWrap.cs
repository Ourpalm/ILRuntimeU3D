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
    public class UnityEngineSliderJoint2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.SliderJoint2D);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 10, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMotorForce", _m_GetMotorForce);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "autoConfigureAngle", _g_get_autoConfigureAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angle", _g_get_angle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useMotor", _g_get_useMotor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useLimits", _g_get_useLimits);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motor", _g_get_motor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "limits", _g_get_limits);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "limitState", _g_get_limitState);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "referenceAngle", _g_get_referenceAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointTranslation", _g_get_jointTranslation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointSpeed", _g_get_jointSpeed);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "autoConfigureAngle", _s_set_autoConfigureAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angle", _s_set_angle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useMotor", _s_set_useMotor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useLimits", _s_set_useLimits);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motor", _s_set_motor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "limits", _s_set_limits);
            
			
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
					
					var gen_ret = new UnityEngine.SliderJoint2D();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SliderJoint2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMotorForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _timeStep = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMotorForce( _timeStep );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoConfigureAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.autoConfigureAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useMotor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useMotor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useLimits(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useLimits);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_motor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.motor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_limits(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.limits);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_limitState(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.limitState);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_referenceAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.referenceAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointTranslation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.jointTranslation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.jointSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoConfigureAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.autoConfigureAngle = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useMotor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useMotor = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useLimits(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useLimits = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_motor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                UnityEngine.JointMotor2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.motor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_limits(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SliderJoint2D gen_to_be_invoked = (UnityEngine.SliderJoint2D)translator.FastGetCSObj(L, 1);
                UnityEngine.JointTranslationLimits2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.limits = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
