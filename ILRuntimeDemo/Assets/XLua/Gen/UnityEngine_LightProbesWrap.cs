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
    public class UnityEngineLightProbesWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.LightProbes);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 1);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "positions", _g_get_positions);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bakedProbes", _g_get_bakedProbes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "count", _g_get_count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellCount", _g_get_cellCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bakedProbes", _s_set_bakedProbes);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Tetrahedralize", _m_Tetrahedralize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TetrahedralizeAsync", _m_TetrahedralizeAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetInterpolatedProbe", _m_GetInterpolatedProbe_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CalculateInterpolatedLightAndOcclusionProbes", _m_CalculateInterpolatedLightAndOcclusionProbes_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "tetrahedralizationCompleted", _e_tetrahedralizationCompleted);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "needsRetetrahedralization", _e_needsRetetrahedralization);
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.LightProbes does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Tetrahedralize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.LightProbes.Tetrahedralize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TetrahedralizeAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.LightProbes.TetrahedralizeAsync(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInterpolatedProbe_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _position;translator.Get(L, 1, out _position);
                    UnityEngine.Renderer _renderer = (UnityEngine.Renderer)translator.GetObject(L, 2, typeof(UnityEngine.Renderer));
                    UnityEngine.Rendering.SphericalHarmonicsL2 _probe;
                    
                    UnityEngine.LightProbes.GetInterpolatedProbe( _position, _renderer, out _probe );
                    translator.Push(L, _probe);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CalculateInterpolatedLightAndOcclusionProbes_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3[]>(L, 1)&& translator.Assignable<UnityEngine.Rendering.SphericalHarmonicsL2[]>(L, 2)&& translator.Assignable<UnityEngine.Vector4[]>(L, 3)) 
                {
                    UnityEngine.Vector3[] _positions = (UnityEngine.Vector3[])translator.GetObject(L, 1, typeof(UnityEngine.Vector3[]));
                    UnityEngine.Rendering.SphericalHarmonicsL2[] _lightProbes = (UnityEngine.Rendering.SphericalHarmonicsL2[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]));
                    UnityEngine.Vector4[] _occlusionProbes = (UnityEngine.Vector4[])translator.GetObject(L, 3, typeof(UnityEngine.Vector4[]));
                    
                    UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes( _positions, _lightProbes, _occlusionProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector4>>(L, 3)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> _positions = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> _lightProbes = (System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>));
                    System.Collections.Generic.List<UnityEngine.Vector4> _occlusionProbes = (System.Collections.Generic.List<UnityEngine.Vector4>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
                    
                    UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes( _positions, _lightProbes, _occlusionProbes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_positions(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbes gen_to_be_invoked = (UnityEngine.LightProbes)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.positions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bakedProbes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbes gen_to_be_invoked = (UnityEngine.LightProbes)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bakedProbes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbes gen_to_be_invoked = (UnityEngine.LightProbes)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cellCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbes gen_to_be_invoked = (UnityEngine.LightProbes)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.cellCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bakedProbes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.LightProbes gen_to_be_invoked = (UnityEngine.LightProbes)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bakedProbes = (UnityEngine.Rendering.SphericalHarmonicsL2[])translator.GetObject(L, 2, typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_tetrahedralizationCompleted(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.LightProbes.tetrahedralizationCompleted += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.LightProbes.tetrahedralizationCompleted -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LightProbes.tetrahedralizationCompleted!");
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_needsRetetrahedralization(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action gen_delegate = translator.GetDelegate<System.Action>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					UnityEngine.LightProbes.needsRetetrahedralization += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					UnityEngine.LightProbes.needsRetetrahedralization -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LightProbes.needsRetetrahedralization!");
        }
        
    }
}
