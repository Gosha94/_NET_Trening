using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var r = MyClass.staticPublicField;
            var t = MyClass.staticPublicReadonlyField;
            Console.WriteLine();
        }
    }

    public class MyClass
    {
        public int fieldWithDeafultValue = 5;
        public int publicField;
        public readonly int publicReadonlyField;
        static public int staticPublicField;
        static public readonly int staticPublicReadonlyField;

        public MyClass(int c)
        {
            publicField = c;
            publicReadonlyField = c;
            staticPublicField = c;

            //статические readonly поля можно инициализировать только в статическом конструкторе
            //staticPublicReadonlyField = c;
        }

        public MyClass()
            : this(2)
        { }

        void Method()
        {
            //publicReadonlyField = 1;
        }


        static MyClass()
        {
            staticPublicField = 1;
            staticPublicReadonlyField = 1;

            //нельзя обращаться к нестатическому полю из статического метода
            //publicField=1;
            //publicReadonlyField=1;
        }
    }

}