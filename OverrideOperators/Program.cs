using System;
using System.Drawing;

namespace OverrideOperators
{
    class Vector
    {
        public double X;
        public double Y;

        public static Vector operator +(Vector p1, Vector p2)
        {
            return new Vector { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }

        public static Vector operator *(Vector p1, double c)
        {
            return new Vector { X = p1.X * c, Y = p1.Y * c };
        }
        public static double operator *(Vector p1, Vector p2)
        {
            return p1.X * p2.X + p1.Y * p2.Y;
        }

        public static explicit operator PointF(Vector p1)
        {
            return new PointF((float)p1.X, (float)p1.Y);
        }

    }

    class Program
    {
        public static void Main()
        {
            var v1 = new Vector { X = 1, Y = 1 };
            var v2 = new Vector { X = 2, Y = 3 };
            var v3 = v1 + v2;
            var v4 = v1 * 5;
            PointF point = (PointF)v1;

            int a = new A() + new A() + new A() * "abc";
            Console.WriteLine(a);
        }

    }

    internal class A
    {
        public A()
        {
        }
        public static int operator +(A a, A b)
            => 1;
        public static int operator *(A a, string s)
            => 2;
        public static implicit operator int(A a)
            => 3;
    }
}