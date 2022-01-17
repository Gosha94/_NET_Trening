using GenericsInterfaces.Models;
using System;
using System.Collections;
using System.Linq;

namespace GenericsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";

            // Выводим все методы, присущие типу String
            DisplayAllMethods(str);

            Console.ReadLine();

            // Выводим все методы, присущие типу ICloneable
            ICloneable cloneable = str;
            DisplayAllMethods(cloneable);

            Console.ReadLine();

            IComparable comparable = str;
            DisplayAllMethods(comparable);

            Console.ReadLine();

            IEnumerable enumerable = (IEnumerable)comparable;
            DisplayAllMethods(enumerable);

            Console.ReadLine();

        }

        private static void DisplayAllMethods<T>(T variable)
        {
            var uniqueMethodsName = typeof(T).GetMethods()
                .Select(n => n.Name).Distinct();
            Console.WriteLine($"Переменная типа {typeof(T)} (фактический тип {variable.GetType()}) содержит в себе следующие методы:");

            foreach (var method in uniqueMethodsName)
            {
                Console.WriteLine(method);
            }
            Console.WriteLine();
        }

        private static void Boxing()
        {
            var x = 1;
            var y = 2;

            IComparable comparable = x;

            // Выполняется упаковка
            // т.к. IComparable.CompareTo(object obj) в качестве аргумента ожидает переменную типа object - ссылочный тип
            // а мы передаем int - значимый тип. Ошибки не будет, но для работы необходимо упаковать переменную в куче :'(
            comparable.CompareTo(y);

            // Ошибка во время выполнения кода Runtime Error
            // т.к. в качестве аргумента ожидается object, то мы спокойно можем поместить туда любой тип
            // но во время выполнения CLR будет выполнять сравнение фактических типов int и string, что будет невозможно
            // На этапе написания кода ошибка выявлена не буит :'(
            comparable.CompareTo("2");

            Console.WriteLine("Boxing");

            // Вызов неявной реализации
            var simpleType = new SimpleType();
            simpleType.Dispose();

            // Вызов явной реализации
            IDisposable disposable = simpleType;
            disposable.Dispose();

            // Происходит упаковка типа, и перенос в кучу
            Temp t = new Temp();
            IComparable comp = t;

            Console.ReadLine();
        }

        private static void WithoutBoxing()
        {
            var x = 1;
            var y = 2;

            IComparable<int> comparable = x;

            // Упаковка не выполняется
            // т.к. IComparable<int>.CompareTo(int other) в качестве аргумента ожидается int
            comparable.CompareTo(y);

            // Выявление ошибки во время написания кода
            // Статический анализатор VS умеет замечать несоответствие:
            // в качестве аргумента ожидается int а передаем string
            //comparable.CompareTo("2");

            Console.WriteLine("Without boxing");
        }

    }
}