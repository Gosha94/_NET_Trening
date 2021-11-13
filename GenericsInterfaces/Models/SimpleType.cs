using System;

namespace GenericsInterfaces.Models
{
    class SimpleType : IDisposable
    {

        // Неявная реализация интерфейсного метода
        public void Dispose()
        {
            Console.WriteLine("SimpleType Dispose()");
        }

        // Явная реализация интерфейсного метода
        void IDisposable.Dispose()
        {
            Console.WriteLine("IDisposable.Dispose()");
        }
    }
}