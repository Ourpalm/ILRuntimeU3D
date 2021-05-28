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
    public class UnityEngineClothWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Cloth);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 24, 22);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearTransformMotion", _m_ClearTransformMotion);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSelfAndInterCollisionIndices", _m_GetSelfAndInterCollisionIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSelfAndInterCollisionIndices", _m_SetSelfAndInterCollisionIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVirtualParticleIndices", _m_GetVirtualParticleIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVirtualParticleIndices", _m_SetVirtualParticleIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVirtualParticleWeights", _m_GetVirtualParticleWeights);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVirtualParticleWeights", _m_SetVirtualParticleWeights);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetEnabledFading", _m_SetEnabledFading);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertices", _g_get_vertices);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normals", _g_get_normals);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "coefficients", _g_get_coefficients);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "capsuleColliders", _g_get_capsuleColliders);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sphereColliders", _g_get_sphereColliders);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sleepThreshold", _g_get_sleepThreshold);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bendingStiffness", _g_get_bendingStiffness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stretchingStiffness", _g_get_stretchingStiffness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "damping", _g_get_damping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "externalAcceleration", _g_get_externalAcceleration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "randomAcceleration", _g_get_randomAcceleration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useGravity", _g_get_useGravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enabled", _g_get_enabled);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "friction", _g_get_friction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collisionMassScale", _g_get_collisionMassScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableContinuousCollision", _g_get_enableContinuousCollision);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useVirtualParticles", _g_get_useVirtualParticles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldVelocityScale", _g_get_worldVelocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldAccelerationScale", _g_get_worldAccelerationScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clothSolverFrequency", _g_get_clothSolverFrequency);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useTethers", _g_get_useTethers);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stiffnessFrequency", _g_get_stiffnessFrequency);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selfCollisionDistance", _g_get_selfCollisionDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "selfCollisionStiffness", _g_get_selfCollisionStiffness);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "coefficients", _s_set_coefficients);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "capsuleColliders", _s_set_capsuleColliders);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sphereColliders", _s_set_sphereColliders);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sleepThreshold", _s_set_sleepThreshold);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bendingStiffness", _s_set_bendingStiffness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stretchingStiffness", _s_set_stretchingStiffness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "damping", _s_set_damping);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "externalAcceleration", _s_set_externalAcceleration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "randomAcceleration", _s_set_randomAcceleration);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useGravity", _s_set_useGravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enabled", _s_set_enabled);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "friction", _s_set_friction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "collisionMassScale", _s_set_collisionMassScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableContinuousCollision", _s_set_enableContinuousCollision);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useVirtualParticles", _s_set_useVirtualParticles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldVelocityScale", _s_set_worldVelocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "worldAccelerationScale", _s_set_worldAccelerationScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clothSolverFrequency", _s_set_clothSolverFrequency);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useTethers", _s_set_useTethers);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "stiffnessFrequency", _s_set_stiffnessFrequency);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selfCollisionDistance", _s_set_selfCollisionDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "selfCollisionStiffness", _s_set_selfCollisionStiffness);
            
			
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
					
					var gen_ret = new UnityEngine.Cloth();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Cloth constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearTransformMotion(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearTransformMotion(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSelfAndInterCollisionIndices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<uint> _indices = (System.Collections.Generic.List<uint>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<uint>));
                    
                    gen_to_be_invoked.GetSelfAndInterCollisionIndices( _indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSelfAndInterCollisionIndices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<uint> _indices = (System.Collections.Generic.List<uint>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<uint>));
                    
                    gen_to_be_invoked.SetSelfAndInterCollisionIndices( _indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVirtualParticleIndices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<uint> _indicesOutList = (System.Collections.Generic.List<uint>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<uint>));
                    
                    gen_to_be_invoked.GetVirtualParticleIndices( _indicesOutList );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVirtualParticleIndices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<uint> _indicesIn = (System.Collections.Generic.List<uint>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<uint>));
                    
                    gen_to_be_invoked.SetVirtualParticleIndices( _indicesIn );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVirtualParticleWeights(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> _weightsOutList = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    gen_to_be_invoked.GetVirtualParticleWeights( _weightsOutList );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVirtualParticleWeights(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> _weights = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    gen_to_be_invoked.SetVirtualParticleWeights( _weights );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetEnabledFading(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _enabled = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetEnabledFading( _enabled );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    bool _enabled = LuaAPI.lua_toboolean(L, 2);
                    float _interpolationTime = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetEnabledFading( _enabled, _interpolationTime );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Cloth.SetEnabledFading!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertices(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.vertices);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normals(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.normals);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_coefficients(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.coefficients);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_capsuleColliders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.capsuleColliders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sphereColliders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sphereColliders);
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
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sleepThreshold);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bendingStiffness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.bendingStiffness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stretchingStiffness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.stretchingStiffness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_damping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.damping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_externalAcceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.externalAcceleration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_randomAcceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.randomAcceleration);
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
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useGravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enabled);
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
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.friction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_collisionMassScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.collisionMassScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableContinuousCollision(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableContinuousCollision);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useVirtualParticles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.useVirtualParticles);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.worldVelocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_worldAccelerationScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.worldAccelerationScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clothSolverFrequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.clothSolverFrequency);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useTethers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useTethers);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stiffnessFrequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.stiffnessFrequency);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selfCollisionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.selfCollisionDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_selfCollisionStiffness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.selfCollisionStiffness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_coefficients(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.coefficients = (UnityEngine.ClothSkinningCoefficient[])translator.GetObject(L, 2, typeof(UnityEngine.ClothSkinningCoefficient[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_capsuleColliders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.capsuleColliders = (UnityEngine.CapsuleCollider[])translator.GetObject(L, 2, typeof(UnityEngine.CapsuleCollider[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sphereColliders(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sphereColliders = (UnityEngine.ClothSphereColliderPair[])translator.GetObject(L, 2, typeof(UnityEngine.ClothSphereColliderPair[]));
            
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
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sleepThreshold = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bendingStiffness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bendingStiffness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stretchingStiffness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stretchingStiffness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_damping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.damping = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_externalAcceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.externalAcceleration = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_randomAcceleration(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.randomAcceleration = gen_value;
            
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
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useGravity = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enabled(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enabled = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_friction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.friction = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_collisionMassScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.collisionMassScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableContinuousCollision(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableContinuousCollision = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useVirtualParticles(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useVirtualParticles = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_worldVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.worldVelocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_worldAccelerationScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.worldAccelerationScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clothSolverFrequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.clothSolverFrequency = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useTethers(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useTethers = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_stiffnessFrequency(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.stiffnessFrequency = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selfCollisionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selfCollisionDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_selfCollisionStiffness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Cloth gen_to_be_invoked = (UnityEngine.Cloth)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.selfCollisionStiffness = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
