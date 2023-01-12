using System;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultado = Kata.AddBinary(5,9);
            Console.WriteLine(resultado);
        }
    }
    public static class Kata
    {
        public static string AddBinary(int a, int b)
        {
            int resultSum = a + b;
            string binary = Convert.ToString(resultSum, 2);
            return binary;
        }
    }
}