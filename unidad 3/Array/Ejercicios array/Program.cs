using System; 
class Program
{
   public static void Main()
    {
        int[] miArray = new int[10];
        int i;


        Console.WriteLine("type 8 elemnts:");
        for (i = 0; i <10; i++)
        {
            Console.WriteLine("element - {0}:", i );
            miArray[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("\n Elements in array are:");
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("{0} :", miArray[i]);

        }

    }




}
