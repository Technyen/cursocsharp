internal class Program
{
    static void Main(string[] args)
    {
        var resultado =Paper.Paperwork(2,3);
        Console.WriteLine(resultado);
    }
}

    public static class Paper
    {
        public static int Paperwork(int n, int m)
        {
        var result = n * m;
        if (n<0 || m<0)
        {
            result = 0;
        }
        return result;
        }
    }
