using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        string[] words = new [] { "hola", "mundo","world" };
        var resultado = Kata.Smash(words);
        Console.WriteLine(resultado);
    }
}
public static class Kata
{
    public static string Smash(string[] words)
    {

        string finalresult = string.Join(" ", words).TrimEnd();

        return finalresult;

        //return string.Join("", words);

        //Smash (string[] words) => string.Join("", words);


    }
}