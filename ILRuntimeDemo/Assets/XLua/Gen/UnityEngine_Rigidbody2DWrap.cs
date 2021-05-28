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
    public class UnityEngineRigidbody2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Rigidbody2D);
			Utils.BeginObjectRegister(type, L, translator, 0, 26, 23, 21);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRotation", _m_SetRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MovePosition", _m_MovePosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveRotation", _m_MoveRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSleeping", _m_IsSleeping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAwake", _m_IsAwake);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Sleep", _m_Sleep);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WakeUp", _m_WakeUp);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsTouching", _m_IsTouching);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsTouchingLayers", _m_IsTouchingLayers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapPoint", _m_OverlapPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Distance", _m_Distance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClosestPoint", _m_ClosestPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddForce", _m_AddForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRelativeForce", _m_AddRelativeForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddForceAtPosition", _m_AddForceAtPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTorque", _m_AddTorque);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPoint", _m_GetPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRelativePoint", _m_GetRelativePoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVector", _m_GetVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRelativeVector", _m_GetRelativeVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPointVelocity", _m_GetPointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRelativePointVelocity", _m_GetRelativePointVelocity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapCollider", _m_OverlapCollider);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetContacts", _m_GetContacts);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAttachedColliders", _m_GetAttachedColliders);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cast", _m_Cast);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", _g_get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotation", _g_get_rotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocity", _g_get_velocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularVelocity", _g_get_angularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useAutoMass", _g_get_useAutoMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mass", _g_get_mass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMaterial", _g_get_sharedMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "centerOfMass", _g_get_centerOfMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldCenterOfMass", _g_get_worldCenterOfMass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "inertia", _g_get_inertia);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drag", _g_get_drag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularDrag", _g_get_angularDrag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravityScale", _g_get_gravityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bodyType", _g_get_bodyType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useFullKinematicContacts", _g_get_useFullKinematicContacts);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isKinematic", _g_get_isKinematic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "freezeRotation", _g_get_freezeRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constraints", _g_get_constraints);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "simulated", _g_get_simulated);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "interpolation", _g_get_interpolation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sleepMode", _g_get_sleepMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collisionDetectionMode", _g_get_collisionDetectionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attachedColliderCount", _g_get_attachedColliderCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", _s_set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotation", _s_set_rotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocity", _s_set_velocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularVelocity", _s_set_angularVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useAutoMass", _s_set_useAutoMass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mass", _s_set_mass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMaterial", _s_set_sharedMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "centerOfMass", _s_set_centerOfMass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "inertia", _s_set_inertia);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drag", _s_set_drag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularDrag", _s_set_angularDrag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gravityScale", _s_set_gravityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bodyType", _s_set_bodyType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useFullKinematicContacts", _s_set_useFullKinematicContacts);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isKinematic", _s_set_isKinematic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "freezeRotation", _s_set_freezeRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "constraints", _s_set_constraints);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "simulated", _s_set_simulated);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "interpolation", _s_set_interpolation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sleepMode", _s_set_sleepMode);
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
					
					var gen_ret = new UnityEngine.Rigidbody2D();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRotation(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _angle = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.SetRotation( _angle );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Quaternion>(L, 2)) 
                {
                    UnityEngine.Quaternion _rotation;translator.Get(L, 2, out _rotation);
                    
                    gen_to_be_invoked.SetRotation( _rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.SetRotation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MovePosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _position;translator.Get(L, 2, out _position);
                    
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
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _angle = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.MoveRotation( _angle );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Quaternion>(L, 2)) 
                {
                    UnityEngine.Quaternion _rotation;translator.Get(L, 2, out _rotation);
                    
                    gen_to_be_invoked.MoveRotation( _rotation );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.MoveRotation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSleeping(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_IsAwake(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsAwake(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Sleep(  );
                    
                    
                    
                    return 0;
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
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.WakeUp(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouching(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = gen_to_be_invoked.IsTouching( _collider );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.IsTouching( _contactFilter );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.IsTouching( _collider, _contactFilter );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.IsTouching!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouchingLayers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.IsTouchingLayers(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.IsTouchingLayers( _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.IsTouchingLayers!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Distance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = gen_to_be_invoked.Distance( _collider );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClosestPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _position;translator.Get(L, 2, out _position);
                    
                        var gen_ret = gen_to_be_invoked.ClosestPoint( _position );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
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
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _force;translator.Get(L, 2, out _force);
                    
                    gen_to_be_invoked.AddForce( _force );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ForceMode2D>(L, 3)) 
                {
                    UnityEngine.Vector2 _force;translator.Get(L, 2, out _force);
                    UnityEngine.ForceMode2D _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddForce( _force, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.AddForce!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddRelativeForce(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _relativeForce;translator.Get(L, 2, out _relativeForce);
                    
                    gen_to_be_invoked.AddRelativeForce( _relativeForce );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ForceMode2D>(L, 3)) 
                {
                    UnityEngine.Vector2 _relativeForce;translator.Get(L, 2, out _relativeForce);
                    UnityEngine.ForceMode2D _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddRelativeForce( _relativeForce, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.AddRelativeForce!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddForceAtPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 _force;translator.Get(L, 2, out _force);
                    UnityEngine.Vector2 _position;translator.Get(L, 3, out _position);
                    
                    gen_to_be_invoked.AddForceAtPosition( _force, _position );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ForceMode2D>(L, 4)) 
                {
                    UnityEngine.Vector2 _force;translator.Get(L, 2, out _force);
                    UnityEngine.Vector2 _position;translator.Get(L, 3, out _position);
                    UnityEngine.ForceMode2D _mode;translator.Get(L, 4, out _mode);
                    
                    gen_to_be_invoked.AddForceAtPosition( _force, _position, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.AddForceAtPosition!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTorque(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float _torque = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.AddTorque( _torque );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ForceMode2D>(L, 3)) 
                {
                    float _torque = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.ForceMode2D _mode;translator.Get(L, 3, out _mode);
                    
                    gen_to_be_invoked.AddTorque( _torque, _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.AddTorque!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    
                        var gen_ret = gen_to_be_invoked.GetPoint( _point );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRelativePoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _relativePoint;translator.Get(L, 2, out _relativePoint);
                    
                        var gen_ret = gen_to_be_invoked.GetRelativePoint( _relativePoint );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _vector;translator.Get(L, 2, out _vector);
                    
                        var gen_ret = gen_to_be_invoked.GetVector( _vector );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRelativeVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _relativeVector;translator.Get(L, 2, out _relativeVector);
                    
                        var gen_ret = gen_to_be_invoked.GetRelativeVector( _relativeVector );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
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
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    
                        var gen_ret = gen_to_be_invoked.GetPointVelocity( _point );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
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
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector2 _relativePoint;translator.Get(L, 2, out _relativePoint);
                    
                        var gen_ret = gen_to_be_invoked.GetRelativePointVelocity( _relativePoint );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCollider(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCollider( _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCollider( _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.OverlapCollider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetContacts(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 2)) 
                {
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 2, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D[] _colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.Collider2D> _colliders = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 3, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _contactFilter, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _colliders = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.GetContacts( _contactFilter, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.GetContacts!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAttachedColliders(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.GetAttachedColliders( _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 2;
                }
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.GetAttachedColliders( _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.GetAttachedColliders!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 3)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Rigidbody2D.Cast!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.position);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.rotation);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.velocity);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angularVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useAutoMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useAutoMass);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.mass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sharedMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sharedMaterial);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.centerOfMass);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.worldCenterOfMass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_inertia(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.inertia);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.angularDrag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gravityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bodyType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bodyType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useFullKinematicContacts(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useFullKinematicContacts);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.constraints);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_simulated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.simulated);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.interpolation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sleepMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sleepMode);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.collisionDetectionMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attachedColliderCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.attachedColliderCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_position(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotation = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angularVelocity = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useAutoMass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useAutoMass = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mass = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sharedMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sharedMaterial = (UnityEngine.PhysicsMaterial2D)translator.GetObject(L, 2, typeof(UnityEngine.PhysicsMaterial2D));
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.centerOfMass = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_inertia(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.inertia = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.angularDrag = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gravityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bodyType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.RigidbodyType2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.bodyType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useFullKinematicContacts(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useFullKinematicContacts = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.RigidbodyConstraints2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.constraints = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_simulated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.simulated = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.RigidbodyInterpolation2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.interpolation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sleepMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.RigidbodySleepMode2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.sleepMode = gen_value;
            
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
			
                UnityEngine.Rigidbody2D gen_to_be_invoked = (UnityEngine.Rigidbody2D)translator.FastGetCSObj(L, 1);
                UnityEngine.CollisionDetectionMode2D gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.collisionDetectionMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
