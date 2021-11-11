//using System;

//namespace BuilderPatterns
//{
//    public class Person
//    {
//        public string Name { get; set; }
//        public string Position { get; set; }
//        public DateTime DateOfBirth { get; set; }

//        public class Builder: PersonBirthDateBuilder<Builder>
//        {
//            internal Builder() { }
//        }
//        public static Builder New => new Builder();
//        public override string ToString()
//        {
//            return $"Name : {Name},Position : {Position},DateOfBirth : {DateOfBirth},";
//        }
//    }

//    public abstract class PersonBuilder
//    {
//        protected Person Person = new Person();
//        public Person Builder()
//        {
//            return Person;
//        }
//    }

//    public class PersonInfoBuilder<T> : PersonBuilder
//        where T : PersonInfoBuilder<T>
//    {
//        public T Called(string name)
//        {
//            Person.Name = name;
//            return (T) this;
//        }
//    }
//    public class PersonJobBuilder<T> : PersonInfoBuilder<PersonJobBuilder<T>>
//        where T : PersonJobBuilder<T>
//    {
//        public T WorksAsA(string position)
//        {
//            Person.Position = position;
//            return (T)this;
//        }
//    }
//    public class PersonBirthDateBuilder<T> : PersonJobBuilder<PersonBirthDateBuilder<T>>
//        where T : PersonBirthDateBuilder<T>
//    {
//        public T Born(DateTime dateOfBirth)
//        {
//            Person.DateOfBirth = dateOfBirth;
//            return (T)this;
//        }
//    }
//    public class BuilderFluentInterface
//    {
//        static void Main(string[] args)
//        {
//            var me = Person.New
//                .Called("Dmitri")
//                .WorksAsA("Quant")
//                .Born(DateTime.UtcNow)
//                .Builder();
//            Console.WriteLine(me);

//        }
//    }
//}