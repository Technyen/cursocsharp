using System.Diagnostics.Tracing;
using System.Runtime.ExceptionServices;

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
    public static string ToJadenCase( string phrase)
    {
        string[] newPhrase = phrase.Split(" ");
        
        var result = newPhrase.Select(x => x.First().ToString().ToUpper() + x.Substring(1));

        string finalresult = string.Join(" ", result);

        return finalresult;
    }
}
//string result =string.Empty;

//foreach (var item in newPhrase)
//{
//    result +=char.ToUpper(item.First()) + item.Substring(1).ToLower() + " " ;


//}
//return result.Trim();


//var result = from word in newPhrase select char.ToUpper(word.First()) + word.Substring(2).ToString();