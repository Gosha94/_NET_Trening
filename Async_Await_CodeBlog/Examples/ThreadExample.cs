using System;
using System.Threading;

namespace Async_Await_CodeBlog.Examples
{
    internal static class ThreadExample
    {

        public static void StartExample()
        {

            Thread thread = new Thread(new ThreadStart(DoWork));
            thread.Start();

            Thread paramThread = new Thread(new ParameterizedThreadStart(ParametrizedDoWork));
            paramThread.Start(int.MaxValue);

            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;

                if (j % 10000 == 0)
                {
                    Console.WriteLine("MainEntryPoint");
                }
            }

            Console.ReadLine();
        }

        private static void DoWork()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;

                if (j % 10000 == 0)
                {
                    Console.WriteLine("DoWork");
                }
            }
        }

        private static void ParametrizedDoWork(object max)
        {
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;

                if (j % 10000 == 0)
                {
                    Console.WriteLine("ParametrizedDoWork");
                }
            }
        }

    }
}