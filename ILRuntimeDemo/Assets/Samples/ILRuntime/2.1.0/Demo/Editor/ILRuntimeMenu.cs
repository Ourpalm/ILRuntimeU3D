#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System;
using System.Text;
using System.Collections.Generic;
[System.Reflection.Obfuscation(Exclude = true)]
public class ILRuntimeMenu
{
   [MenuItem("ILRuntime/安装VS调试插件")]
    static void InstallDebugger()
    {   
        EditorUtility.OpenWithDefaultApp("Assets/Samples/ILRuntime/2.0.2/Demo/Debugger~/ILRuntimeDebuggerLauncher.vsix");
    }

    [MenuItem("ILRuntime/打开ILRuntime中文文档")]
    static void OpenDocumentation()
    {
        Application.OpenURL("https://ourpalm.github.io/ILRuntime/");
    }

    [MenuItem("ILRuntime/打开ILRuntime Github项目")]
    static void OpenGithub()
    {
        Application.OpenURL("https://github.com/Ourpalm/ILRuntime");
    }

    [MenuItem("ILRuntime/打开ILRuntime视频教程")]
    static void OpenTutorial()
    {
        Application.OpenURL("https://learn.u3d.cn/tutorial/ilruntime");
    }
}
#endif
