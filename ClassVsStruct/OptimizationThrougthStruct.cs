using System;
using System.Diagnostics;

namespace ClassVsStruct
{
    static class OptimizationThrougthStruct
    {
        class Point // или class Point
        {
            public int X;
            public int Y;
        }
            internal static void CheckMemory()
            {
                int N = 10000000;
                var timer = new Stopwatch();

                var before = GC.GetTotalMemory(false);
                timer.Start();

                var points = new Point[N];
                /* 

                Это нужно делать, только если Point — класс.
                Под структуры память выделяется в момент создания массива.

                Но даже если этот цикл оставить, код со структурами будет всё равно работать заметно быстрее.
                */
                for (int i = 0; i < points.Length; i++)
                    points[i] = new Point();

                var after = GC.GetTotalMemory(false);
                timer.Stop();

                Console.WriteLine("Memory(bytes):");
                Console.WriteLine((double)(after - before) / N);
                Console.WriteLine("Time(msc):");
                Console.WriteLine(timer.ElapsedMilliseconds);
            }
        }
    }