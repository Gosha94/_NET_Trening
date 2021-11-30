using System;

namespace DateTimeOffsets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //"2013-10-22T20:00:00+00:00"
            //"1987-11-27T21:00:00+00:00"
            var testDate = "2013-10-22T20:00:00+00:00";
            var testDt = DateTime.Parse(testDate);
            var offs = DateTimeOffset.UtcNow;
            var uni = testDt.ToUniversalTime();
            var loc = testDt.ToLocalTime();

            Console.ReadLine();
        }
    }
}