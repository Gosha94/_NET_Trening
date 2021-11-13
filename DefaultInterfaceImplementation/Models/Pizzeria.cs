using DefaultInterfaceImplementation.Contracts;

namespace DefaultInterfaceImplementation.Models
{

    // Мы можем наследовать интерфейс с реализацией по умолчанию обязательного определения метода интерфейса
    // При этом метод GetMenu() не будет доступен из экземпляра класса
    // Но вызвать реализацию интерфейсного метода возможно, приведя экземпляр класса к интерфейсному типу
    class Pizzeria : IRestaurant
    {

    }

}