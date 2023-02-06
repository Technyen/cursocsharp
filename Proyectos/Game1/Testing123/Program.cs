using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static void Main(string[] args)
    {
        var lines = new List<string>() { "a", "b", "c" };
        var resultado = LineNumbering.Number(lines);
        Console.WriteLine(resultado);
    }
}

    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {

        string result = string.Empty;

        foreach (var item in lines)
        {
         Console.WriteLine(lines.IndexOf(item)+": " + item);
        }

        return lines;
        }
    }
