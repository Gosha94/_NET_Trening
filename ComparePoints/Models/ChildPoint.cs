using System;

namespace ComparePoints.Models
{
    class ChildPoint : Point
    {
        
        public ChildPoint(int x, int y) : base(x, y)
        { }

        // Можем переопределить
        public override int CompareTo(Point other)
        {
            // Полиморфизм интерфейса 
            var s = "";
            IComparable<string> temp = s;

            return base.CompareTo(other);
        }

        // Не можем переопределить
        // override TestSealedMethod
        //public override int TestSealedMethod(Point other)
        //{
        //    return base.TestSealedMethod(other);
        //}

    }
}