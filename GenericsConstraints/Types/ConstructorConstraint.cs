using System;

namespace GenericsConstraints.Types
{
    internal sealed class ConstructorConstraint<T>
        where T : new()
    {
        public static T UniversalTypeFactory()
        {
            // Допустимо, т.к. у всеъ значимых типов неявно задан открытый конструктор без параметров,
            // и данное ограничение одновременно требует наличия у ссылочных типов открытого конструктора без параметров

            return new T();
        }
    }
}
