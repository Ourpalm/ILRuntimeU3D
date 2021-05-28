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
    public class UnityEngineCompositeCollider2DWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.CompositeCollider2D);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 7, 5);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GenerateGeometry", _m_GenerateGeometry);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPathPointCount", _m_GetPathPointCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPath", _m_GetPath);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "geometryType", _g_get_geometryType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "generationType", _g_get_generationType);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vertexDistance", _g_get_vertexDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "edgeRadius", _g_get_edgeRadius);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "offsetDistance", _g_get_offsetDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pathCount", _g_get_pathCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pointCount", _g_get_pointCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "geometryType", _s_set_geometryType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "generationType", _s_set_generationType);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vertexDistance", _s_set_vertexDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "edgeRadius", _s_set_edgeRadius);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "offsetDistance", _s_set_offsetDistance);
            
			
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
					
					var gen_ret = new UnityEngine.CompositeCollider2D();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CompositeCollider2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateGeometry(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.GenerateGeometry(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPathPointCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPathPointCount( _index );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPath(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Vector2[]>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Vector2[] _points = (UnityEngine.Vector2[])translator.GetObject(L, 3, typeof(UnityEngine.Vector2[]));
                    
                        var gen_ret = gen_to_be_invoked.GetPath( _index, _points );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Vector2>>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.List<UnityEngine.Vector2> _points = (System.Collections.Generic.List<UnityEngine.Vector2>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Vector2>));
                    
                        var gen_ret = gen_to_be_invoked.GetPath( _index, _points );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CompositeCollider2D.GetPath!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_geometryType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.geometryType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_generationType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.generationType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vertexDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.vertexDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_edgeRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.edgeRadius);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_offsetDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.offsetDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pathCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pathCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pointCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pointCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_geometryType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                UnityEngine.CompositeCollider2D.GeometryType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.geometryType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_generationType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                UnityEngine.CompositeCollider2D.GenerationType gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.generationType = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vertexDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.vertexDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_edgeRadius(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.edgeRadius = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_offsetDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CompositeCollider2D gen_to_be_invoked = (UnityEngine.CompositeCollider2D)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.offsetDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
