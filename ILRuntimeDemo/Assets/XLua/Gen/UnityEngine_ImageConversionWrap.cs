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
    public class UnityEngineImageConversionWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ImageConversion);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 1, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeArrayToTGA", _m_EncodeArrayToTGA_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeArrayToPNG", _m_EncodeArrayToPNG_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeArrayToJPG", _m_EncodeArrayToJPG_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncodeArrayToEXR", _m_EncodeArrayToEXR_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "EnableLegacyPngGammaRuntimeLoadBehavior", _g_get_EnableLegacyPngGammaRuntimeLoadBehavior);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "EnableLegacyPngGammaRuntimeLoadBehavior", _s_set_EnableLegacyPngGammaRuntimeLoadBehavior);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.ImageConversion does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeArrayToTGA_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    uint _rowBytes = LuaAPI.xlua_touint(L, 5);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToTGA( _array, _format, _width, _height, _rowBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToTGA( _array, _format, _width, _height );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ImageConversion.EncodeArrayToTGA!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeArrayToPNG_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    uint _rowBytes = LuaAPI.xlua_touint(L, 5);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToPNG( _array, _format, _width, _height, _rowBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToPNG( _array, _format, _width, _height );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ImageConversion.EncodeArrayToPNG!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeArrayToJPG_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    uint _rowBytes = LuaAPI.xlua_touint(L, 5);
                    int _quality = LuaAPI.xlua_tointeger(L, 6);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToJPG( _array, _format, _width, _height, _rowBytes, _quality );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    uint _rowBytes = LuaAPI.xlua_touint(L, 5);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToJPG( _array, _format, _width, _height, _rowBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToJPG( _array, _format, _width, _height );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ImageConversion.EncodeArrayToJPG!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncodeArrayToEXR_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 6&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Texture2D.EXRFlags>(L, 6)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    uint _rowBytes = LuaAPI.xlua_touint(L, 5);
                    UnityEngine.Texture2D.EXRFlags _flags;translator.Get(L, 6, out _flags);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToEXR( _array, _format, _width, _height, _rowBytes, _flags );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    uint _rowBytes = LuaAPI.xlua_touint(L, 5);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToEXR( _array, _format, _width, _height, _rowBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<System.Array>(L, 1)&& translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    System.Array _array = (System.Array)translator.GetObject(L, 1, typeof(System.Array));
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 2, out _format);
                    uint _width = LuaAPI.xlua_touint(L, 3);
                    uint _height = LuaAPI.xlua_touint(L, 4);
                    
                        var gen_ret = UnityEngine.ImageConversion.EncodeArrayToEXR( _array, _format, _width, _height );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ImageConversion.EncodeArrayToEXR!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EnableLegacyPngGammaRuntimeLoadBehavior(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.ImageConversion.EnableLegacyPngGammaRuntimeLoadBehavior);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EnableLegacyPngGammaRuntimeLoadBehavior(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.ImageConversion.EnableLegacyPngGammaRuntimeLoadBehavior = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
