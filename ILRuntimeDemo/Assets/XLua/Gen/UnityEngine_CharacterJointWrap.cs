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
    public class UnityEngineCharacterJointWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.CharacterJoint);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 10, 10);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "swingAxis", _g_get_swingAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "twistLimitSpring", _g_get_twistLimitSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swingLimitSpring", _g_get_swingLimitSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lowTwistLimit", _g_get_lowTwistLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "highTwistLimit", _g_get_highTwistLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swing1Limit", _g_get_swing1Limit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swing2Limit", _g_get_swing2Limit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableProjection", _g_get_enableProjection);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionDistance", _g_get_projectionDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionAngle", _g_get_projectionAngle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "swingAxis", _s_set_swingAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "twistLimitSpring", _s_set_twistLimitSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swingLimitSpring", _s_set_swingLimitSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lowTwistLimit", _s_set_lowTwistLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "highTwistLimit", _s_set_highTwistLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swing1Limit", _s_set_swing1Limit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swing2Limit", _s_set_swing2Limit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableProjection", _s_set_enableProjection);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionDistance", _s_set_projectionDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionAngle", _s_set_projectionAngle);
            
			
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
					
					var gen_ret = new UnityEngine.CharacterJoint();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CharacterJoint constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swingAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.swingAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_twistLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.twistLimitSpring);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swingLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.swingLimitSpring);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lowTwistLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lowTwistLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_highTwistLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.highTwistLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swing1Limit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.swing1Limit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swing2Limit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.swing2Limit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableProjection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.enableProjection);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_projectionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.projectionDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_projectionAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.projectionAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swingAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.swingAxis = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_twistLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimitSpring gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.twistLimitSpring = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swingLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimitSpring gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.swingLimitSpring = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lowTwistLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.lowTwistLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_highTwistLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.highTwistLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swing1Limit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.swing1Limit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swing2Limit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.swing2Limit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableProjection(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.enableProjection = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_projectionDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.projectionDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_projectionAngle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CharacterJoint gen_to_be_invoked = (UnityEngine.CharacterJoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.projectionAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
