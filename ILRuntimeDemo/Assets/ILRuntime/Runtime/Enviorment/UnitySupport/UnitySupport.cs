using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Utils;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using UnityEngine;
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = ILRuntime.Other.UncheckedList<object>;
#endif
namespace ILRuntime.Runtime.Enviorment
{
    public class UnitySupport
    {
#if DEBUG && !DISABLE_ILRUNTIME_DEBUG
        static string projectName;
        [RuntimeInitializeOnLoadMethod]
        public static void InitializeDebugger()
        {

#if UNITY_EDITOR
            var path = Application.dataPath;
            projectName = Path.GetFileName(Path.GetDirectoryName(path));
#else
            projectName = Application.productName;
#endif
            ILRuntime.Runtime.Debugger.DebuggerServer.GetProjectNameFunction = () => projectName;
        }
#endif
    }
}
