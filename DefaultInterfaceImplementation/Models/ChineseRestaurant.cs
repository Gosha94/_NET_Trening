using DefaultInterfaceImplementation.Contracts;
using System;

namespace DefaultInterfaceImplementation.Models
{
    class ChineseRestaurant : IRestaurant
    {
        public void GetMenu()
        {
            Console.WriteLine("ChineseRestaurant.GetMenu() - own ChineseRestaurant Class implementation");
        }
    }
}