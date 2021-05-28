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
    public class UnityEngineSparseTextureWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.SparseTexture);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 3, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateTile", _m_UpdateTile);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateTileRaw", _m_UpdateTileRaw);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnloadTile", _m_UnloadTile);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "tileWidth", _g_get_tileWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tileHeight", _g_get_tileHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isCreated", _g_get_isCreated);
            
			
			
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
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 4, out _format);
					int _mipCount = LuaAPI.xlua_tointeger(L, 5);
					
					var gen_ret = new UnityEngine.SparseTexture(_width, _height, _format, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 4, out _format);
					int _mipCount = LuaAPI.xlua_tointeger(L, 5);
					
					var gen_ret = new UnityEngine.SparseTexture(_width, _height, _format, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 4, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 5);
					
					var gen_ret = new UnityEngine.SparseTexture(_width, _height, _textureFormat, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.TextureFormat>(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 4, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 5);
					bool _linear = LuaAPI.lua_toboolean(L, 6);
					
					var gen_ret = new UnityEngine.SparseTexture(_width, _height, _textureFormat, _mipCount, _linear);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SparseTexture constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateTile(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.SparseTexture gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _tileX = LuaAPI.xlua_tointeger(L, 2);
                    int _tileY = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Color32[] _data = (UnityEngine.Color32[])translator.GetObject(L, 5, typeof(UnityEngine.Color32[]));
                    
                    gen_to_be_invoked.UpdateTile( _tileX, _tileY, _miplevel, _data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateTileRaw(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.SparseTexture gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _tileX = LuaAPI.xlua_tointeger(L, 2);
                    int _tileY = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    byte[] _data = LuaAPI.lua_tobytes(L, 5);
                    
                    gen_to_be_invoked.UpdateTileRaw( _tileX, _tileY, _miplevel, _data );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnloadTile(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.SparseTexture gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _tileX = LuaAPI.xlua_tointeger(L, 2);
                    int _tileY = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.UnloadTile( _tileX, _tileY, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tileWidth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SparseTexture gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.tileWidth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tileHeight(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SparseTexture gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.tileHeight);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isCreated(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.SparseTexture gen_to_be_invoked = (UnityEngine.SparseTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isCreated);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
