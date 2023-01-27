class Program
{
    static void Main(string[] args)
    {
        var resultado = JadenCase.ToJadenCase("hola como va");
        Console.WriteLine(resultado);
    }
}
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string[] newPhrase = phrase.Split(" ");
        foreach (var item in newPhrase)
        {
            Console.Write(item);
        }
        return null;
    }
}