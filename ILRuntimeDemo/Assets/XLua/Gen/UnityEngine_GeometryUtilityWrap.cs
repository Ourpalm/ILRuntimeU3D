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
    public class UnityEngineGeometryUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GeometryUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateFrustumPlanes", _m_CalculateFrustumPlanes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateBounds", _m_CalculateBounds_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryCreatePlaneFromPolygon", _m_TryCreatePlaneFromPolygon_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TestPlanesAABB", _m_TestPlanesAABB_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.GeometryUtility();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GeometryUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateFrustumPlanes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Camera>(L, 1)) 
                {
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
                    
                        var gen_ret = UnityEngine.GeometryUtility.CalculateFrustumPlanes( _camera );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Matrix4x4>(L, 1)) 
                {
                    UnityEngine.Matrix4x4 _worldToProjectionMatrix;translator.Get(L, 1, out _worldToProjectionMatrix);
                    
                        var gen_ret = UnityEngine.GeometryUtility.CalculateFrustumPlanes( _worldToProjectionMatrix );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Camera>(L, 1)&& translator.Assignable<UnityEngine.Plane[]>(L, 2)) 
                {
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 1, typeof(UnityEngine.Camera));
                    UnityEngine.Plane[] _planes = (UnityEngine.Plane[])translator.GetObject(L, 2, typeof(UnityEngine.Plane[]));
                    
                    UnityEngine.GeometryUtility.CalculateFrustumPlanes( _camera, _planes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Matrix4x4>(L, 1)&& translator.Assignable<UnityEngine.Plane[]>(L, 2)) 
                {
                    UnityEngine.Matrix4x4 _worldToProjectionMatrix;translator.Get(L, 1, out _worldToProjectionMatrix);
                    UnityEngine.Plane[] _planes = (UnityEngine.Plane[])translator.GetObject(L, 2, typeof(UnityEngine.Plane[]));
                    
                    UnityEngine.GeometryUtility.CalculateFrustumPlanes( _worldToProjectionMatrix, _planes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GeometryUtility.CalculateFrustumPlanes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateBounds_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3[] _positions = (UnityEngine.Vector3[])translator.GetObject(L, 1, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Matrix4x4 _transform;translator.Get(L, 2, out _transform);
                    
                        var gen_ret = UnityEngine.GeometryUtility.CalculateBounds( _positions, _transform );
                        translator.PushUnityEngineBounds(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryCreatePlaneFromPolygon_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3[] _vertices = (UnityEngine.Vector3[])translator.GetObject(L, 1, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Plane _plane;
                    
                        var gen_ret = UnityEngine.GeometryUtility.TryCreatePlaneFromPolygon( _vertices, out _plane );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _plane);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TestPlanesAABB_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Plane[] _planes = (UnityEngine.Plane[])translator.GetObject(L, 1, typeof(UnityEngine.Plane[]));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    
                        var gen_ret = UnityEngine.GeometryUtility.TestPlanesAABB( _planes, _bounds );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
