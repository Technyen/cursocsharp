using System;
internal class Program
{
    static void Main(string[] args)
    {
        var resultado = kata.boolean_to_string();
        Console.WriteLine(resultado);
    }
}
public class kata
{
    public static string boolean_to_string(bool b)
    {
        if (b == true) return "true";
        else return "false";
    }
}