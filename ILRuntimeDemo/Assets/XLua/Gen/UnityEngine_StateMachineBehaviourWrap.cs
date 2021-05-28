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
    public class UnityEngineStateMachineBehaviourWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.StateMachineBehaviour);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateEnter", _m_OnStateEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateUpdate", _m_OnStateUpdate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateExit", _m_OnStateExit);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateMove", _m_OnStateMove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateIK", _m_OnStateIK);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateMachineEnter", _m_OnStateMachineEnter);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnStateMachineExit", _m_OnStateMachineExit);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.StateMachineBehaviour does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.OnStateEnter( _animator, _stateInfo, _layerIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 5, out _controller);
                    
                    gen_to_be_invoked.OnStateEnter( _animator, _stateInfo, _layerIndex, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateEnter!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateUpdate(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.OnStateUpdate( _animator, _stateInfo, _layerIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 5, out _controller);
                    
                    gen_to_be_invoked.OnStateUpdate( _animator, _stateInfo, _layerIndex, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateUpdate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateExit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.OnStateExit( _animator, _stateInfo, _layerIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 5, out _controller);
                    
                    gen_to_be_invoked.OnStateExit( _animator, _stateInfo, _layerIndex, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateExit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateMove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.OnStateMove( _animator, _stateInfo, _layerIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 5, out _controller);
                    
                    gen_to_be_invoked.OnStateMove( _animator, _stateInfo, _layerIndex, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateMove!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateIK(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.OnStateIK( _animator, _stateInfo, _layerIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Animator>(L, 2)&& translator.Assignable<UnityEngine.AnimatorStateInfo>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 5)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    UnityEngine.AnimatorStateInfo _stateInfo;translator.Get(L, 3, out _stateInfo);
                    int _layerIndex = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 5, out _controller);
                    
                    gen_to_be_invoked.OnStateIK( _animator, _stateInfo, _layerIndex, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateIK!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateMachineEnter(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int _stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.OnStateMachineEnter( _animator, _stateMachinePathHash );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int _stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 4, out _controller);
                    
                    gen_to_be_invoked.OnStateMachineEnter( _animator, _stateMachinePathHash, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateMachineEnter!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnStateMachineExit(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.StateMachineBehaviour gen_to_be_invoked = (UnityEngine.StateMachineBehaviour)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int _stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.OnStateMachineExit( _animator, _stateMachinePathHash );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Animator>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Animations.AnimatorControllerPlayable>(L, 4)) 
                {
                    UnityEngine.Animator _animator = (UnityEngine.Animator)translator.GetObject(L, 2, typeof(UnityEngine.Animator));
                    int _stateMachinePathHash = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Animations.AnimatorControllerPlayable _controller;translator.Get(L, 4, out _controller);
                    
                    gen_to_be_invoked.OnStateMachineExit( _animator, _stateMachinePathHash, _controller );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.StateMachineBehaviour.OnStateMachineExit!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
