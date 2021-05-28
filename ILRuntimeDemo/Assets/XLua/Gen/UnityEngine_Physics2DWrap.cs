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
    public class UnityEnginePhysics2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Physics2D);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 51, 31, 30);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Simulate", _m_Simulate_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SyncTransforms", _m_SyncTransforms_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IgnoreCollision", _m_IgnoreCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIgnoreCollision", _m_GetIgnoreCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IgnoreLayerCollision", _m_IgnoreLayerCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetIgnoreLayerCollision", _m_GetIgnoreLayerCollision_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetLayerCollisionMask", _m_SetLayerCollisionMask_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetLayerCollisionMask", _m_GetLayerCollisionMask_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsTouching", _m_IsTouching_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsTouchingLayers", _m_IsTouchingLayers_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance", _m_Distance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClosestPoint", _m_ClosestPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Linecast", _m_Linecast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LinecastAll", _m_LinecastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LinecastNonAlloc", _m_LinecastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Raycast", _m_Raycast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RaycastNonAlloc", _m_RaycastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RaycastAll", _m_RaycastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CircleCast", _m_CircleCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CircleCastAll", _m_CircleCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CircleCastNonAlloc", _m_CircleCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCast", _m_BoxCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCastAll", _m_BoxCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoxCastNonAlloc", _m_BoxCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCast", _m_CapsuleCast_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCastAll", _m_CapsuleCastAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CapsuleCastNonAlloc", _m_CapsuleCastNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRayIntersection", _m_GetRayIntersection_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRayIntersectionAll", _m_GetRayIntersectionAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRayIntersectionNonAlloc", _m_GetRayIntersectionNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapPoint", _m_OverlapPoint_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapPointAll", _m_OverlapPointAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapPointNonAlloc", _m_OverlapPointNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCircle", _m_OverlapCircle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCircleAll", _m_OverlapCircleAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCircleNonAlloc", _m_OverlapCircleNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBox", _m_OverlapBox_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBoxAll", _m_OverlapBoxAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapBoxNonAlloc", _m_OverlapBoxNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapArea", _m_OverlapArea_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapAreaAll", _m_OverlapAreaAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapAreaNonAlloc", _m_OverlapAreaNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsule", _m_OverlapCapsule_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsuleAll", _m_OverlapCapsuleAll_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCapsuleNonAlloc", _m_OverlapCapsuleNonAlloc_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OverlapCollider", _m_OverlapCollider_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetContacts", _m_GetContacts_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "IgnoreRaycastLayer", UnityEngine.Physics2D.IgnoreRaycastLayer);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultRaycastLayers", UnityEngine.Physics2D.DefaultRaycastLayers);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AllLayers", UnityEngine.Physics2D.AllLayers);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultPhysicsScene", _g_get_defaultPhysicsScene);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "velocityIterations", _g_get_velocityIterations);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "positionIterations", _g_get_positionIterations);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gravity", _g_get_gravity);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "queriesHitTriggers", _g_get_queriesHitTriggers);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "queriesStartInColliders", _g_get_queriesStartInColliders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "callbacksOnDisable", _g_get_callbacksOnDisable);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "reuseCollisionCallbacks", _g_get_reuseCollisionCallbacks);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "autoSyncTransforms", _g_get_autoSyncTransforms);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "simulationMode", _g_get_simulationMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "jobOptions", _g_get_jobOptions);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "velocityThreshold", _g_get_velocityThreshold);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxLinearCorrection", _g_get_maxLinearCorrection);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxAngularCorrection", _g_get_maxAngularCorrection);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxTranslationSpeed", _g_get_maxTranslationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxRotationSpeed", _g_get_maxRotationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultContactOffset", _g_get_defaultContactOffset);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "baumgarteScale", _g_get_baumgarteScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "baumgarteTOIScale", _g_get_baumgarteTOIScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeToSleep", _g_get_timeToSleep);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "linearSleepTolerance", _g_get_linearSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "angularSleepTolerance", _g_get_angularSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "alwaysShowColliders", _g_get_alwaysShowColliders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showColliderSleep", _g_get_showColliderSleep);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showColliderContacts", _g_get_showColliderContacts);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "showColliderAABB", _g_get_showColliderAABB);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "contactArrowScale", _g_get_contactArrowScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderAwakeColor", _g_get_colliderAwakeColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderAsleepColor", _g_get_colliderAsleepColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderContactColor", _g_get_colliderContactColor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "colliderAABBColor", _g_get_colliderAABBColor);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "velocityIterations", _s_set_velocityIterations);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "positionIterations", _s_set_positionIterations);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "gravity", _s_set_gravity);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "queriesHitTriggers", _s_set_queriesHitTriggers);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "queriesStartInColliders", _s_set_queriesStartInColliders);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "callbacksOnDisable", _s_set_callbacksOnDisable);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "reuseCollisionCallbacks", _s_set_reuseCollisionCallbacks);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "autoSyncTransforms", _s_set_autoSyncTransforms);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "simulationMode", _s_set_simulationMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "jobOptions", _s_set_jobOptions);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "velocityThreshold", _s_set_velocityThreshold);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxLinearCorrection", _s_set_maxLinearCorrection);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxAngularCorrection", _s_set_maxAngularCorrection);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxTranslationSpeed", _s_set_maxTranslationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maxRotationSpeed", _s_set_maxRotationSpeed);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "defaultContactOffset", _s_set_defaultContactOffset);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "baumgarteScale", _s_set_baumgarteScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "baumgarteTOIScale", _s_set_baumgarteTOIScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "timeToSleep", _s_set_timeToSleep);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "linearSleepTolerance", _s_set_linearSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "angularSleepTolerance", _s_set_angularSleepTolerance);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "alwaysShowColliders", _s_set_alwaysShowColliders);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showColliderSleep", _s_set_showColliderSleep);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showColliderContacts", _s_set_showColliderContacts);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "showColliderAABB", _s_set_showColliderAABB);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "contactArrowScale", _s_set_contactArrowScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderAwakeColor", _s_set_colliderAwakeColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderAsleepColor", _s_set_colliderAsleepColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderContactColor", _s_set_colliderContactColor);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "colliderAABBColor", _s_set_colliderAABBColor);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Physics2D();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Simulate_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _step = (float)LuaAPI.lua_tonumber(L, 1);
                    
                        var gen_ret = UnityEngine.Physics2D.Simulate( _step );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SyncTransforms_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Physics2D.SyncTransforms(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IgnoreCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                    UnityEngine.Physics2D.IgnoreCollision( _collider1, _collider2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    bool _ignore = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Physics2D.IgnoreCollision( _collider1, _collider2, _ignore );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IgnoreCollision!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIgnoreCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = UnityEngine.Physics2D.GetIgnoreCollision( _collider1, _collider2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IgnoreLayerCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int _layer2 = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Physics2D.IgnoreLayerCollision( _layer1, _layer2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int _layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int _layer2 = LuaAPI.xlua_tointeger(L, 2);
                    bool _ignore = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Physics2D.IgnoreLayerCollision( _layer1, _layer2, _ignore );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IgnoreLayerCollision!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIgnoreLayerCollision_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _layer1 = LuaAPI.xlua_tointeger(L, 1);
                    int _layer2 = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.GetIgnoreLayerCollision( _layer1, _layer2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetLayerCollisionMask_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _layer = LuaAPI.xlua_tointeger(L, 1);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Physics2D.SetLayerCollisionMask( _layer, _layerMask );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayerCollisionMask_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _layer = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Physics2D.GetLayerCollisionMask( _layer );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouching_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = UnityEngine.Physics2D.IsTouching( _collider1, _collider2 );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    
                        var gen_ret = UnityEngine.Physics2D.IsTouching( _collider, _contactFilter );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    
                        var gen_ret = UnityEngine.Physics2D.IsTouching( _collider1, _collider2, _contactFilter );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IsTouching!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsTouchingLayers_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Collider2D>(L, 1)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = UnityEngine.Physics2D.IsTouchingLayers( _collider );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.IsTouchingLayers( _collider, _layerMask );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.IsTouchingLayers!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Distance_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Collider2D _colliderA = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _colliderB = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = UnityEngine.Physics2D.Distance( _colliderA, _colliderB );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClosestPoint_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)) 
                {
                    UnityEngine.Vector2 _position;translator.Get(L, 1, out _position);
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    
                        var gen_ret = UnityEngine.Physics2D.ClosestPoint( _position, _collider );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 2)) 
                {
                    UnityEngine.Vector2 _position;translator.Get(L, 1, out _position);
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 2, typeof(UnityEngine.Rigidbody2D));
                    
                        var gen_ret = UnityEngine.Physics2D.ClosestPoint( _position, _rigidbody );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.ClosestPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Linecast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    
                        var gen_ret = UnityEngine.Physics2D.Linecast( _start, _end );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.Linecast( _start, _end, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.Linecast( _start, _end, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.Linecast( _start, _end, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.Linecast( _start, _end, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.Linecast( _start, _end, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.Linecast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LinecastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastAll( _start, _end );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastAll( _start, _end, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastAll( _start, _end, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastAll( _start, _end, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.LinecastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LinecastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( _start, _end, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( _start, _end, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( _start, _end, _results, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _start;translator.Get(L, 1, out _start);
                    UnityEngine.Vector2 _end;translator.Get(L, 2, out _end);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.LinecastNonAlloc( _start, _end, _results, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.LinecastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.Raycast( _origin, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.Raycast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaycastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( _origin, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( _origin, _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( _origin, _direction, _results, _distance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( _origin, _direction, _results, _distance, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 3, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastNonAlloc( _origin, _direction, _results, _distance, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.RaycastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RaycastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastAll( _origin, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastAll( _origin, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastAll( _origin, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastAll( _origin, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _direction;translator.Get(L, 2, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.RaycastAll( _origin, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.RaycastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCast( _origin, _radius, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CircleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastAll( _origin, _radius, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastAll( _origin, _radius, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastAll( _origin, _radius, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastAll( _origin, _radius, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastAll( _origin, _radius, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CircleCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CircleCastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( _origin, _radius, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( _origin, _radius, _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( _origin, _radius, _direction, _results, _distance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( _origin, _radius, _direction, _results, _distance, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Vector2 _direction;translator.Get(L, 3, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 4, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.CircleCastNonAlloc( _origin, _radius, _direction, _results, _distance, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CircleCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCast( _origin, _size, _angle, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.BoxCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastAll( _origin, _size, _angle, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastAll( _origin, _size, _angle, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastAll( _origin, _size, _angle, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastAll( _origin, _size, _angle, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 5);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastAll( _origin, _size, _angle, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.BoxCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxCastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( _origin, _size, _angle, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( _origin, _size, _angle, _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( _origin, _size, _angle, _direction, _results, _distance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( _origin, _size, _angle, _direction, _results, _distance, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Vector2 _direction;translator.Get(L, 4, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 5, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        var gen_ret = UnityEngine.Physics2D.BoxCastNonAlloc( _origin, _size, _angle, _direction, _results, _distance, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.BoxCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCast_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 7, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _contactFilter, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.RaycastHit2D>>(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 6, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.RaycastHit2D> _results = (System.Collections.Generic.List<UnityEngine.RaycastHit2D>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.RaycastHit2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCast( _origin, _size, _capsuleDirection, _angle, _direction, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CapsuleCast!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCastAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastAll( _origin, _size, _capsuleDirection, _angle, _direction );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastAll( _origin, _size, _capsuleDirection, _angle, _direction, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastAll( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastAll( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 6);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 7);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastAll( _origin, _size, _capsuleDirection, _angle, _direction, _distance, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CapsuleCastAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CapsuleCastNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( _origin, _size, _capsuleDirection, _angle, _direction, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( _origin, _size, _capsuleDirection, _angle, _direction, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( _origin, _size, _capsuleDirection, _angle, _direction, _results, _distance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( _origin, _size, _capsuleDirection, _angle, _direction, _results, _distance, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Vector2>(L, 5)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Vector2 _origin;translator.Get(L, 1, out _origin);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _capsuleDirection;translator.Get(L, 3, out _capsuleDirection);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Vector2 _direction;translator.Get(L, 5, out _direction);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 6, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 7);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 8);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 9);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 10);
                    
                        var gen_ret = UnityEngine.Physics2D.CapsuleCastNonAlloc( _origin, _size, _capsuleDirection, _angle, _direction, _results, _distance, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.CapsuleCastNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersection_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersection( _ray );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersection( _ray, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersection( _ray, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetRayIntersection!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersectionAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Ray>(L, 1)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersectionAll( _ray );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersectionAll( _ray, _distance );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    float _distance = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersectionAll( _ray, _distance, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetRayIntersectionAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRayIntersectionNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 2)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersectionNonAlloc( _ray, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersectionNonAlloc( _ray, _results, _distance );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Ray>(L, 1)&& translator.Assignable<UnityEngine.RaycastHit2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Ray _ray;translator.Get(L, 1, out _ray);
                    UnityEngine.RaycastHit2D[] _results = (UnityEngine.RaycastHit2D[])translator.GetObject(L, 2, typeof(UnityEngine.RaycastHit2D[]));
                    float _distance = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.GetRayIntersectionNonAlloc( _ray, _results, _distance, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetRayIntersectionNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPoint_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Vector2>(L, 1)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPoint( _point );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPoint( _point, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPoint( _point, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPoint( _point, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPoint( _point, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPoint( _point, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPointAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Vector2>(L, 1)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointAll( _point );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointAll( _point, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointAll( _point, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 2);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 3);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointAll( _point, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapPointAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapPointNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( _point, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( _point, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( _point, _results, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapPointNonAlloc( _point, _results, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapPointNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircle( _point, _radius );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircle( _point, _radius, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircle( _point, _radius, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircle( _point, _radius, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircle( _point, _radius, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircle( _point, _radius, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCircle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircleAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleAll( _point, _radius );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleAll( _point, _radius, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleAll( _point, _radius, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleAll( _point, _radius, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCircleAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCircleNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( _point, _radius, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( _point, _radius, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( _point, _radius, _results, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    float _radius = (float)LuaAPI.lua_tonumber(L, 2);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCircleNonAlloc( _point, _radius, _results, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCircleNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBox_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBox( _point, _size, _angle );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBox( _point, _size, _angle, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBox( _point, _size, _angle, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBox( _point, _size, _angle, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBox( _point, _size, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 4, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBox( _point, _size, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapBox!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBoxAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxAll( _point, _size, _angle );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxAll( _point, _size, _angle, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxAll( _point, _size, _angle, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxAll( _point, _size, _angle, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapBoxAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapBoxNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( _point, _size, _angle, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( _point, _size, _angle, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( _point, _size, _angle, _results, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapBoxNonAlloc( _point, _size, _angle, _results, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapBoxNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapArea_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapArea( _pointA, _pointB );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapArea( _pointA, _pointB, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapArea( _pointA, _pointB, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapArea( _pointA, _pointB, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 4, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapArea( _pointA, _pointB, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapArea( _pointA, _pointB, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapArea!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapAreaAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaAll( _pointA, _pointB );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaAll( _pointA, _pointB, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaAll( _pointA, _pointB, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 3);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 4);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaAll( _pointA, _pointB, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapAreaAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapAreaNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( _pointA, _pointB, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( _pointA, _pointB, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( _pointA, _pointB, _results, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _pointA;translator.Get(L, 1, out _pointA);
                    UnityEngine.Vector2 _pointB;translator.Get(L, 2, out _pointB);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 4);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 5);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapAreaNonAlloc( _pointA, _pointB, _results, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapAreaNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsule_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsule( _point, _size, _direction, _angle );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsule( _point, _size, _direction, _angle, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsule( _point, _size, _direction, _angle, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsule( _point, _size, _direction, _angle, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 6, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsule( _point, _size, _direction, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 5, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsule( _point, _size, _direction, _angle, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCapsule!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsuleAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( _point, _size, _direction, _angle );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( _point, _size, _direction, _angle, _layerMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( _point, _size, _direction, _angle, _layerMask, _minDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    int _layerMask = LuaAPI.xlua_tointeger(L, 5);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 6);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleAll( _point, _size, _direction, _angle, _layerMask, _minDepth, _maxDepth );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCapsuleAll!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCapsuleNonAlloc_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( _point, _size, _direction, _angle, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( _point, _size, _direction, _angle, _results, _layerMask );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( _point, _size, _direction, _angle, _results, _layerMask, _minDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Vector2>(L, 1)&& translator.Assignable<UnityEngine.Vector2>(L, 2)&& translator.Assignable<UnityEngine.CapsuleDirection2D>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Vector2 _point;translator.Get(L, 1, out _point);
                    UnityEngine.Vector2 _size;translator.Get(L, 2, out _size);
                    UnityEngine.CapsuleDirection2D _direction;translator.Get(L, 3, out _direction);
                    float _angle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 5, typeof(UnityEngine.Collider2D[]));
                    int _layerMask = LuaAPI.xlua_tointeger(L, 6);
                    float _minDepth = (float)LuaAPI.lua_tonumber(L, 7);
                    float _maxDepth = (float)LuaAPI.lua_tonumber(L, 8);
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCapsuleNonAlloc( _point, _size, _direction, _angle, _results, _layerMask, _minDepth, _maxDepth );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCapsuleNonAlloc!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OverlapCollider_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _results = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCollider( _collider, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _results = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.OverlapCollider( _collider, _contactFilter, _results );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.OverlapCollider!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetContacts_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 2, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D[] _colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 2)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 2, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 2)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.Collider2D[] _colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 2, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 2)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    System.Collections.Generic.List<UnityEngine.Collider2D> _colliders = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 2)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 2)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    System.Collections.Generic.List<UnityEngine.Collider2D> _colliders = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 3, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _contactFilter, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 3)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 3, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<UnityEngine.Collider2D[]>(L, 3)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    UnityEngine.Collider2D[] _colliders = (UnityEngine.Collider2D[])translator.GetObject(L, 3, typeof(UnityEngine.Collider2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _contactFilter, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.Collider2D _collider = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _colliders = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider, _contactFilter, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 3)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rigidbody2D>(L, 1)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Collider2D>>(L, 3)) 
                {
                    UnityEngine.Rigidbody2D _rigidbody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 1, typeof(UnityEngine.Rigidbody2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 2, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.Collider2D> _colliders = (System.Collections.Generic.List<UnityEngine.Collider2D>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Collider2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _rigidbody, _contactFilter, _colliders );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<UnityEngine.ContactPoint2D[]>(L, 4)) 
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    UnityEngine.ContactPoint2D[] _contacts = (UnityEngine.ContactPoint2D[])translator.GetObject(L, 4, typeof(UnityEngine.ContactPoint2D[]));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider1, _collider2, _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Collider2D>(L, 1)&& translator.Assignable<UnityEngine.Collider2D>(L, 2)&& translator.Assignable<UnityEngine.ContactFilter2D>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.ContactPoint2D>>(L, 4)) 
                {
                    UnityEngine.Collider2D _collider1 = (UnityEngine.Collider2D)translator.GetObject(L, 1, typeof(UnityEngine.Collider2D));
                    UnityEngine.Collider2D _collider2 = (UnityEngine.Collider2D)translator.GetObject(L, 2, typeof(UnityEngine.Collider2D));
                    UnityEngine.ContactFilter2D _contactFilter;translator.Get(L, 3, out _contactFilter);
                    System.Collections.Generic.List<UnityEngine.ContactPoint2D> _contacts = (System.Collections.Generic.List<UnityEngine.ContactPoint2D>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.ContactPoint2D>));
                    
                        var gen_ret = UnityEngine.Physics2D.GetContacts( _collider1, _collider2, _contactFilter, _contacts );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Physics2D.GetContacts!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultPhysicsScene(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Physics2D.defaultPhysicsScene);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityIterations(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Physics2D.velocityIterations);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_positionIterations(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Physics2D.positionIterations);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineVector2(L, UnityEngine.Physics2D.gravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_queriesHitTriggers(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.queriesHitTriggers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_queriesStartInColliders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.queriesStartInColliders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_callbacksOnDisable(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.callbacksOnDisable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reuseCollisionCallbacks(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.reuseCollisionCallbacks);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_autoSyncTransforms(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.autoSyncTransforms);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_simulationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Physics2D.simulationMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_jobOptions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Physics2D.jobOptions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityThreshold(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.velocityThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxLinearCorrection(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxLinearCorrection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxAngularCorrection(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxAngularCorrection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxTranslationSpeed(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxTranslationSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxRotationSpeed(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.maxRotationSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultContactOffset(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.defaultContactOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baumgarteScale(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.baumgarteScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_baumgarteTOIScale(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.baumgarteTOIScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeToSleep(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.timeToSleep);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearSleepTolerance(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.linearSleepTolerance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularSleepTolerance(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.angularSleepTolerance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alwaysShowColliders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.alwaysShowColliders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showColliderSleep(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.showColliderSleep);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showColliderContacts(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.showColliderContacts);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_showColliderAABB(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Physics2D.showColliderAABB);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_contactArrowScale(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.Physics2D.contactArrowScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderAwakeColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderAwakeColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderAsleepColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderAsleepColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderContactColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderContactColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_colliderAABBColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushUnityEngineColor(L, UnityEngine.Physics2D.colliderAABBColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityIterations(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.velocityIterations = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_positionIterations(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.positionIterations = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Vector2 gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.gravity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_queriesHitTriggers(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.queriesHitTriggers = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_queriesStartInColliders(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.queriesStartInColliders = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_callbacksOnDisable(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.callbacksOnDisable = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reuseCollisionCallbacks(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.reuseCollisionCallbacks = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_autoSyncTransforms(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.autoSyncTransforms = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_simulationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.SimulationMode2D gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.simulationMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_jobOptions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.PhysicsJobOptions2D gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.jobOptions = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityThreshold(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.velocityThreshold = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxLinearCorrection(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.maxLinearCorrection = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxAngularCorrection(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.maxAngularCorrection = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxTranslationSpeed(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.maxTranslationSpeed = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxRotationSpeed(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.maxRotationSpeed = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultContactOffset(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.defaultContactOffset = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baumgarteScale(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.baumgarteScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_baumgarteTOIScale(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.baumgarteTOIScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeToSleep(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.timeToSleep = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearSleepTolerance(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.linearSleepTolerance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularSleepTolerance(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.angularSleepTolerance = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alwaysShowColliders(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.alwaysShowColliders = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showColliderSleep(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.showColliderSleep = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showColliderContacts(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.showColliderContacts = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_showColliderAABB(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.showColliderAABB = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_contactArrowScale(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Physics2D.contactArrowScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderAwakeColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.colliderAwakeColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderAsleepColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.colliderAsleepColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderContactColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.colliderContactColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_colliderAABBColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Color gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Physics2D.colliderAABBColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
