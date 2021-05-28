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
    public class UnityEngineRigidbodyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Rigidbody);
			Utils.BeginObjectRegister(type, L, translator, 0, 19, 23, 22);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDensity", _m_SetDensity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MovePosition", _m_MovePosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveRotation", _m_MoveRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Sleep", _m_Sleep);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSleeping", _m_IsSleeping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WakeUp", _m_WakeUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetCenterOfMass", _m_ResetCenterOfMass);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetInertiaTensor", _m_ResetInertiaTensor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRelativePointVelocity", _m_GetRelativePointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPointVelocity", _m_GetPointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddForce", _m_AddForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRelativeForce", _m_AddRelativeForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTorque", _m_AddTorque);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRelativeTorque", _m_AddRelativeTorque);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddForceAtPosition", _m_AddForceAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddExplosionForce", _m_AddExplosionForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClosestPointOnBounds", _m_ClosestPointOnBounds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SweepTest", _m_SweepTest);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SweepTestAll", _m_SweepTestAll);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", _g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularVelocity", _g_get_angularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drag", _g_get_drag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularDrag", _g_get_angularDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mass", _g_get_mass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useGravity", _g_get_useGravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxDepenetrationVelocity", _g_get_maxDepenetrationVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isKinematic", _g_get_isKinematic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "freezeRotation", _g_get_freezeRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constraints", _g_get_constraints);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collisionDetectionMode", _g_get_collisionDetectionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "centerOfMass", _g_get_centerOfMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCenterOfMass", _g_get_worldCenterOfMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertiaTensorRotation", _g_get_inertiaTensorRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertiaTensor", _g_get_inertiaTensor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "detectCollisions", _g_get_detectCollisions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotation", _g_get_rotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interpolation", _g_get_interpolation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "solverIterations", _g_get_solverIterations);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sleepThreshold", _g_get_sleepThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxAngularVelocity", _g_get_maxAngularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "solverVelocityIterations", _g_get_solverVelocityIterations);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocity", _s_set_velocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularVelocity", _s_set_angularVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drag", _s_set_drag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularDrag", _s_set_angularDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mass", _s_set_mass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useGravity", _s_set_useGravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxDepenetrationVelocity", _s_set_maxDepenetrationVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isKinematic", _s_set_isKinematic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "freezeRotation", _s_set_freezeRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "constraints", _s_set_constraints);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "collisionDetectionMode", _s_set_collisionDetectionMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "centerOfMass", _s_set_centerOfMass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertiaTensorRotation", _s_set_inertiaTensorRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertiaTensor", _s_set_inertiaTensor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "detectCollisions", _s_set_detectCollisions);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotation", _s_set_rotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interpolation", _s_set_interpolation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "solverIterations", _s_set_solverIterations);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sleepThreshold", _s_set_sleepThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxAngularVelocity", _s_set_maxAngularVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "solverVelocityIterations", _s_set_solverVelocityIterations);
            
			
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
					
					var gen_ret = new UnityEngine.Rigidbody();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDensity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _density = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.SetDensity( _density );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MovePosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                    gen_to_be_invoked.MovePosition( _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveRotation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Quaternion _rot;translator.Get(L, 2, out _rot);
                    
                    gen_to_be_invoked.MoveRotation( _rot );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Sleep(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Sleep(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSleeping(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsSleeping(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WakeUp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.WakeUp(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetCenterOfMass(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetCenterOfMass(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetInertiaTensor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetInertiaTensor(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRelativePointVelocity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _relativePoint;translator.Get(L, 2, out _relativePoint);
                    
                        var gen_ret = gen_to_be_invoked.GetRelativePointVelocity( _relativePoint );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPointVelocity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _worldPoint;translator.Get(L, 2, out _worldPoint);
                    
                        var gen_ret = gen_to_be_invoked.GetPointVelocity( _worldPoint );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddForce( _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    
                    gen_to_be_invoked.AddForce( _force );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ForceMode>(L, 5)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ForceMode _mode;translator.Get(L, 5, out _mode);
                    
                    gen_to_be_invoked.AddForce( _x, _y, _z, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.ForceMode>(L, 3)) 
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    UnityEngine.ForceMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddForce( _force, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.AddForce!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRelativeForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddRelativeForce( _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    
                    gen_to_be_invoked.AddRelativeForce( _force );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ForceMode>(L, 5)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ForceMode _mode;translator.Get(L, 5, out _mode);
                    
                    gen_to_be_invoked.AddRelativeForce( _x, _y, _z, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.ForceMode>(L, 3)) 
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    UnityEngine.ForceMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddRelativeForce( _force, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.AddRelativeForce!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTorque(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddTorque( _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _torque;translator.Get(L, 2, out _torque);
                    
                    gen_to_be_invoked.AddTorque( _torque );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ForceMode>(L, 5)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ForceMode _mode;translator.Get(L, 5, out _mode);
                    
                    gen_to_be_invoked.AddTorque( _x, _y, _z, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.ForceMode>(L, 3)) 
                {
                    UnityEngine.Vector3 _torque;translator.Get(L, 2, out _torque);
                    UnityEngine.ForceMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddTorque( _torque, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.AddTorque!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRelativeTorque(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddRelativeTorque( _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _torque;translator.Get(L, 2, out _torque);
                    
                    gen_to_be_invoked.AddRelativeTorque( _torque );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ForceMode>(L, 5)) 
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ForceMode _mode;translator.Get(L, 5, out _mode);
                    
                    gen_to_be_invoked.AddRelativeTorque( _x, _y, _z, _mode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.ForceMode>(L, 3)) 
                {
                    UnityEngine.Vector3 _torque;translator.Get(L, 2, out _torque);
                    UnityEngine.ForceMode _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddRelativeTorque( _torque, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.AddRelativeTorque!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddForceAtPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    
                    gen_to_be_invoked.AddForceAtPosition( _force, _position );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.ForceMode>(L, 4)) 
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    UnityEngine.ForceMode _mode;translator.Get(L, 4, out _mode);
                    
                    gen_to_be_invoked.AddForceAtPosition( _force, _position, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.AddForceAtPosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddExplosionForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _explosionForce = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 _explosionPosition;translator.Get(L, 3, out _explosionPosition);
                    float _explosionRadius = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.AddExplosionForce( _explosionForce, _explosionPosition, _explosionRadius );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    float _explosionForce = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 _explosionPosition;translator.Get(L, 3, out _explosionPosition);
                    float _explosionRadius = (float)LuaAPI.lua_tonumber(L, 4);
                    float _upwardsModifier = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    gen_to_be_invoked.AddExplosionForce( _explosionForce, _explosionPosition, _explosionRadius, _upwardsModifier );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ForceMode>(L, 6)) 
                {
                    float _explosionForce = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector3 _explosionPosition;translator.Get(L, 3, out _explosionPosition);
                    float _explosionRadius = (float)LuaAPI.lua_tonumber(L, 4);
                    float _upwardsModifier = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ForceMode _mode;translator.Get(L, 6, out _mode);
                    
                    gen_to_be_invoked.AddExplosionForce( _explosionForce, _explosionPosition, _explosionRadius, _upwardsModifier, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.AddExplosionForce!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClosestPointOnBounds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    
                        var gen_ret = gen_to_be_invoked.ClosestPointOnBounds( _position );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SweepTest(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    
                        var gen_ret = gen_to_be_invoked.SweepTest( _direction, out _hitInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.SweepTest( _direction, out _hitInfo, _maxDistance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 4, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.SweepTest( _direction, out _hitInfo, _maxDistance, _queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.SweepTest!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SweepTestAll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    
                        var gen_ret = gen_to_be_invoked.SweepTestAll( _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.SweepTestAll( _direction, _maxDistance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 4)) 
                {
                    UnityEngine.Vector3 _direction;translator.Get(L, 2, out _direction);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 4, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.SweepTestAll( _direction, _maxDistance, _queryTriggerInteraction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody.SweepTestAll!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.velocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.angularVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.drag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angularDrag);
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
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useGravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useGravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxDepenetrationVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxDepenetrationVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isKinematic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isKinematic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_freezeRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.freezeRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constraints(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.constraints);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_collisionDetectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.collisionDetectionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_centerOfMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.centerOfMass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldCenterOfMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.worldCenterOfMass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inertiaTensorRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.inertiaTensorRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inertiaTensor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.inertiaTensor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_detectCollisions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.detectCollisions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.position);
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
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.rotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_interpolation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interpolation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_solverIterations(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.solverIterations);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sleepThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sleepThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxAngularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxAngularVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_solverVelocityIterations(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.solverVelocityIterations);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.velocity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularVelocity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.drag = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularDrag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angularDrag = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mass = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useGravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useGravity = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxDepenetrationVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxDepenetrationVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isKinematic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isKinematic = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_freezeRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.freezeRotation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_constraints(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.RigidbodyConstraints gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.constraints = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_collisionDetectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.CollisionDetectionMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.collisionDetectionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_centerOfMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.centerOfMass = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inertiaTensorRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.inertiaTensorRotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inertiaTensor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.inertiaTensor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_detectCollisions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.detectCollisions = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.position = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_interpolation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                UnityEngine.RigidbodyInterpolation gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.interpolation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_solverIterations(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.solverIterations = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sleepThreshold(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sleepThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxAngularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxAngularVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_solverVelocityIterations(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody gen_to_be_invoked = (UnityEngine.Rigidbody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.solverVelocityIterations = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
