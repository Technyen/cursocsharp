using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ponga 4 numeros para sumar");
          int num1= Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());


            int sum = Sum(num1, num2, num3,num4);
            
            Console.WriteLine(" tu resultado es "+ sum);

        }

        public static int Sum(int number1, int number2,int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }

    }
}