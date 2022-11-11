using System;

namespace OOP // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ponga 3 nombres");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            Person[] myPersons =
            {
                new Person
                {
                    Name = name1
                },
                new Person()
                {
                    Name = name2
                },
                new Person()
                {
                    Name = name3
                }

            };

            Console.WriteLine(myPersons[0].ToString());
            Console.WriteLine(myPersons[1].ToString());
            Console.WriteLine(myPersons[2].ToString());



        }
    }
    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}