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
    public class UnityEngineShaderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Shader);
			Utils.BeginObjectRegister(type, L, translator, 0, 16, 4, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDependency", _m_GetDependency);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindPassTagValue", _m_FindPassTagValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyCount", _m_GetPropertyCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindPropertyIndex", _m_FindPropertyIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyName", _m_GetPropertyName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyNameId", _m_GetPropertyNameId);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyType", _m_GetPropertyType);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyDescription", _m_GetPropertyDescription);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyFlags", _m_GetPropertyFlags);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyAttributes", _m_GetPropertyAttributes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyDefaultFloatValue", _m_GetPropertyDefaultFloatValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyDefaultVectorValue", _m_GetPropertyDefaultVectorValue);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyRangeLimits", _m_GetPropertyRangeLimits);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyTextureDimension", _m_GetPropertyTextureDimension);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPropertyTextureDefaultName", _m_GetPropertyTextureDefaultName);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindTextureStack", _m_FindTextureStack);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "maximumLOD", _g_get_maximumLOD);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isSupported", _g_get_isSupported);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderQueue", _g_get_renderQueue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "passCount", _g_get_passCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "maximumLOD", _s_set_maximumLOD);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 29, 2, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", _m_Find_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EnableKeyword", _m_EnableKeyword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DisableKeyword", _m_DisableKeyword_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsKeywordEnabled", _m_IsKeywordEnabled_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WarmupAllShaders", _m_WarmupAllShaders_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PropertyToID", _m_PropertyToID_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalInt", _m_SetGlobalInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalFloat", _m_SetGlobalFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalInteger", _m_SetGlobalInteger_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalVector", _m_SetGlobalVector_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalColor", _m_SetGlobalColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalMatrix", _m_SetGlobalMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalTexture", _m_SetGlobalTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalBuffer", _m_SetGlobalBuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalConstantBuffer", _m_SetGlobalConstantBuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalFloatArray", _m_SetGlobalFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalVectorArray", _m_SetGlobalVectorArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGlobalMatrixArray", _m_SetGlobalMatrixArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalInt", _m_GetGlobalInt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalFloat", _m_GetGlobalFloat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalInteger", _m_GetGlobalInteger_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalVector", _m_GetGlobalVector_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalColor", _m_GetGlobalColor_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalMatrix", _m_GetGlobalMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalTexture", _m_GetGlobalTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalFloatArray", _m_GetGlobalFloatArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalVectorArray", _m_GetGlobalVectorArray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGlobalMatrixArray", _m_GetGlobalMatrixArray_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "globalMaximumLOD", _g_get_globalMaximumLOD);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "globalRenderPipeline", _g_get_globalRenderPipeline);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "globalMaximumLOD", _s_set_globalMaximumLOD);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "globalRenderPipeline", _s_set_globalRenderPipeline);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Shader does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Find_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.Find( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableKeyword_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _keyword = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Shader.EnableKeyword( _keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableKeyword_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _keyword = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.Shader.DisableKeyword( _keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsKeywordEnabled_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _keyword = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.IsKeywordEnabled( _keyword );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WarmupAllShaders_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Shader.WarmupAllShaders(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PropertyToID_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.PropertyToID( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDependency(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetDependency( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindPassTagValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _passIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.ShaderTagId _tagName;translator.Get(L, 3, out _tagName);
                    
                        var gen_ret = gen_to_be_invoked.FindPassTagValue( _passIndex, _tagName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInt( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInt( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Shader.SetGlobalFloat( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.Shader.SetGlobalFloat( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalInteger_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInteger( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Shader.SetGlobalInteger( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVector_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector4 _value;translator.Get(L, 2, out _value);
                    
                    UnityEngine.Shader.SetGlobalVector( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector4 _value;translator.Get(L, 2, out _value);
                    
                    UnityEngine.Shader.SetGlobalVector( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Color _value;translator.Get(L, 2, out _value);
                    
                    UnityEngine.Shader.SetGlobalColor( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Color>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Color _value;translator.Get(L, 2, out _value);
                    
                    UnityEngine.Shader.SetGlobalColor( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Matrix4x4 _value;translator.Get(L, 2, out _value);
                    
                    UnityEngine.Shader.SetGlobalMatrix( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Matrix4x4 _value;translator.Get(L, 2, out _value);
                    
                    UnityEngine.Shader.SetGlobalMatrix( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Texture _value = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Shader.SetGlobalTexture( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Texture _value = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Shader.SetGlobalTexture( _name, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTextureSubElement>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.RenderTexture _value = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Rendering.RenderTextureSubElement _element;translator.Get(L, 3, out _element);
                    
                    UnityEngine.Shader.SetGlobalTexture( _nameID, _value, _element );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Rendering.RenderTextureSubElement>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.RenderTexture _value = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Rendering.RenderTextureSubElement _element;translator.Get(L, 3, out _element);
                    
                    UnityEngine.Shader.SetGlobalTexture( _name, _value, _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalBuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( _name, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    
                    UnityEngine.Shader.SetGlobalBuffer( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalConstantBuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Shader.SetGlobalConstantBuffer( _nameID, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Shader.SetGlobalConstantBuffer( _nameID, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Shader.SetGlobalConstantBuffer( _name, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 3);
                    int _size = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Shader.SetGlobalConstantBuffer( _name, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalConstantBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<float[]>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    float[] _values = (float[])translator.GetObject(L, 2, typeof(float[]));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<float[]>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    float[] _values = (float[])translator.GetObject(L, 2, typeof(float[]));
                    
                    UnityEngine.Shader.SetGlobalFloatArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalVectorArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Vector4[]>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector4[] _values = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4[]>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Vector4[] _values = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
                    
                    UnityEngine.Shader.SetGlobalVectorArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGlobalMatrixArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Matrix4x4[] _values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 2, typeof(UnityEngine.Matrix4x4[]));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Matrix4x4[] _values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 2, typeof(UnityEngine.Matrix4x4[]));
                    
                    UnityEngine.Shader.SetGlobalMatrixArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.SetGlobalMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalInt_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalInt( _nameID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalInt( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalFloat_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalFloat( _nameID );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalFloat( _name );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalInteger_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalInteger( _nameID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalInteger( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalVector_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalVector( _nameID );
                        translator.PushUnityEngineVector4(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalVector( _name );
                        translator.PushUnityEngineVector4(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalColor_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalColor( _nameID );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalColor( _name );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalMatrix( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalMatrix( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalTexture( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalTexture( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalFloatArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalFloatArray( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalFloatArray( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.GetGlobalFloatArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<float>));
                    
                    UnityEngine.Shader.GetGlobalFloatArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalVectorArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalVectorArray( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalVectorArray( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.GetGlobalVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.Shader.GetGlobalVectorArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGlobalMatrixArray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalMatrixArray( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Shader.GetGlobalMatrixArray( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.GetGlobalMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 2)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Shader.GetGlobalMatrixArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Shader.GetGlobalMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyCount(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindPropertyIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _propertyName = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.FindPropertyIndex( _propertyName );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyName( _propertyIndex );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyNameId(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyNameId( _propertyIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyType(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyType( _propertyIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyDescription(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyDescription( _propertyIndex );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyFlags(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyFlags( _propertyIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyAttributes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyAttributes( _propertyIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyDefaultFloatValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyDefaultFloatValue( _propertyIndex );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyDefaultVectorValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyDefaultVectorValue( _propertyIndex );
                        translator.PushUnityEngineVector4(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyRangeLimits(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyRangeLimits( _propertyIndex );
                        translator.PushUnityEngineVector2(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyTextureDimension(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyTextureDimension( _propertyIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPropertyTextureDefaultName(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPropertyTextureDefaultName( _propertyIndex );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindTextureStack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _propertyIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _stackName;
                    int _layerIndex;
                    
                        var gen_ret = gen_to_be_invoked.FindTextureStack( _propertyIndex, out _stackName, out _layerIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    LuaAPI.lua_pushstring(L, _stackName);
                        
                    LuaAPI.xlua_pushinteger(L, _layerIndex);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maximumLOD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.maximumLOD);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_globalMaximumLOD(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Shader.globalMaximumLOD);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isSupported(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isSupported);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_globalRenderPipeline(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.Shader.globalRenderPipeline);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderQueue(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderQueue);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_passCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.passCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maximumLOD(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Shader gen_to_be_invoked = (UnityEngine.Shader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maximumLOD = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_globalMaximumLOD(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Shader.globalMaximumLOD = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_globalRenderPipeline(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Shader.globalRenderPipeline = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
