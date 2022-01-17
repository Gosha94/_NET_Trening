using System;

namespace ClassVsStruct
{
    class MyClass
    {
        public string field = "значение поля не изменено";
    }

    struct MyStruct
    {
        public string field; // = "значение поля не изменено" ;//- в структурах так нельзя
    }
    class Program
    {
        public static void UpdateClass(MyClass c)
        {
            c.field = "значение поля изменено";
        }
        public static void UpdateStructWrong(MyStruct s)
        {
            s.field = "значение поля изменено";
        }
        public static void UpdateStructCorrect(ref MyStruct s)
        {
            s.field = "значение поля изменено";
        }
        public static MyStruct UpdateStructPerfect(MyStruct s)
        {
            return new MyStruct { field = "значение поля изменено" };
        }
        static void Main(string[] args)
        {
            var c = new MyClass();
            UpdateClass(c);
            Console.WriteLine(c.field);
            
            var s = new MyStruct() { field = "значение поля не изменено" };
            //			UpdateStructWrong(s);
            //			UpdateStructCorrect(ref s);
            s = UpdateStructPerfect(s);
            Console.WriteLine(s.field);

            OptimizationThrougthStruct.CheckMemory();

        }
    }
}
