using System;

namespace Murmur
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var resultado = CountSheep(6);
            Console.WriteLine(resultado);

        }

        public static string CountSheep(int cantidadOvejas)
        {
           var resultado = "1 sheep...";
    
            if( cantidadOvejas == 0)
            {
                return "";
            }
            else
            {
                for (int i = 2; i <= cantidadOvejas; i++)
                {
                    resultado += i + " sheep..." ;
                }
                return resultado;
            }

          
            
        }
    }

}