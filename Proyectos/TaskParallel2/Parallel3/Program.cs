using System;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using System.Reflection;

namespace Parallel3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object lockFactorial = new object();
            
            int target = 5;

            BigInteger factorial = 1;
            Parallel.For (1, target + 1, (i) =>
            {
                lock(lockFactorial)
                {
                    factorial *= i;
                }

            }) ;

            Console.WriteLine($"The factorial of {target} is {factorial}");
          
        }

    }
}