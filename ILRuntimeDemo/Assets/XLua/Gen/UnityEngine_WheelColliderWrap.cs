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
    public class UnityEngineWheelColliderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.WheelCollider);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 16, 14);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetSprungMasses", _m_ResetSprungMasses);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConfigureVehicleSubsteps", _m_ConfigureVehicleSubsteps);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetWorldPose", _m_GetWorldPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetGroundHit", _m_GetGroundHit);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "center", _g_get_center);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "radius", _g_get_radius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "suspensionDistance", _g_get_suspensionDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "suspensionSpring", _g_get_suspensionSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "suspensionExpansionLimited", _g_get_suspensionExpansionLimited);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forceAppPointDistance", _g_get_forceAppPointDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mass", _g_get_mass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wheelDampingRate", _g_get_wheelDampingRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forwardFriction", _g_get_forwardFriction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sidewaysFriction", _g_get_sidewaysFriction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "motorTorque", _g_get_motorTorque);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "brakeTorque", _g_get_brakeTorque);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "steerAngle", _g_get_steerAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isGrounded", _g_get_isGrounded);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rpm", _g_get_rpm);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sprungMass", _g_get_sprungMass);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "center", _s_set_center);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "radius", _s_set_radius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "suspensionDistance", _s_set_suspensionDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "suspensionSpring", _s_set_suspensionSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "suspensionExpansionLimited", _s_set_suspensionExpansionLimited);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forceAppPointDistance", _s_set_forceAppPointDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mass", _s_set_mass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wheelDampingRate", _s_set_wheelDampingRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forwardFriction", _s_set_forwardFriction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sidewaysFriction", _s_set_sidewaysFriction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "motorTorque", _s_set_motorTorque);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "brakeTorque", _s_set_brakeTorque);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "steerAngle", _s_set_steerAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sprungMass", _s_set_sprungMass);
            
			
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
					
					var gen_ret = new UnityEngine.WheelCollider();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.WheelCollider constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetSprungMasses(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetSprungMasses(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConfigureVehicleSubsteps(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _speedThreshold = (float)LuaAPI.lua_tonumber(L, 2);
                    int _stepsBelowThreshold = LuaAPI.xlua_tointeger(L, 3);
                    int _stepsAboveThreshold = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.ConfigureVehicleSubsteps( _speedThreshold, _stepsBelowThreshold, _stepsAboveThreshold );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetWorldPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _pos;
                    UnityEngine.Quaternion _quat;
                    
                    gen_to_be_invoked.GetWorldPose( out _pos, out _quat );
                    translator.PushUnityEngineVector3(L, _pos);
                        
                    translator.PushUnityEngineQuaternion(L, _quat);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGroundHit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.WheelHit _hit;
                    
                        var gen_ret = gen_to_be_invoked.GetGroundHit( out _hit );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hit);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_center(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.center);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_radius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.radius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_suspensionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.suspensionDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_suspensionSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.suspensionSpring);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_suspensionExpansionLimited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.suspensionExpansionLimited);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forceAppPointDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.forceAppPointDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wheelDampingRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.wheelDampingRate);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_forwardFriction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.forwardFriction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sidewaysFriction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sidewaysFriction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_motorTorque(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.motorTorque);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_brakeTorque(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.brakeTorque);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_steerAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.steerAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isGrounded(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isGrounded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rpm(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.rpm);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sprungMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sprungMass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_center(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.center = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_radius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.radius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_suspensionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.suspensionDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_suspensionSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.JointSpring gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.suspensionSpring = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_suspensionExpansionLimited(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.suspensionExpansionLimited = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forceAppPointDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.forceAppPointDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mass = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wheelDampingRate(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.wheelDampingRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_forwardFriction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.WheelFrictionCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.forwardFriction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sidewaysFriction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                UnityEngine.WheelFrictionCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.sidewaysFriction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_motorTorque(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.motorTorque = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_brakeTorque(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.brakeTorque = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_steerAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.steerAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sprungMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.WheelCollider gen_to_be_invoked = (UnityEngine.WheelCollider)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sprungMass = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
