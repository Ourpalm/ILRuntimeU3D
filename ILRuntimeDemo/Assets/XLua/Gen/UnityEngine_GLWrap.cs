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
    public class UnityEngineGLWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GL);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 32, 4, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Vertex3", _m_Vertex3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Vertex", _m_Vertex_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TexCoord3", _m_TexCoord3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TexCoord", _m_TexCoord_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TexCoord2", _m_TexCoord2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultiTexCoord3", _m_MultiTexCoord3_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultiTexCoord", _m_MultiTexCoord_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultiTexCoord2", _m_MultiTexCoord2_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Color", _m_Color_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Flush", _m_Flush_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RenderTargetBarrier", _m_RenderTargetBarrier_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MultMatrix", _m_MultMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PushMatrix", _m_PushMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PopMatrix", _m_PopMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadIdentity", _m_LoadIdentity_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadOrtho", _m_LoadOrtho_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadPixelMatrix", _m_LoadPixelMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LoadProjectionMatrix", _m_LoadProjectionMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InvalidateState", _m_InvalidateState_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGPUProjectionMatrix", _m_GetGPUProjectionMatrix_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IssuePluginEvent", _m_IssuePluginEvent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Begin", _m_Begin_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "End", _m_End_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clear", _m_Clear_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Viewport", _m_Viewport_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearWithSkybox", _m_ClearWithSkybox_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TRIANGLES", UnityEngine.GL.TRIANGLES);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "TRIANGLE_STRIP", UnityEngine.GL.TRIANGLE_STRIP);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "QUADS", UnityEngine.GL.QUADS);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LINES", UnityEngine.GL.LINES);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LINE_STRIP", UnityEngine.GL.LINE_STRIP);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "wireframe", _g_get_wireframe);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "sRGBWrite", _g_get_sRGBWrite);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "invertCulling", _g_get_invertCulling);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "modelview", _g_get_modelview);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "wireframe", _s_set_wireframe);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "sRGBWrite", _s_set_sRGBWrite);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "invertCulling", _s_set_invertCulling);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "modelview", _s_set_modelview);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.GL();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GL constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Vertex3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 1);
                    float _y = (float)LuaAPI.lua_tonumber(L, 2);
                    float _z = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.GL.Vertex3( _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Vertex_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _v;translator.Get(L, 1, out _v);
                    
                    UnityEngine.GL.Vertex( _v );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TexCoord3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 1);
                    float _y = (float)LuaAPI.lua_tonumber(L, 2);
                    float _z = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.GL.TexCoord3( _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TexCoord_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Vector3 _v;translator.Get(L, 1, out _v);
                    
                    UnityEngine.GL.TexCoord( _v );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TexCoord2_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    float _x = (float)LuaAPI.lua_tonumber(L, 1);
                    float _y = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    UnityEngine.GL.TexCoord2( _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultiTexCoord3_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _unit = LuaAPI.xlua_tointeger(L, 1);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    float _z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.GL.MultiTexCoord3( _unit, _x, _y, _z );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultiTexCoord_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _unit = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.Vector3 _v;translator.Get(L, 2, out _v);
                    
                    UnityEngine.GL.MultiTexCoord( _unit, _v );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultiTexCoord2_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _unit = LuaAPI.xlua_tointeger(L, 1);
                    float _x = (float)LuaAPI.lua_tonumber(L, 2);
                    float _y = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    UnityEngine.GL.MultiTexCoord2( _unit, _x, _y );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Color_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Color _c;translator.Get(L, 1, out _c);
                    
                    UnityEngine.GL.Color( _c );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Flush_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.Flush(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RenderTargetBarrier_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.RenderTargetBarrier(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MultMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 _m;translator.Get(L, 1, out _m);
                    
                    UnityEngine.GL.MultMatrix( _m );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PushMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.PushMatrix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PopMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.PopMatrix(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadIdentity_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.LoadIdentity(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadOrtho_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.LoadOrtho(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadPixelMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                    UnityEngine.GL.LoadPixelMatrix(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float _left = (float)LuaAPI.lua_tonumber(L, 1);
                    float _right = (float)LuaAPI.lua_tonumber(L, 2);
                    float _bottom = (float)LuaAPI.lua_tonumber(L, 3);
                    float _top = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.GL.LoadPixelMatrix( _left, _right, _bottom, _top );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GL.LoadPixelMatrix!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_LoadProjectionMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 _mat;translator.Get(L, 1, out _mat);
                    
                    UnityEngine.GL.LoadProjectionMatrix( _mat );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvalidateState_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.InvalidateState(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGPUProjectionMatrix_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Matrix4x4 _proj;translator.Get(L, 1, out _proj);
                    bool _renderIntoTexture = LuaAPI.lua_toboolean(L, 2);
                    
                        var gen_ret = UnityEngine.GL.GetGPUProjectionMatrix( _proj, _renderIntoTexture );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IssuePluginEvent_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    System.IntPtr _callback = LuaAPI.lua_touserdata(L, 1);
                    int _eventID = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.GL.IssuePluginEvent( _callback, _eventID );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Begin_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _mode = LuaAPI.xlua_tointeger(L, 1);
                    
                    UnityEngine.GL.Begin( _mode );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_End_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.GL.End(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    bool _clearDepth = LuaAPI.lua_toboolean(L, 1);
                    bool _clearColor = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.Color _backgroundColor;translator.Get(L, 3, out _backgroundColor);
                    
                    UnityEngine.GL.Clear( _clearDepth, _clearColor, _backgroundColor );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    bool _clearDepth = LuaAPI.lua_toboolean(L, 1);
                    bool _clearColor = LuaAPI.lua_toboolean(L, 2);
                    UnityEngine.Color _backgroundColor;translator.Get(L, 3, out _backgroundColor);
                    float _depth = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.GL.Clear( _clearDepth, _clearColor, _backgroundColor, _depth );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GL.Clear!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Viewport_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rect _pixelRect;translator.Get(L, 1, out _pixelRect);
                    
                    UnityEngine.GL.Viewport( _pixelRect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearWithSkybox_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    bool _clearDepth = LuaAPI.lua_toboolean(L, 1);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 2, typeof(UnityEngine.Camera));
                    
                    UnityEngine.GL.ClearWithSkybox( _clearDepth, _camera );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wireframe(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.GL.wireframe);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sRGBWrite(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.GL.sRGBWrite);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_invertCulling(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.GL.invertCulling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_modelview(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.GL.modelview);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wireframe(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.GL.wireframe = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sRGBWrite(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.GL.sRGBWrite = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_invertCulling(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.GL.invertCulling = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_modelview(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Matrix4x4 gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.GL.modelview = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
