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
    public class UnityEnginePhysicsScene2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.PhysicsScene2D);
			Utils.BeginObjectRegister(type, L, translator, 1, 17, 0, 0);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", _m_GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsValid", _m_IsValid);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsEmpty", _m_IsEmpty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Simulate", _m_Simulate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Linecast", _m_Linecast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CircleCast", _m_CircleCast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BoxCast", _m_BoxCast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CapsuleCast", _m_CapsuleCast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRayIntersection", _m_GetRayIntersection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapPoint", _m_OverlapPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapCircle", _m_OverlapCircle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapBox", _m_OverlapBox);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapArea", _m_OverlapArea);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OverlapCapsule", _m_OverlapCapsule);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCollider", _m_OverlapCollider_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(UnityEngine.PhysicsScene2D));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D constructor!");
            
        }
        
		
        
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			
				if (translator.Assignable<UnityEngine.PhysicsScene2D>(L, 1) && translator.Assignable<UnityEngine.PhysicsScene2D>(L, 2))
				{
					UnityEngine.PhysicsScene2D leftside;translator.Get(L, 1, out leftside);
					UnityEngine.PhysicsScene2D rightside;translator.Get(L, 2, out rightside);
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
            
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.PhysicsScene2D!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
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
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
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
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _other = translator.GetObject(L, 2, typeof(object));
                    
                        var gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.PhysicsScene2D>(L, 2)) 
                {
                    UnityEngine.PhysicsScene2D _other;translator.Get(L, 2, out _other);
                    
                        var gen_ret = gen_to_be_invoked.Equals( _other );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsValid(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
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
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
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
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    float _step = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.Simulate( _step );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Linecast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 5)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 2, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 3, out _end);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.Linecast( _start, _end, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.Linecast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.Raycast( _origin, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.CircleCast( _origin, _radius, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.CircleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 7, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 7)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 7, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 8, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 7)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 7, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.BoxCast( _origin, _size, _angle, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.BoxCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 8, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 8, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 9);
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 8, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 8)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 8, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 9, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Vector2>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 8)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 4, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Vector2 _direction;translator.Get(L, 6, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 8, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 9, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = gen_to_be_invoked.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.CapsuleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersection(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.GetRayIntersection( _ray, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetRayIntersection( _ray, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Ray>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.GetRayIntersection( _ray, _distance, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 2, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = gen_to_be_invoked.GetRayIntersection( _ray, _distance, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.GetRayIntersection!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPoint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.OverlapPoint( _point, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.OverlapPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCircle( _point, _radius, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.OverlapCircle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBox(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 6, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.OverlapBox( _point, _size, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.OverlapBox!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapArea(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 5)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 2, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 3, out _pointB);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.OverlapArea( _pointA, _pointB, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.OverlapArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsule(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.PhysicsScene2D gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle, _contactFilter );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 6, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 6, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 7, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 2, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 3, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 4, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = gen_to_be_invoked.OverlapCapsule( _point, _size, _direction, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.OverlapCapsule!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCollider_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.PhysicsScene2D.OverlapCollider( _collider, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.PhysicsScene2D.OverlapCollider( _collider, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.PhysicsScene2D.OverlapCollider( _collider, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.PhysicsScene2D.OverlapCollider( _collider, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.PhysicsScene2D.OverlapCollider!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
