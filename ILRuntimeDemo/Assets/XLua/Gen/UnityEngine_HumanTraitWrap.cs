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
    public class UnityEngineHumanTraitWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.HumanTrait);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 5, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "MuscleFromBone", _m_MuscleFromBone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BoneFromMuscle", _m_BoneFromMuscle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RequiredBone", _m_RequiredBone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMuscleDefaultMin", _m_GetMuscleDefaultMin_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetMuscleDefaultMax", _m_GetMuscleDefaultMax_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetBoneDefaultHierarchyMass", _m_GetBoneDefaultHierarchyMass_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetParentBone", _m_GetParentBone_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MuscleCount", _g_get_MuscleCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MuscleName", _g_get_MuscleName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BoneCount", _g_get_BoneCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "BoneName", _g_get_BoneName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "RequiredBoneCount", _g_get_RequiredBoneCount);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.HumanTrait();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.HumanTrait constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MuscleFromBone_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    int _dofIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.HumanTrait.MuscleFromBone( _i, _dofIndex );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BoneFromMuscle_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.HumanTrait.BoneFromMuscle( _i );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RequiredBone_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.HumanTrait.RequiredBone( _i );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMuscleDefaultMin_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.HumanTrait.GetMuscleDefaultMin( _i );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetMuscleDefaultMax_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.HumanTrait.GetMuscleDefaultMax( _i );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetBoneDefaultHierarchyMass_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.HumanTrait.GetBoneDefaultHierarchyMass( _i );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetParentBone_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _i = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.HumanTrait.GetParentBone( _i );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MuscleCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.HumanTrait.MuscleCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MuscleName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.HumanTrait.MuscleName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BoneCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.HumanTrait.BoneCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BoneName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.HumanTrait.BoneName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_RequiredBoneCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.HumanTrait.RequiredBoneCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
