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
    public class UnityEngineParticleSystemForceFieldWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.ParticleSystemForceField);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 18, 18);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "shape", _g_get_shape);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startRange", _g_get_startRange);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "endRange", _g_get_endRange);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", _g_get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravityFocus", _g_get_gravityFocus);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationRandomness", _g_get_rotationRandomness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiplyDragByParticleSize", _g_get_multiplyDragByParticleSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "multiplyDragByParticleVelocity", _g_get_multiplyDragByParticleVelocity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vectorField", _g_get_vectorField);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directionX", _g_get_directionX);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directionY", _g_get_directionY);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "directionZ", _g_get_directionZ);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravity", _g_get_gravity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationSpeed", _g_get_rotationSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotationAttraction", _g_get_rotationAttraction);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "drag", _g_get_drag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vectorFieldSpeed", _g_get_vectorFieldSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vectorFieldAttraction", _g_get_vectorFieldAttraction);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "shape", _s_set_shape);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startRange", _s_set_startRange);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "endRange", _s_set_endRange);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "length", _s_set_length);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gravityFocus", _s_set_gravityFocus);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationRandomness", _s_set_rotationRandomness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "multiplyDragByParticleSize", _s_set_multiplyDragByParticleSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "multiplyDragByParticleVelocity", _s_set_multiplyDragByParticleVelocity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vectorField", _s_set_vectorField);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directionX", _s_set_directionX);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directionY", _s_set_directionY);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "directionZ", _s_set_directionZ);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gravity", _s_set_gravity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationSpeed", _s_set_rotationSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotationAttraction", _s_set_rotationAttraction);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "drag", _s_set_drag);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vectorFieldSpeed", _s_set_vectorFieldSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vectorFieldAttraction", _s_set_vectorFieldAttraction);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "FindAll", _m_FindAll_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.ParticleSystemForceField();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystemForceField constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindAll_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        var gen_ret = UnityEngine.ParticleSystemForceField.FindAll(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shape(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.shape);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startRange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.startRange);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_endRange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.endRange);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravityFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.gravityFocus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationRandomness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, gen_to_be_invoked.rotationRandomness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_multiplyDragByParticleSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.multiplyDragByParticleSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_multiplyDragByParticleVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.multiplyDragByParticleVelocity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vectorField(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.vectorField);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directionX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directionX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directionY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directionY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_directionZ(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.directionZ);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gravity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotationSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rotationAttraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rotationAttraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.drag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vectorFieldSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.vectorFieldSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vectorFieldAttraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.vectorFieldAttraction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shape(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemForceFieldShape gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.shape = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startRange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startRange = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_endRange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.endRange = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.length = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravityFocus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.gravityFocus = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationRandomness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotationRandomness = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_multiplyDragByParticleSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.multiplyDragByParticleSize = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_multiplyDragByParticleVelocity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.multiplyDragByParticleVelocity = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vectorField(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.vectorField = (UnityEngine.Texture3D)translator.GetObject(L, 2, typeof(UnityEngine.Texture3D));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directionX(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.directionX = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directionY(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.directionY = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_directionZ(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.directionZ = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_gravity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.gravity = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotationSpeed = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rotationAttraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.rotationAttraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_drag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.drag = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vectorFieldSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.vectorFieldSpeed = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vectorFieldAttraction(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.ParticleSystemForceField gen_to_be_invoked = (UnityEngine.ParticleSystemForceField)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystem.MinMaxCurve gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.vectorFieldAttraction = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
