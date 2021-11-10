namespace GenericsConstraints.Types
{
    class UniversalClass<TFromClass>
    {
        public static T DropGenericTypeToDefaultValue<T>()
            => default;
        
        public void GenericMethod<TFromMethod>(TFromClass arg1, TFromClass arg2)
        {

        }

    }
}
