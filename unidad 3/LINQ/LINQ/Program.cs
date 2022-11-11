using System;
using System.Collections.Generic;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 67, 92, 153, 15 };

            var numQuery = numbers.Where(x => x > 30 && x < 100);
            foreach (var item in numQuery)
            {
                Console.WriteLine(item);
            }
        }

        
    }

   


}