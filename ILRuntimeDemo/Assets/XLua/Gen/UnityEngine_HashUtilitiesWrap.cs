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
    public class UnityEngineHashUtilitiesWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.HashUtilities);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 5, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "AppendHash", _m_AppendHash_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "QuantisedMatrixHash", _m_QuantisedMatrixHash_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "QuantisedVectorHash", _m_QuantisedVectorHash_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ComputeHash128", _m_ComputeHash128_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.HashUtilities does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AppendHash_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Hash128 _inHash;translator.Get(L, 1, out _inHash);
                    UnityEngine.Hash128 _outHash;translator.Get(L, 2, out _outHash);
                    
                    UnityEngine.HashUtilities.AppendHash( ref _inHash, ref _outHash );
                    translator.Push(L, _inHash);
                        translator.Update(L, 1, _inHash);
                        
                    translator.Push(L, _outHash);
                        translator.Update(L, 2, _outHash);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QuantisedMatrixHash_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 _value;translator.Get(L, 1, out _value);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                    UnityEngine.HashUtilities.QuantisedMatrixHash( ref _value, ref _hash );
                    translator.Push(L, _value);
                        translator.Update(L, 1, _value);
                        
                    translator.Push(L, _hash);
                        translator.Update(L, 2, _hash);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_QuantisedVectorHash_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _value;translator.Get(L, 1, out _value);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                    UnityEngine.HashUtilities.QuantisedVectorHash( ref _value, ref _hash );
                    translator.PushUnityEngineVector3(L, _value);
                        translator.UpdateUnityEngineVector3(L, 1, _value);
                        
                    translator.Push(L, _hash);
                        translator.Update(L, 2, _hash);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ComputeHash128_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    byte[] _value = LuaAPI.lua_tobytes(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                    UnityEngine.HashUtilities.ComputeHash128( _value, ref _hash );
                    translator.Push(L, _hash);
                        translator.Update(L, 2, _hash);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
