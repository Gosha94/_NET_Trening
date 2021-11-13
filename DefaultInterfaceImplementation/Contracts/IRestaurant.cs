using System;

namespace DefaultInterfaceImplementation.Contracts
{

    interface IRestaurant
    {

        // В интерфейсе объявлен мептод и для него добавлена реализация по умолчанию
        // Применяется таким образом: (IRestaurant)someImplementClassLink.GetMenu();
        // Аналогичен методу внутри реализующего интерфейс класса: IRestaurant.GetMenu()
        void GetMenu()
        {
            Console.WriteLine("IRestaurant.GetMenu() - default interface implementation");
        }

    }
}