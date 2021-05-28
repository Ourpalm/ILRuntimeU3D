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
    public class UnityEngineHumanPoseHandlerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.HumanPoseHandler);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHumanPose", _m_GetHumanPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetHumanPose", _m_SetHumanPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInternalHumanPose", _m_GetInternalHumanPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInternalHumanPose", _m_SetInternalHumanPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetInternalAvatarPose", _m_GetInternalAvatarPose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetInternalAvatarPose", _m_SetInternalAvatarPose);
			
			
			
			
			
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
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Avatar>(L, 2) && translator.Assignable<UnityEngine.Transform>(L, 3))
				{
					UnityEngine.Avatar _avatar = (UnityEngine.Avatar)translator.GetObject(L, 2, typeof(UnityEngine.Avatar));
					UnityEngine.Transform _root = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
					
					var gen_ret = new UnityEngine.HumanPoseHandler(_avatar, _root);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<UnityEngine.Avatar>(L, 2) && translator.Assignable<string[]>(L, 3))
				{
					UnityEngine.Avatar _avatar = (UnityEngine.Avatar)translator.GetObject(L, 2, typeof(UnityEngine.Avatar));
					string[] _jointPaths = (string[])translator.GetObject(L, 3, typeof(string[]));
					
					var gen_ret = new UnityEngine.HumanPoseHandler(_avatar, _jointPaths);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.HumanPoseHandler constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetHumanPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.HumanPose _humanPose;translator.Get(L, 2, out _humanPose);
                    
                    gen_to_be_invoked.GetHumanPose( ref _humanPose );
                    translator.Push(L, _humanPose);
                        translator.Update(L, 2, _humanPose);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetHumanPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.HumanPose _humanPose;translator.Get(L, 2, out _humanPose);
                    
                    gen_to_be_invoked.SetHumanPose( ref _humanPose );
                    translator.Push(L, _humanPose);
                        translator.Update(L, 2, _humanPose);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInternalHumanPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.HumanPose _humanPose;translator.Get(L, 2, out _humanPose);
                    
                    gen_to_be_invoked.GetInternalHumanPose( ref _humanPose );
                    translator.Push(L, _humanPose);
                        translator.Update(L, 2, _humanPose);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInternalHumanPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.HumanPose _humanPose;translator.Get(L, 2, out _humanPose);
                    
                    gen_to_be_invoked.SetInternalHumanPose( ref _humanPose );
                    translator.Push(L, _humanPose);
                        translator.Update(L, 2, _humanPose);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetInternalAvatarPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Unity.Collections.NativeArray<float> _avatarPose;translator.Get(L, 2, out _avatarPose);
                    
                    gen_to_be_invoked.GetInternalAvatarPose( _avatarPose );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetInternalAvatarPose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.HumanPoseHandler gen_to_be_invoked = (UnityEngine.HumanPoseHandler)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    Unity.Collections.NativeArray<float> _avatarPose;translator.Get(L, 2, out _avatarPose);
                    
                    gen_to_be_invoked.SetInternalAvatarPose( _avatarPose );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
