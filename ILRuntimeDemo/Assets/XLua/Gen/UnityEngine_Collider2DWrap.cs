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
    public class UnityEngineCollider2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Collider2D);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 12, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateMesh", _m_CreateMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetShapeHash", _m_GetShapeHash);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsTouching", _m_IsTouching);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsTouchingLayers", _m_IsTouchingLayers);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapPoint", _m_OverlapPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Distance", _m_Distance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapCollider", _m_OverlapCollider);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetContacts", _m_GetContacts);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Cast", _m_Cast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClosestPoint", _m_ClosestPoint);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "density", _g_get_density);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isTrigger", _g_get_isTrigger);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usedByEffector", _g_get_usedByEffector);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usedByComposite", _g_get_usedByComposite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "composite", _g_get_composite);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "offset", _g_get_offset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "attachedRigidbody", _g_get_attachedRigidbody);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shapeCount", _g_get_shapeCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounds", _g_get_bounds);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMaterial", _g_get_sharedMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "friction", _g_get_friction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bounciness", _g_get_bounciness);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "density", _s_set_density);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isTrigger", _s_set_isTrigger);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "usedByEffector", _s_set_usedByEffector);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "usedByComposite", _s_set_usedByComposite);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "offset", _s_set_offset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMaterial", _s_set_sharedMaterial);
            
			
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
					
					var gen_ret = new UnityEngine.Collider2D();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _useBodyPosition = LuaAPI.lua_toboolean(L, 2);
                    bool _useBodyRotation = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.CreateMesh( _useBodyPosition, _useBodyRotation );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetShapeHash(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetShapeHash(  );
                        LuaAPI.xlua_pushuint(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D.IsTouching!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouchingLayers(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D.IsTouchingLayers!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
                
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
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _m_OverlapCollider(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCollider( _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D.OverlapCollider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetContacts(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D.GetContacts!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
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
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    bool _ignoreSiblingColliders = LuaAPI.lua_toboolean(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _results, _distance, _ignoreSiblingColliders );
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
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    bool _ignoreSiblingColliders = LuaAPI.lua_toboolean(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _contactFilter, _results, _distance, _ignoreSiblingColliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    bool _ignoreSiblingColliders = LuaAPI.lua_toboolean(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _contactFilter, _results, _distance, _ignoreSiblingColliders );
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
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.Cast( _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D.Cast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _results, _distance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _results, _distance, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _results, _distance, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Collider2D.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClosestPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_density(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.density);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isTrigger(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isTrigger);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usedByEffector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.usedByEffector);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usedByComposite(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.usedByComposite);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_composite(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.composite);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_offset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.offset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_attachedRigidbody(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.attachedRigidbody);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shapeCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.shapeCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bounds(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, gen_to_be_invoked.bounds);
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
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sharedMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_friction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.friction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bounciness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.bounciness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_density(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.density = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isTrigger(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isTrigger = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_usedByEffector(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.usedByEffector = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_usedByComposite(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.usedByComposite = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_offset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.offset = gen_value;
            
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
			
                UnityEngine.Collider2D gen_to_be_invoked = (UnityEngine.Collider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sharedMaterial = (UnityEngine.PhysicsMaterial2D)translator.GetObject(L, 2, typeof(UnityEngine.PhysicsMaterial2D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
