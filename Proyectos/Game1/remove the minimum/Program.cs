using System;
using System.Collections.Generic;
using System.Linq;
namespace MyNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var query = Remover.RemoveSmallest(numbers);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            var query = numbers.Where(x => x != numbers.Min()).ToList();
            return query;
        }
    }

}
