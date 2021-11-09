using System;
using System.Collections.Generic;

namespace CoContrAndInGenericVariance
{

    public delegate TResult Func<in T, out TResult>(T arg);

    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Аргументы типа могут быть 3 видов:
             * Инвариантные     (Параметр-Тип не может меняться, поведение по умолчанию)
             * Контрвариантные  (Параметр-Тип может быть преобразован к классу-наследнику, ключевое слово in) - Должен использоваться во входной позиции, пример: как аргумент метода
             * Ковариантные     (Параметр-Тип может быть преобразован к классу-предку(базовому), ключевое слово out) - Должен использоваться в выходной позиции, пример: как возвращаемое значение
             */

            Func<object, ArgumentException> fn1 = null;
            Func<string, Exception> fn2 = fn1; // Явное приведение типа не требуется
            Exception e = fn2("");

            // Для значимых типов, например DateTime, вариантность невозможна, т.к. в куче создается новый экземпляр при упаковке
            IEnumerable<DateTime> dates = new List<DateTime> { DateTime.Now, DateTime.UtcNow };
            //ProcessCollection(dates); // Error

            IEnumerable<string> strings = new List<string> { "Hello", "World" };
            ProcessCollection(strings);

            int n1 = 1, n2 = 3;
            Swap(ref n1, ref n2);

            Swap<int>(ref n1, ref n2);

            string s1 = "Ivan", s2 = "Petrov";
            Swap(ref s1, ref s2);

        }

        /// <summary>
        /// Метод, который не будет работать со значимыми типами из за невозможности узнать какой тип должен быть после упаковки/распаковки
        /// </summary>
        /// <param name="collection"></param>
        static void ProcessCollection(IEnumerable<object> collection) { }

        /// <summary>
        /// Исправленный метод, который может работать со значимыми типами, выполнять упаковки/распаковки, т.к. указан один и тот же тип в сигнатуре и аргументе метода
        /// </summary>
        /// <param name="collection"></param>
        static void SolveProblemProcessCollection<T>(IEnumerable<T> collection) { }

        // Для делегатов рекомендация использовать ко и контр вариантность где это возможно
        // Для интерфейсов также возможно применять ко и контр вариантность, но нужно быть осторожным с их изменением, вероятные жесткие последствия смены ко на контрвариантность (in на out аргументы)


        // Выведение типов - особый механизм языка
        // При наличии нескольких методов, среди которых есть необобщенный метод, предпочтение отдается необобщенной реализации метода
                
        private static void Swap<T>(ref T var1, ref T var2)
        {
            Console.WriteLine("Generic Swap");
            T temp = var1;
            var1 = var2;
            var2 = temp;
        }

        private static void Swap(ref int var1, ref int var2)
        {
            Console.WriteLine("Standard Integer Swap");
            int temp = var1;
            var1 = var2;
            var2 = temp;
        }

        /*
        Параметры типа (MyClass<T>) отсутствуют у следующих конструкций C#:
        Свойств
        Индексаторов
        Событий
        Операторов (Математических)
        Конструкторов
        Деструкторов

        !!! Но при этом определенный в классе тип можно использовать в данных конструкциях ( T SomeProperty {get; set;} ), т.к. вероятность применения обобщения к ним крайне мала
         */
    }
}