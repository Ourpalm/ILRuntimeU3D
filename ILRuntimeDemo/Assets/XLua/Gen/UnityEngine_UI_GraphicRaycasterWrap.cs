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
    public class UnityEngineUIGraphicRaycasterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.GraphicRaycaster);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 6, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Raycast", _m_Raycast);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sortOrderPriority", _g_get_sortOrderPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderOrderPriority", _g_get_renderOrderPriority);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ignoreReversedGraphics", _g_get_ignoreReversedGraphics);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockingObjects", _g_get_blockingObjects);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "blockingMask", _g_get_blockingMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eventCamera", _g_get_eventCamera);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ignoreReversedGraphics", _s_set_ignoreReversedGraphics);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockingObjects", _s_set_blockingObjects);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "blockingMask", _s_set_blockingMask);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.GraphicRaycaster does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Raycast(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.EventSystems.PointerEventData _eventData = (UnityEngine.EventSystems.PointerEventData)translator.GetObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
                    System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> _resultAppendList = (System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>));
                    
                    gen_to_be_invoked.Raycast( _eventData, _resultAppendList );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sortOrderPriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.sortOrderPriority);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderOrderPriority(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.renderOrderPriority);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ignoreReversedGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ignoreReversedGraphics);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blockingObjects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.blockingObjects);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_blockingMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.blockingMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_eventCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.eventCamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ignoreReversedGraphics(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ignoreReversedGraphics = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blockingObjects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                UnityEngine.UI.GraphicRaycaster.BlockingObjects gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.blockingObjects = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_blockingMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.UI.GraphicRaycaster gen_to_be_invoked = (UnityEngine.UI.GraphicRaycaster)translator.FastGetCSObj(L, 1);
                UnityEngine.LayerMask gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.blockingMask = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
