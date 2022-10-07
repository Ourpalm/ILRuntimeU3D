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
        //EditorUtility.OpenWithDefaultApp("Assets/Samples/ILRuntime/2.0.2/Demo/Debugger~/ILRuntimeDebuggerLauncher.vsix");
        EditorUtility.DisplayDialog("提示", "新版本调试插件已提交至VS和VSCode商店，可直接在商店中搜索ILRuntime进行安装\n请注意，新版本调试插件只支持2.1.0版以上的ILRuntime", "确定");
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
