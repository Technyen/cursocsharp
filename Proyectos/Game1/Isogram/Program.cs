using System;

namespace Isogram

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = IsIsogram("kanzsky");

            Console.WriteLine(result);
           
        }
        public static bool IsIsogram(string str)
        {
            char[] strArray =str.ToLower().ToArray();
           

            for (int i = 0; i < strArray.Length; i++)
            {
                for (int j = i+1 ; j < strArray.Length; j++)
                {
                    if (strArray[i] == strArray[j] )
                    {
                        
                        return false;
                    }
                }
            }
            return true;




        }



    }
}