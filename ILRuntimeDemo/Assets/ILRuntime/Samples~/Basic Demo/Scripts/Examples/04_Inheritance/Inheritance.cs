using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntimeDemo;

public abstract class TestClassBase
{
    public virtual int Value
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }

    public virtual void TestVirtual(string str)
    {
        Debug.Log("!! TestClassBase.TestVirtual, str = " + str);
    }

    public abstract void TestAbstract(int gg);
}
public class Inheritance : MonoBehaviour
{
    //AppDomain是ILRuntime的入口，最好是在一个单例类中保存，整个游戏全局就一个，这里为了示例方便，每个例子里面都单独做了一个
    //大家在正式项目中请全局只创建一个AppDomain
    AppDomain appdomain;
    System.IO.MemoryStream fs;
    System.IO.MemoryStream p;

    void Start()
    {
        StartCoroutine(LoadHotFixAssembly());
    }

    IEnumerator LoadHotFixAssembly()
    {
        //首先实例化ILRuntime的AppDomain，AppDomain是一个应用程序域，每个AppDomain都是一个独立的沙盒
        appdomain = new ILRuntime.Runtime.Enviorment.AppDomain();
        //正常项目中应该是自行从其他地方下载dll，或者打包在AssetBundle中读取，平时开发以及为了演示方便直接从StreammingAssets中读取，
        //正式发布的时候需要大家自行从其他地方读取dll

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //这个DLL文件是直接编译HotFix_Project.sln生成的，已经在项目中设置好输出目录为StreamingAssets，在VS里直接编译即可生成到对应目录，无需手动拷贝
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
        appdomain.LoadAssembly(fs, p, new ILRuntime.Mono.Cecil.Pdb.PdbReaderProvider());


        InitializeILRuntime();
        OnHotFixLoaded();
    }

    void InitializeILRuntime()
    {
#if DEBUG && (UNITY_EDITOR || UNITY_ANDROID || UNITY_IPHONE)
        //由于Unity的Profiler接口只允许在主线程使用，为了避免出异常，需要告诉ILRuntime主线程的线程ID才能正确将函数运行耗时报告给Profiler
        appdomain.UnityMainThreadID = System.Threading.Thread.CurrentThread.ManagedThreadId;
#endif
        //这里做一些ILRuntime的注册，这里应该写继承适配器的注册，为了演示方便，这个例子写在OnHotFixLoaded了
    }

    void OnHotFixLoaded()
    {
        Debug.Log("首先我们来创建热更里的类实例");
        TestClassBase obj;
        Debug.Log("现在我们来注册适配器, 该适配器由ILRuntime/Generate Cross Binding Adapter菜单命令自动生成");
        appdomain.RegisterCrossBindingAdaptor(new TestClassBaseAdapter());
        Debug.Log("现在再来尝试创建一个实例");
        obj = appdomain.Instantiate<TestClassBase>("HotFix_Project.TestInheritance");
        Debug.Log("现在来调用成员方法");
        obj.TestAbstract(123);
        obj.TestVirtual("Hello");
        obj.Value = 233;
        Debug.LogFormat("obj.Value={0}", obj.Value);


        Debug.Log("现在换个方式创建实例");
        obj = appdomain.Invoke("HotFix_Project.TestInheritance", "NewObject", null, null) as TestClassBase;
        obj.TestAbstract(456);
        obj.TestVirtual("Foobar");
        obj.Value = 2333333;
        Debug.LogFormat("obj.Value={0}", obj.Value);
    }

    void Update()
    {

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
}
