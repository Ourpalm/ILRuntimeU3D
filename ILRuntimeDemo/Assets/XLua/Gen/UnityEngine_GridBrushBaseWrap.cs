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
    public class UnityEngineGridBrushBaseWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GridBrushBase);
			Utils.BeginObjectRegister(type, L, translator, 0, 14, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Paint", _m_Paint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Erase", _m_Erase);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BoxFill", _m_BoxFill);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BoxErase", _m_BoxErase);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Select", _m_Select);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FloodFill", _m_FloodFill);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rotate", _m_Rotate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Flip", _m_Flip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pick", _m_Pick);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Move", _m_Move);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveStart", _m_MoveStart);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "MoveEnd", _m_MoveEnd);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ChangeZPosition", _m_ChangeZPosition);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ResetZPosition", _m_ResetZPosition);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.GridBrushBase does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Paint(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.Vector3Int _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.Paint( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Erase(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.Vector3Int _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.Erase( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxFill(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.BoxFill( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoxErase(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.BoxErase( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Select(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.Select( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FloodFill(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.Vector3Int _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.FloodFill( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Rotate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridBrushBase.RotationDirection _direction;translator.Get(L, 2, out _direction);
                    UnityEngine.GridLayout.CellLayout _layout;translator.Get(L, 3, out _layout);
                    
                    gen_to_be_invoked.Rotate( _direction, _layout );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Flip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridBrushBase.FlipAxis _flip;translator.Get(L, 2, out _flip);
                    UnityEngine.GridLayout.CellLayout _layout;translator.Get(L, 3, out _layout);
                    
                    gen_to_be_invoked.Flip( _flip, _layout );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Pick(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _position;translator.Get(L, 4, out _position);
                    UnityEngine.Vector3Int _pivot;translator.Get(L, 5, out _pivot);
                    
                    gen_to_be_invoked.Pick( _gridLayout, _brushTarget, _position, _pivot );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Move(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _from;translator.Get(L, 4, out _from);
                    UnityEngine.BoundsInt _to;translator.Get(L, 5, out _to);
                    
                    gen_to_be_invoked.Move( _gridLayout, _brushTarget, _from, _to );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveStart(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.MoveStart( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveEnd(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.GridLayout _gridLayout = (UnityEngine.GridLayout)translator.GetObject(L, 2, typeof(UnityEngine.GridLayout));
                    UnityEngine.GameObject _brushTarget = (UnityEngine.GameObject)translator.GetObject(L, 3, typeof(UnityEngine.GameObject));
                    UnityEngine.BoundsInt _position;translator.Get(L, 4, out _position);
                    
                    gen_to_be_invoked.MoveEnd( _gridLayout, _brushTarget, _position );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ChangeZPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _change = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.ChangeZPosition( _change );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetZPosition(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GridBrushBase gen_to_be_invoked = (UnityEngine.GridBrushBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ResetZPosition(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
