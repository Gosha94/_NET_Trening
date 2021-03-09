using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_AninymusTypes.Classes
{
    public class Policeman<T> : Person<T>
    {
        public Policeman(string name, T age, T salary): base(name, age, salary)
        {

        }
    }
}
