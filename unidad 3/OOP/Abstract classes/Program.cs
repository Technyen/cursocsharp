using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            Console.WriteLine("Escriba el nombre del perro");
            string name = Console.ReadLine();
            myDog.GuardarNombre(name);
            myDog.Eat();
           
        }
    }

    public abstract class Animal
    {
     
        public string Name { get; set; }


       public void GuardarNombre(string name)
        {
            Name = name; 
        }
        public string GetName()
        {
            return Name;    
        }

        public abstract void Eat();
       

    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("the dog" + Name + "is eating");
        }



    }
}