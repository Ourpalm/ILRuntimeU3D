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
    public class UnityEngineSystemInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.SystemInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 82, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsRenderTextureFormat", _m_SupportsRenderTextureFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsBlendingOnRenderTextureFormat", _m_SupportsBlendingOnRenderTextureFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsRandomWriteOnRenderTextureFormat", _m_SupportsRandomWriteOnRenderTextureFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsTextureFormat", _m_SupportsTextureFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SupportsVertexAttributeFormat", _m_SupportsVertexAttributeFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsFormatSupported", _m_IsFormatSupported_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCompatibleFormat", _m_GetCompatibleFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGraphicsFormat", _m_GetGraphicsFormat_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetRenderTextureSupportedMSAASampleCount", _m_GetRenderTextureSupportedMSAASampleCount_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "unsupportedIdentifier", UnityEngine.SystemInfo.unsupportedIdentifier);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "batteryLevel", _g_get_batteryLevel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "batteryStatus", _g_get_batteryStatus);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "operatingSystem", _g_get_operatingSystem);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "operatingSystemFamily", _g_get_operatingSystemFamily);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "processorType", _g_get_processorType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "processorFrequency", _g_get_processorFrequency);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "processorCount", _g_get_processorCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "systemMemorySize", _g_get_systemMemorySize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceUniqueIdentifier", _g_get_deviceUniqueIdentifier);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceName", _g_get_deviceName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceModel", _g_get_deviceModel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsAccelerometer", _g_get_supportsAccelerometer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsGyroscope", _g_get_supportsGyroscope);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsLocationService", _g_get_supportsLocationService);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsVibration", _g_get_supportsVibration);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsAudio", _g_get_supportsAudio);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deviceType", _g_get_deviceType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsMemorySize", _g_get_graphicsMemorySize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceName", _g_get_graphicsDeviceName);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceVendor", _g_get_graphicsDeviceVendor);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceID", _g_get_graphicsDeviceID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceVendorID", _g_get_graphicsDeviceVendorID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceType", _g_get_graphicsDeviceType);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsUVStartsAtTop", _g_get_graphicsUVStartsAtTop);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsDeviceVersion", _g_get_graphicsDeviceVersion);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsShaderLevel", _g_get_graphicsShaderLevel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "graphicsMultiThreaded", _g_get_graphicsMultiThreaded);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "renderingThreadingMode", _g_get_renderingThreadingMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hasHiddenSurfaceRemovalOnGPU", _g_get_hasHiddenSurfaceRemovalOnGPU);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hasDynamicUniformArrayIndexingInFragmentShaders", _g_get_hasDynamicUniformArrayIndexingInFragmentShaders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsShadows", _g_get_supportsShadows);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsRawShadowDepthSampling", _g_get_supportsRawShadowDepthSampling);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMotionVectors", _g_get_supportsMotionVectors);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports3DTextures", _g_get_supports3DTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsCompressed3DTextures", _g_get_supportsCompressed3DTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports2DArrayTextures", _g_get_supports2DArrayTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports3DRenderTextures", _g_get_supports3DRenderTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsCubemapArrayTextures", _g_get_supportsCubemapArrayTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "copyTextureSupport", _g_get_copyTextureSupport);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsComputeShaders", _g_get_supportsComputeShaders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsGeometryShaders", _g_get_supportsGeometryShaders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsTessellationShaders", _g_get_supportsTessellationShaders);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsRenderTargetArrayIndexFromVertexShader", _g_get_supportsRenderTargetArrayIndexFromVertexShader);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsInstancing", _g_get_supportsInstancing);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsHardwareQuadTopology", _g_get_supportsHardwareQuadTopology);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supports32bitsIndexBuffer", _g_get_supports32bitsIndexBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsSparseTextures", _g_get_supportsSparseTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportedRenderTargetCount", _g_get_supportedRenderTargetCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsSeparatedRenderTargetsBlend", _g_get_supportsSeparatedRenderTargetsBlend);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportedRandomWriteTargetCount", _g_get_supportedRandomWriteTargetCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMultisampledTextures", _g_get_supportsMultisampledTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMultisampled2DArrayTextures", _g_get_supportsMultisampled2DArrayTextures);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMultisampleAutoResolve", _g_get_supportsMultisampleAutoResolve);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsTextureWrapMirrorOnce", _g_get_supportsTextureWrapMirrorOnce);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "usesReversedZBuffer", _g_get_usesReversedZBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "npotSupport", _g_get_npotSupport);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxTextureSize", _g_get_maxTextureSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxCubemapSize", _g_get_maxCubemapSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeBufferInputsVertex", _g_get_maxComputeBufferInputsVertex);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeBufferInputsFragment", _g_get_maxComputeBufferInputsFragment);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeBufferInputsGeometry", _g_get_maxComputeBufferInputsGeometry);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeBufferInputsDomain", _g_get_maxComputeBufferInputsDomain);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeBufferInputsHull", _g_get_maxComputeBufferInputsHull);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeBufferInputsCompute", _g_get_maxComputeBufferInputsCompute);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeWorkGroupSize", _g_get_maxComputeWorkGroupSize);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeWorkGroupSizeX", _g_get_maxComputeWorkGroupSizeX);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeWorkGroupSizeY", _g_get_maxComputeWorkGroupSizeY);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maxComputeWorkGroupSizeZ", _g_get_maxComputeWorkGroupSizeZ);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsAsyncCompute", _g_get_supportsAsyncCompute);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsGpuRecorder", _g_get_supportsGpuRecorder);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsGraphicsFence", _g_get_supportsGraphicsFence);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsAsyncGPUReadback", _g_get_supportsAsyncGPUReadback);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsRayTracing", _g_get_supportsRayTracing);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsSetConstantBuffer", _g_get_supportsSetConstantBuffer);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "constantBufferOffsetAlignment", _g_get_constantBufferOffsetAlignment);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hasMipMaxLevel", _g_get_hasMipMaxLevel);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMipStreaming", _g_get_supportsMipStreaming);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "usesLoadStoreActions", _g_get_usesLoadStoreActions);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "hdrDisplaySupportFlags", _g_get_hdrDisplaySupportFlags);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsConservativeRaster", _g_get_supportsConservativeRaster);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsMultiview", _g_get_supportsMultiview);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "supportsStoreAndResolveAction", _g_get_supportsStoreAndResolveAction);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.SystemInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SystemInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsRenderTextureFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTextureFormat _format;translator.Get(L, 1, out _format);
                    
                        var gen_ret = UnityEngine.SystemInfo.SupportsRenderTextureFormat( _format );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsBlendingOnRenderTextureFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTextureFormat _format;translator.Get(L, 1, out _format);
                    
                        var gen_ret = UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat( _format );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsRandomWriteOnRenderTextureFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTextureFormat _format;translator.Get(L, 1, out _format);
                    
                        var gen_ret = UnityEngine.SystemInfo.SupportsRandomWriteOnRenderTextureFormat( _format );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsTextureFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.TextureFormat _format;translator.Get(L, 1, out _format);
                    
                        var gen_ret = UnityEngine.SystemInfo.SupportsTextureFormat( _format );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SupportsVertexAttributeFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Rendering.VertexAttributeFormat _format;translator.Get(L, 1, out _format);
                    int _dimension = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = UnityEngine.SystemInfo.SupportsVertexAttributeFormat( _format, _dimension );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsFormatSupported_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 1, out _format);
                    UnityEngine.Experimental.Rendering.FormatUsage _usage;translator.Get(L, 2, out _usage);
                    
                        var gen_ret = UnityEngine.SystemInfo.IsFormatSupported( _format, _usage );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCompatibleFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 1, out _format);
                    UnityEngine.Experimental.Rendering.FormatUsage _usage;translator.Get(L, 2, out _usage);
                    
                        var gen_ret = UnityEngine.SystemInfo.GetCompatibleFormat( _format, _usage );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGraphicsFormat_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 1, out _format);
                    
                        var gen_ret = UnityEngine.SystemInfo.GetGraphicsFormat( _format );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetRenderTextureSupportedMSAASampleCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.RenderTextureDescriptor _desc;translator.Get(L, 1, out _desc);
                    
                        var gen_ret = UnityEngine.SystemInfo.GetRenderTextureSupportedMSAASampleCount( _desc );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_batteryLevel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, UnityEngine.SystemInfo.batteryLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_batteryStatus(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.batteryStatus);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_operatingSystem(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.operatingSystem);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_operatingSystemFamily(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.operatingSystemFamily);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processorType(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.processorType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processorFrequency(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.processorFrequency);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_processorCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.processorCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_systemMemorySize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.systemMemorySize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceUniqueIdentifier(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.deviceUniqueIdentifier);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.deviceName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceModel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.deviceModel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsAccelerometer(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsAccelerometer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsGyroscope(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsGyroscope);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsLocationService(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsLocationService);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsVibration(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsVibration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsAudio(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsAudio);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_deviceType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.deviceType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsMemorySize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsMemorySize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceName(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.graphicsDeviceName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceVendor(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.graphicsDeviceVendor);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsDeviceID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceVendorID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsDeviceVendorID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceType(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.graphicsDeviceType);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsUVStartsAtTop(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.graphicsUVStartsAtTop);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsDeviceVersion(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, UnityEngine.SystemInfo.graphicsDeviceVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsShaderLevel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.graphicsShaderLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_graphicsMultiThreaded(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.graphicsMultiThreaded);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_renderingThreadingMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.renderingThreadingMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasHiddenSurfaceRemovalOnGPU(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.hasHiddenSurfaceRemovalOnGPU);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasDynamicUniformArrayIndexingInFragmentShaders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsShadows(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsShadows);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsRawShadowDepthSampling(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsRawShadowDepthSampling);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMotionVectors(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsMotionVectors);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports3DTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports3DTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsCompressed3DTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsCompressed3DTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports2DArrayTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports2DArrayTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports3DRenderTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports3DRenderTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsCubemapArrayTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsCubemapArrayTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_copyTextureSupport(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.copyTextureSupport);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsComputeShaders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsComputeShaders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsGeometryShaders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsGeometryShaders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsTessellationShaders(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsTessellationShaders);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsRenderTargetArrayIndexFromVertexShader(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsRenderTargetArrayIndexFromVertexShader);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsInstancing(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsInstancing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsHardwareQuadTopology(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsHardwareQuadTopology);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supports32bitsIndexBuffer(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supports32bitsIndexBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsSparseTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsSparseTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportedRenderTargetCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.supportedRenderTargetCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsSeparatedRenderTargetsBlend(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsSeparatedRenderTargetsBlend);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportedRandomWriteTargetCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.supportedRandomWriteTargetCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMultisampledTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.supportsMultisampledTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMultisampled2DArrayTextures(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsMultisampled2DArrayTextures);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMultisampleAutoResolve(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsMultisampleAutoResolve);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsTextureWrapMirrorOnce(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usesReversedZBuffer(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.usesReversedZBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_npotSupport(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.npotSupport);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxTextureSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxTextureSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxCubemapSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxCubemapSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeBufferInputsVertex(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeBufferInputsVertex);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeBufferInputsFragment(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeBufferInputsFragment);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeBufferInputsGeometry(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeBufferInputsGeometry);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeBufferInputsDomain(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeBufferInputsDomain);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeBufferInputsHull(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeBufferInputsHull);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeBufferInputsCompute(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeBufferInputsCompute);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeWorkGroupSize(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeWorkGroupSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeWorkGroupSizeX(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeWorkGroupSizeX);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeWorkGroupSizeY(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeWorkGroupSizeY);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_maxComputeWorkGroupSizeZ(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.maxComputeWorkGroupSizeZ);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsAsyncCompute(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsAsyncCompute);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsGpuRecorder(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsGpuRecorder);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsGraphicsFence(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsGraphicsFence);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsAsyncGPUReadback(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsAsyncGPUReadback);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsRayTracing(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsRayTracing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsSetConstantBuffer(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsSetConstantBuffer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_constantBufferOffsetAlignment(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.SystemInfo.constantBufferOffsetAlignment);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hasMipMaxLevel(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.hasMipMaxLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMipStreaming(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsMipStreaming);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usesLoadStoreActions(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.usesLoadStoreActions);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_hdrDisplaySupportFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.SystemInfo.hdrDisplaySupportFlags);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsConservativeRaster(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsConservativeRaster);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsMultiview(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsMultiview);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_supportsStoreAndResolveAction(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.SystemInfo.supportsStoreAndResolveAction);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
