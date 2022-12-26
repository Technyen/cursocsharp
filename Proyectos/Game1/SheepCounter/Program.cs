using System;

namespace SheepCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listSheep  = new bool[] { true, true, false };

            var result = CountSheeps(listSheep);
            Console.WriteLine(result);
        }
        public static int CountSheeps(bool[] sheeps)
        {
          return sheeps.Count(x => x);

          
        }
    }
}