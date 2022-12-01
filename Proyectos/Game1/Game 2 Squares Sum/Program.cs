using System;
using System.Linq;

public class Kata2
{
    static void Main(string[] args)
    {

        var resultado = Kata2.SquaresSum(new[] {1, 2, 2 });
        Console.WriteLine(resultado);

    }
    public static int SquaresSum(int[] numbers)
    {

        return numbers.Select(x => x * x).Sum();


    }
}

