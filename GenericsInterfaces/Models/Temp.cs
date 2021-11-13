using System;

namespace GenericsInterfaces.Models
{
    struct Temp : IComparable
    {
        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}