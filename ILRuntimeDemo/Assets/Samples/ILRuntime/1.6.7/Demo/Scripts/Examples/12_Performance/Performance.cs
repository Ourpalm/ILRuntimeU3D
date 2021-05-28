using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

using UnityEngine.UI;
using ILRuntime.Runtime;
using ILRuntime.Runtime.Enviorment;
using XLua;
//下面这行为了取消使用WWW的警告，Unity2018以后推荐使用UnityWebRequest，处于兼容性考虑Demo依然使用WWW
#pragma warning disable CS0618
[LuaCallCSharp]

public class Performance : MonoBehaviour
{
    public Button btnLoadStack;
    public Button btnLoadRegister;
    public Button btnUnload;
    public CanvasGroup panelTest;
    public RectTransform panelButton;
    public Text lbResult;
    //AppDomain是ILRuntime的入口，最好是在一个单例类中保存，整个游戏全局就一个，这里为了示例方便，每个例子里面都单独做了一个
    //大家在正式项目中请全局只创建一个AppDomain
    AppDomain appdomain;

    System.IO.MemoryStream fs;
    System.IO.MemoryStream p;
    LuaEnv luaenv = null;

    List<string> tests = new List<string>();

    [XLua.CSharpCallLua]
    public delegate void LuaCallPerfCase(StringBuilder sb);
    private void Awake()
    {
        tests.Add("TestMandelbrot");
        tests.Add("Test0");
        tests.Add("Test1");
        tests.Add("Test2");
        tests.Add("Test3");
        tests.Add("Test4");
        tests.Add("Test5");
        tests.Add("Test6");
        tests.Add("Test7");
        tests.Add("Test8");
        tests.Add("Test9");
        tests.Add("Test10");
        tests.Add("Test11");
        var go = panelButton.GetChild(0).gameObject;
        go.SetActive(false);

        foreach(var i in tests)
        {
            var child = Instantiate(go);
            child.transform.SetParent(panelButton);            
            CreateTestButton(i, child);
            child.SetActive(true);
        }
    }

    void CreateTestButton(string testName, GameObject go)
    {
        Button btn = go.GetComponent<Button>();
        Text txt = go.GetComponentInChildren<Text>();
        txt.text = testName;
        btn.onClick.AddListener(() =>
        {
            StringBuilder sb = new StringBuilder();
            if (luaenv != null)
            {
                var perf = luaenv.Global.GetInPath<LuaCallPerfCase>(testName);
                perf(sb);
            }
            else
                appdomain.Invoke("HotFix_Project.TestPerformance", testName, null, sb);
            lbResult.text = sb.ToString();
        });
    }
    public void LoadHotFixAssemblyStack()
    {
        //首先实例化ILRuntime的AppDomain，AppDomain是一个应用程序域，每个AppDomain都是一个独立的沙盒
        appdomain = new ILRuntime.Runtime.Enviorment.AppDomain();
        StartCoroutine(LoadHotFixAssembly());

    }

    public void LoadHotFixAssemblyRegister()
    {
        //首先实例化ILRuntime的AppDomain，AppDomain是一个应用程序域，每个AppDomain都是一个独立的沙盒
        //ILRuntimeJITFlags.JITImmediately表示默认使用寄存器VM执行所有方法
        appdomain = new ILRuntime.Runtime.Enviorment.AppDomain(ILRuntimeJITFlags.JITImmediately);
        StartCoroutine(LoadHotFixAssembly());
    }

    public void LoadLua()
    {
        string luaStr = @"require 'performance'";
        luaenv = new LuaEnv();
        luaenv.DoString(luaStr);
        OnHotFixLoaded();
    }

    IEnumerator LoadHotFixAssembly()
    {
        btnLoadRegister.interactable = false;
        btnLoadStack.interactable = false;
        //正常项目中应该是自行从其他地方下载dll，或者打包在AssetBundle中读取，平时开发以及为了演示方便直接从StreammingAssets中读取，
        //正式发布的时候需要大家自行从其他地方读取dll

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //这个DLL文件是直接编译HotFix_Project.sln生成的，已经在项目中设置好输出目录为StreamingAssets，在VS里直接编译即可生成到对应目录，无需手动拷贝
        //工程目录在Assets\Samples\ILRuntime\1.6\Demo\HotFix_Project~
        //以下加载写法只为演示，并没有处理在编辑器切换到Android平台的读取，需要自行修改
#if UNITY_ANDROID
        WWW www = new WWW(Application.streamingAssetsPath + "/HotFix_Project.dll");
#else
        WWW www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFix_Project.dll");
#endif
        while (!www.isDone)
            yield return null;
        if (!string.IsNullOrEmpty(www.error))
            UnityEngine.Debug.LogError(www.error);
        byte[] dll = www.bytes;
        www.Dispose();

        //PDB文件是调试数据库，如需要在日志中显示报错的行号，则必须提供PDB文件，不过由于会额外耗用内存，正式发布时请将PDB去掉，下面LoadAssembly的时候pdb传null即可
#if UNITY_ANDROID
        www = new WWW(Application.streamingAssetsPath + "/HotFix_Project.pdb");
#else
        www = new WWW("file:///" + Application.streamingAssetsPath + "/HotFix_Project.pdb");
#endif
        while (!www.isDone)
            yield return null;
        if (!string.IsNullOrEmpty(www.error))
            UnityEngine.Debug.LogError(www.error);
        byte[] pdb = www.bytes;
        fs = new MemoryStream(dll);
        p = new MemoryStream(pdb);
        try
        {
            appdomain.LoadAssembly(fs, p, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());
        }
        catch
        {
            Debug.LogError("加载热更DLL失败，请确保已经通过VS打开Assets/Samples/ILRuntime/1.6/Demo/HotFix_Project/HotFix_Project.sln编译过热更DLL");
        }

        InitializeILRuntime();
        OnHotFixLoaded();
    }

    void InitializeILRuntime()
    {
#if DEBUG && (UNITY_EDITOR || UNITY_ANDROID || UNITY_IPHONE)
        //由于Unity的Profiler接口只允许在主线程使用，为了避免出异常，需要告诉ILRuntime主线程的线程ID才能正确将函数运行耗时报告给Profiler
        appdomain.UnityMainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;
#endif  
        ILRuntime.Runtime.CLRBinding.CLRBindingUtils.Initialize(appdomain);
    }

    void OnHotFixLoaded()
    {
        btnUnload.interactable = true;
        panelTest.interactable = true;

    }

    public void Unload()
    {
        if (fs != null)
            fs.Close();
        if (p != null)
            p.Close();
        fs = null;
        p = null;
        appdomain = null;
        if (luaenv != null)
            luaenv.Dispose();
        luaenv = null;
        btnUnload.interactable = false;
        btnLoadRegister.interactable = true;
        btnLoadStack.interactable = true;
        panelTest.interactable = false;
    }

    private void OnDestroy()
    {
        if (fs != null)
            fs.Close();
        if (p != null)
            p.Close();
        fs = null;
        p = null;
    }

    void Update()
    {

    }

    public static bool MandelbrotCheck(float workX, float workY)
    {
        return ((workX * workX) + (workY * workY)) < 4.0f;
    }

    public static void TestFunc1(int a, string b, Vector3 c, Transform d)
    {
        
    }
}
