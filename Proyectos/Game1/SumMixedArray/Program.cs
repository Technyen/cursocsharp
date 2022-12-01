using System.Linq;
public class Kata
{
    static void Main(string[] args)
    {
        SumMix(new object[] {1,"5"} );
       
    }

    public static int SumMix(object[] x)
    {
        var result = 0;

        foreach (var item in x)
        {
           var num = Convert.ToInt32(item);

           result += num;

        }
        Console.WriteLine(result);
        return result;
       

    }
}