using System;

namespace TaskParallel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[100,100];

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    matrix[i, j] = i;
                }
                
            }

            long sum = 0;

            Parallel.For(0, 100, (i) =>
            {
                Console.WriteLine($"Adding array number{i}");
                for (int j = 0; j < 100; j++)
                {
                    sum += matrix[i, j];
                }
            });
            Console.WriteLine($"the sum of all the elements in matrix {sum}");
        }
    }
}   