
Console.WriteLine("Introducir el ancho ");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introducir el alto ");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Tiene relleno? ");
bool esRelleno = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de formas");
int cantidad = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < cantidad; i++)
{
    if (esRelleno)
    {

        for (int fila = 0; fila < alto; fila++)
        {
            for (int columna = 0; columna < ancho; columna++)
            {

                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
    else
    {
        for (int fila = 0; fila < alto; fila++)
        {
            for (int columna = 0; columna < ancho; columna++)
            {
                if (columna == 0 || columna == ancho - 1 || fila == 0 || fila == alto - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
}

