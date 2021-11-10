using System;

namespace GenericsMeeting.ErrorsWithGenerics
{
    class WrongCasting
    {
        private static void CastingAGenericTypeVariable1<T>(T obj)
        {
            Int32 x = (Int32)obj;   // Ошибка синтаксиса
            String s = (String)obj; // Ошибка синтаксиса
        }

        // Получаем Runtime Exception, т.к не контролируется входной параметр-тип (Говнокод)
        private static void CastingAGenericTypeVariableWithRuntimeException<T>(T obj)
        {
            Int32 x = (Int32)(Object)obj;
            String s = (String)(Object)obj;
        }

    }
}
