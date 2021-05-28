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
    public class UnityEngineParticleSystemRendererWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ParticleSystemRenderer);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 23, 20);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMeshes", _m_GetMeshes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMeshes", _m_SetMeshes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BakeMesh", _m_BakeMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BakeTrailsMesh", _m_BakeTrailsMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetActiveVertexStreams", _m_SetActiveVertexStreams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetActiveVertexStreams", _m_GetActiveVertexStreams);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "alignment", _g_get_alignment);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderMode", _g_get_renderMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortMode", _g_get_sortMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lengthScale", _g_get_lengthScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "velocityScale", _g_get_velocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraVelocityScale", _g_get_cameraVelocityScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalDirection", _g_get_normalDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shadowBias", _g_get_shadowBias);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortingFudge", _g_get_sortingFudge);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "minParticleSize", _g_get_minParticleSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxParticleSize", _g_get_maxParticleSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pivot", _g_get_pivot);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "flip", _g_get_flip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maskInteraction", _g_get_maskInteraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "trailMaterial", _g_get_trailMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableGPUInstancing", _g_get_enableGPUInstancing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "allowRoll", _g_get_allowRoll);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "freeformStretching", _g_get_freeformStretching);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotateWithStretchDirection", _g_get_rotateWithStretchDirection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mesh", _g_get_mesh);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "meshCount", _g_get_meshCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeVertexStreamsCount", _g_get_activeVertexStreamsCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "supportsMeshInstancing", _g_get_supportsMeshInstancing);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "alignment", _s_set_alignment);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "renderMode", _s_set_renderMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortMode", _s_set_sortMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lengthScale", _s_set_lengthScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "velocityScale", _s_set_velocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cameraVelocityScale", _s_set_cameraVelocityScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "normalDirection", _s_set_normalDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shadowBias", _s_set_shadowBias);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sortingFudge", _s_set_sortingFudge);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "minParticleSize", _s_set_minParticleSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxParticleSize", _s_set_maxParticleSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pivot", _s_set_pivot);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "flip", _s_set_flip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maskInteraction", _s_set_maskInteraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "trailMaterial", _s_set_trailMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableGPUInstancing", _s_set_enableGPUInstancing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "allowRoll", _s_set_allowRoll);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "freeformStretching", _s_set_freeformStretching);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotateWithStretchDirection", _s_set_rotateWithStretchDirection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "mesh", _s_set_mesh);
            
			
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
					
					var gen_ret = new UnityEngine.ParticleSystemRenderer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystemRenderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMeshes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Mesh[] _meshes = (UnityEngine.Mesh[])translator.GetObject(L, 2, typeof(UnityEngine.Mesh[]));
                    
                        var gen_ret = gen_to_be_invoked.GetMeshes( _meshes );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMeshes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh[]>(L, 2)) 
                {
                    UnityEngine.Mesh[] _meshes = (UnityEngine.Mesh[])translator.GetObject(L, 2, typeof(UnityEngine.Mesh[]));
                    
                    gen_to_be_invoked.SetMeshes( _meshes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Mesh[] _meshes = (UnityEngine.Mesh[])translator.GetObject(L, 2, typeof(UnityEngine.Mesh[]));
                    int _size = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetMeshes( _meshes, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystemRenderer.SetMeshes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BakeMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    bool _useTransform = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.BakeMesh( _mesh, _useTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    gen_to_be_invoked.BakeMesh( _mesh );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Camera>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    bool _useTransform = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.BakeMesh( _mesh, _camera, _useTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Camera>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    
                    gen_to_be_invoked.BakeMesh( _mesh, _camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystemRenderer.BakeMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BakeTrailsMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    bool _useTransform = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.BakeTrailsMesh( _mesh, _useTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    gen_to_be_invoked.BakeTrailsMesh( _mesh );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Camera>(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    bool _useTransform = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.BakeTrailsMesh( _mesh, _camera, _useTransform );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 2)&& translator.Assignable<UnityEngine.Camera>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 3, typeof(UnityEngine.Camera));
                    
                    gen_to_be_invoked.BakeTrailsMesh( _mesh, _camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystemRenderer.BakeTrailsMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActiveVertexStreams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> _streams = (System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>));
                    
                    gen_to_be_invoked.SetActiveVertexStreams( _streams );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetActiveVertexStreams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> _streams = (System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream>));
                    
                    gen_to_be_invoked.GetActiveVertexStreams( _streams );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_alignment(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.alignment);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.renderMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.sortMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lengthScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.lengthScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_velocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.velocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cameraVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.cameraVelocityScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_normalDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.normalDirection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shadowBias(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.shadowBias);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortingFudge(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.sortingFudge);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minParticleSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minParticleSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxParticleSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxParticleSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pivot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.pivot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_flip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.flip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maskInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.maskInteraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_trailMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.trailMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableGPUInstancing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableGPUInstancing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allowRoll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.allowRoll);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_freeformStretching(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.freeformStretching);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotateWithStretchDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.rotateWithStretchDirection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.mesh);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_meshCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.meshCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeVertexStreamsCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.activeVertexStreamsCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMeshInstancing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.supportsMeshInstancing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_alignment(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemRenderSpace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.alignment = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_renderMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemRenderMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.renderMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemSortMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.sortMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lengthScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lengthScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_velocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.velocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cameraVelocityScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cameraVelocityScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_normalDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.normalDirection = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shadowBias(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.shadowBias = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sortingFudge(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.sortingFudge = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minParticleSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minParticleSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxParticleSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxParticleSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pivot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.pivot = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_flip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.flip = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maskInteraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.SpriteMaskInteraction gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.maskInteraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_trailMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.trailMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableGPUInstancing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableGPUInstancing = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_allowRoll(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.allowRoll = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_freeformStretching(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.freeformStretching = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotateWithStretchDirection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rotateWithStretchDirection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_mesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemRenderer gen_to_be_invoked = (UnityEngine.ParticleSystemRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
