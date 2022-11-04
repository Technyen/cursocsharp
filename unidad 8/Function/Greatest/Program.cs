using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.WriteLine(" ponga 3 numeros");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            int answer = Greatest(number1, number2, number3);
            Console.WriteLine("greatest is " + answer);


        }


        public static int Greatest(int numb1, int numb2, int numb3)
        {


            if ((numb1 > numb2) && (numb1 > numb3))
            {
                return numb1;

            }

            else if ((numb2 > numb3) && (numb2 > numb1))

            {
                return numb2;
            }

            else
            {
                return numb3;
            }


        }


    }

}