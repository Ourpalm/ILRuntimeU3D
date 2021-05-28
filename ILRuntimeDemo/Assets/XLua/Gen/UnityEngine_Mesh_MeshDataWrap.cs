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
    public class UnityEngineMeshMeshDataWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Mesh.MeshData);
			Utils.BeginObjectRegister(type, L, translator, 0, 13, 4, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasVertexAttribute", _m_HasVertexAttribute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVertexAttributeDimension", _m_GetVertexAttributeDimension);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVertexAttributeFormat", _m_GetVertexAttributeFormat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVertices", _m_GetVertices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNormals", _m_GetNormals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTangents", _m_GetTangents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetColors", _m_GetColors);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUVs", _m_GetUVs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVertexBufferParams", _m_SetVertexBufferParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetIndexBufferParams", _m_SetIndexBufferParams);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetIndices", _m_GetIndices);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSubMesh", _m_GetSubMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSubMesh", _m_SetSubMesh);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertexCount", _g_get_vertexCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertexBufferCount", _g_get_vertexBufferCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "indexFormat", _g_get_indexFormat);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "subMeshCount", _g_get_subMeshCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "subMeshCount", _s_set_subMeshCount);
            
			
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
				    translator.Push(L, default(UnityEngine.Mesh.MeshData));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.MeshData constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasVertexAttribute(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    UnityEngine.Rendering.VertexAttribute _attr;translator.Get(L, 2, out _attr);
                    
                        var gen_ret = gen_to_be_invoked.HasVertexAttribute( _attr );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVertexAttributeDimension(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    UnityEngine.Rendering.VertexAttribute _attr;translator.Get(L, 2, out _attr);
                    
                        var gen_ret = gen_to_be_invoked.GetVertexAttributeDimension( _attr );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVertexAttributeFormat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    UnityEngine.Rendering.VertexAttribute _attr;translator.Get(L, 2, out _attr);
                    
                        var gen_ret = gen_to_be_invoked.GetVertexAttributeFormat( _attr );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVertices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    Unity.Collections.NativeArray<UnityEngine.Vector3> _outVertices;translator.Get(L, 2, out _outVertices);
                    
                    gen_to_be_invoked.GetVertices( _outVertices );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNormals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    Unity.Collections.NativeArray<UnityEngine.Vector3> _outNormals;translator.Get(L, 2, out _outNormals);
                    
                    gen_to_be_invoked.GetNormals( _outNormals );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTangents(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    Unity.Collections.NativeArray<UnityEngine.Vector4> _outTangents;translator.Get(L, 2, out _outTangents);
                    
                    gen_to_be_invoked.GetTangents( _outTangents );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetColors(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Color>>(L, 2)) 
                {
                    Unity.Collections.NativeArray<UnityEngine.Color> _outColors;translator.Get(L, 2, out _outColors);
                    
                    gen_to_be_invoked.GetColors( _outColors );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Color32>>(L, 2)) 
                {
                    Unity.Collections.NativeArray<UnityEngine.Color32> _outColors;translator.Get(L, 2, out _outColors);
                    
                    gen_to_be_invoked.GetColors( _outColors );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.MeshData.GetColors!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUVs(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Vector2>>(L, 3)) 
                {
                    int _channel = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Collections.NativeArray<UnityEngine.Vector2> _outUVs;translator.Get(L, 3, out _outUVs);
                    
                    gen_to_be_invoked.GetUVs( _channel, _outUVs );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Vector3>>(L, 3)) 
                {
                    int _channel = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Collections.NativeArray<UnityEngine.Vector3> _outUVs;translator.Get(L, 3, out _outUVs);
                    
                    gen_to_be_invoked.GetUVs( _channel, _outUVs );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Vector4>>(L, 3)) 
                {
                    int _channel = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Collections.NativeArray<UnityEngine.Vector4> _outUVs;translator.Get(L, 3, out _outUVs);
                    
                    gen_to_be_invoked.GetUVs( _channel, _outUVs );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.MeshData.GetUVs!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVertexBufferParams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<UnityEngine.Rendering.VertexAttributeDescriptor>(L, 3))) 
                {
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.VertexAttributeDescriptor[] _attributes = translator.GetParams<UnityEngine.Rendering.VertexAttributeDescriptor>(L, 3);
                    
                    gen_to_be_invoked.SetVertexBufferParams( _vertexCount, _attributes );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor>>(L, 3)) 
                {
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> _attributes;translator.Get(L, 3, out _attributes);
                    
                    gen_to_be_invoked.SetVertexBufferParams( _vertexCount, _attributes );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.MeshData.SetVertexBufferParams!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetIndexBufferParams(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int _indexCount = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.IndexFormat _format;translator.Get(L, 3, out _format);
                    
                    gen_to_be_invoked.SetIndexBufferParams( _indexCount, _format );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetIndices(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<Unity.Collections.NativeArray<ushort>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    Unity.Collections.NativeArray<ushort> _outIndices;translator.Get(L, 2, out _outIndices);
                    int _submesh = LuaAPI.xlua_tointeger(L, 3);
                    bool _applyBaseVertex = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.GetIndices( _outIndices, _submesh, _applyBaseVertex );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<Unity.Collections.NativeArray<ushort>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    Unity.Collections.NativeArray<ushort> _outIndices;translator.Get(L, 2, out _outIndices);
                    int _submesh = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.GetIndices( _outIndices, _submesh );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<Unity.Collections.NativeArray<int>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    Unity.Collections.NativeArray<int> _outIndices;translator.Get(L, 2, out _outIndices);
                    int _submesh = LuaAPI.xlua_tointeger(L, 3);
                    bool _applyBaseVertex = LuaAPI.lua_toboolean(L, 4);
                    
                    gen_to_be_invoked.GetIndices( _outIndices, _submesh, _applyBaseVertex );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<Unity.Collections.NativeArray<int>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    Unity.Collections.NativeArray<int> _outIndices;translator.Get(L, 2, out _outIndices);
                    int _submesh = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.GetIndices( _outIndices, _submesh );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.MeshData.GetIndices!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSubMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetSubMesh( _index );
                        translator.Push(L, gen_ret);
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSubMesh(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.SubMeshDescriptor>(L, 3)&& translator.Assignable<UnityEngine.Rendering.MeshUpdateFlags>(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.SubMeshDescriptor _desc;translator.Get(L, 3, out _desc);
                    UnityEngine.Rendering.MeshUpdateFlags _flags;translator.Get(L, 4, out _flags);
                    
                    gen_to_be_invoked.SetSubMesh( _index, _desc, _flags );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.SubMeshDescriptor>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.SubMeshDescriptor _desc;translator.Get(L, 3, out _desc);
                    
                    gen_to_be_invoked.SetSubMesh( _index, _desc );
                    
                    
                        translator.Update(L, 1, gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Mesh.MeshData.SetSubMesh!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertexCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.vertexCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertexBufferCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.vertexBufferCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_indexFormat(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.indexFormat);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_subMeshCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.subMeshCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_subMeshCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Mesh.MeshData gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.subMeshCount = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
