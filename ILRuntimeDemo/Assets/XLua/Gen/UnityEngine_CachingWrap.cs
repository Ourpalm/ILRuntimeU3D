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
    public class UnityEngineCachingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Caching);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 17, 5, 2);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearCache", _m_ClearCache_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearCachedVersion", _m_ClearCachedVersion_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearOtherCachedVersions", _m_ClearOtherCachedVersions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearAllCachedVersions", _m_ClearAllCachedVersions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCachedVersions", _m_GetCachedVersions_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "IsVersionCached", _m_IsVersionCached_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MarkAsUsed", _m_MarkAsUsed_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetNoBackupFlag", _m_SetNoBackupFlag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ResetNoBackupFlag", _m_ResetNoBackupFlag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddCache", _m_AddCache_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCacheAt", _m_GetCacheAt_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetCacheByPath", _m_GetCacheByPath_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetAllCachePaths", _m_GetAllCachePaths_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RemoveCache", _m_RemoveCache_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveCacheBefore", _m_MoveCacheBefore_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveCacheAfter", _m_MoveCacheAfter_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "compressionEnabled", _g_get_compressionEnabled);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ready", _g_get_ready);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "cacheCount", _g_get_cacheCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "defaultCache", _g_get_defaultCache);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "currentCacheForWriting", _g_get_currentCacheForWriting);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "compressionEnabled", _s_set_compressionEnabled);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "currentCacheForWriting", _s_set_currentCacheForWriting);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.Caching();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Caching constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearCache_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 0) 
                {
                    
                        var gen_ret = UnityEngine.Caching.ClearCache(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _expiration = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Caching.ClearCache( _expiration );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Caching.ClearCache!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearCachedVersion_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                        var gen_ret = UnityEngine.Caching.ClearCachedVersion( _assetBundleName, _hash );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearOtherCachedVersions_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                        var gen_ret = UnityEngine.Caching.ClearOtherCachedVersions( _assetBundleName, _hash );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearAllCachedVersions_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Caching.ClearAllCachedVersions( _assetBundleName );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCachedVersions_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _assetBundleName = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.Hash128> _outCachedVersions = (System.Collections.Generic.List<UnityEngine.Hash128>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Hash128>));
                    
                    UnityEngine.Caching.GetCachedVersions( _assetBundleName, _outCachedVersions );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsVersionCached_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.CachedAssetBundle>(L, 1)) 
                {
                    UnityEngine.CachedAssetBundle _cachedBundle;translator.Get(L, 1, out _cachedBundle);
                    
                        var gen_ret = UnityEngine.Caching.IsVersionCached( _cachedBundle );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Hash128>(L, 2)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                        var gen_ret = UnityEngine.Caching.IsVersionCached( _url, _hash );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Caching.IsVersionCached!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MarkAsUsed_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.CachedAssetBundle>(L, 1)) 
                {
                    UnityEngine.CachedAssetBundle _cachedBundle;translator.Get(L, 1, out _cachedBundle);
                    
                        var gen_ret = UnityEngine.Caching.MarkAsUsed( _cachedBundle );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Hash128>(L, 2)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                        var gen_ret = UnityEngine.Caching.MarkAsUsed( _url, _hash );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Caching.MarkAsUsed!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetNoBackupFlag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.CachedAssetBundle>(L, 1)) 
                {
                    UnityEngine.CachedAssetBundle _cachedBundle;translator.Get(L, 1, out _cachedBundle);
                    
                    UnityEngine.Caching.SetNoBackupFlag( _cachedBundle );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Hash128>(L, 2)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                    UnityEngine.Caching.SetNoBackupFlag( _url, _hash );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Caching.SetNoBackupFlag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ResetNoBackupFlag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.CachedAssetBundle>(L, 1)) 
                {
                    UnityEngine.CachedAssetBundle _cachedBundle;translator.Get(L, 1, out _cachedBundle);
                    
                    UnityEngine.Caching.ResetNoBackupFlag( _cachedBundle );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Hash128>(L, 2)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    UnityEngine.Hash128 _hash;translator.Get(L, 2, out _hash);
                    
                    UnityEngine.Caching.ResetNoBackupFlag( _url, _hash );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Caching.ResetNoBackupFlag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddCache_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _cachePath = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Caching.AddCache( _cachePath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCacheAt_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _cacheIndex = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.Caching.GetCacheAt( _cacheIndex );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetCacheByPath_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _cachePath = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.Caching.GetCacheByPath( _cachePath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetAllCachePaths_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    System.Collections.Generic.List<string> _cachePaths = (System.Collections.Generic.List<string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<string>));
                    
                    UnityEngine.Caching.GetAllCachePaths( _cachePaths );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveCache_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Cache _cache;translator.Get(L, 1, out _cache);
                    
                        var gen_ret = UnityEngine.Caching.RemoveCache( _cache );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveCacheBefore_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Cache _src;translator.Get(L, 1, out _src);
                    UnityEngine.Cache _dst;translator.Get(L, 2, out _dst);
                    
                    UnityEngine.Caching.MoveCacheBefore( _src, _dst );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_MoveCacheAfter_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Cache _src;translator.Get(L, 1, out _src);
                    UnityEngine.Cache _dst;translator.Get(L, 2, out _dst);
                    
                    UnityEngine.Caching.MoveCacheAfter( _src, _dst );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_compressionEnabled(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Caching.compressionEnabled);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ready(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, UnityEngine.Caching.ready);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_cacheCount(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Caching.cacheCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultCache(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Caching.defaultCache);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentCacheForWriting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, UnityEngine.Caching.currentCacheForWriting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_compressionEnabled(RealStatePtr L)
        {
		    try {
                
			    UnityEngine.Caching.compressionEnabled = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentCacheForWriting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			UnityEngine.Cache gen_value;translator.Get(L, 1, out gen_value);
				UnityEngine.Caching.currentCacheForWriting = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
