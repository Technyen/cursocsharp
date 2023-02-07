using System;
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

        for (int i = 0; i <lines.Count; i++)
        {
            lines.Add((i+1).ToString() +": " + lines[i]);
        }
        return lines;
        }
    }
