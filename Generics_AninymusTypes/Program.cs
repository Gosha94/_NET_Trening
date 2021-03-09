using Generics_AninymusTypes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_AninymusTypes
{
    class Program
    {
        //+ ДЗ определить базовый класс и несколько наследников
        //+ добавить в базовый класс универсальный тип
        //+ создать класс, который будет принимать в качестве универс типа базовый класс
        // Поэкспериментровать с универсальными типами ( ограничения типов, вызывать, создать метод, получить его значения )


        static void Main(string[] args)
        {
            //var person1 = new Person <int> ("Peter", 20, 13567);
            //var person2 = new Person <decimal> ("Ilya", 25.8M, 45678.567M);
            var work = new Work<Person<int>>();
            var policeman = new Policeman<int>("Joe", 20, 15000);
            var balerine = new Balerine<int>("Beatrice", 25, 345);
            work.CalculateSalary(policeman);
            Console.WriteLine("Salary of the policeman: " + work.Salary);
            work.ClearSalary();
            work.CalculateSalary(balerine);
            Console.WriteLine("Salary of the balerine: " + work.Salary);
            Console.ReadLine();
            var list = new List<int>();
            var map = new Dictionary<int, string>();
            map.Add(4, "Four");
        }
    }
}
