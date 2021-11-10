namespace GenericsMeeting.ConcreteTypes
{
    class ClassWithGenericsMethod<TClass>
    {

        public TClass Property { get; set; }
        public void Method<TMethod>(TClass arg1, TMethod arg2)
        {

        }
    }
}
