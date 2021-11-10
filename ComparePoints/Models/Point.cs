using System;

namespace ComparePoints.Models
{
    class Point : IComparable<Point>
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Все методы, в реализации интерфейса - виртуальные и запечатанные по умолчанию (virtual + sealed)
        // если указать virtual, то метод становится просто виртуальным и распечатывается!!! Magic
        public virtual int CompareTo(Point other)
            => Math.Sign(Math.Sqrt(X * X + Y * Y) - Math.Sqrt(other.X * other.X + other.Y * other.Y));

        public int TestSealedMethod(Point other)
            => Math.Sign(Math.Sqrt(X * X + Y * Y) - Math.Sqrt(other.X * other.X + other.Y * other.Y));

        public override string ToString()
            => $"[{X}; {Y}]";

    }
}