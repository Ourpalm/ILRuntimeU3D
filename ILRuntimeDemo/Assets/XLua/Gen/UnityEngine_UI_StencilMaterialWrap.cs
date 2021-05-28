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
    public class UnityEngineUIStencilMaterialWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.UI.StencilMaterial);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Add", _m_Add_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Remove", _m_Remove_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearAll", _m_ClearAll_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.StencilMaterial does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Material>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.StencilOp>(L, 3)&& translator.Assignable<UnityEngine.Rendering.CompareFunction>(L, 4)&& translator.Assignable<UnityEngine.Rendering.ColorWriteMask>(L, 5)) 
                {
                    UnityEngine.Material _baseMat = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    int _stencilID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.StencilOp _operation;translator.Get(L, 3, out _operation);
                    UnityEngine.Rendering.CompareFunction _compareFunction;translator.Get(L, 4, out _compareFunction);
                    UnityEngine.Rendering.ColorWriteMask _colorWriteMask;translator.Get(L, 5, out _colorWriteMask);
                    
                        var gen_ret = UnityEngine.UI.StencilMaterial.Add( _baseMat, _stencilID, _operation, _compareFunction, _colorWriteMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Material>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Rendering.StencilOp>(L, 3)&& translator.Assignable<UnityEngine.Rendering.CompareFunction>(L, 4)&& translator.Assignable<UnityEngine.Rendering.ColorWriteMask>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Material _baseMat = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    int _stencilID = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Rendering.StencilOp _operation;translator.Get(L, 3, out _operation);
                    UnityEngine.Rendering.CompareFunction _compareFunction;translator.Get(L, 4, out _compareFunction);
                    UnityEngine.Rendering.ColorWriteMask _colorWriteMask;translator.Get(L, 5, out _colorWriteMask);
                    int _readMask = LuaAPI.xlua_tointeger(L, 6);
                    int _writeMask = LuaAPI.xlua_tointeger(L, 7);
                    
                        var gen_ret = UnityEngine.UI.StencilMaterial.Add( _baseMat, _stencilID, _operation, _compareFunction, _colorWriteMask, _readMask, _writeMask );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.UI.StencilMaterial.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Material _customMat = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    
                    UnityEngine.UI.StencilMaterial.Remove( _customMat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.UI.StencilMaterial.ClearAll(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
