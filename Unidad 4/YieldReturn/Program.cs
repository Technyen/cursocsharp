using System;
using System.Reflection;

namespace Yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultado = NumbOdd();
            
            foreach (var item in resultado)
            {
                if (item < 100)
                {
                    Console.WriteLine(item);

                }
            }
        }
       
        public static IEnumerable<int>NumbOdd()
        {
            var number = 0;
           
            while (true)
            {

                if (number % 2 == 1)
                {
                    yield return number;
                    
                }
                number++;
            }
        }
    }
}