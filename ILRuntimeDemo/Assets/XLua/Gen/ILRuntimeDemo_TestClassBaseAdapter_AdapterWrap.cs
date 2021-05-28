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
    public class ILRuntimeDemoTestClassBaseAdapterAdapterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ILRuntimeDemo.TestClassBaseAdapter.Adapter);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TestVirtual", _m_TestVirtual);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TestAbstract", _m_TestAbstract);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ILInstance", _g_get_ILInstance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Value", _g_get_Value);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Value", _s_set_Value);
            
			
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
					
					var gen_ret = new ILRuntimeDemo.TestClassBaseAdapter.Adapter();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && translator.Assignable<ILRuntime.Runtime.Enviorment.AppDomain>(L, 2) && translator.Assignable<ILRuntime.Runtime.Intepreter.ILTypeInstance>(L, 3))
				{
					ILRuntime.Runtime.Enviorment.AppDomain _appdomain = (ILRuntime.Runtime.Enviorment.AppDomain)translator.GetObject(L, 2, typeof(ILRuntime.Runtime.Enviorment.AppDomain));
					ILRuntime.Runtime.Intepreter.ILTypeInstance _instance = (ILRuntime.Runtime.Intepreter.ILTypeInstance)translator.GetObject(L, 3, typeof(ILRuntime.Runtime.Intepreter.ILTypeInstance));
					
					var gen_ret = new ILRuntimeDemo.TestClassBaseAdapter.Adapter(_appdomain, _instance);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ILRuntimeDemo.TestClassBaseAdapter.Adapter constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TestVirtual(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ILRuntimeDemo.TestClassBaseAdapter.Adapter gen_to_be_invoked = (ILRuntimeDemo.TestClassBaseAdapter.Adapter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.TestVirtual( _str );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TestAbstract(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ILRuntimeDemo.TestClassBaseAdapter.Adapter gen_to_be_invoked = (ILRuntimeDemo.TestClassBaseAdapter.Adapter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _gg = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.TestAbstract( _gg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                ILRuntimeDemo.TestClassBaseAdapter.Adapter gen_to_be_invoked = (ILRuntimeDemo.TestClassBaseAdapter.Adapter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ILInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ILRuntimeDemo.TestClassBaseAdapter.Adapter gen_to_be_invoked = (ILRuntimeDemo.TestClassBaseAdapter.Adapter)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ILInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ILRuntimeDemo.TestClassBaseAdapter.Adapter gen_to_be_invoked = (ILRuntimeDemo.TestClassBaseAdapter.Adapter)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Value);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Value(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                ILRuntimeDemo.TestClassBaseAdapter.Adapter gen_to_be_invoked = (ILRuntimeDemo.TestClassBaseAdapter.Adapter)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Value = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
