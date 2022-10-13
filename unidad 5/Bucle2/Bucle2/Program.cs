using System;
using System.Runtime.InteropServices;


string servicio = "internet Pi";
string email = "pepe123@gmail.com";
int precio = 100;


Console.WriteLine("Ponga su nombre ");
string nombre = Console.ReadLine();

Console.WriteLine("Ponga su email ");
Console.ReadLine();

Console.WriteLine("Ponga su servicio ");
Console.ReadLine();


if (nombre=="Pedro")
{
    Console.WriteLine(" Usted es cliente!");
}
else
{
    Console.WriteLine(" Usted no es cliente")
;
}

Console.WriteLine(" usted tiene cupon?");
bool siTieneCupon = Convert.ToBoolean(Console.ReadLine());

if (siTieneCupon)
{
    Console.WriteLine($"usted tiene un cupon de descuento de {precio/2}% el precio final es $50");
}
else
{
    Console.WriteLine("usted no tiene cupon de descuento :C precio final = $100");
}