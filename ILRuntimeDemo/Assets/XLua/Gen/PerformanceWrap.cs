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
    public class PerformanceWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Performance);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadHotFixAssemblyStack", _m_LoadHotFixAssemblyStack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadHotFixAssemblyRegister", _m_LoadHotFixAssemblyRegister);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LoadLua", _m_LoadLua);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Unload", _m_Unload);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "btnLoadStack", _g_get_btnLoadStack);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "btnLoadRegister", _g_get_btnLoadRegister);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "btnUnload", _g_get_btnUnload);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panelTest", _g_get_panelTest);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "panelButton", _g_get_panelButton);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lbResult", _g_get_lbResult);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "btnLoadStack", _s_set_btnLoadStack);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "btnLoadRegister", _s_set_btnLoadRegister);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "btnUnload", _s_set_btnUnload);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panelTest", _s_set_panelTest);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "panelButton", _s_set_panelButton);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lbResult", _s_set_lbResult);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MandelbrotCheck", _m_MandelbrotCheck_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TestFunc1", _m_TestFunc1_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new Performance();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Performance constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadHotFixAssemblyStack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.LoadHotFixAssemblyStack(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadHotFixAssemblyRegister(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.LoadHotFixAssemblyRegister(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadLua(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.LoadLua(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Unload(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Unload(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MandelbrotCheck_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _workX = (float)LuaAPI.lua_tonumber(L, 1);
                    float _workY = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        var gen_ret = Performance.MandelbrotCheck( _workX, _workY );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TestFunc1_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _a = LuaAPI.xlua_tointeger(L, 1);
                    string _b = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _c;translator.Get(L, 3, out _c);
                    UnityEngine.Transform _d = (UnityEngine.Transform)translator.GetObject(L, 4, typeof(UnityEngine.Transform));
                    
                    Performance.TestFunc1( _a, _b, _c, _d );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_btnLoadStack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.btnLoadStack);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_btnLoadRegister(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.btnLoadRegister);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_btnUnload(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.btnUnload);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panelTest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.panelTest);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_panelButton(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.panelButton);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lbResult(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lbResult);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_btnLoadStack(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.btnLoadStack = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_btnLoadRegister(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.btnLoadRegister = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_btnUnload(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.btnUnload = (UnityEngine.UI.Button)translator.GetObject(L, 2, typeof(UnityEngine.UI.Button));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panelTest(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.panelTest = (UnityEngine.CanvasGroup)translator.GetObject(L, 2, typeof(UnityEngine.CanvasGroup));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_panelButton(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.panelButton = (UnityEngine.RectTransform)translator.GetObject(L, 2, typeof(UnityEngine.RectTransform));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lbResult(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Performance gen_to_be_invoked = (Performance)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.lbResult = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
