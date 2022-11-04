using System;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Input your numbers");
        int repeticiones = Convert.ToInt32(Console.ReadLine());


        PrintPhrase(repeticiones);




    

    }
    static void PrintPhrase(int repeti2)
    {

        for (int i = 0; i < repeti2; i++)
        {
            Console.WriteLine("In a hole in the ground there lived a method.");
        }

    }
}