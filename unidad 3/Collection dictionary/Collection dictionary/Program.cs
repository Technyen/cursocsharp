using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int , string > dict = new Dictionary< int , string >();
            dict.Add(1, "Player 5");
            dict.Add(2, "Player 1");
            dict.Add(3, "Player 3");
            dict.Add(4, "Player 2");
            dict.Add(5, "Player 4");


            foreach (var item in dict)
            {
                Console.WriteLine("Position " + item.Key + " value " + item.Value);
            }

            dict[1] = "Player 4";
            dict[5] = "Player 5";

            Console.WriteLine(" Despues del replacement");
            foreach (var item in dict)
            {
                Console.WriteLine("Position " + item.Key + " value " + item.Value);
            }


            dict.Clear();
            Console.WriteLine(" Despues del clear");
            foreach (var item in dict)
            {
                Console.WriteLine("Position " + item.Key + " value " + item.Value);
            }
        }
    }
}`