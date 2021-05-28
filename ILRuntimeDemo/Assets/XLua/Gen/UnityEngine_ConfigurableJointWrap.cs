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
    public class UnityEngineConfigurableJointWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ConfigurableJoint);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 31, 31);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "secondaryAxis", _g_get_secondaryAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xMotion", _g_get_xMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "yMotion", _g_get_yMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "zMotion", _g_get_zMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularXMotion", _g_get_angularXMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularYMotion", _g_get_angularYMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularZMotion", _g_get_angularZMotion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearLimitSpring", _g_get_linearLimitSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularXLimitSpring", _g_get_angularXLimitSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularYZLimitSpring", _g_get_angularYZLimitSpring);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linearLimit", _g_get_linearLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lowAngularXLimit", _g_get_lowAngularXLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "highAngularXLimit", _g_get_highAngularXLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularYLimit", _g_get_angularYLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularZLimit", _g_get_angularZLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetPosition", _g_get_targetPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetVelocity", _g_get_targetVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "xDrive", _g_get_xDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "yDrive", _g_get_yDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "zDrive", _g_get_zDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetRotation", _g_get_targetRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "targetAngularVelocity", _g_get_targetAngularVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationDriveMode", _g_get_rotationDriveMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularXDrive", _g_get_angularXDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "angularYZDrive", _g_get_angularYZDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "slerpDrive", _g_get_slerpDrive);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionMode", _g_get_projectionMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionDistance", _g_get_projectionDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "projectionAngle", _g_get_projectionAngle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "configuredInWorldSpace", _g_get_configuredInWorldSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "swapBodies", _g_get_swapBodies);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "secondaryAxis", _s_set_secondaryAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xMotion", _s_set_xMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "yMotion", _s_set_yMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "zMotion", _s_set_zMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularXMotion", _s_set_angularXMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularYMotion", _s_set_angularYMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularZMotion", _s_set_angularZMotion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearLimitSpring", _s_set_linearLimitSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularXLimitSpring", _s_set_angularXLimitSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularYZLimitSpring", _s_set_angularYZLimitSpring);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "linearLimit", _s_set_linearLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "lowAngularXLimit", _s_set_lowAngularXLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "highAngularXLimit", _s_set_highAngularXLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularYLimit", _s_set_angularYLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularZLimit", _s_set_angularZLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetPosition", _s_set_targetPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetVelocity", _s_set_targetVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "xDrive", _s_set_xDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "yDrive", _s_set_yDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "zDrive", _s_set_zDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetRotation", _s_set_targetRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "targetAngularVelocity", _s_set_targetAngularVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationDriveMode", _s_set_rotationDriveMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularXDrive", _s_set_angularXDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "angularYZDrive", _s_set_angularYZDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "slerpDrive", _s_set_slerpDrive);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionMode", _s_set_projectionMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionDistance", _s_set_projectionDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "projectionAngle", _s_set_projectionAngle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "configuredInWorldSpace", _s_set_configuredInWorldSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "swapBodies", _s_set_swapBodies);
            
			
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
					
					var gen_ret = new UnityEngine.ConfigurableJoint();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ConfigurableJoint constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_secondaryAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.secondaryAxis);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.xMotion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_yMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.yMotion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_zMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.zMotion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularXMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularXMotion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularYMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularYMotion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularZMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularZMotion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.linearLimitSpring);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularXLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularXLimitSpring);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularYZLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularYZLimitSpring);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_linearLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.linearLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_lowAngularXLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.lowAngularXLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_highAngularXLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.highAngularXLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularYLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularYLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularZLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularZLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.targetPosition);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.targetVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_xDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.xDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_yDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.yDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_zDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.zDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, gen_to_be_invoked.targetRotation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_targetAngularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.targetAngularVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationDriveMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotationDriveMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularXDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularXDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_angularYZDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.angularYZDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_slerpDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.slerpDrive);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_projectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.projectionMode);
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
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.projectionAngle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_configuredInWorldSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.configuredInWorldSpace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_swapBodies(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.swapBodies);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_secondaryAxis(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.secondaryAxis = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_xMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.ConfigurableJointMotion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.xMotion = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_yMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.ConfigurableJointMotion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.yMotion = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_zMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.ConfigurableJointMotion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.zMotion = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularXMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.ConfigurableJointMotion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularXMotion = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularYMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.ConfigurableJointMotion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularYMotion = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularZMotion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.ConfigurableJointMotion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularZMotion = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimitSpring gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.linearLimitSpring = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularXLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimitSpring gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularXLimitSpring = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularYZLimitSpring(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimitSpring gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularYZLimitSpring = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_linearLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.linearLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_lowAngularXLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.lowAngularXLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_highAngularXLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.highAngularXLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularYLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularYLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularZLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.SoftJointLimit gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularZLimit = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetPosition(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetPosition = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetVelocity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_xDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.xDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_yDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.yDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_zDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.zDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetRotation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetRotation = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_targetAngularVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.targetAngularVelocity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationDriveMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.RotationDriveMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotationDriveMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularXDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularXDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_angularYZDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.angularYZDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_slerpDrive(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointDrive gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.slerpDrive = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_projectionMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                UnityEngine.JointProjectionMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.projectionMode = gen_value;
            
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
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
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
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.projectionAngle = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_configuredInWorldSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.configuredInWorldSpace = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_swapBodies(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ConfigurableJoint gen_to_be_invoked = (UnityEngine.ConfigurableJoint)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.swapBodies = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
