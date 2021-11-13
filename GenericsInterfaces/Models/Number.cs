using System;

namespace GenericsInterfaces.Models
{

    // Реализуем интерфейс IComparable<> с двумя разными фактическими типами
    public sealed class Number : IComparable<int>, IComparable<string>
    {

        public int Value { get; }

        public Number(int value)
        {
            Value = value;
        }

        // Реализация интерфейса IComparable с int
        public int CompareTo(int other)
        {
            return Value.CompareTo(other);
        }

        // Реализация интерфейса IComparable со strting
        public int CompareTo(string other)
            => Value.CompareTo(int.Parse(other));
        
    }
}