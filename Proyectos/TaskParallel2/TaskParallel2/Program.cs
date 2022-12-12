using System;
using System.Threading.Tasks;
using System.Threading;

namespace Parallel2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            Random random= new Random();
            for (int i = 0; i <1000 ; i++)
            {
                list.Add(random.Next(0,100));    
            }

            var queryList = list.OrderBy(x => x).AsParallel();

            
            foreach (int number in queryList) 
            {
                Console.WriteLine(number);
            }
        }

    }
}