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
        foreach (var item in resultado)
        {
            Console.WriteLine(item);

        }
    }
}

    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {

        for (int i = 0; i <lines.Count; i++)
        {
            lines[i] = i+1 +": " + lines[i];
        }
        return lines;
        }
    }
