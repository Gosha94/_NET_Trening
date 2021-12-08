using System;

namespace TypeInitialize
{
    class Helper
    {
        public static int Report(string str)
        {
            Console.WriteLine(str);
            return 0;
        }
    }

    class MyClass
    {
        static int staticField = Helper.Report("2. Инициализация статических полей");

        static MyClass()
        {
            Helper.Report("3. Статический конструктор");
        }

        int field = Helper.Report("4. Инициализация нестатических полей");

        public MyClass(int c)
        {
            Helper.Report("5. Конструктор, вызванный другим конструктором");
        }

        public MyClass()
            : this(1)
        {
            Helper.Report("6. Явно вызванный конструктор");
        }

        public void Method()
        {
            Helper.Report("7. Метод");
        }
    }

    class Program
    {
        public static void MainX()
        {
            Helper.Report("1. Начало программы");
            new MyClass().Method();
        }
    }
}
