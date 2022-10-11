int num;
int positivo = 0;
int negativo = 0;
do
{
    Console.WriteLine("ponga un numero o 0 para terminar");
     num = Convert.ToInt32(Console.ReadLine());
    
    if (num < 0)
    {
        Console.WriteLine($"tu numero negativo es {num} ");
        negativo++;
    

    }
    else if (num > 0)
    {
        Console.WriteLine($"tu numero positivo es {num}");
        positivo++;
       

    }

    Console.WriteLine($"positivos= {positivo} y negativos = {negativo}");

} while (num != 0);




