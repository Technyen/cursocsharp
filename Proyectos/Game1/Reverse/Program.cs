using System;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultado = ReverseWords("hola como va");
            Console.WriteLine(resultado);

        }

        public static string ReverseWords(string sentence)
        {
           
           var words= sentence.Split(" ");
            string joinString = string.Empty;

            foreach (var word in words)
            {
                char[] wordLetters = word.ToCharArray();
                Array.Reverse(wordLetters);
                string wordReversed = new string(wordLetters);
                joinString += " " + wordReversed;

            }
            return joinString.Trim() ;
        }
    }

}