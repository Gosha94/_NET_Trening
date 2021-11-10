using System.Collections.Generic;
using ComparePoints.Models;
using System;

namespace ComparePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>
            {
                new Point(3, 3),
                new Point(1, 2)
            };

            if (points[0].CompareTo(points[1]) > 0)
            {
                var tempPoint = points[0];
                points[0] = points[1];
                points[1] = tempPoint;
            }

            Console.WriteLine("Упорядочили точки по возрастанию от начала координатных осей X и Y:");

            foreach (var point in points)
            {
                Console.WriteLine(point);
            }

            ChildPoint p = new ChildPoint(1, 2);
            p.CompareTo(points[0]);

        }
    }
}