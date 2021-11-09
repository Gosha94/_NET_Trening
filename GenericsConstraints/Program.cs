using GenericsConstraints.Types;
using System;

namespace GenericsConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ограничения в обобщениях
            var compareResult = ItemComparer<bool>.CompareTwoItems(true, true);
            

            MethodTakingAnyType(5);
            MethodTakingAnyType("hello");
            MethodTakingAnyType(3.5);

            Min(1,3);
            
            Console.WriteLine($"Compare Result: {compareResult}");
            Console.ReadLine();

        }
        private static bool MethodTakingAnyType<T>(T o)
        {
            T temp = o;

            Console.WriteLine(o.ToString());

            var result = temp.Equals(o);
            return result;
        }

        private static T Min<T>(T firstVal, T secondVal) where T : IComparable<T>
            => (firstVal.CompareTo(secondVal) < 0) ? firstVal : secondVal;

    }
}