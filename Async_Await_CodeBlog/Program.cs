using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Async_Await_CodeBlog.Examples;

namespace Async_Await_CodeBlog
{
    class Program
    {

        /// <summary>
        /// Объект-локер должен быть ссылочным, чтобы потоки не могли создавать его копии
        /// </summary>
        public static object globalLocker = new object();

        #region DeadLockExample

        public static int i1 = 100;

        static void M1()
        {
            for (int i = 0; i < i1; i++)
            {

            }
        }

        static void M2()
        {
            for (int i = i1; i < i1; i--)
            {

            }          
        }

        #endregion        

        static void Main(string[] args)
        {

            #region Threading

            // ThreadExample.ThreadExample.StartExample();

            #endregion

            #region Async/Await

            // new ParametrizedAsyncExample().StartExample();            
            
            new ReturnedDataAsyncExample().StartExample();

            #endregion
            
            var input = Console.ReadLine();
            
        }
    }
}