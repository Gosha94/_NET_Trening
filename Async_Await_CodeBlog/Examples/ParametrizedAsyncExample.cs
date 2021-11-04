using System;
using System.Threading.Tasks;

namespace Async_Await_CodeBlog.Examples
{
    internal sealed class ParametrizedAsyncExample
    {
        internal void StartExample()
        {
            Console.WriteLine("Begin Main");
            DoWorkAsync();
            DoParametrizedWorkAsync(100);
            Console.WriteLine("Continue Main");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main");
            }

            Console.WriteLine("End Main");
        }
        private async Task DoWorkAsync()
        {
            Console.WriteLine("Begin Async");
            await Task.Run(() => DoWork());
            Console.WriteLine("End Async");
        }

        private async Task DoParametrizedWorkAsync(int max)
        {
            Console.WriteLine("Begin Param Async");
            await Task.Run(() => ParametrizedDoWork(max));
            Console.WriteLine("End Param Async");
        }

        private void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("DoWork");
            }
        }

        private void ParametrizedDoWork(int max)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("ParametrizedDoWork");
            }
        }

    }
}