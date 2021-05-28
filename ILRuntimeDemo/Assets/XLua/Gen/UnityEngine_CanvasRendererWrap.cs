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
    public class UnityEngineCanvasRendererWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.CanvasRenderer);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 10, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetColor", _m_SetColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetColor", _m_GetColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableRectClipping", _m_EnableRectClipping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableRectClipping", _m_DisableRectClipping);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMaterial", _m_SetMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMaterial", _m_GetMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPopMaterial", _m_SetPopMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPopMaterial", _m_GetPopMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTexture", _m_SetTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAlphaTexture", _m_SetAlphaTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMesh", _m_SetMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetAlpha", _m_GetAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAlpha", _m_SetAlpha);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInheritedAlpha", _m_GetInheritedAlpha);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasPopInstruction", _g_get_hasPopInstruction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "materialCount", _g_get_materialCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "popMaterialCount", _g_get_popMaterialCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "absoluteDepth", _g_get_absoluteDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasMoved", _g_get_hasMoved);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cullTransparentMesh", _g_get_cullTransparentMesh);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasRectClipping", _g_get_hasRectClipping);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "relativeDepth", _g_get_relativeDepth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cull", _g_get_cull);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "clippingSoftness", _g_get_clippingSoftness);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "hasPopInstruction", _s_set_hasPopInstruction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "materialCount", _s_set_materialCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "popMaterialCount", _s_set_popMaterialCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cullTransparentMesh", _s_set_cullTransparentMesh);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cull", _s_set_cull);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "clippingSoftness", _s_set_clippingSoftness);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SplitUIVertexStreams", _m_SplitUIVertexStreams_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateUIVertexStream", _m_CreateUIVertexStream_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddUIVertexStream", _m_AddUIVertexStream_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.CanvasRenderer();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Color _color;translator.Get(L, 2, out _color);
                    
                    gen_to_be_invoked.SetColor( _color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetColor(  );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableRectClipping(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Rect _rect;translator.Get(L, 2, out _rect);
                    
                    gen_to_be_invoked.EnableRectClipping( _rect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableRectClipping(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DisableRectClipping(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMaterial(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Material>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetMaterial( _material, _index );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Material>(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetMaterial( _material, _texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.SetMaterial!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMaterial(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.GetMaterial(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMaterial( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.GetMaterial!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPopMaterial(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int _index = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPopMaterial( _material, _index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPopMaterial(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPopMaterial( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetTexture( _texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAlphaTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetAlphaTexture( _texture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    gen_to_be_invoked.SetMesh( _mesh );
                    
                    
                    
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
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAlpha(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetAlpha(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetAlpha(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    float _alpha = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    gen_to_be_invoked.SetAlpha( _alpha );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInheritedAlpha(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetInheritedAlpha(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SplitUIVertexStreams_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 8&& translator.Assignable<System.Collections.Generic.List<UnityEngine.UIVertex>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 7)&& translator.Assignable<System.Collections.Generic.List<int>>(L, 8)) 
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> _colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv0S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv1S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<int> _indices = (System.Collections.Generic.List<int>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.CanvasRenderer.SplitUIVertexStreams( _verts, _positions, _colors, _uv0S, _uv1S, _normals, _tangents, _indices );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<System.Collections.Generic.List<UnityEngine.UIVertex>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 7)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 8)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 9)&& translator.Assignable<System.Collections.Generic.List<int>>(L, 10)) 
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> _colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv0S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv1S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv2S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv3S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 9, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<int> _indices = (System.Collections.Generic.List<int>)translator.GetObject(L, 10, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.CanvasRenderer.SplitUIVertexStreams( _verts, _positions, _colors, _uv0S, _uv1S, _uv2S, _uv3S, _normals, _tangents, _indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.SplitUIVertexStreams!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateUIVertexStream_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 8&& translator.Assignable<System.Collections.Generic.List<UnityEngine.UIVertex>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 7)&& translator.Assignable<System.Collections.Generic.List<int>>(L, 8)) 
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> _colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv0S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv1S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<int> _indices = (System.Collections.Generic.List<int>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.CanvasRenderer.CreateUIVertexStream( _verts, _positions, _colors, _uv0S, _uv1S, _normals, _tangents, _indices );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<System.Collections.Generic.List<UnityEngine.UIVertex>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 7)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 8)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 9)&& translator.Assignable<System.Collections.Generic.List<int>>(L, 10)) 
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> _colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv0S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv1S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv2S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv3S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 9, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<int> _indices = (System.Collections.Generic.List<int>)translator.GetObject(L, 10, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.CanvasRenderer.CreateUIVertexStream( _verts, _positions, _colors, _uv0S, _uv1S, _uv2S, _uv3S, _normals, _tangents, _indices );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.CreateUIVertexStream!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUIVertexStream_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 7&& translator.Assignable<System.Collections.Generic.List<UnityEngine.UIVertex>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 7)) 
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> _colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv0S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv1S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.CanvasRenderer.AddUIVertexStream( _verts, _positions, _colors, _uv0S, _uv1S, _normals, _tangents );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<System.Collections.Generic.List<UnityEngine.UIVertex>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Color32>>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 4)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 5)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 6)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 7)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 8)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 9)) 
                {
                    System.Collections.Generic.List<UnityEngine.UIVertex> _verts = (System.Collections.Generic.List<UnityEngine.UIVertex>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.UIVertex>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Color32> _colors = (System.Collections.Generic.List<UnityEngine.Color32>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Color32>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv0S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv1S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 5, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv2S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 6, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _uv3S = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 7, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    System.Collections.Generic.List<UnityEngine.Vector3> _normals = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 8, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _tangents = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 9, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.CanvasRenderer.AddUIVertexStream( _verts, _positions, _colors, _uv0S, _uv1S, _uv2S, _uv3S, _normals, _tangents );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CanvasRenderer.AddUIVertexStream!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasPopInstruction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasPopInstruction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_materialCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.materialCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_popMaterialCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.popMaterialCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_absoluteDepth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.absoluteDepth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasMoved(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasMoved);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cullTransparentMesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.cullTransparentMesh);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasRectClipping(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.hasRectClipping);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_relativeDepth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.relativeDepth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cull(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.cull);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_clippingSoftness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.clippingSoftness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_hasPopInstruction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.hasPopInstruction = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_materialCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.materialCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_popMaterialCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.popMaterialCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cullTransparentMesh(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cullTransparentMesh = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cull(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cull = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_clippingSoftness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CanvasRenderer gen_to_be_invoked = (UnityEngine.CanvasRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.clippingSoftness = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
