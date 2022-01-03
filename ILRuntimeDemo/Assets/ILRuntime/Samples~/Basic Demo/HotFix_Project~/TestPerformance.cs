using System;
using UnityEngine;
using System.Collections.Generic;
using System.Text;

namespace HotFix_Project
{
    public class TestPerformance
    {
        public static void TestMandelbrot(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            float total = Mandelbrot(64, 64, 4);
            sw.Stop();
            sb.AppendLine(string.Format("res=" + total + ", time:{0:0}", sw.ElapsedMilliseconds));
            sw.Restart();
            total = Mandelbrot2(64, 64, 4);
            sw.Stop();
            sb.AppendLine(string.Format("res2=" + total + ", time:{0:0}", sw.ElapsedMilliseconds));
        }

        static bool MandelbrotCheck(float workX, float workY)
        {
            return ((workX * workX) + (workY * workY)) < 4.0f;
        }
        static float Mandelbrot(uint width, uint height, uint iterations)
        {
            float data = 0.0f;

            for (int i = 0; i < iterations; i++)
            { // ideally you should have for loops broken up into jobs
                float  // should declare variables outside of loops (*1)
                    left = -2.1f,
                    right = 1.0f,
                    top = -1.3f,
                    bottom = 1.3f,
                    deltaX = (right - left) / width,  //invert this e.g.  invWidth = 1f / width; outside of the loop and multiply.
                    deltaY = (bottom - top) / height, //ditto for height.
                    coordinateX = left;

                for (int x = 0; x < width; x++)
                { // ideally you should have for loops broken up into jobs
                    float coordinateY = top; // (*1)

                    for (int y = 0; y < height; y++)
                    { // ideally you should have for loops broken up into jobs
                        float workX = 0;  // (*1)
                        float workY = 0;
                        int counter = 0;

                        // should use Burst Mathermatics.Sqrt not Math.Sqrt
                        while (counter < 255 && MandelbrotCheck(workX, workY))
                        {
                            counter++;

                            // recalculating workx * workx and worky multiple times in the loop and conditional test.
                            float newX = (workX * workX) - (workY * workY) + coordinateX; //(*1)

                            workY = 2 * workX * workY + coordinateY;
                            workX = newX;
                        }

                        data = workX + workY;
                        coordinateY += deltaY;
                    }

                    coordinateX += deltaX;
                }
            }

            return data;
        }

        static float Mandelbrot2(uint width, uint height, uint iterations)
        {
            float data = 0.0f;

            for (int i = 0; i < iterations; i++)
            { // ideally you should have for loops broken up into jobs
                float  // should declare variables outside of loops (*1)
                    left = -2.1f,
                    right = 1.0f,
                    top = -1.3f,
                    bottom = 1.3f,
                    deltaX = (right - left) / width,  //invert this e.g.  invWidth = 1f / width; outside of the loop and multiply.
                    deltaY = (bottom - top) / height, //ditto for height.
                    coordinateX = left;

                for (int x = 0; x < width; x++)
                { // ideally you should have for loops broken up into jobs
                    float coordinateY = top; // (*1)

                    for (int y = 0; y < height; y++)
                    { // ideally you should have for loops broken up into jobs
                        float workX = 0;  // (*1)
                        float workY = 0;
                        int counter = 0;

                        // should use Burst Mathermatics.Sqrt not Math.Sqrt
                        while (counter < 255 && Performance.MandelbrotCheck(workX, workY))
                        {
                            counter++;

                            // recalculating workx * workx and worky multiple times in the loop and conditional test.
                            float newX = (workX * workX) - (workY * workY) + coordinateX; //(*1)

                            workY = 2 * workX * workY + coordinateY;
                            workX = newX;
                        }

                        data = workX + workY;
                        coordinateY += deltaY;
                    }

                    coordinateX += deltaX;
                }
            }

            return data;
        }

        public static void Test0(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var go = new GameObject("t");
            var transform = go.transform;


            for (int i = 0; i < 2000000; i++) 
            {
                transform.position = transform.position;        
            }

            GameObject.Destroy(go);
            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test1(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var go = new GameObject("t");
            var transform = go.transform;


            for (int i = 0; i < 2000000; i++)
            {
                transform.Rotate(Vector3.up, 1);
            }

            GameObject.Destroy(go);
            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test2(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 2000000; i++)
            {
                var v = new Vector3(i, i, i);
                var x = v.x;
                var y = v.y;
                var z = v.z;
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test3(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 20000; i++)
            {
                var go = new GameObject();
                GameObject.Destroy(go);
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test4(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var tp = typeof(SkinnedMeshRenderer);
            for (int i = 0; i < 20000; i++)
            {
                var go = new GameObject();
                go.AddComponent(tp);
                var c = go.GetComponent(tp) as SkinnedMeshRenderer;
                c.receiveShadows = false;
                GameObject.Destroy(go);
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test5(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 2000000; i++)
            {
                var p = Input.mousePosition;
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test6(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 2000000; i++)
            {
                var v = new Vector3(i, i, i);
                Vector3.Normalize(v);
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test7(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 2000000; i++)
            {
                var q1 = Quaternion.Euler(i, i, i);
                var q2 = Quaternion.Euler(i * 2, i * 2, i * 2);
                Quaternion.Slerp(Quaternion.identity, q1, 0.5f);
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        public static void Test8(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            long total = 0;

            for (int i = 0; i < 2000000; i++)
            {
                total = total + i - (i / 2) * (i + 3) / (i + 5);
            }

            sw.Stop();
            sb.AppendLine("res=" + total + ",time:" + sw.ElapsedMilliseconds);
        }

        public static void Test9(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            int[] array = new int[1024];
            for(int i = 0; i < 1024; i++)
            {
                array[i] = i;
            }
            sw.Start();
            long total = 0;

            for (int j = 0; j < 20000; j++)
            {
                for (int i = 0; i < 1024; i++)
                {
                    total = total + array[i];
                }
            }
            sw.Stop();
            sb.AppendLine("res=" + total + ",time:" + sw.ElapsedMilliseconds);
        }

        public static void Test10(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var go = new GameObject("t");
            var transform = go.transform;

            for (int i = 0; i < 2000000; i++)
            {
                Performance.TestFunc1(1, "123", transform);
            }
            GameObject.Destroy(go);
            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }

        static void c(Vector3 o, Vector3 x)
        {
            var r = o + x;
        }
        public static void Test11(StringBuilder sb)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < 2000000; i++)
            {
                var a = new Vector3(1, 2, 3);
                var b = new Vector3(4, 5, 6);
                c(a, b);
            }

            sw.Stop();
            sb.AppendLine("time:" + sw.ElapsedMilliseconds);
        }
    }



}
