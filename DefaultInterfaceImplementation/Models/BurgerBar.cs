using DefaultInterfaceImplementation.Contracts;
using System;

namespace DefaultInterfaceImplementation.Models
{
    class BurgerBar : IRestaurant
    {
        void IRestaurant.GetMenu()
        {
            Console.WriteLine("BurgerBar.GetMenu() - own ChineseRestaurant Class implementation");
        }

    }
}
