using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listWords = new List<int>
            {
              78, -9, 0, 23, 54,  21, 7, 86
            };


            var listWords2 = listWords.OrderByDescending(x => x ).Take(5) ;
            listWords2.ToList().
            foreach (var item in listWords2)
            {
                Console.WriteLine(item);
            }
        }
    }
}