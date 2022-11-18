using System;
using System.Collections;
using System.ComponentModel;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<Person>
            {
                new Person { Name= "Pepe", Address ="Av Rivadavia",Age =18 },
                 new Person { Name= "Juan", Address ="Av J.B justo",Age =13 }

            };

            var anonymList = myList.Select(x => 
            {
              var item = new { Name = x.Name, Address = x.Address, Age = x.Age };

                Console.WriteLine(item.Age + item.Address + item.Name);
               
                return item;
                

            }).ToList();
            Console.WriteLine("sagsfda");
            foreach (var item in anonymList)
            {
                Console.WriteLine(1);
            }


        }

        public class Person
        {

            public string Name { get; set; }
            public string Address { get; set; }

            public int Age { get; set; }
        }


    }// crear 2 personas complet
     // hacer linq crear 2 objetons anonymus que tenga name, age, favoriteColor sin crear clases 
     //imprimir las 2 objetos anonm todas las prop
}// imprimir obj anmy y retornar