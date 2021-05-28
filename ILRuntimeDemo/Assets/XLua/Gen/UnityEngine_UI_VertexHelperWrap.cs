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
    public class UnityEngineUIVertexHelperWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.VertexHelper);
			Utils.BeginObjectRegister(type, L, translator, 0, 11, 2, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PopulateUIVertex", _m_PopulateUIVertex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUIVertex", _m_SetUIVertex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FillMesh", _m_FillMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddVert", _m_AddVert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddTriangle", _m_AddTriangle);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIVertexQuad", _m_AddUIVertexQuad);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIVertexStream", _m_AddUIVertexStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddUIVertexTriangleStream", _m_AddUIVertexTriangleStream);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUIVertexStream", _m_GetUIVertexStream);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentVertCount", _g_get_currentVertCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentIndexCount", _g_get_currentIndexCount);
            
			
			
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
					
					var gen_ret = new UnityEngine.UI.VertexHelper();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.Mesh>(L, 2))
				{
					UnityEngine.Mesh _m = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
					
					var gen_ret = new UnityEngine.UI.VertexHelper(_m);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.VertexHelper constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PopulateUIVertex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UIVertex _vertex;translator.Get(L, 2, out _vertex);
                    int _i = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.PopulateUIVertex( ref _vertex, _i );
                    translator.Push(L, _vertex);
                        translator.Update(L, 2, _vertex);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUIVertex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UIVertex _vertex;translator.Get(L, 2, out _vertex);
                    int _i = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetUIVertex( _vertex, _i );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FillMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    gen_to_be_invoked.FillMesh( _mesh );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddVert(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.UIVertex>(L, 2)) 
                {
                    UnityEngine.UIVertex _v;translator.Get(L, 2, out _v);
                    
                    gen_to_be_invoked.AddVert( _v );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color32>(L, 3)&& translator.Assignable<UnityEngine.Vector4>(L, 4)) 
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Color32 _color;translator.Get(L, 3, out _color);
                    UnityEngine.Vector4 _uv0;translator.Get(L, 4, out _uv0);
                    
                    gen_to_be_invoked.AddVert( _position, _color, _uv0 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color32>(L, 3)&& translator.Assignable<UnityEngine.Vector4>(L, 4)&& translator.Assignable<UnityEngine.Vector4>(L, 5)&& translator.Assignable<UnityEngine.Vector3>(L, 6)&& translator.Assignable<UnityEngine.Vector4>(L, 7)) 
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Color32 _color;translator.Get(L, 3, out _color);
                    UnityEngine.Vector4 _uv0;translator.Get(L, 4, out _uv0);
                    UnityEngine.Vector4 _uv1;translator.Get(L, 5, out _uv1);
                    UnityEngine.Vector3 _normal;translator.Get(L, 6, out _normal);
                    UnityEngine.Vector4 _tangent;translator.Get(L, 7, out _tangent);
                    
                    gen_to_be_invoked.AddVert( _position, _color, _uv0, _uv1, _normal, _tangent );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color32>(L, 3)&& translator.Assignable<UnityEngine.Vector4>(L, 4)&& translator.Assignable<UnityEngine.Vector4>(L, 5)&& translator.Assignable<UnityEngine.Vector4>(L, 6)&& translator.Assignable<UnityEngine.Vector4>(L, 7)&& translator.Assignable<UnityEngine.Vector3>(L, 8)&& translator.Assignable<UnityEngine.Vector4>(L, 9)) 
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Color32 _color;translator.Get(L, 3, out _color);
                    UnityEngine.Vector4 _uv0;translator.Get(L, 4, out _uv0);
                    UnityEngine.Vector4 _uv1;translator.Get(L, 5, out _uv1);
                    UnityEngine.Vector4 _uv2;translator.Get(L, 6, out _uv2);
                    UnityEngine.Vector4 _uv3;translator.Get(L, 7, out _uv3);
                    UnityEngine.Vector3 _normal;translator.Get(L, 8, out _normal);
                    UnityEngine.Vector4 _tangent;translator.Get(L, 9, out _tangent);
                    
                    gen_to_be_invoked.AddVert( _position, _color, _uv0, _uv1, _uv2, _uv3, _normal, _tangent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.VertexHelper.AddVert!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddTriangle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _idx0 = LuaAPI.xlua_tointeger(L, 2);
                    int _idx1 = LuaAPI.xlua_tointeger(L, 3);
                    int _idx2 = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AddTriangle( _idx0, _idx1, _idx2 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexQuad(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.UIVertex[] _verts = (UnityEngine.UIVertex[])translator.GetObject(L, 2, typeof(UnityEngine.UIVertex[]));
                    
                    gen_to_be_invoked.AddUIVertexQuad( _verts );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexStream(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<int> _indices = (System.Collections.Generic.List<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<int>));
                    
                    gen_to_be_invoked.AddUIVertexStream( _verts, _indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexTriangleStream(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    
                    gen_to_be_invoked.AddUIVertexTriangleStream( _verts );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUIVertexStream(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _stream = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    
                    gen_to_be_invoked.GetUIVertexStream( _stream );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentVertCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.currentVertCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentIndexCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.VertexHelper gen_to_be_invoked = (UnityEngine.UI.VertexHelper)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.currentIndexCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
