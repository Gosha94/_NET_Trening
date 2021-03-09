namespace Generics_AninymusTypes.Classes
{
    public class Person<T>
    {
        public string Name { get; set; }
        public T Age { get; set; }
        public T Salary { get; set; }

        public Person(string name, T age, T salary)
        {
            // TODO: Проверить входные параметры
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
