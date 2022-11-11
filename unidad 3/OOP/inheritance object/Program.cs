using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] myPersons = new Person[3];
            Console.WriteLine("ponga nombre 1");
            myPersons[0] = new Teacher(Console.ReadLine());
            Console.WriteLine("ponga nombre 2");
            myPersons[1] = new Student(Console.ReadLine());
            Console.WriteLine("ponga nombre 3");
            myPersons[2] = new Student(Console.ReadLine());

            ((Teacher)myPersons[0]).Explain();
            ((Student)myPersons[1]).Study();
            ((Student)myPersons[2]).Study();
        }
    }
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
        ~Person()
        {
            Name = String.Empty;
        }

    }

    public class Student : Person
    {
        public Student(string nameStudent) : base(nameStudent)
        {
            Name = nameStudent;
        }

        public void Study()
        {
            Console.WriteLine( "my name is " + Name + " I'm studying");
        }
    }

    public class Teacher : Person
    {
        public Teacher(string nameTeacher) : base(nameTeacher)
        {
            Name = nameTeacher;
        }
        public void Explain()
        {
            Console.WriteLine("my name is "+ Name + " I'm teaching");
        }

    }
}
