using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new CustomCollection();
            collection[1, "1"] = 10;

            Console.WriteLine("Hello World!");
        }
    }
}
