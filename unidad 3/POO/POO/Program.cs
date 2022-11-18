using System;

namespace MyApp7 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empleados = new List<Employee>();
            empleados.Add(new Employee());    

            foreach (Employee empleado in empleados)
            {

                Person miPerson = empleado as Person;
                if (miPerson != null)
                {
                    miPerson.ImprimirQuienSoy();
                }

                   
                    
 
            }

        }
     
    }
    public  class Person
    {

        public virtual void ImprimirQuienSoy()
        {
            Console.WriteLine(" Soy Person");
        }
    }

    public class Employee:Person
    {
        public override void ImprimirQuienSoy()
        {
            Console.WriteLine("soy empleado");
        }
        
    }
}