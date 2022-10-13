Console.WriteLine(" selecciona tu lenguaje \n a= C# \n b = Java \n c= Phyton  \n Ingrese el char");
char lenguaje = Convert.ToChar (Console.ReadLine().ToLower());


switch (lenguaje)
{
	case 'a' :
		Console.WriteLine("C# = hello world");
		break;

	case 'b' :
		Console.WriteLine(" Java");
		 break;
	case 'c' :
		Console.WriteLine(" phyton");
		break ;
	default:
		Console.WriteLine(" no es lenguaje de programcion");
		break;
}