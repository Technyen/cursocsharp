internal class Program
{
    static void Main(string[] args)
    {
        string[] words = new [] { "hola", "mundo" };
        var resultado = Kata.Smash(words);
        Console.WriteLine(resultado);
    }
}
public static class Kata
{
    public static string Smash(string[] words)
    {
        var finalResult=string.Empty;

        foreach (var item in words)
        {
            finalResult += item.Join("",item);
        }
            return finalResult;

    }
}