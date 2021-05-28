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
    public class UnityEngineGridLayoutWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GridLayout);
			Utils.BeginObjectRegister(type, L, translator, 0, 10, 4, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBoundsLocal", _m_GetBoundsLocal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CellToLocal", _m_CellToLocal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalToCell", _m_LocalToCell);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CellToLocalInterpolated", _m_CellToLocalInterpolated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalToCellInterpolated", _m_LocalToCellInterpolated);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CellToWorld", _m_CellToWorld);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToCell", _m_WorldToCell);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LocalToWorld", _m_LocalToWorld);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WorldToLocal", _m_WorldToLocal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetLayoutCellCenter", _m_GetLayoutCellCenter);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellSize", _g_get_cellSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellGap", _g_get_cellGap);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellLayout", _g_get_cellLayout);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellSwizzle", _g_get_cellSwizzle);
            
			
			
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
					
					var gen_ret = new UnityEngine.GridLayout();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GridLayout constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBoundsLocal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3Int>(L, 2)) 
                {
                    UnityEngine.Vector3Int _cellPosition;translator.Get(L, 2, out _cellPosition);
                    
                        var gen_ret = gen_to_be_invoked.GetBoundsLocal( _cellPosition );
                        translator.PushUnityEngineBounds(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 _origin;translator.Get(L, 2, out _origin);
                    UnityEngine.Vector3 _size;translator.Get(L, 3, out _size);
                    
                        var gen_ret = gen_to_be_invoked.GetBoundsLocal( _origin, _size );
                        translator.PushUnityEngineBounds(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GridLayout.GetBoundsLocal!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CellToLocal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3Int _cellPosition;translator.Get(L, 2, out _cellPosition);
                    
                        var gen_ret = gen_to_be_invoked.CellToLocal( _cellPosition );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToCell(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _localPosition;translator.Get(L, 2, out _localPosition);
                    
                        var gen_ret = gen_to_be_invoked.LocalToCell( _localPosition );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CellToLocalInterpolated(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _cellPosition;translator.Get(L, 2, out _cellPosition);
                    
                        var gen_ret = gen_to_be_invoked.CellToLocalInterpolated( _cellPosition );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToCellInterpolated(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _localPosition;translator.Get(L, 2, out _localPosition);
                    
                        var gen_ret = gen_to_be_invoked.LocalToCellInterpolated( _localPosition );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CellToWorld(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3Int _cellPosition;translator.Get(L, 2, out _cellPosition);
                    
                        var gen_ret = gen_to_be_invoked.CellToWorld( _cellPosition );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToCell(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _worldPosition;translator.Get(L, 2, out _worldPosition);
                    
                        var gen_ret = gen_to_be_invoked.WorldToCell( _worldPosition );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LocalToWorld(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _localPosition;translator.Get(L, 2, out _localPosition);
                    
                        var gen_ret = gen_to_be_invoked.LocalToWorld( _localPosition );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WorldToLocal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Vector3 _worldPosition;translator.Get(L, 2, out _worldPosition);
                    
                        var gen_ret = gen_to_be_invoked.WorldToLocal( _worldPosition );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetLayoutCellCenter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetLayoutCellCenter(  );
                        translator.PushUnityEngineVector3(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.cellSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellGap(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.cellGap);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellLayout(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.cellLayout);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellSwizzle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GridLayout gen_to_be_invoked = (UnityEngine.GridLayout)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.cellSwizzle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
