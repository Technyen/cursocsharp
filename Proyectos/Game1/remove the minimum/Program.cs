using System;
using System.Collections.Generic;
using System.Linq;
namespace MyNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>() { 1, 2, 3, 4, 5 };
            Remover.RemoveSmallest(myList);
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Remover
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            var newNumbers = numbers;
            newNumbers.Remove(newNumbers.Min());

            return newNumbers;
        }
    }

}
