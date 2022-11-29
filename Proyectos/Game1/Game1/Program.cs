using System;
using System.Linq;


public class Kata
{
    static void Main(string[] args)
    {

        var resultado = Kata.PositiveSum(new[] { -1, -2,-3,-5 });
        Console.WriteLine(resultado);

    }
    public static int PositiveSum(int[] arr)
    {

            return arr.Where(x => x > 0).Sum();

        
    }
}



