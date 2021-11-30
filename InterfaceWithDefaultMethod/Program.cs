using InterfaceWithDefaultMethod.Contracts;
using InterfaceWithDefaultMethod.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceWithDefaultMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Default Interface Implementation!");

            var parserList = new List<IParser>
            {
                new AvitoParser(),
                new DromParser(),
                new OzonParser()
            };

            int i = 0;

            foreach (var parser in parserList)
            {
                var parserName = parser.GetType().Name;
                var parsResult = parser.GetAliasFromId(i);
                Console.WriteLine($"Парсер: {parserName}, Алиас: {parsResult}");
                i++;
            }

            Console.WriteLine("Please press (Enter) for exit...");
            Console.ReadLine();

        }
    }
}