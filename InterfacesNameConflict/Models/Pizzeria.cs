using InterfacesNameConflict.Contracts;
using System;

namespace InterfacesNameConflict.Models
{
    class Pizzeria : IWindow, IRestaurant
    {

        // Явная реализация интерфейса IWindow
        void IWindow.GetMenu()
        {
            Console.WriteLine("IWindow.GetMenu()");
        }

        // Явная реализация интерфейса IRestaurant
        void IRestaurant.GetMenu()
        {
            Console.WriteLine("IRestaurant.GetMenu()");
        }

        // Собственная реализация метода GetMenu, никак не связана с реализуемыми классом интерфейсами
        public void GetMenu()
        {
            Console.WriteLine("Pizzeria.GetMenu()");
        }

    }
}