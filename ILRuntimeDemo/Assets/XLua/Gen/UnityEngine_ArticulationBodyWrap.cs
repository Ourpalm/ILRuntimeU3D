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
    public class UnityEngineArticulationBodyWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ArticulationBody);
			Utils.BeginObjectRegister(type, L, translator, 0, 29, 42, 38);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddForce", _m_AddForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRelativeForce", _m_AddRelativeForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTorque", _m_AddTorque);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRelativeTorque", _m_AddRelativeTorque);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddForceAtPosition", _m_AddForceAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetCenterOfMass", _m_ResetCenterOfMass);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetInertiaTensor", _m_ResetInertiaTensor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Sleep", _m_Sleep);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSleeping", _m_IsSleeping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WakeUp", _m_WakeUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TeleportRoot", _m_TeleportRoot);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetClosestPoint", _m_GetClosestPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRelativePointVelocity", _m_GetRelativePointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPointVelocity", _m_GetPointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDenseJacobian", _m_GetDenseJacobian);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetJointPositions", _m_GetJointPositions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetJointPositions", _m_SetJointPositions);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetJointVelocities", _m_GetJointVelocities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetJointVelocities", _m_SetJointVelocities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetJointAccelerations", _m_GetJointAccelerations);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetJointAccelerations", _m_SetJointAccelerations);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetJointForces", _m_GetJointForces);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetJointForces", _m_SetJointForces);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDriveTargets", _m_GetDriveTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDriveTargets", _m_SetDriveTargets);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDriveTargetVelocities", _m_GetDriveTargetVelocities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetDriveTargetVelocities", _m_SetDriveTargetVelocities);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDofStartIndices", _m_GetDofStartIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SnapAnchorToClosestContact", _m_SnapAnchorToClosestContact);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointType", _g_get_jointType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorPosition", _g_get_anchorPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parentAnchorPosition", _g_get_parentAnchorPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anchorRotation", _g_get_anchorRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parentAnchorRotation", _g_get_parentAnchorRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isRoot", _g_get_isRoot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "computeParentAnchor", _g_get_computeParentAnchor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearLockX", _g_get_linearLockX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearLockY", _g_get_linearLockY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearLockZ", _g_get_linearLockZ);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swingYLock", _g_get_swingYLock);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swingZLock", _g_get_swingZLock);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "twistLock", _g_get_twistLock);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xDrive", _g_get_xDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "yDrive", _g_get_yDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "zDrive", _g_get_zDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "immovable", _g_get_immovable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useGravity", _g_get_useGravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearDamping", _g_get_linearDamping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularDamping", _g_get_angularDamping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointFriction", _g_get_jointFriction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", _g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularVelocity", _g_get_angularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mass", _g_get_mass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "centerOfMass", _g_get_centerOfMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCenterOfMass", _g_get_worldCenterOfMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertiaTensor", _g_get_inertiaTensor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertiaTensorRotation", _g_get_inertiaTensorRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sleepThreshold", _g_get_sleepThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "solverIterations", _g_get_solverIterations);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "solverVelocityIterations", _g_get_solverVelocityIterations);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxAngularVelocity", _g_get_maxAngularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxLinearVelocity", _g_get_maxLinearVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxJointVelocity", _g_get_maxJointVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxDepenetrationVelocity", _g_get_maxDepenetrationVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointPosition", _g_get_jointPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointVelocity", _g_get_jointVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointAcceleration", _g_get_jointAcceleration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "jointForce", _g_get_jointForce);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "dofCount", _g_get_dofCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "index", _g_get_index);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collisionDetectionMode", _g_get_collisionDetectionMode);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "jointType", _s_set_jointType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchorPosition", _s_set_anchorPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parentAnchorPosition", _s_set_parentAnchorPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anchorRotation", _s_set_anchorRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parentAnchorRotation", _s_set_parentAnchorRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "computeParentAnchor", _s_set_computeParentAnchor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearLockX", _s_set_linearLockX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearLockY", _s_set_linearLockY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearLockZ", _s_set_linearLockZ);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swingYLock", _s_set_swingYLock);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swingZLock", _s_set_swingZLock);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "twistLock", _s_set_twistLock);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xDrive", _s_set_xDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "yDrive", _s_set_yDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "zDrive", _s_set_zDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "immovable", _s_set_immovable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useGravity", _s_set_useGravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearDamping", _s_set_linearDamping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularDamping", _s_set_angularDamping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "jointFriction", _s_set_jointFriction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocity", _s_set_velocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularVelocity", _s_set_angularVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mass", _s_set_mass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "centerOfMass", _s_set_centerOfMass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertiaTensor", _s_set_inertiaTensor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertiaTensorRotation", _s_set_inertiaTensorRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sleepThreshold", _s_set_sleepThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "solverIterations", _s_set_solverIterations);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "solverVelocityIterations", _s_set_solverVelocityIterations);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxAngularVelocity", _s_set_maxAngularVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxLinearVelocity", _s_set_maxLinearVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxJointVelocity", _s_set_maxJointVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxDepenetrationVelocity", _s_set_maxDepenetrationVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "jointPosition", _s_set_jointPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "jointVelocity", _s_set_jointVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "jointAcceleration", _s_set_jointAcceleration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "jointForce", _s_set_jointForce);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "collisionDetectionMode", _s_set_collisionDetectionMode);
            
			
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
					
					var gen_ret = new UnityEngine.ArticulationBody();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ArticulationBody constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    
                    gen_to_be_invoked.AddForce( _force );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRelativeForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    
                    gen_to_be_invoked.AddRelativeForce( _force );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTorque(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _torque;translator.Get(L, 2, out _torque);
                    
                    gen_to_be_invoked.AddTorque( _torque );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRelativeTorque(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _torque;translator.Get(L, 2, out _torque);
                    
                    gen_to_be_invoked.AddRelativeTorque( _torque );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddForceAtPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _force;translator.Get(L, 2, out _force);
                    UnityEngine.Vector3 _position;translator.Get(L, 3, out _position);
                    
                    gen_to_be_invoked.AddForceAtPosition( _force, _position );
                    
                    
                    
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetInertiaTensor(  );
                    
                    
                    
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.WakeUp(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TeleportRoot(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    
                    gen_to_be_invoked.TeleportRoot( _position, _rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetClosestPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _point;translator.Get(L, 2, out _point);
                    
                        var gen_ret = gen_to_be_invoked.GetClosestPoint( _point );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_GetDenseJacobian(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.ArticulationJacobian _jacobian;translator.Get(L, 2, out _jacobian);
                    
                        var gen_ret = gen_to_be_invoked.GetDenseJacobian( ref _jacobian );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    translator.Push(L, _jacobian);
                        translator.Update(L, 2, _jacobian);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetJointPositions(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _positions = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                        var gen_ret = gen_to_be_invoked.GetJointPositions( _positions );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetJointPositions(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _positions = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetJointPositions( _positions );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetJointVelocities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _velocities = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                        var gen_ret = gen_to_be_invoked.GetJointVelocities( _velocities );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetJointVelocities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _velocities = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetJointVelocities( _velocities );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetJointAccelerations(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _accelerations = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                        var gen_ret = gen_to_be_invoked.GetJointAccelerations( _accelerations );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetJointAccelerations(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _accelerations = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetJointAccelerations( _accelerations );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetJointForces(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _forces = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                        var gen_ret = gen_to_be_invoked.GetJointForces( _forces );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetJointForces(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _forces = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetJointForces( _forces );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDriveTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _targets = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                        var gen_ret = gen_to_be_invoked.GetDriveTargets( _targets );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDriveTargets(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _targets = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetDriveTargets( _targets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDriveTargetVelocities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _targetVelocities = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                        var gen_ret = gen_to_be_invoked.GetDriveTargetVelocities( _targetVelocities );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetDriveTargetVelocities(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<float> _targetVelocities = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetDriveTargetVelocities( _targetVelocities );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDofStartIndices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<int> _dofStartIndices = (System.Collections.Generic.List<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<int>));
                    
                        var gen_ret = gen_to_be_invoked.GetDofStartIndices( _dofStartIndices );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SnapAnchorToClosestContact(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SnapAnchorToClosestContact(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.jointType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anchorPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.anchorPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parentAnchorPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.parentAnchorPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anchorRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.anchorRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_parentAnchorRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.parentAnchorRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_computeParentAnchor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.computeParentAnchor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearLockX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.linearLockX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearLockY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.linearLockY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearLockZ(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.linearLockZ);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swingYLock(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.swingYLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swingZLock(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.swingZLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_twistLock(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.twistLock);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.xDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_yDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.yDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_zDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.zDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_immovable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.immovable);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useGravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.linearDamping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angularDamping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointFriction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.jointFriction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.angularVelocity);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mass);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.worldCenterOfMass);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.inertiaTensor);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.inertiaTensorRotation);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sleepThreshold);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.solverIterations);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.solverVelocityIterations);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxAngularVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLinearVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxLinearVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxJointVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxJointVelocity);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxDepenetrationVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.jointPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.jointVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointAcceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.jointAcceleration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jointForce(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.jointForce);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_dofCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.dofCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_index(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.index);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.collisionDetectionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jointType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationJointType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.jointType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_anchorPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.anchorPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_parentAnchorPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.parentAnchorPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_anchorRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.anchorRotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_parentAnchorRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.parentAnchorRotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_computeParentAnchor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.computeParentAnchor = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearLockX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDofLock gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.linearLockX = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearLockY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDofLock gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.linearLockY = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearLockZ(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDofLock gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.linearLockZ = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swingYLock(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDofLock gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.swingYLock = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swingZLock(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDofLock gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.swingZLock = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_twistLock(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDofLock gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.twistLock = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_xDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.xDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_yDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.yDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_zDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.zDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_immovable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.immovable = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useGravity = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.linearDamping = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularDamping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angularDamping = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jointFriction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.jointFriction = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularVelocity = gen_value;
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mass = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.centerOfMass = gen_value;
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.inertiaTensor = gen_value;
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.inertiaTensorRotation = gen_value;
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sleepThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.solverIterations = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.solverVelocityIterations = LuaAPI.xlua_tointeger(L, 2);
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxAngularVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLinearVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxLinearVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxJointVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxJointVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxDepenetrationVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jointPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationReducedSpace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.jointPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jointVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationReducedSpace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.jointVelocity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jointAcceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationReducedSpace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.jointAcceleration = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jointForce(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.ArticulationReducedSpace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.jointForce = gen_value;
            
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
			
                UnityEngine.ArticulationBody gen_to_be_invoked = (UnityEngine.ArticulationBody)translator.FastGetCSObj(L, 1);
                UnityEngine.CollisionDetectionMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.collisionDetectionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
