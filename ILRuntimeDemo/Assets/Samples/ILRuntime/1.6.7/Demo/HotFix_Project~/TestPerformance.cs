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
    }



}
