using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_AninymusTypes.Classes
{
    public class Balerine<T> : Person<T>
    {
        public Balerine(string name, T age, T salary) : base(name, age, salary)
        {
        }
    }
}
