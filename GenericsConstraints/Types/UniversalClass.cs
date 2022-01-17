namespace GenericsConstraints.Types
{
    class UniversalClass<TFromClass>
    {
        public static T DropGenericTypeToDefaultValue<T>()
            => default(T);

        //public static T WrongDropGenericTypeToDefaultValue<T>() 
        //    => null; // CS0403 : нельзя привести null к параметру типа T, значимые типы не могут быть null

        public void GenericMethod<TFromMethod>(TFromClass arg1, TFromClass arg2)
        {

        }

    }
}