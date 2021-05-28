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
    public class UnityEngineTexture3DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Texture3D);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateExternalTexture", _m_UpdateExternalTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels", _m_GetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels32", _m_GetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels", _m_SetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels32", _m_SetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixel", _m_SetPixel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixel", _m_GetPixel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixelBilinear", _m_GetPixelBilinear);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "format", _g_get_format);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isReadable", _g_get_isReadable);
            
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateExternalTexture", _m_CreateExternalTexture_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _format, _flags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _format, _flags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _format, _flags, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _textureFormat, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					System.IntPtr _nativeTex = LuaAPI.lua_touserdata(L, 7);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _textureFormat, _mipCount, _nativeTex);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _textureFormat, _mipChain);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TLIGHTUSERDATA == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					System.IntPtr _nativeTex = LuaAPI.lua_touserdata(L, 7);
					
					var gen_ret = new UnityEngine.Texture3D(_width, _height, _depth, _textureFormat, _mipChain, _nativeTex);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateExternalTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.IntPtr _nativeTex = LuaAPI.lua_touserdata(L, 2);
                    
                    gen_to_be_invoked.UpdateExternalTexture( _nativeTex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.GetPixels(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _miplevel = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels( _miplevel );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.GetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.GetPixels32(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _miplevel = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels32( _miplevel );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.GetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Color[]>(L, 2)) 
                {
                    UnityEngine.Color[] _colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    
                    gen_to_be_invoked.SetPixels( _colors );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color[] _colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    int _miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPixels( _colors, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.SetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Color32[]>(L, 2)) 
                {
                    UnityEngine.Color32[] _colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    
                    gen_to_be_invoked.SetPixels32( _colors );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color32[] _colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    int _miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPixels32( _colors, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.SetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateExternalTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _width = LuaAPI.xlua_tointeger(L, 1);
                    int _height = LuaAPI.xlua_tointeger(L, 2);
                    int _depth = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.TextureFormat _format;translator.Get(L, 4, out _format);
                    bool _mipChain = LuaAPI.lua_toboolean(L, 5);
                    System.IntPtr _nativeTex = LuaAPI.lua_touserdata(L, 6);
                    
                        var gen_ret = UnityEngine.Texture3D.CreateExternalTexture( _width, _height, _depth, _format, _mipChain, _nativeTex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Apply(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Apply( _updateMipmaps );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool _updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    bool _makeNoLongerReadable = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Apply( _updateMipmaps, _makeNoLongerReadable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.Apply!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Color>(L, 5)) 
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _z = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Color _color;translator.Get(L, 5, out _color);
                    
                    gen_to_be_invoked.SetPixel( _x, _y, _z, _color );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Color>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _z = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Color _color;translator.Get(L, 5, out _color);
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 6);
                    
                    gen_to_be_invoked.SetPixel( _x, _y, _z, _color, _mipLevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.SetPixel!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _z = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.GetPixel( _x, _y, _z );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _x = LuaAPI.xlua_tointeger(L, 2);
                    int _y = LuaAPI.xlua_tointeger(L, 3);
                    int _z = LuaAPI.xlua_tointeger(L, 4);
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.GetPixel( _x, _y, _z, _mipLevel );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.GetPixel!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixelBilinear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _u = (float)LuaAPI.lua_tonumber(L, 2);
                    float _v = (float)LuaAPI.lua_tonumber(L, 3);
                    float _w = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.GetPixelBilinear( _u, _v, _w );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    float _u = (float)LuaAPI.lua_tonumber(L, 2);
                    float _v = (float)LuaAPI.lua_tonumber(L, 3);
                    float _w = (float)LuaAPI.lua_tonumber(L, 4);
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 5);
                    
                        var gen_ret = gen_to_be_invoked.GetPixelBilinear( _u, _v, _w, _mipLevel );
                        translator.PushUnityEngineColor(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture3D.GetPixelBilinear!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_format(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.format);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isReadable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture3D gen_to_be_invoked = (UnityEngine.Texture3D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isReadable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
