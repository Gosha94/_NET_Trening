using DefaultInterfaceImplementation.Contracts;
using DefaultInterfaceImplementation.Models;
using System;

namespace DefaultInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {

            var pizzeria = new Pizzeria();
            //pizzeria.GetMenu(); // Метод GetMenu() недоступен у экземпляра класса, т.к. класс не имеет собственной реализации данного метода
            ((IRestaurant)pizzeria).GetMenu(); // Можем обратиться к реализации интерфейса по умолчанию через приведение к экземплярному типу

            var burgerBar = new BurgerBar();
            //burgerBar.GetMenu(); // Метод GetMenu() недоступен у экземпляра класса, т.к. класс имеет явную реализацию интерфейсного метода, то есть вынесунную из интерфейса в класс
            ((IRestaurant)burgerBar).GetMenu(); // И нам все равно нужно привести наш класс к интерфейсу

            var chineseRestaurant = new ChineseRestaurant();
            chineseRestaurant.GetMenu(); // Вызывая метод, получим собственную реализацию метода из класса
            ((IRestaurant)chineseRestaurant).GetMenu(); // Даже через приведение к экземплярному типу получим собственную реализацию метода из класса!!!

            Console.ReadLine();
        }
    }
}