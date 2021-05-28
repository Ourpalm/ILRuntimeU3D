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
    public class UnityEngineScreenCaptureWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ScreenCapture);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CaptureScreenshot", _m_CaptureScreenshot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CaptureScreenshotAsTexture", _m_CaptureScreenshotAsTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CaptureScreenshotIntoRenderTexture", _m_CaptureScreenshotIntoRenderTexture_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.ScreenCapture does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CaptureScreenshot_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    
                    UnityEngine.ScreenCapture.CaptureScreenshot( _filename );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    int _superSize = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.ScreenCapture.CaptureScreenshot( _filename, _superSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.ScreenCapture.StereoScreenCaptureMode>(L, 2)) 
                {
                    string _filename = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.ScreenCapture.StereoScreenCaptureMode _stereoCaptureMode;translator.Get(L, 2, out _stereoCaptureMode);
                    
                    UnityEngine.ScreenCapture.CaptureScreenshot( _filename, _stereoCaptureMode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ScreenCapture.CaptureScreenshot!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CaptureScreenshotAsTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        var gen_ret = UnityEngine.ScreenCapture.CaptureScreenshotAsTexture(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _superSize = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.ScreenCapture.CaptureScreenshotAsTexture( _superSize );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.ScreenCapture.StereoScreenCaptureMode>(L, 1)) 
                {
                    UnityEngine.ScreenCapture.StereoScreenCaptureMode _stereoCaptureMode;translator.Get(L, 1, out _stereoCaptureMode);
                    
                        var gen_ret = UnityEngine.ScreenCapture.CaptureScreenshotAsTexture( _stereoCaptureMode );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ScreenCapture.CaptureScreenshotAsTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CaptureScreenshotIntoRenderTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTexture _renderTexture = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.ScreenCapture.CaptureScreenshotIntoRenderTexture( _renderTexture );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
