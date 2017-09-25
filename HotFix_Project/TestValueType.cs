using System;
using System.Collections.Generic;
using UnityEngine;

namespace HotFix_Project
{
    class TestValueType
    {
        public static void RunTest()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //Debug.Log("测试Vector3的各种运算");
            Vector3 a = new Vector3(1, 2, 3);
            Vector3 b = Vector3.one;

            Debug.Log("a + b = " + (a + b));
            Debug.Log("a - b = " + (a - b));
            Debug.Log("a * 2 = " + (a * 2));
            Debug.Log("2 * a = " + (2 * a));
            Debug.Log("a / 2 = " + (a / 2));
            Debug.Log("-a = " + (-a));
            Debug.Log("a == b = " + (a == b));
            Debug.Log("a != b = " + (a != b));
            Debug.Log("a dot b = " + Vector3.Dot(a, b));
            Debug.Log("a cross b = " + Vector3.Cross(a, b));
            Debug.Log("a distance b = " + Vector3.Distance(a, b));
            Debug.Log("a.magnitude = " + a.magnitude);
            Debug.Log("a.normalized = " + a.normalized);
            Debug.Log("a.sqrMagnitude = " + a.sqrMagnitude);

            sw.Start();
            float dot = 0;
            for(int i = 0; i < 100000; i++)
            {
                a += Vector3.one;
                dot += Vector3.Dot(a, Vector3.zero);
            }
            sw.Stop();

            Debug.LogFormat("Value: a={0},dot={1}, time = {2}ms", a, dot, sw.ElapsedMilliseconds);
        }
    }
}
