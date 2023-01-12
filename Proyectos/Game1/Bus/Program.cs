using System;

namespace BusTaion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            var resultado = Kata.Number(peopleList);
            Console.WriteLine(resultado);
        }
    }
    public static class Kata
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int result = 0;
            foreach (var item in peopleListInOut)
            {
                result+= item[0] - item[1];
              
            }
            return result;

        }
    }
}