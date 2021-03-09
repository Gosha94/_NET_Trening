using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLearn.Exceptions
{
    class MyException : Exception
    {
        public MyException() : base("Кастомное исключение, созданное юзером.")
        {
            
        }

        //public MyException(string message) : base(message)
        //{
        //}

    }
}
