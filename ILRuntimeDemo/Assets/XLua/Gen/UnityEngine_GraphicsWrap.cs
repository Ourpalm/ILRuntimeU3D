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
    public class UnityEngineGraphicsWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Graphics);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 23, 6, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearRandomWriteTargets", _m_ClearRandomWriteTargets_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExecuteCommandBuffer", _m_ExecuteCommandBuffer_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ExecuteCommandBufferAsync", _m_ExecuteCommandBufferAsync_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetRenderTarget", _m_SetRenderTarget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetRandomWriteTarget", _m_SetRandomWriteTarget_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyTexture", _m_CopyTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ConvertTexture", _m_ConvertTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateAsyncGraphicsFence", _m_CreateAsyncGraphicsFence_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateGraphicsFence", _m_CreateGraphicsFence_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "WaitOnAsyncGraphicsFence", _m_WaitOnAsyncGraphicsFence_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawTexture", _m_DrawTexture_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshNow", _m_DrawMeshNow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMesh", _m_DrawMesh_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshInstanced", _m_DrawMeshInstanced_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshInstancedProcedural", _m_DrawMeshInstancedProcedural_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawMeshInstancedIndirect", _m_DrawMeshInstancedIndirect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawProceduralNow", _m_DrawProceduralNow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawProceduralIndirectNow", _m_DrawProceduralIndirectNow_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawProcedural", _m_DrawProcedural_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawProceduralIndirect", _m_DrawProceduralIndirect_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Blit", _m_Blit_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BlitMultiTap", _m_BlitMultiTap_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeColorGamut", _g_get_activeColorGamut);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeTier", _g_get_activeTier);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "preserveFramebufferAlpha", _g_get_preserveFramebufferAlpha);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "minOpenGLESVersion", _g_get_minOpenGLESVersion);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeColorBuffer", _g_get_activeColorBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "activeDepthBuffer", _g_get_activeDepthBuffer);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "activeTier", _s_set_activeTier);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Graphics();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearRandomWriteTargets_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    UnityEngine.Graphics.ClearRandomWriteTargets(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteCommandBuffer_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rendering.CommandBuffer _buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 1, typeof(UnityEngine.Rendering.CommandBuffer));
                    
                    UnityEngine.Graphics.ExecuteCommandBuffer( _buffer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteCommandBufferAsync_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rendering.CommandBuffer _buffer = (UnityEngine.Rendering.CommandBuffer)translator.GetObject(L, 1, typeof(UnityEngine.Rendering.CommandBuffer));
                    UnityEngine.Rendering.ComputeQueueType _queueType;translator.Get(L, 2, out _queueType);
                    
                    UnityEngine.Graphics.ExecuteCommandBufferAsync( _buffer, _queueType );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRenderTarget_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.RenderTargetSetup>(L, 1)) 
                {
                    UnityEngine.RenderTargetSetup _setup;translator.Get(L, 1, out _setup);
                    
                    UnityEngine.Graphics.SetRenderTarget( _setup );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)) 
                {
                    UnityEngine.RenderTexture _rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.Graphics.SetRenderTarget( _rt );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.RenderTexture _rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Graphics.SetRenderTarget( _rt, _mipLevel );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.RenderBuffer[]>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)) 
                {
                    UnityEngine.RenderBuffer[] _colorBuffers = (UnityEngine.RenderBuffer[])translator.GetObject(L, 1, typeof(UnityEngine.RenderBuffer[]));
                    UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 2, out _depthBuffer);
                    
                    UnityEngine.Graphics.SetRenderTarget( _colorBuffers, _depthBuffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)) 
                {
                    UnityEngine.RenderBuffer _colorBuffer;translator.Get(L, 1, out _colorBuffer);
                    UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 2, out _depthBuffer);
                    
                    UnityEngine.Graphics.SetRenderTarget( _colorBuffer, _depthBuffer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)) 
                {
                    UnityEngine.RenderTexture _rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.CubemapFace _face;translator.Get(L, 3, out _face);
                    
                    UnityEngine.Graphics.SetRenderTarget( _rt, _mipLevel, _face );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.RenderBuffer _colorBuffer;translator.Get(L, 1, out _colorBuffer);
                    UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 2, out _depthBuffer);
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.SetRenderTarget( _colorBuffer, _depthBuffer, _mipLevel );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.RenderTexture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.CubemapFace>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.RenderTexture _rt = (UnityEngine.RenderTexture)translator.GetObject(L, 1, typeof(UnityEngine.RenderTexture));
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.CubemapFace _face;translator.Get(L, 3, out _face);
                    int _depthSlice = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.SetRenderTarget( _rt, _mipLevel, _face, _depthSlice );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.CubemapFace>(L, 4)) 
                {
                    UnityEngine.RenderBuffer _colorBuffer;translator.Get(L, 1, out _colorBuffer);
                    UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 2, out _depthBuffer);
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.CubemapFace _face;translator.Get(L, 4, out _face);
                    
                    UnityEngine.Graphics.SetRenderTarget( _colorBuffer, _depthBuffer, _mipLevel, _face );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.RenderBuffer>(L, 1)&& translator.Assignable<UnityEngine.RenderBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.CubemapFace>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.RenderBuffer _colorBuffer;translator.Get(L, 1, out _colorBuffer);
                    UnityEngine.RenderBuffer _depthBuffer;translator.Get(L, 2, out _depthBuffer);
                    int _mipLevel = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.CubemapFace _face;translator.Get(L, 4, out _face);
                    int _depthSlice = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.SetRenderTarget( _colorBuffer, _depthBuffer, _mipLevel, _face, _depthSlice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.SetRenderTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetRandomWriteTarget_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.RenderTexture _uav = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( _index, _uav );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer _uav = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( _index, _uav );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GraphicsBuffer _uav = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( _index, _uav );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.ComputeBuffer _uav = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    bool _preserveCounterValue = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( _index, _uav, _preserveCounterValue );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    UnityEngine.GraphicsBuffer _uav = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    bool _preserveCounterValue = LuaAPI.lua_toboolean(L, 3);
                    
                    UnityEngine.Graphics.SetRandomWriteTarget( _index, _uav, _preserveCounterValue );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.SetRandomWriteTarget!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Texture _dst = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Graphics.CopyTexture( _src, _dst );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int _srcElement = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture _dst = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    int _dstElement = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.CopyTexture( _src, _srcElement, _dst, _dstElement );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Texture>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int _srcElement = LuaAPI.xlua_tointeger(L, 2);
                    int _srcMip = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Texture _dst = (UnityEngine.Texture)translator.GetObject(L, 4, typeof(UnityEngine.Texture));
                    int _dstElement = LuaAPI.xlua_tointeger(L, 5);
                    int _dstMip = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.CopyTexture( _src, _srcElement, _srcMip, _dst, _dstElement, _dstMip );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Texture>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int _srcElement = LuaAPI.xlua_tointeger(L, 2);
                    int _srcMip = LuaAPI.xlua_tointeger(L, 3);
                    int _srcX = LuaAPI.xlua_tointeger(L, 4);
                    int _srcY = LuaAPI.xlua_tointeger(L, 5);
                    int _srcWidth = LuaAPI.xlua_tointeger(L, 6);
                    int _srcHeight = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Texture _dst = (UnityEngine.Texture)translator.GetObject(L, 8, typeof(UnityEngine.Texture));
                    int _dstElement = LuaAPI.xlua_tointeger(L, 9);
                    int _dstMip = LuaAPI.xlua_tointeger(L, 10);
                    int _dstX = LuaAPI.xlua_tointeger(L, 11);
                    int _dstY = LuaAPI.xlua_tointeger(L, 12);
                    
                    UnityEngine.Graphics.CopyTexture( _src, _srcElement, _srcMip, _srcX, _srcY, _srcWidth, _srcHeight, _dst, _dstElement, _dstMip, _dstX, _dstY );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.CopyTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConvertTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Texture _dst = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                        var gen_ret = UnityEngine.Graphics.ConvertTexture( _src, _dst );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Texture>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    int _srcElement = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Texture _dst = (UnityEngine.Texture)translator.GetObject(L, 3, typeof(UnityEngine.Texture));
                    int _dstElement = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = UnityEngine.Graphics.ConvertTexture( _src, _srcElement, _dst, _dstElement );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.ConvertTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateAsyncGraphicsFence_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        var gen_ret = UnityEngine.Graphics.CreateAsyncGraphicsFence(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Rendering.SynchronisationStage>(L, 1)) 
                {
                    UnityEngine.Rendering.SynchronisationStage _stage;translator.Get(L, 1, out _stage);
                    
                        var gen_ret = UnityEngine.Graphics.CreateAsyncGraphicsFence( _stage );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.CreateAsyncGraphicsFence!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateGraphicsFence_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rendering.GraphicsFenceType _fenceType;translator.Get(L, 1, out _fenceType);
                    UnityEngine.Rendering.SynchronisationStageFlags _stage;translator.Get(L, 2, out _stage);
                    
                        var gen_ret = UnityEngine.Graphics.CreateGraphicsFence( _fenceType, _stage );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_WaitOnAsyncGraphicsFence_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Rendering.GraphicsFence>(L, 1)) 
                {
                    UnityEngine.Rendering.GraphicsFence _fence;translator.Get(L, 1, out _fence);
                    
                    UnityEngine.Graphics.WaitOnAsyncGraphicsFence( _fence );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rendering.GraphicsFence>(L, 1)&& translator.Assignable<UnityEngine.Rendering.SynchronisationStage>(L, 2)) 
                {
                    UnityEngine.Rendering.GraphicsFence _fence;translator.Get(L, 1, out _fence);
                    UnityEngine.Rendering.SynchronisationStage _stage;translator.Get(L, 2, out _stage);
                    
                    UnityEngine.Graphics.WaitOnAsyncGraphicsFence( _fence, _stage );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.WaitOnAsyncGraphicsFence!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawTexture_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _leftBorder, _rightBorder, _topBorder, _bottomBorder );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _mat, _pass );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect _sourceRect;translator.Get(L, 3, out _sourceRect);
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _sourceRect, _leftBorder, _rightBorder, _topBorder, _bottomBorder );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Material>(L, 7)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 7, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Material>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 3);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 7, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 8);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _mat, _pass );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Color>(L, 8)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect _sourceRect;translator.Get(L, 3, out _sourceRect);
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Color _color;translator.Get(L, 8, out _color);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _sourceRect, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _color );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Material>(L, 8)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect _sourceRect;translator.Get(L, 3, out _sourceRect);
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 8, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _sourceRect, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Material>(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect _sourceRect;translator.Get(L, 3, out _sourceRect);
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 8, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 9);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _sourceRect, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _mat, _pass );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Color>(L, 8)&& translator.Assignable<UnityEngine.Material>(L, 9)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect _sourceRect;translator.Get(L, 3, out _sourceRect);
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Color _color;translator.Get(L, 8, out _color);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 9, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _sourceRect, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _color, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Rect>(L, 1)&& translator.Assignable<UnityEngine.Texture>(L, 2)&& translator.Assignable<UnityEngine.Rect>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.Color>(L, 8)&& translator.Assignable<UnityEngine.Material>(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Rect _screenRect;translator.Get(L, 1, out _screenRect);
                    UnityEngine.Texture _texture = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    UnityEngine.Rect _sourceRect;translator.Get(L, 3, out _sourceRect);
                    int _leftBorder = LuaAPI.xlua_tointeger(L, 4);
                    int _rightBorder = LuaAPI.xlua_tointeger(L, 5);
                    int _topBorder = LuaAPI.xlua_tointeger(L, 6);
                    int _bottomBorder = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.Color _color;translator.Get(L, 8, out _color);
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 9, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawTexture( _screenRect, _texture, _sourceRect, _leftBorder, _rightBorder, _topBorder, _bottomBorder, _color, _mat, _pass );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawTexture!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshNow_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    
                    UnityEngine.Graphics.DrawMeshNow( _mesh, _matrix );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    int _materialIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawMeshNow( _mesh, _matrix, _materialIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    
                    UnityEngine.Graphics.DrawMeshNow( _mesh, _position, _rotation );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    int _materialIndex = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawMeshNow( _mesh, _position, _rotation, _materialIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshNow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMesh_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    bool _castShadows = LuaAPI.lua_toboolean(L, 8);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    bool _castShadows = LuaAPI.lua_toboolean(L, 8);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    bool _castShadows = LuaAPI.lua_toboolean(L, 8);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    bool _useLightProbes = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    bool _castShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    bool _castShadows = LuaAPI.lua_toboolean(L, 9);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    bool _castShadows = LuaAPI.lua_toboolean(L, 9);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    bool _useLightProbes = LuaAPI.lua_toboolean(L, 11);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Transform>(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    UnityEngine.Transform _probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 10, typeof(UnityEngine.Transform));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _probeAnchor );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Transform>(L, 10)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    UnityEngine.Transform _probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 10, typeof(UnityEngine.Transform));
                    bool _useLightProbes = LuaAPI.lua_toboolean(L, 11);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _probeAnchor, _useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Transform>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    UnityEngine.Transform _probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 11, typeof(UnityEngine.Transform));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _probeAnchor );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Transform>(L, 10)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    UnityEngine.Transform _probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 10, typeof(UnityEngine.Transform));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 11, out _lightProbeUsage);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _probeAnchor, _lightProbeUsage );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Quaternion>(L, 3)&& translator.Assignable<UnityEngine.Material>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Transform>(L, 11)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Vector3 _position;translator.Get(L, 2, out _position);
                    UnityEngine.Quaternion _rotation;translator.Get(L, 3, out _rotation);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 4, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 7);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    UnityEngine.Transform _probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 11, typeof(UnityEngine.Transform));
                    bool _useLightProbes = LuaAPI.lua_toboolean(L, 12);
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _position, _rotation, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _probeAnchor, _useLightProbes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& translator.Assignable<UnityEngine.Matrix4x4>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Camera>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Transform>(L, 10)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 11)&& translator.Assignable<UnityEngine.LightProbeProxyVolume>(L, 12)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    UnityEngine.Matrix4x4 _matrix;translator.Get(L, 2, out _matrix);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _layer = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 5, typeof(UnityEngine.Camera));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    UnityEngine.Transform _probeAnchor = (UnityEngine.Transform)translator.GetObject(L, 10, typeof(UnityEngine.Transform));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 11, out _lightProbeUsage);
                    UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)translator.GetObject(L, 12, typeof(UnityEngine.LightProbeProxyVolume));
                    
                    UnityEngine.Graphics.DrawMesh( _mesh, _matrix, _material, _layer, _camera, _submeshIndex, _properties, _castShadows, _receiveShadows, _probeAnchor, _lightProbeUsage, _lightProbeProxyVolume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMesh!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstanced_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 6, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 6, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 6, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    int _layer = LuaAPI.xlua_tointeger(L, 8);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.Camera>(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 6, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    int _layer = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 9, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties, _castShadows, _receiveShadows, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties, _castShadows, _receiveShadows, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.Camera>(L, 9)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 6, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    int _layer = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 9, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 10, out _lightProbeUsage);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 11, out _lightProbeUsage);
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Matrix4x4>>(L, 4)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 5)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 6)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<UnityEngine.Camera>(L, 9)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 10)&& translator.Assignable<UnityEngine.LightProbeProxyVolume>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    System.Collections.Generic.List<UnityEngine.Matrix4x4> _matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)translator.GetObject(L, 4, typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 5, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 6, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 7);
                    int _layer = LuaAPI.xlua_tointeger(L, 8);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 9, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 10, out _lightProbeUsage);
                    UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)translator.GetObject(L, 11, typeof(UnityEngine.LightProbeProxyVolume));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage, _lightProbeProxyVolume );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Matrix4x4[]>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 11)&& translator.Assignable<UnityEngine.LightProbeProxyVolume>(L, 12)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Matrix4x4[] _matrices = (UnityEngine.Matrix4x4[])translator.GetObject(L, 4, typeof(UnityEngine.Matrix4x4[]));
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 11, out _lightProbeUsage);
                    UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)translator.GetObject(L, 12, typeof(UnityEngine.LightProbeProxyVolume));
                    
                    UnityEngine.Graphics.DrawMeshInstanced( _mesh, _submeshIndex, _material, _matrices, _count, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage, _lightProbeProxyVolume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshInstanced!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstancedProcedural_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 11)&& translator.Assignable<UnityEngine.LightProbeProxyVolume>(L, 12)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 11, out _lightProbeUsage);
                    UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)translator.GetObject(L, 12, typeof(UnityEngine.LightProbeProxyVolume));
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage, _lightProbeProxyVolume );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 11, out _lightProbeUsage);
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& translator.Assignable<UnityEngine.Camera>(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 10, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties, _castShadows, _receiveShadows, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    int _layer = LuaAPI.xlua_tointeger(L, 9);
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 8);
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 7, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 6, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawMeshInstancedProcedural( _mesh, _submeshIndex, _material, _bounds, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshInstancedProcedural!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawMeshInstancedIndirect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 12)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 12, out _lightProbeUsage);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 12)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 12, out _lightProbeUsage);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 13&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 12)&& translator.Assignable<UnityEngine.LightProbeProxyVolume>(L, 13)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 12, out _lightProbeUsage);
                    UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)translator.GetObject(L, 13, typeof(UnityEngine.LightProbeProxyVolume));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage, _lightProbeProxyVolume );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 13&& translator.Assignable<UnityEngine.Mesh>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& translator.Assignable<UnityEngine.Bounds>(L, 4)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& translator.Assignable<UnityEngine.Camera>(L, 11)&& translator.Assignable<UnityEngine.Rendering.LightProbeUsage>(L, 12)&& translator.Assignable<UnityEngine.LightProbeProxyVolume>(L, 13)) 
                {
                    UnityEngine.Mesh _mesh = (UnityEngine.Mesh)translator.GetObject(L, 1, typeof(UnityEngine.Mesh));
                    int _submeshIndex = LuaAPI.xlua_tointeger(L, 2);
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 4, out _bounds);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 5, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 11, typeof(UnityEngine.Camera));
                    UnityEngine.Rendering.LightProbeUsage _lightProbeUsage;translator.Get(L, 12, out _lightProbeUsage);
                    UnityEngine.LightProbeProxyVolume _lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)translator.GetObject(L, 13, typeof(UnityEngine.LightProbeProxyVolume));
                    
                    UnityEngine.Graphics.DrawMeshInstancedIndirect( _mesh, _submeshIndex, _material, _bounds, _bufferWithArgs, _argsOffset, _properties, _castShadows, _receiveShadows, _layer, _camera, _lightProbeUsage, _lightProbeProxyVolume );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawMeshInstancedIndirect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProceduralNow_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 2);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawProceduralNow( _topology, _vertexCount, _instanceCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 2);
                    
                    UnityEngine.Graphics.DrawProceduralNow( _topology, _vertexCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 3);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawProceduralNow( _topology, _indexBuffer, _indexCount, _instanceCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawProceduralNow( _topology, _indexBuffer, _indexCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawProceduralNow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProceduralIndirectNow_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _indexBuffer, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 3)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 3, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _indexBuffer, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _indexBuffer, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.MeshTopology>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 3)) 
                {
                    UnityEngine.MeshTopology _topology;translator.Get(L, 1, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.GraphicsBuffer _bufferWithArgs = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 3, typeof(UnityEngine.GraphicsBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirectNow( _topology, _indexBuffer, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawProceduralIndirectNow!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProcedural_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount, _instanceCount, _camera, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount, _instanceCount, _camera, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount, _instanceCount, _camera, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount, _instanceCount, _camera, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount, _instanceCount, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount, _instanceCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    int _vertexCount = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _vertexCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    int _layer = LuaAPI.xlua_tointeger(L, 11);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount, _instanceCount, _camera, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount, _instanceCount, _camera, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount, _instanceCount, _camera, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount, _instanceCount, _camera, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount, _instanceCount, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    int _instanceCount = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount, _instanceCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    int _indexCount = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawProcedural( _material, _bounds, _topology, _indexBuffer, _indexCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawProcedural!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DrawProceduralIndirect_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    int _layer = LuaAPI.xlua_tointeger(L, 10);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs, _argsOffset, _camera, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 9)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 9);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs, _argsOffset, _camera, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 8)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 8, out _castShadows);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs, _argsOffset, _camera, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 7)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 7, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs, _argsOffset, _camera, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Camera>(L, 6)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 5);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 6, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs, _argsOffset, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 4)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 4, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 11&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    int _layer = LuaAPI.xlua_tointeger(L, 11);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs, _argsOffset, _camera, _properties, _castShadows, _receiveShadows, _layer );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 10)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    bool _receiveShadows = LuaAPI.lua_toboolean(L, 10);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs, _argsOffset, _camera, _properties, _castShadows, _receiveShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)&& translator.Assignable<UnityEngine.Rendering.ShadowCastingMode>(L, 9)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    UnityEngine.Rendering.ShadowCastingMode _castShadows;translator.Get(L, 9, out _castShadows);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs, _argsOffset, _camera, _properties, _castShadows );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)&& translator.Assignable<UnityEngine.MaterialPropertyBlock>(L, 8)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    UnityEngine.MaterialPropertyBlock _properties = (UnityEngine.MaterialPropertyBlock)translator.GetObject(L, 8, typeof(UnityEngine.MaterialPropertyBlock));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs, _argsOffset, _camera, _properties );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<UnityEngine.Camera>(L, 7)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    UnityEngine.Camera _camera = (UnityEngine.Camera)translator.GetObject(L, 7, typeof(UnityEngine.Camera));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs, _argsOffset, _camera );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    int _argsOffset = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs, _argsOffset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Material>(L, 1)&& translator.Assignable<UnityEngine.Bounds>(L, 2)&& translator.Assignable<UnityEngine.MeshTopology>(L, 3)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 4)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 5)) 
                {
                    UnityEngine.Material _material = (UnityEngine.Material)translator.GetObject(L, 1, typeof(UnityEngine.Material));
                    UnityEngine.Bounds _bounds;translator.Get(L, 2, out _bounds);
                    UnityEngine.MeshTopology _topology;translator.Get(L, 3, out _topology);
                    UnityEngine.GraphicsBuffer _indexBuffer = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 4, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _bufferWithArgs = (UnityEngine.ComputeBuffer)translator.GetObject(L, 5, typeof(UnityEngine.ComputeBuffer));
                    
                    UnityEngine.Graphics.DrawProceduralIndirect( _material, _bounds, _topology, _indexBuffer, _bufferWithArgs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.DrawProceduralIndirect!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Blit_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    
                    UnityEngine.Graphics.Blit( _source, _dest );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Material>(L, 2)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.Blit( _source, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Material>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.Graphics.Blit( _source, _mat, _pass );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    int _sourceDepthSlice = LuaAPI.xlua_tointeger(L, 3);
                    int _destDepthSlice = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.Blit( _source, _dest, _sourceDepthSlice, _destDepthSlice );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.Material>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 3);
                    int _destDepthSlice = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.Blit( _source, _mat, _pass, _destDepthSlice );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    
                    UnityEngine.Graphics.Blit( _source, _dest, _mat );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 4);
                    
                    UnityEngine.Graphics.Blit( _source, _dest, _mat, _pass );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _pass = LuaAPI.xlua_tointeger(L, 4);
                    int _destDepthSlice = LuaAPI.xlua_tointeger(L, 5);
                    
                    UnityEngine.Graphics.Blit( _source, _dest, _mat, _pass, _destDepthSlice );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Vector2 _scale;translator.Get(L, 3, out _scale);
                    UnityEngine.Vector2 _offset;translator.Get(L, 4, out _offset);
                    
                    UnityEngine.Graphics.Blit( _source, _dest, _scale, _offset );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Vector2>(L, 3)&& translator.Assignable<UnityEngine.Vector2>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Vector2 _scale;translator.Get(L, 3, out _scale);
                    UnityEngine.Vector2 _offset;translator.Get(L, 4, out _offset);
                    int _sourceDepthSlice = LuaAPI.xlua_tointeger(L, 5);
                    int _destDepthSlice = LuaAPI.xlua_tointeger(L, 6);
                    
                    UnityEngine.Graphics.Blit( _source, _dest, _scale, _offset, _sourceDepthSlice, _destDepthSlice );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.Blit!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BlitMultiTap_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count >= 3&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 4) || translator.Assignable<UnityEngine.Vector2>(L, 4))) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    UnityEngine.Vector2[] _offsets = translator.GetParams<UnityEngine.Vector2>(L, 4);
                    
                    UnityEngine.Graphics.BlitMultiTap( _source, _dest, _mat, _offsets );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count >= 4&& translator.Assignable<UnityEngine.Texture>(L, 1)&& translator.Assignable<UnityEngine.RenderTexture>(L, 2)&& translator.Assignable<UnityEngine.Material>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 5) || translator.Assignable<UnityEngine.Vector2>(L, 5))) 
                {
                    UnityEngine.Texture _source = (UnityEngine.Texture)translator.GetObject(L, 1, typeof(UnityEngine.Texture));
                    UnityEngine.RenderTexture _dest = (UnityEngine.RenderTexture)translator.GetObject(L, 2, typeof(UnityEngine.RenderTexture));
                    UnityEngine.Material _mat = (UnityEngine.Material)translator.GetObject(L, 3, typeof(UnityEngine.Material));
                    int _destDepthSlice = LuaAPI.xlua_tointeger(L, 4);
                    UnityEngine.Vector2[] _offsets = translator.GetParams<UnityEngine.Vector2>(L, 5);
                    
                    UnityEngine.Graphics.BlitMultiTap( _source, _dest, _mat, _destDepthSlice, _offsets );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Graphics.BlitMultiTap!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeColorGamut(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeColorGamut);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeTier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeTier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_preserveFramebufferAlpha(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Graphics.preserveFramebufferAlpha);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_minOpenGLESVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.minOpenGLESVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeColorBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeColorBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeDepthBuffer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Graphics.activeDepthBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_activeTier(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Rendering.GraphicsTier gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Graphics.activeTier = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
