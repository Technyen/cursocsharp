struct Cliente
{
    public string Nombre;
    public string Apellido;
    public int Telefono;
    public string Direccion;
    public string Email;
    public bool SiEsCliente;

}
class Program
{
    static void Main(string[] args)
    {
        Cliente cli;
        cli.Nombre = "juan";
        cli.Apellido = "He";
        cli.Telefono = 124556;
        cli.Direccion = "av rivadavia";
        cli.Email = "juan124@gmail.com";
        cli.SiEsCliente = true;
   
    Console.WriteLine( "El nombre es {0} {1}",cli.Nombre, cli.Apellido);
        Console.WriteLine("su telefono es {0}",cli.Telefono);
        Console.WriteLine(" su direccion es {0}",cli.Direccion);
        Console.WriteLine(" su mail es  {0}",cli.Email);
        Console.WriteLine("Es cliente {0}", cli.SiEsCliente);
        Console.ReadKey();
    }
     
}