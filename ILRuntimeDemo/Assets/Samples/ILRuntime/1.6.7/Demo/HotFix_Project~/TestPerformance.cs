using System;
using UnityEngine;
using System.Collections.Generic;
using System.Text;
namespace HotFix_Project
{
    public class TestPerformance
    {
        public static void Test01(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            int total = Fib(30);
            sw.Stop();
            sb.AppendLine(string.Format("res=" + total + ", time:{0:0}", sw.ElapsedMilliseconds));
        }
        static int Fib(int n)
        {
            return n < 2 ? 1 : Fib(n - 1) + Fib(n - 2);
        }
    }


}
