using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class DelegateDemo_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::DelegateDemo);

            field = type.GetField("TestMethodDelegate", flag);
            app.RegisterCLRFieldGetter(field, get_TestMethodDelegate_0);
            app.RegisterCLRFieldSetter(field, set_TestMethodDelegate_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TestMethodDelegate_0, AssignFromStack_TestMethodDelegate_0);
            field = type.GetField("TestFunctionDelegate", flag);
            app.RegisterCLRFieldGetter(field, get_TestFunctionDelegate_1);
            app.RegisterCLRFieldSetter(field, set_TestFunctionDelegate_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_TestFunctionDelegate_1, AssignFromStack_TestFunctionDelegate_1);
            field = type.GetField("TestActionDelegate", flag);
            app.RegisterCLRFieldGetter(field, get_TestActionDelegate_2);
            app.RegisterCLRFieldSetter(field, set_TestActionDelegate_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_TestActionDelegate_2, AssignFromStack_TestActionDelegate_2);


        }



        static object get_TestMethodDelegate_0(ref object o)
        {
            return global::DelegateDemo.TestMethodDelegate;
        }

        static StackObject* CopyToStack_TestMethodDelegate_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::DelegateDemo.TestMethodDelegate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TestMethodDelegate_0(ref object o, object v)
        {
            global::DelegateDemo.TestMethodDelegate = (global::TestDelegateMethod)v;
        }

        static StackObject* AssignFromStack_TestMethodDelegate_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            global::TestDelegateMethod @TestMethodDelegate = (global::TestDelegateMethod)typeof(global::TestDelegateMethod).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            global::DelegateDemo.TestMethodDelegate = @TestMethodDelegate;
            return ptr_of_this_method;
        }

        static object get_TestFunctionDelegate_1(ref object o)
        {
            return global::DelegateDemo.TestFunctionDelegate;
        }

        static StackObject* CopyToStack_TestFunctionDelegate_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::DelegateDemo.TestFunctionDelegate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TestFunctionDelegate_1(ref object o, object v)
        {
            global::DelegateDemo.TestFunctionDelegate = (global::TestDelegateFunction)v;
        }

        static StackObject* AssignFromStack_TestFunctionDelegate_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            global::TestDelegateFunction @TestFunctionDelegate = (global::TestDelegateFunction)typeof(global::TestDelegateFunction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            global::DelegateDemo.TestFunctionDelegate = @TestFunctionDelegate;
            return ptr_of_this_method;
        }

        static object get_TestActionDelegate_2(ref object o)
        {
            return global::DelegateDemo.TestActionDelegate;
        }

        static StackObject* CopyToStack_TestActionDelegate_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = global::DelegateDemo.TestActionDelegate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TestActionDelegate_2(ref object o, object v)
        {
            global::DelegateDemo.TestActionDelegate = (System.Action<System.String>)v;
        }

        static StackObject* AssignFromStack_TestActionDelegate_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.String> @TestActionDelegate = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            global::DelegateDemo.TestActionDelegate = @TestActionDelegate;
            return ptr_of_this_method;
        }



    }
}
