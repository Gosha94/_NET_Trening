using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await_CodeBlog.Examples
{
    internal sealed class ReturnedDataAsyncExample
    {

        internal async void StartExample()
        {
            var result = await SaveFileAsync("D:\\ForDelete\\AsyncWriteTest.txt");
            Console.WriteLine(result);
        }

        private async Task<bool> SaveFileAsync(string path)
        {
            Console.WriteLine("Start Async Write File");
            var result = await Task.Run(() => SaveFile(path));
            Console.WriteLine("End Async Write File");
            return result;
        }

        private bool SaveFile(string path)
        {
            
            lock (Program.globalLocker)
            {
                var rand = new Random();
                var stringBuilder = new StringBuilder();

                for (int i = 0; i < 10000000; i++)
                {
                    stringBuilder.Append(rand.Next());
                }            

                using (var streamWriter = new StreamWriter(path, false, Encoding.UTF8))
                {
                    streamWriter.WriteLine(stringBuilder);
                }

                return true;
            }
        }
    }
}