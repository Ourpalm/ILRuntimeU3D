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
    public class UnityEngineMaterialPropertyBlockWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.MaterialPropertyBlock);
			Utils.BeginObjectRegister(type, L, translator, 0, 35, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInt", _m_SetInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloat", _m_SetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInteger", _m_SetInteger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVector", _m_SetVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetColor", _m_SetColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMatrix", _m_SetMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBuffer", _m_SetBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetTexture", _m_SetTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetConstantBuffer", _m_SetConstantBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFloatArray", _m_SetFloatArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetVectorArray", _m_SetVectorArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetMatrixArray", _m_SetMatrixArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasProperty", _m_HasProperty);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasInt", _m_HasInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasFloat", _m_HasFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasInteger", _m_HasInteger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasTexture", _m_HasTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasMatrix", _m_HasMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasVector", _m_HasVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasColor", _m_HasColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasBuffer", _m_HasBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "HasConstantBuffer", _m_HasConstantBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloat", _m_GetFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInt", _m_GetInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInteger", _m_GetInteger);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVector", _m_GetVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetColor", _m_GetColor);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMatrix", _m_GetMatrix);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetTexture", _m_GetTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetFloatArray", _m_GetFloatArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetVectorArray", _m_GetVectorArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetMatrixArray", _m_GetMatrixArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopySHCoefficientArraysFrom", _m_CopySHCoefficientArraysFrom);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyProbeOcclusionArrayFrom", _m_CopyProbeOcclusionArrayFrom);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isEmpty", _g_get_isEmpty);
            
			
			
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
					
					var gen_ret = new UnityEngine.MaterialPropertyBlock();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInt( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInt( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetFloat( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    gen_to_be_invoked.SetFloat( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInteger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInteger( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetInteger( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4 _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetVector( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector4>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector4 _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetVector( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Color _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetColor( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Color _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetColor( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMatrix(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Matrix4x4 _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetMatrix( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Matrix4x4 _value;translator.Get(L, 3, out _value);
                    
                    gen_to_be_invoked.SetMatrix( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _name, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    
                    gen_to_be_invoked.SetBuffer( _name, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture _value = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetTexture( _nameID, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Texture>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Texture _value = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.SetTexture( _name, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.RenderTexture>(L, 3)&& translator.Assignable<UnityEngine.Rendering.RenderTextureSubElement>(L, 4)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.RenderTexture _value = (UnityEngine.RenderTexture)translator.GetObject(L, 3, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Rendering.RenderTextureSubElement _element;translator.Get(L, 4, out _element);
                    
                    gen_to_be_invoked.SetTexture( _nameID, _value, _element );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.RenderTexture>(L, 3)&& translator.Assignable<UnityEngine.Rendering.RenderTextureSubElement>(L, 4)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.RenderTexture _value = (UnityEngine.RenderTexture)translator.GetObject(L, 3, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Rendering.RenderTextureSubElement _element;translator.Get(L, 4, out _element);
                    
                    gen_to_be_invoked.SetTexture( _name, _value, _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetConstantBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _nameID, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _nameID, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.ComputeBuffer _value = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _name, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.GraphicsBuffer _value = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    int _offset = LuaAPI.xlua_tointeger(L, 4);
                    int _size = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetConstantBuffer( _name, _value, _offset, _size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetConstantBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetFloatArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetFloatArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<float[]>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    float[] _values = (float[])translator.GetObject(L, 3, typeof(float[]));
                    
                    gen_to_be_invoked.SetFloatArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.SetFloatArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<float[]>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    float[] _values = (float[])translator.GetObject(L, 3, typeof(float[]));
                    
                    gen_to_be_invoked.SetFloatArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetVectorArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    gen_to_be_invoked.SetVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector4[]>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector4[] _values = (UnityEngine.Vector4[])translator.GetObject(L, 3, typeof(UnityEngine.Vector4[]));
                    
                    gen_to_be_invoked.SetVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    gen_to_be_invoked.SetVectorArray( _name, _values );
                    
                    
                    
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetMatrixArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    gen_to_be_invoked.SetMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Matrix4x4[] _values = (UnityEngine.Matrix4x4[])translator.GetObject(L, 3, typeof(UnityEngine.Matrix4x4[]));
                    
                    gen_to_be_invoked.SetMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    gen_to_be_invoked.SetMatrixArray( _name, _values );
                    
                    
                    
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
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.SetMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasProperty(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasProperty( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasProperty( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasProperty!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasInt( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasInt( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasFloat( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasFloat( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasInteger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasInteger( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasInteger( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasTexture( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasTexture( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasMatrix(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasMatrix( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasMatrix( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasVector( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasVector( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasColor( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasColor( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasBuffer( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasBuffer( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HasConstantBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasConstantBuffer( _nameID );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.HasConstantBuffer( _name );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.HasConstantBuffer!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetFloat( _nameID );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetFloat( _name );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetFloat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInt(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetInt( _nameID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetInt( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetInt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInteger(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetInteger( _nameID );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetInteger( _name );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetInteger!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVector(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetVector( _nameID );
                        translator.PushUnityEngineVector4(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetVector( _name );
                        translator.PushUnityEngineVector4(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetColor(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetColor( _nameID );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetColor( _name );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetColor!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMatrix(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMatrix( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMatrix( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetTexture( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetTexture( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetFloatArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetFloatArray( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetFloatArray( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.GetFloatArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<float>>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<float> _values = (System.Collections.Generic.List<float>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<float>));
                    
                    gen_to_be_invoked.GetFloatArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetFloatArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVectorArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetVectorArray( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetVectorArray( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    gen_to_be_invoked.GetVectorArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector4> _values = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    gen_to_be_invoked.GetVectorArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetVectorArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMatrixArray(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMatrixArray( _nameID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetMatrixArray( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 3)) 
                {
                    int _nameID = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    gen_to_be_invoked.GetMatrixArray( _nameID, _values );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 3)) 
                {
                    string _name = LuaAPI.lua_tostring(L, 2);
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    gen_to_be_invoked.GetMatrixArray( _name, _values );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.GetMatrixArray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopySHCoefficientArraysFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> _lightProbes = (System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>));
                    
                    gen_to_be_invoked.CopySHCoefficientArraysFrom( _lightProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rendering.SphericalHarmonicsL2[]>(L, 2)) 
                {
                    UnityEngine.Rendering.SphericalHarmonicsL2[] _lightProbes = (UnityEngine.Rendering.SphericalHarmonicsL2[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]));
                    
                    gen_to_be_invoked.CopySHCoefficientArraysFrom( _lightProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> _lightProbes = (System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>));
                    int _sourceStart = LuaAPI.xlua_tointeger(L, 3);
                    int _destStart = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.CopySHCoefficientArraysFrom( _lightProbes, _sourceStart, _destStart, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Rendering.SphericalHarmonicsL2[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Rendering.SphericalHarmonicsL2[] _lightProbes = (UnityEngine.Rendering.SphericalHarmonicsL2[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]));
                    int _sourceStart = LuaAPI.xlua_tointeger(L, 3);
                    int _destStart = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.CopySHCoefficientArraysFrom( _lightProbes, _sourceStart, _destStart, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.CopySHCoefficientArraysFrom!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyProbeOcclusionArrayFrom(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector4> _occlusionProbes = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    gen_to_be_invoked.CopyProbeOcclusionArrayFrom( _occlusionProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector4[]>(L, 2)) 
                {
                    UnityEngine.Vector4[] _occlusionProbes = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
                    
                    gen_to_be_invoked.CopyProbeOcclusionArrayFrom( _occlusionProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector4> _occlusionProbes = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    int _sourceStart = LuaAPI.xlua_tointeger(L, 3);
                    int _destStart = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.CopyProbeOcclusionArrayFrom( _occlusionProbes, _sourceStart, _destStart, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Vector4[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector4[] _occlusionProbes = (UnityEngine.Vector4[])translator.GetObject(L, 2, typeof(UnityEngine.Vector4[]));
                    int _sourceStart = LuaAPI.xlua_tointeger(L, 3);
                    int _destStart = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.CopyProbeOcclusionArrayFrom( _occlusionProbes, _sourceStart, _destStart, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.MaterialPropertyBlock.CopyProbeOcclusionArrayFrom!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isEmpty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.MaterialPropertyBlock gen_to_be_invoked = (UnityEngine.MaterialPropertyBlock)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isEmpty);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
