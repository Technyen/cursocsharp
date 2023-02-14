internal class Program
{
    static void Main(string[] args)
    {
        var resultado = Kata.CheckForFactor(25,5);
        Console.WriteLine(resultado);
    }
}

public class Kata
{
    public static bool CheckForFactor(int num, int factor)
    {
        var reminder = num % factor;


        if (reminder == 0)
        {
            return true;
        }
        return false;
    nu}
}