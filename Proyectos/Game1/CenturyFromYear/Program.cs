internal class Program
{
    static void Main(string[] args)
    {
        var resultado = Kata.СenturyFromYear(2000);
        Console.WriteLine(resultado);
    }
}

public static class Kata
{
    public static int СenturyFromYear(int year)
    {
       
        var result = year / 100;
        var reminder = year % 100;
        if ( reminder != 0)
        {
            result =result + 1;
        }
        
        return result;
    }
}