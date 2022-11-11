using System;

namespace OOP // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int veces = 2;
            Person[] personas = new Person[veces];

            for (int i = 0; i < veces; i++)
            {
                string nombre = Console.ReadLine();
                Person persona = new Person(nombre);
                personas[i]=persona;    
            }


            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine(personas[i].Name);
            }




        }
    }
    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Person(string name)
        {
            Name = name;
        }


        ~Person()
        {
            Console.WriteLine("se elimino");
            Name="";
        }
    }


   
}