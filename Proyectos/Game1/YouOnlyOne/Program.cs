using System;

namespace GameOne

{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] listStr = { 123, 456 };
            int x = 123;
            var resultado = Kata.Check(listStr, x);
            Console.WriteLine(resultado);
        }
    }
    public static class Kata
    {
        public static bool Check(object[] listStr, object x)
        {
            foreach (var item in listStr)
            {
                if (item == x) return true;
            }

            return false;
        }
    }
}