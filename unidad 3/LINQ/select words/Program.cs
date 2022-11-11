using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listWords = new List<string>
            {
                "mum", "amsterdam", "bloom"
            };


            var listWords2 = listWords.Where(x => x.StartsWith("a") && x.EndsWith("m") );

            foreach (var item in listWords2)
            {
                Console.WriteLine(item);
            }
        }
    }
}