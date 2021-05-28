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
    public class UnityEnginePhysicsSceneWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.PhysicsScene);
			Utils.BeginObjectRegister(type, L, translator, 1, 13, 0, 0);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsValid", _m_IsValid);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEmpty", _m_IsEmpty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Simulate", _m_Simulate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CapsuleCast", _m_CapsuleCast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapCapsule", _m_OverlapCapsule);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SphereCast", _m_SphereCast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapSphere", _m_OverlapSphere);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BoxCast", _m_BoxCast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapBox", _m_OverlapBox);
			
			
			
			
			
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
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(UnityEngine.PhysicsScene));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<UnityEngine.PhysicsScene>(L, 1) && translator.Assignable<UnityEngine.PhysicsScene>(L, 2))
				{
					UnityEngine.PhysicsScene leftside;translator.Get(L, 1, out leftside);
					UnityEngine.PhysicsScene rightside;translator.Get(L, 2, out rightside);
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.PhysicsScene!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHashCode(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _other = translator.GetObject(L, 2, typeof(object));
                    
                        var gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.PhysicsScene>(L, 2)) 
                {
                    UnityEngine.PhysicsScene _other;translator.Get(L, 2, out _other);
                    
                        var gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsValid(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsValid(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsEmpty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsEmpty(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Simulate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    float _step = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.Simulate( _step );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 6, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _maxDistance, _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _maxDistance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 6)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 6, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, out _hitInfo, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, out _hitInfo, _maxDistance, _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, out _hitInfo, _maxDistance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, out _hitInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit[] _raycastHits = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 7, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _raycastHits, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit[] _raycastHits = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _raycastHits, _maxDistance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit[] _raycastHits = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _raycastHits, _maxDistance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 4)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit[] _raycastHits = (UnityEngine.RaycastHit[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit[]));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _raycastHits );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 8)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 8, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, out _hitInfo, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, out _hitInfo, _maxDistance, _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, out _hitInfo, _maxDistance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, out _hitInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 9)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 9, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, _results, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, _results, _maxDistance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, _results, _maxDistance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector3>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 6)) 
                {
                    UnityEngine.Vector3 _point1;translator.Get(L, 2, out _point1);
                    UnityEngine.Vector3 _point2;translator.Get(L, 3, out _point2);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector3 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit[]));
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _point1, _point2, _radius, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.CapsuleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsule(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 _point0;translator.Get(L, 2, out _point0);
                    UnityEngine.Vector3 _point1;translator.Get(L, 3, out _point1);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 5, typeof(UnityEngine.Collider[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 7, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point0, _point1, _radius, _results, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _point0;translator.Get(L, 2, out _point0);
                    UnityEngine.Vector3 _point1;translator.Get(L, 3, out _point1);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 5, typeof(UnityEngine.Collider[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point0, _point1, _radius, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider[]>(L, 5)) 
                {
                    UnityEngine.Vector3 _point0;translator.Get(L, 2, out _point0);
                    UnityEngine.Vector3 _point1;translator.Get(L, 3, out _point1);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 5, typeof(UnityEngine.Collider[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point0, _point1, _radius, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.OverlapCapsule!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SphereCast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 7, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, out _hitInfo, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, out _hitInfo, _maxDistance, _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, out _hitInfo, _maxDistance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, out _hitInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 8)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 8, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, _results, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, _results, _maxDistance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, _results, _maxDistance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    
                        var gen_ret = gen_to_be_invoked.SphereCast( _origin, _radius, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.SphereCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapSphere(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 6, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.OverlapSphere( _position, _radius, _results, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, out _hitInfo );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 8)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 8, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, out _hitInfo, _orientation, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, out _hitInfo, _orientation, _maxDistance, _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, out _hitInfo, _orientation, _maxDistance );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit _hitInfo;
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, out _hitInfo, _orientation );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _hitInfo);
                        
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 2;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& translator.Assignable<UnityEngine.Quaternion>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 9)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 6, out _orientation);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 9, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, _results, _orientation, _maxDistance, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& translator.Assignable<UnityEngine.Quaternion>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 6, out _orientation);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, _results, _orientation, _maxDistance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& translator.Assignable<UnityEngine.Quaternion>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 6, out _orientation);
                    float _maxDistance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, _results, _orientation, _maxDistance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit[]>(L, 5)&& translator.Assignable<UnityEngine.Quaternion>(L, 6)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Vector3 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit[] _results = (UnityEngine.RaycastHit[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 6, out _orientation);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _center, _halfExtents, _direction, _results, _orientation );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.BoxCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBox(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _center, _halfExtents, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.QueryTriggerInteraction>(L, 7)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.QueryTriggerInteraction _queryTriggerInteraction;translator.Get(L, 7, out _queryTriggerInteraction);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _center, _halfExtents, _results, _orientation, _layerMask, _queryTriggerInteraction );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _center, _halfExtents, _results, _orientation, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Collider[]>(L, 4)&& translator.Assignable<UnityEngine.Quaternion>(L, 5)) 
                {
                    UnityEngine.Vector3 _center;translator.Get(L, 2, out _center);
                    UnityEngine.Vector3 _halfExtents;translator.Get(L, 3, out _halfExtents);
                    UnityEngine.Collider[] _results = (UnityEngine.Collider[])translator.GetObject(L, 4, typeof(UnityEngine.Collider[]));
                    UnityEngine.Quaternion _orientation;translator.Get(L, 5, out _orientation);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _center, _halfExtents, _results, _orientation );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene.OverlapBox!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
