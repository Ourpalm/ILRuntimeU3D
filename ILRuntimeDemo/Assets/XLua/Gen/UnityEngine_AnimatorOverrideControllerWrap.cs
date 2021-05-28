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
    public class UnityEngineAnimatorOverrideControllerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AnimatorOverrideController);
			Utils.BeginObjectRegister(type, L, translator, 0, 4, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "get_Item", _m_get_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "set_Item", _m_set_Item);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetOverrides", _m_GetOverrides);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ApplyOverrides", _m_ApplyOverrides);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "runtimeAnimatorController", _g_get_runtimeAnimatorController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "overridesCount", _g_get_overridesCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "runtimeAnimatorController", _s_set_runtimeAnimatorController);
            
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
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
					
					var gen_ret = new UnityEngine.AnimatorOverrideController();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<UnityEngine.RuntimeAnimatorController>(L, 2))
				{
					UnityEngine.RuntimeAnimatorController _controller = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
					
					var gen_ret = new UnityEngine.AnimatorOverrideController(_controller);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimatorOverrideController constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<UnityEngine.AnimatorOverrideController>(L, 1) && translator.Assignable<UnityEngine.AnimationClip>(L, 2))
				{
					
					UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
					UnityEngine.AnimationClip index = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
					LuaAPI.lua_pushboolean(L, true);
					translator.Push(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<UnityEngine.AnimatorOverrideController>(L, 1) && translator.Assignable<UnityEngine.AnimationClip>(L, 2) && translator.Assignable<UnityEngine.AnimationClip>(L, 3))
				{
					
					UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
					UnityEngine.AnimationClip key = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
					gen_to_be_invoked[key] = (UnityEngine.AnimationClip)translator.GetObject(L, 3, typeof(UnityEngine.AnimationClip));
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_get_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					translator.Push(L, gen_to_be_invoked[key]);
					
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_set_Item(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
					string key = LuaAPI.lua_tostring(L, 2);
					UnityEngine.AnimationClip gen_value = (UnityEngine.AnimationClip)translator.GetObject(L, 3, typeof(UnityEngine.AnimationClip));
                    gen_to_be_invoked[key] = gen_value;
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetOverrides(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> _overrides = (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>));
                    
                    gen_to_be_invoked.GetOverrides( _overrides );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ApplyOverrides(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>> _overrides = (System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip, UnityEngine.AnimationClip>>));
                    
                    gen_to_be_invoked.ApplyOverrides( _overrides );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_runtimeAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.runtimeAnimatorController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_overridesCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.overridesCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_runtimeAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AnimatorOverrideController gen_to_be_invoked = (UnityEngine.AnimatorOverrideController)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.runtimeAnimatorController = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
