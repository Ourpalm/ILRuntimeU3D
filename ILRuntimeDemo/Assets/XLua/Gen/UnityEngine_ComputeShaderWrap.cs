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
    public class UnityEngineComputeShaderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ComputeShader);
			Utils.BeginObjectRegister(type, L, translator, 0, 22, 1, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindKernel", _m_FindKernel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasKernel", _m_HasKernel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloat", _m_SetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInt", _m_SetInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVector", _m_SetVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMatrix", _m_SetMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVectorArray", _m_SetVectorArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMatrixArray", _m_SetMatrixArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTexture", _m_SetTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTextureFromGlobal", _m_SetTextureFromGlobal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBuffer", _m_SetBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetKernelThreadGroupSizes", _m_GetKernelThreadGroupSizes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispatch", _m_Dispatch);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnableKeyword", _m_EnableKeyword);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DisableKeyword", _m_DisableKeyword);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsKeywordEnabled", _m_IsKeywordEnabled);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsSupported", _m_IsSupported);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloats", _m_SetFloats);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInts", _m_SetInts);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBool", _m_SetBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetConstantBuffer", _m_SetConstantBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DispatchIndirect", _m_DispatchIndirect);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "shaderKeywords", _g_get_shaderKeywords);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "shaderKeywords", _s_set_shaderKeywords);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.ComputeShader does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindKernel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.FindKernel( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasKernel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasKernel( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    float _val = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetFloat( _nameID, _val );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    float _val = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetFloat( _name, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    int _val = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInt( _nameID, _val );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    int _val = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInt( _name, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.SetVector( _nameID, _val );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector4 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.SetVector( _name, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMatrix(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Matrix4x4 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.SetMatrix( _nameID, _val );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Matrix4x4 _val;translator.Get(L, 3, out _val);
                    
                    gen_to_be_invoked.SetMatrix( _name, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVectorArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4[]>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4[] _values = (UnityEngine.Vector4[])translator.GetObject(L, 3, typeof(UnityEngine.Vector4[]));
                    
                    gen_to_be_invoked.SetVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4[]>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector4[] _values = (UnityEngine.Vector4[])translator.GetObject(L, 3, typeof(UnityEngine.Vector4[]));
                    
                    gen_to_be_invoked.SetVectorArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMatrixArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Matrix4x4[] _values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 3, typeof(UnityEngine.Matrix4x4[]));
                    
                    gen_to_be_invoked.SetMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Matrix4x4[] _values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 3, typeof(UnityEngine.Matrix4x4[]));
                    
                    gen_to_be_invoked.SetMatrixArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _nameID = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetTexture( _kernelIndex, _nameID, _texture );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _nameID = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetTexture( _kernelIndex, _nameID, _texture, _mipLevel );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Texture>(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetTexture( _kernelIndex, _name, _texture );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetTexture( _kernelIndex, _name, _texture, _mipLevel );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.RenderTexture>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Rendering.RenderTextureSubElement>(L, 6)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _nameID = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.RenderTexture _texture = (UnityEngine.RenderTexture)translator.GetObject(L, 4, typeof(UnityEngine.RenderTexture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Rendering.RenderTextureSubElement _element;translator.Get(L, 6, out _element);
                    
                    gen_to_be_invoked.SetTexture( _kernelIndex, _nameID, _texture, _mipLevel, _element );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.RenderTexture>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Rendering.RenderTextureSubElement>(L, 6)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.RenderTexture _texture = (UnityEngine.RenderTexture)translator.GetObject(L, 4, typeof(UnityEngine.RenderTexture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Rendering.RenderTextureSubElement _element;translator.Get(L, 6, out _element);
                    
                    gen_to_be_invoked.SetTexture( _kernelIndex, _name, _texture, _mipLevel, _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTextureFromGlobal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _nameID = LuaAPI.xlua_tointeger(L, 3);
                    int _globalTextureNameID = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetTextureFromGlobal( _kernelIndex, _nameID, _globalTextureNameID );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    string _globalTextureName = LuaAPI.lua_tostring(L, 4);
                    
                    gen_to_be_invoked.SetTextureFromGlobal( _kernelIndex, _name, _globalTextureName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetTextureFromGlobal!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _nameID = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.ComputeBuffer _buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _kernelIndex, _nameID, _buffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _nameID = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.GraphicsBuffer _buffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _kernelIndex, _nameID, _buffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.ComputeBuffer _buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _kernelIndex, _name, _buffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.GraphicsBuffer _buffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _kernelIndex, _name, _buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetKernelThreadGroupSizes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    uint _x;
                    uint _y;
                    uint _z;
                    
                    gen_to_be_invoked.GetKernelThreadGroupSizes( _kernelIndex, out _x, out _y, out _z );
                    LuaAPI.xlua_pushuint(L, _x);
                        
                    LuaAPI.xlua_pushuint(L, _y);
                        
                    LuaAPI.xlua_pushuint(L, _z);
                        
                    
                    
                    
                    return 3;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispatch(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _threadGroupsX = LuaAPI.xlua_tointeger(L, 3);
                    int _threadGroupsY = LuaAPI.xlua_tointeger(L, 4);
                    int _threadGroupsZ = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.Dispatch( _kernelIndex, _threadGroupsX, _threadGroupsY, _threadGroupsZ );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnableKeyword(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _keyword = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.EnableKeyword( _keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DisableKeyword(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _keyword = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.DisableKeyword( _keyword );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsKeywordEnabled(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _keyword = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.IsKeywordEnabled( _keyword );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsSupported(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.IsSupported( _kernelIndex );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloats(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    float[] _values = translator.GetParams<float>(L, 3);
                    
                    gen_to_be_invoked.SetFloats( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    float[] _values = translator.GetParams<float>(L, 3);
                    
                    gen_to_be_invoked.SetFloats( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetFloats!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInts(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    int[] _values = translator.GetParams<int>(L, 3);
                    
                    gen_to_be_invoked.SetInts( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    int[] _values = translator.GetParams<int>(L, 3);
                    
                    gen_to_be_invoked.SetInts( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetInts!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBool(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    bool _val = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetBool( _nameID, _val );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    bool _val = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.SetBool( _name, _val );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetBool!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetConstantBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.ComputeBuffer _buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _nameID, _buffer, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GraphicsBuffer _buffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _nameID, _buffer, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.ComputeBuffer _buffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _name, _buffer, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GraphicsBuffer _buffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _name, _buffer, _offset, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.SetConstantBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DispatchIndirect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.ComputeBuffer _argsBuffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    
                    gen_to_be_invoked.DispatchIndirect( _kernelIndex, _argsBuffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GraphicsBuffer _argsBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    
                    gen_to_be_invoked.DispatchIndirect( _kernelIndex, _argsBuffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.ComputeBuffer _argsBuffer = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    uint _argsOffset = LuaAPI.xlua_touint(L, 4);
                    
                    gen_to_be_invoked.DispatchIndirect( _kernelIndex, _argsBuffer, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _kernelIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GraphicsBuffer _argsBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    uint _argsOffset = LuaAPI.xlua_touint(L, 4);
                    
                    gen_to_be_invoked.DispatchIndirect( _kernelIndex, _argsBuffer, _argsOffset );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ComputeShader.DispatchIndirect!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shaderKeywords(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.shaderKeywords);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shaderKeywords(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ComputeShader gen_to_be_invoked = (UnityEngine.ComputeShader)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.shaderKeywords = (string[])translator.GetObject(L, 2, typeof(string[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
