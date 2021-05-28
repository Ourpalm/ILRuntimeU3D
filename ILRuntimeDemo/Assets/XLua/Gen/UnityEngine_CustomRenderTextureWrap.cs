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
    public class UnityEngineCustomRenderTextureWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.CustomRenderTexture);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 13, 13);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Update", _m_Update);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Initialize", _m_Initialize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearUpdateZones", _m_ClearUpdateZones);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetUpdateZones", _m_GetUpdateZones);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetDoubleBufferRenderTexture", _m_GetDoubleBufferRenderTexture);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureDoubleBufferConsistency", _m_EnsureDoubleBufferConsistency);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetUpdateZones", _m_SetUpdateZones);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "material", _g_get_material);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "initializationMaterial", _g_get_initializationMaterial);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "initializationTexture", _g_get_initializationTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "initializationSource", _g_get_initializationSource);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "initializationColor", _g_get_initializationColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateMode", _g_get_updateMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "initializationMode", _g_get_initializationMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateZoneSpace", _g_get_updateZoneSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "shaderPass", _g_get_shaderPass);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cubemapFaceMask", _g_get_cubemapFaceMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "doubleBuffered", _g_get_doubleBuffered);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wrapUpdateZones", _g_get_wrapUpdateZones);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updatePeriod", _g_get_updatePeriod);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "material", _s_set_material);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "initializationMaterial", _s_set_initializationMaterial);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "initializationTexture", _s_set_initializationTexture);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "initializationSource", _s_set_initializationSource);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "initializationColor", _s_set_initializationColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateMode", _s_set_updateMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "initializationMode", _s_set_initializationMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateZoneSpace", _s_set_updateZoneSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "shaderPass", _s_set_shaderPass);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cubemapFaceMask", _s_set_cubemapFaceMask);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "doubleBuffered", _s_set_doubleBuffered);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wrapUpdateZones", _s_set_wrapUpdateZones);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updatePeriod", _s_set_updatePeriod);
            
			
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
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.RenderTextureFormat>(L, 4) && translator.Assignable<UnityEngine.RenderTextureReadWrite>(L, 5))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.RenderTextureFormat _format;translator.Get(L, 4, out _format);
					UnityEngine.RenderTextureReadWrite _readWrite;translator.Get(L, 5, out _readWrite);
					
					var gen_ret = new UnityEngine.CustomRenderTexture(_width, _height, _format, _readWrite);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.RenderTextureFormat>(L, 4))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.RenderTextureFormat _format;translator.Get(L, 4, out _format);
					
					var gen_ret = new UnityEngine.CustomRenderTexture(_width, _height, _format);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					
					var gen_ret = new UnityEngine.CustomRenderTexture(_width, _height);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 4))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.Experimental.Rendering.DefaultFormat _defaultFormat;translator.Get(L, 4, out _defaultFormat);
					
					var gen_ret = new UnityEngine.CustomRenderTexture(_width, _height, _defaultFormat);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 4))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 4, out _format);
					
					var gen_ret = new UnityEngine.CustomRenderTexture(_width, _height, _format);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CustomRenderTexture constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Update(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Update(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Update( _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.CustomRenderTexture.Update!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Initialize(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Initialize(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearUpdateZones(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearUpdateZones(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUpdateZones(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Collections.Generic.List<UnityEngine.CustomRenderTextureUpdateZone> _updateZones = (System.Collections.Generic.List<UnityEngine.CustomRenderTextureUpdateZone>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.CustomRenderTextureUpdateZone>));
                    
                    gen_to_be_invoked.GetUpdateZones( _updateZones );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDoubleBufferRenderTexture(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetDoubleBufferRenderTexture(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureDoubleBufferConsistency(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.EnsureDoubleBufferConsistency(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetUpdateZones(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.CustomRenderTextureUpdateZone[] _updateZones = (UnityEngine.CustomRenderTextureUpdateZone[])translator.GetObject(L, 2, typeof(UnityEngine.CustomRenderTextureUpdateZone[]));
                    
                    gen_to_be_invoked.SetUpdateZones( _updateZones );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_material(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.material);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializationMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.initializationMaterial);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializationTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.initializationTexture);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializationSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.initializationSource);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializationColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, gen_to_be_invoked.initializationColor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.updateMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_initializationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.initializationMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updateZoneSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.updateZoneSpace);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_shaderPass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.shaderPass);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cubemapFaceMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, gen_to_be_invoked.cubemapFaceMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_doubleBuffered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.doubleBuffered);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wrapUpdateZones(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.wrapUpdateZones);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_updatePeriod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.updatePeriod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_material(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.material = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_initializationMaterial(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.initializationMaterial = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_initializationTexture(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.initializationTexture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_initializationSource(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.CustomRenderTextureInitializationSource gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.initializationSource = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_initializationColor(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.Color gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.initializationColor = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updateMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.CustomRenderTextureUpdateMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.updateMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_initializationMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.CustomRenderTextureUpdateMode gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.initializationMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updateZoneSpace(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                UnityEngine.CustomRenderTextureUpdateZoneSpace gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.updateZoneSpace = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_shaderPass(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.shaderPass = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cubemapFaceMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cubemapFaceMask = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_doubleBuffered(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.doubleBuffered = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wrapUpdateZones(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.wrapUpdateZones = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_updatePeriod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.CustomRenderTexture gen_to_be_invoked = (UnityEngine.CustomRenderTexture)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.updatePeriod = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
