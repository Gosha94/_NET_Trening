using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_AninymusTypes.Classes
{
    public class Work<T>
        where T : Person<int>
    {
        public int Salary { get; private set; }
        public void CalculateSalary(T person)
        {
            this.Salary += person.Age * person.Age;
        }
        public void ClearSalary()
        {
            this.Salary = 0; 
        }
    }
}
