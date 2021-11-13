using InterfacesNameConflict.Contracts;
using InterfacesNameConflict.Models;

namespace GenericsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzeria = new Pizzeria();

            // По умолчанию будет вызываться собственный метод класса, интерфейсные методы игнорятся
            // При удалении из класса Pizzeria собственной реализации метода получаем ошибку отсутствия найденного метода
            // Явные реализации методов принадлежат интерфейсу, а не классу в котором описаны
            pizzeria.GetMenu();

            // Приведя экземпляр класса к интерфейсному типу мы будем вызывать явную реализацию метода
            IWindow window = pizzeria;
            window.GetMenu();

            // Более короткая версия приведения к интерфейсному типу и вызов явной реализации интерфейсного метода
            ((IRestaurant)pizzeria).GetMenu();
        }
    }
}