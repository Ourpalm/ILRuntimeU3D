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
    public class UnityEngineUICanvasUpdateRegistryWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.CanvasUpdateRegistry);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterCanvasElementForLayoutRebuild", _m_RegisterCanvasElementForLayoutRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryRegisterCanvasElementForLayoutRebuild", _m_TryRegisterCanvasElementForLayoutRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RegisterCanvasElementForGraphicRebuild", _m_RegisterCanvasElementForGraphicRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TryRegisterCanvasElementForGraphicRebuild", _m_TryRegisterCanvasElementForGraphicRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnRegisterCanvasElementForRebuild", _m_UnRegisterCanvasElementForRebuild_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRebuildingLayout", _m_IsRebuildingLayout_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsRebuildingGraphics", _m_IsRebuildingGraphics_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "instance", _g_get_instance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.CanvasUpdateRegistry does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterCanvasElementForLayoutRebuild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.ICanvasElement _element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                    UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild( _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryRegisterCanvasElementForLayoutRebuild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.ICanvasElement _element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                        var gen_ret = UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild( _element );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RegisterCanvasElementForGraphicRebuild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.ICanvasElement _element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                    UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild( _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryRegisterCanvasElementForGraphicRebuild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.ICanvasElement _element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                        var gen_ret = UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild( _element );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnRegisterCanvasElementForRebuild_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.ICanvasElement _element = (UnityEngine.UI.ICanvasElement)translator.GetObject(L, 1, typeof(UnityEngine.UI.ICanvasElement));
                    
                    UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild( _element );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRebuildingLayout_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        var gen_ret = UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsRebuildingGraphics_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        var gen_ret = UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingGraphics(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.UI.CanvasUpdateRegistry.instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
