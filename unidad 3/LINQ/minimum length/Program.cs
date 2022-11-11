using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words= { "computer", "usb", "mouse", "display" };

            var listaW = words.Where(x => x.Count() >= 5);
            foreach (var item in listaW)
            {
                Console.WriteLine(item.ToUpper());
            }
        }

    }
}
