using System;
using System.Security.Cryptography;

namespace Handicap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = OpenOrSenior(new int [2] [] { new int[]{ 45, 12 }, new int[]{ 55, 21 } });
            Console.WriteLine(result);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> resultList = new List<string>();


            for (int i = 0; i < data.Length; i++)
            {
                
                
                    if (data[i][0]>=55 && data [i][1]>=7)
                    {

                        resultList.Add ("Senior");
                    }
                    else
                    {
                        resultList.Add ("Open");
                    }
                
            }

            return resultList.ToArray() ;
        }

        

    }
}