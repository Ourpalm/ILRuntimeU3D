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
    public class UnityEngineLineUtilityWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.LineUtility);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Simplify", _m_Simplify_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.LineUtility();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LineUtility constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Simplify_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<int>>(L, 3)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> _points = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    float _tolerance = (float)LuaAPI.lua_tonumber(L, 2);
                    System.Collections.Generic.List<int> _pointsToKeep = (System.Collections.Generic.List<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.LineUtility.Simplify( _points, _tolerance, _pointsToKeep );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector3>>(L, 3)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector3> _points = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    float _tolerance = (float)LuaAPI.lua_tonumber(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector3> _simplifiedPoints = (System.Collections.Generic.List<UnityEngine.Vector3>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector3>));
                    
                    UnityEngine.LineUtility.Simplify( _points, _tolerance, _simplifiedPoints );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector2>>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<int>>(L, 3)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector2> _points = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    float _tolerance = (float)LuaAPI.lua_tonumber(L, 2);
                    System.Collections.Generic.List<int> _pointsToKeep = (System.Collections.Generic.List<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<int>));
                    
                    UnityEngine.LineUtility.Simplify( _points, _tolerance, _pointsToKeep );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector2>>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector2>>(L, 3)) 
                {
                    System.Collections.Generic.List<UnityEngine.Vector2> _points = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    float _tolerance = (float)LuaAPI.lua_tonumber(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector2> _simplifiedPoints = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    
                    UnityEngine.LineUtility.Simplify( _points, _tolerance, _simplifiedPoints );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.LineUtility.Simplify!");
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
