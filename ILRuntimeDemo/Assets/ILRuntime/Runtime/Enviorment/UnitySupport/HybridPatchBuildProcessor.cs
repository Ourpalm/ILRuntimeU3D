using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using ILRuntime.Hybrid;
using ILRuntime.Mono.Cecil;
using System.Threading;


#if UNITY_EDITOR && UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace ILRuntime.Runtime.Enviorment
{
    public enum HybridPatchProcessModes
    {
        Injection,
        GeneratePatch,
    }
    public interface IHybridPatchInjectionSettings
    {
        HybridPatchProcessModes GenerationMode { get; }
        bool ShouldInjectAssembly(string assemblyName);
        IPatchSettings GetPatchSetting();

        string GetHashInfoSavePath();

        string GetPatchSavePath();
    }
    public class HybridPatchBuildProcessor : IPostBuildPlayerScriptDLLs
    {
        //Make sure it's got called at last
        public int callbackOrder => int.MinValue;

        IHybridPatchInjectionSettings LoadSetting()
        {
            var types = System.AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly =>
            {
                try
                {
                    return assembly.GetTypes();
                }
                catch (System.Reflection.ReflectionTypeLoadException e)
                {
                    // 有些动态程序集或Unity内部程序集可能无法加载类型，跳过它们
                    Debug.LogWarning($"HybridPatchBuildProcessor: Could not load types from assembly {assembly.FullName}: {e.Message}");
                    return Type.EmptyTypes;
                }
            })
            .Where(type => typeof(IHybridPatchInjectionSettings).IsAssignableFrom(type) &&
                           !type.IsInterface &&
                           !type.IsAbstract);

            foreach (Type type in types)
            {
                try
                {
                    if (type.GetConstructor(Type.EmptyTypes) != null) // 确保有无参构造函数
                    {
                        IHybridPatchInjectionSettings setting = Activator.CreateInstance(type) as IHybridPatchInjectionSettings;
                        if (setting != null)
                        {
                            return setting;
                        }
                    }
                    else
                    {
                        Debug.LogWarning($"HybridPatchBuildProcessor: Type '{type.FullName}' implements IHybridPatchSettings but does not have a parameterless constructor. Skipping.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.LogError($"HybridPatchBuildProcessor: Failed to instantiate IHybridPatchSettings type '{type.FullName}': {ex.Message}");
                }
            }
            return null;
        }

        public void OnPostBuildPlayerScriptDLLs(BuildReport report)
        {
            if (report == null || report.summary.result == BuildResult.Failed || report.summary.result == BuildResult.Cancelled)
            {
                return;
            }

            Debug.Log("HybridPatchBuildProcessor: Attempting to modify assemblies...");

            IHybridPatchInjectionSettings foundSetting = LoadSetting();

            if (foundSetting != null)
            {
                List<KeyValuePair<string, string>> assembliesToModify = new List<KeyValuePair<string, string>>();
                if (report.GetFiles() != null)
                {
#if UNITY_2022_1_OR_NEWER
                    foreach (var file in report.GetFiles()) // BuildFile 类型
#else
                    foreach (var file in report.files) // BuildFile 类型
#endif
                    {
                        // 在 IPostBuildPlayerScriptDLLs 上下文中，
                        // 我们关注的是角色为 "ManagedLibrary" 并且在我们的 IInjectionSettings 中被指定需要注入的程序集。
                        if (file.role == CommonRoles.managedLibrary)
                        {
                            string assemblyFileName = Path.GetFileName(file.path);
                            string assemblyFullPath = file.path;

                            if (foundSetting.ShouldInjectAssembly(assemblyFileName))
                            {
                                assembliesToModify.Add(new KeyValuePair<string, string>(assemblyFileName, assemblyFullPath));
                                Debug.Log($"[HybridPatchBuildProcessor] Identified '{assemblyFileName}' (Role: {file.role}) via report.files and settings for processing. Path: {assemblyFullPath}");
                            }
                        }
                    }
                }
                else
                {
                    Debug.LogWarning("[HybridPatchBuildProcessor] report.files is null. Cannot find any assemblies to process.");
                }

                if (assembliesToModify.Count == 0)
                {
                    Debug.Log("[HybridPatchBuildProcessor] No assemblies identified for modification based on current settings and report.files data.");
                }
                else
                {
                    Debug.Log($"[HybridPatchBuildProcessor] Found {assembliesToModify.Count} assemblies to modify.");
                }
                switch (foundSetting.GenerationMode)
                {
                    case HybridPatchProcessModes.GeneratePatch:
                        GeneratePatch(foundSetting, assembliesToModify);
                        break;
                    case HybridPatchProcessModes.Injection:
                        ModifyAssemblies(foundSetting, assembliesToModify);
                        break;
                }
            }
        }

        void GeneratePatch(IHybridPatchInjectionSettings setting, List<KeyValuePair<string, string>> assembliesToModify)
        {
            Debug.Log($"[HybridPatchBuildProcessor] Running Patch Generation.");
            string patchPath = setting.GetPatchSavePath();
            string patchFolder = Path.GetDirectoryName(patchPath);
            if (!Directory.Exists(patchFolder))
            {
                Directory.CreateDirectory(patchFolder);
            }

            if (File.Exists(setting.GetHashInfoSavePath()))
            {
                Dictionary<string, AssemblyHashInfo> hashInfos = new Dictionary<string, AssemblyHashInfo>();
                using (FileStream fs = File.OpenRead(setting.GetHashInfoSavePath()))
                {
                    BinaryReader br = new BinaryReader(fs);
                    if (br.ReadInt32() != HybridPatchManager.HASH_INFO_FILE_MAGIC)
                        throw new NotSupportedException("Wrong Magic");
                    if (br.ReadInt32() != HybridPatchManager.VERSION)
                        throw new NotSupportedException("Wrong Version");
                    int cnt = br.ReadInt32();
                    for (int i = 0; i < cnt; i++)
                    {
                        var hash = AssemblyHashInfo.FromStream(fs);
                        hashInfos[hash.Name.Substring(0, hash.Name.IndexOf(','))] = hash;
                    }
                }
                int count = 0;
                DefaultAssemblyResolver assemblyResolver = new DefaultAssemblyResolver();
                assemblyResolver.AddSearchDirectory(Path.Combine(EditorApplication.applicationContentsPath, "Managed", "UnityEngine"));
                HashSet<string> searchPaths = new HashSet<string>();
                var patchSetting = setting.GetPatchSetting();

                using (FileStream fs = File.Create(patchPath))
                {
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(HybridPatchManager.PATCH_FILE_MAGIC);
                    bw.Write(HybridPatchManager.VERSION);
                    long startPos = fs.Position;
                    bw.Write(0);//Place holder count;
                    foreach (var i in assembliesToModify)
                    {
                        var asmName = Path.GetFileNameWithoutExtension(i.Key);
                        if (hashInfos.TryGetValue(asmName, out var hashInfo))
                        {
                            string folder = Path.GetDirectoryName(i.Value);

                            if (!searchPaths.Contains(folder))
                            {
                                assemblyResolver.AddSearchDirectory(folder);
                                searchPaths.Add(folder);
                            }
                            using (FileStream dll = File.OpenRead(i.Value))
                            {
                                PatchGenerator patch = new PatchGenerator(hashInfo, dll, assemblyResolver, setting.GetPatchSetting());
                                patch.Analyze();
                                if (patch.HasPatch)
                                {
                                    count += patch.PatchInfo.Types.Length;
                                    patch.SavePatch(fs);
                                }
                            }
                        }
                    }
                    fs.Position = startPos;
                    bw.Write(count);
                }
                if (count == 0)
                {
                    //No Patch, delete the patch file
                    File.Delete(patchPath);
                }
                else
                {
                    Debug.Log($"[HybridPatchBuildProcessor] {count} types patched.");
                }
            }
            else
            {
                Debug.LogError($"[HybridPatchBuildProcessor] Assembly Hash Info File doesn't exist. Run Injection Mode first!(path:{setting.GetHashInfoSavePath()})");
            }
        }

        void ModifyAssemblies(IHybridPatchInjectionSettings setting, List<KeyValuePair<string, string>> assembliesToModify)
        {
            Debug.Log($"[HybridPatchBuildProcessor] Running Assembly Injection.");
            string hashPath = setting.GetHashInfoSavePath();
            string hashFolder = Path.GetDirectoryName(hashPath);
            if (!Directory.Exists(hashFolder))
            {
                Directory.CreateDirectory(hashFolder);
            }
            DefaultAssemblyResolver assemblyResolver = new DefaultAssemblyResolver();
            assemblyResolver.AddSearchDirectory(Path.Combine(EditorApplication.applicationContentsPath, "Managed", "UnityEngine")); 
            HashSet<string> searchPaths = new HashSet<string>(); 
            var patchSetting = setting.GetPatchSetting();

            using (FileStream fs = File.Create(hashPath))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(HybridPatchManager.HASH_INFO_FILE_MAGIC);
                bw.Write(HybridPatchManager.VERSION);
                bw.Write(assembliesToModify.Count);

                foreach(var i in assembliesToModify)
                {
                    string folder = Path.GetDirectoryName(i.Value);
                    string fn = Path.GetFileNameWithoutExtension(i.Value);
                    string pdbFileName = string.Format("{0}/{1}.pdb", folder, fn);
                    string saveFileName = string.Format("{0}/{1}_patched.dll", folder, fn);
                    string savePdbFileName = string.Format("{0}/{1}_patched.pdb", folder, fn);
                    if (!searchPaths.Contains(folder))
                    {
                        assemblyResolver.AddSearchDirectory(folder);
                        searchPaths.Add(folder);
                    }

                    bool hasSymbol = File.Exists(pdbFileName);
                    Stream asmStream;
                    Stream pdbStream = null;
                    AssemblyInjector injector;
                    using (asmStream = File.OpenRead(i.Value))
                    {
                        if (hasSymbol)
                            pdbStream = File.OpenRead(pdbFileName);
                        injector = AssemblyInjector.CreateInjector(asmStream, pdbStream, patchSetting, assemblyResolver);
                        injector.Inject();
                        pdbStream?.Close();
                        pdbStream = null;
                    }
                    assemblyResolver.Dispose();
                    using (asmStream = File.Create(saveFileName))
                    {
                        if (hasSymbol)
                            pdbStream = File.Create(savePdbFileName);
                        injector.WriteAssemblyToFile(asmStream, pdbStream);
                        injector.WritePatchInfoToFile(fs);
                        pdbStream?.Close();
                        pdbStream = null;
                    }

                    PerformFileOperationWithRetry(() =>
                    {
                        File.Copy(saveFileName, i.Value, true);
                    }, "Copy DLL:" + fn);
                    File.Delete(saveFileName);
                    if (hasSymbol)
                    {
                        PerformFileOperationWithRetry(() =>
                        {
                            File.Copy(savePdbFileName, pdbFileName, true);
                        }, "Copy PDB:" + fn);
                        File.Delete(savePdbFileName);
                    }
                }
            }

            AssetDatabase.Refresh();
        }

        private void PerformFileOperationWithRetry(Action operation, string operationDescription, int maxRetries = 5, int delayMilliseconds = 200)
        {
            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    operation();
                    return; // 操作成功
                }
                catch (IOException ex)
                {
                    // 检查是否是常见的共享冲突或文件占用错误
                    // HResult for "file being used by another process" is often -2147024864 (0x80070020 ERROR_SHARING_VIOLATION)
                    // HResult for "sharing violation" can also be similar.
                    // A simpler check is often on the message content if HResults are not consistent across environments.
                    bool isSharingViolation = ex.Message.ToLowerInvariant().Contains("sharing violation") ||
                                              ex.Message.ToLowerInvariant().Contains("being used by another process") ||
                                              (ex.HResult & 0xFFFF) == 0x20 || // ERROR_SHARING_VIOLATION
                                              (ex.HResult & 0xFFFF) == 0x21;   // ERROR_LOCK_VIOLATION

                    if (isSharingViolation)
                    {
                        if (i == maxRetries - 1)
                        {
                            Debug.LogError($"[HybridPatchBuildProcessor] File operation '{operationDescription}' failed after {maxRetries} retries. Last error: {ex.Message}");
                            throw; // 最后一次尝试失败，重新抛出异常
                        }
                        Debug.LogWarning($"[HybridPatchBuildProcessor] File operation '{operationDescription}' failed due to sharing violation (attempt {i + 1}/{maxRetries}). Retrying in {delayMilliseconds}ms... Error: {ex.Message}");
                        Thread.Sleep(delayMilliseconds);
                    }
                    else
                    {
                        throw; // 如果不是共享冲突，直接重新抛出
                    }
                }
            }
        }
    }

}
#endif