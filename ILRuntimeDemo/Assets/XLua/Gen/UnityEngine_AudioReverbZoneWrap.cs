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
    public class UnityEngineAudioReverbZoneWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.AudioReverbZone);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 16, 16);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "minDistance", _g_get_minDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxDistance", _g_get_maxDistance);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reverbPreset", _g_get_reverbPreset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "room", _g_get_room);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "roomHF", _g_get_roomHF);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "roomLF", _g_get_roomLF);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "decayTime", _g_get_decayTime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "decayHFRatio", _g_get_decayHFRatio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reflections", _g_get_reflections);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reflectionsDelay", _g_get_reflectionsDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reverb", _g_get_reverb);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reverbDelay", _g_get_reverbDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HFReference", _g_get_HFReference);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LFReference", _g_get_LFReference);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "diffusion", _g_get_diffusion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "density", _g_get_density);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "minDistance", _s_set_minDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxDistance", _s_set_maxDistance);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reverbPreset", _s_set_reverbPreset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "room", _s_set_room);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "roomHF", _s_set_roomHF);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "roomLF", _s_set_roomLF);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "decayTime", _s_set_decayTime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "decayHFRatio", _s_set_decayHFRatio);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reflections", _s_set_reflections);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reflectionsDelay", _s_set_reflectionsDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reverb", _s_set_reverb);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "reverbDelay", _s_set_reverbDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HFReference", _s_set_HFReference);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LFReference", _s_set_LFReference);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "diffusion", _s_set_diffusion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "density", _s_set_density);
            
			
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
					
					var gen_ret = new UnityEngine.AudioReverbZone();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AudioReverbZone constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.minDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.maxDistance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reverbPreset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.reverbPreset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_room(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.room);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_roomHF(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.roomHF);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_roomLF(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.roomLF);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_decayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.decayTime);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_decayHFRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.decayHFRatio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflections(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.reflections);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reflectionsDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.reflectionsDelay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reverb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.reverb);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reverbDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.reverbDelay);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HFReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.HFReference);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LFReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.LFReference);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_diffusion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.diffusion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_density(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.density);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_minDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.minDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_maxDistance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.maxDistance = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reverbPreset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                UnityEngine.AudioReverbPreset gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.reverbPreset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_room(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.room = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_roomHF(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.roomHF = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_roomLF(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.roomLF = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_decayTime(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.decayTime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_decayHFRatio(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.decayHFRatio = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflections(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reflections = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reflectionsDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reflectionsDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reverb(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reverb = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_reverbDelay(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.reverbDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HFReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HFReference = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LFReference(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LFReference = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_diffusion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.diffusion = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_density(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.AudioReverbZone gen_to_be_invoked = (UnityEngine.AudioReverbZone)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.density = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
