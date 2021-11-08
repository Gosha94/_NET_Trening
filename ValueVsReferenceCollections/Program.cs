using System;
using System.Collections;
using System.Collections.Generic;
using ValueVsReferenceCollections.Helpers;

namespace ValueVsReferenceCollections
{
    public static class Program
    {
        const int TEST_SIZE = 100_000_000;
        static void Main()
        {
            ValueTypePerformanceTest(TEST_SIZE);
            ReferenceTypePerformanceTest(TEST_SIZE);
            Console.ReadLine();
        }

        private static void ValueTypePerformanceTest(int counter)
        {
            using (new OperationTimer("List<int>"))
            {
                var intList = new List<int>();
                for (var i = 0; i < counter; i++)
                {
                    intList.Add(i);        // Без упаковки
                    var x = intList[i];    // Без распаковки
                }
                intList = null; // Для удаления при GC
            }

            using (new OperationTimer("ArrayList of int"))
            {
                var arrList = new ArrayList();
                for (int i = 0; i < counter; i++)
                {
                    arrList.Add(i);          // Упаковка
                    var x = (int)arrList[i]; // Распаковка
                }
                arrList = null; // Удаление GC
            }
        }

        private static void ReferenceTypePerformanceTest(int counter)
        {
            using (new OperationTimer("List<string>"))
            {
                var strList = new List<string>();
                for (var i = 0; i < counter; i++)
                {
                    strList.Add("X");      // Копирование ссылки
                    var x = strList[i];    // Копирование ссылки
                }
                strList = null; // Для удаления при GC
            }

            using (new OperationTimer("ArrayList of string"))
            {
                var arrList = new ArrayList();
                for (int i = 0; i < counter; i++)
                {
                    arrList.Add("X");           // Копирование ссылки
                    var x = (string)arrList[i]; // Проверка преобразования и копирование ссылки
                }
                arrList = null; // Удаление GC
            }
        }

    }
}