using GenericsMeeting.Contracts;
using System.Collections.Generic;
using GenericsMeeting.ConcreteTypes;

namespace GenericsMeeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var class1 = new IntClass();
            var struct1 = new IntStruct();
            var wrong = new WrongClass();
            
            // Обобщенные интерфейсы позволяют избегать лишних операций упаковки значимых типов (структур) в область кучи
            var list = new List<IGenericContract<int>>() 
            {
                class1,
                struct1,
                //wrong // Error
            };


            //Deleg<Base, GrandChild, Child> item = null;
            Deleg<Child, Child, Child> item = null;
            Deleg<Child, Child, Child> item2 = null;
            item2 = item;

            // in можно брать наследника
            // out можно брать родителя
            // стандарт - без ключевых слов, класс должен совпадать
            // Если элемент должен быть и входным аргументом и выходным параметром - он должен быть инвариантным!!!

            // Вся эта лабуда нужна для того, чтобы использовать классы, методы и делегаты в большем количестве мест и условий кода без его дублирования
            // Возврат из метода максимально общий, входные данные в метод максимально конкретные

            // Обобщенные методы
            var intItem = new ClassWithGenericsMethod<int>();
            intItem.Method<string>(5, "hello");


            Min(5, 7);
            Min(5, 7.5);
            Min(5.9, 7);

            var b = new Base();
            var c = new Child();
            Min(c, b);
            Mini(c, b);
        }

        //public delegate TCovar Deleg<in TContrvar, out TCovar, TInvar>(TContrvar arg);
        public delegate TResult Deleg<in TArg, out TResult, TStandard>(TArg arg);

        public class Base { }
        public class Child : Base { }
        public class GrandChild : Child { }
        
        // ---------------------------------------------------------------------
        // Проверка возможности приведения типов

        /// <summary>
        /// В данном методе при записи ограничения (T1 : T2) Тип T1 будет зависеть от T2
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="firstVal"></param>
        /// <param name="secondVal"></param>
        /// <returns></returns>
        private static bool Min<T1, T2>(T1 firstVal, T2 secondVal) where T1 : T2
            => true;

        // Ограничение на наличие конструктора по умолчанию
        private static bool Mini<T1, T2>(T1 firstVal, T2 secondVal) where T1 : new()
            => true;

    }
}