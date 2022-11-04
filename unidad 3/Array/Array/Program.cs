//int resultado = CalcularCuadrado(2); 
//Console.WriteLine(resultado);
//programa

//using System;

//CalcularAprobado(1);
//CalcularAprobado(5);
//CalcularAprobado(9);

//int i = 0;
//Console.WriteLine("i desde Main" + i);
//CalcularCuadrado ( 3 , i );
//Console.WriteLine("i desde Main" + i);

//int CalcularCuadrado(int n, int i)
//{
//    //Console.WriteLine(n * n);

//    Console.WriteLine("i desde fun" + ++i);
//    return i;
//}

//void CalcularAprobado( int a)
//	{
//		if (a < 5)
//		{
//			Console.WriteLine(" has suspendido :C");
//		}
//		else if (a == 5)
//		{
//			Console.WriteLine(" Aprobado raspado :/");
//		}
//		else
//		{
//			Console.WriteLine(" Aprobado :D");
//		}
//	}

//int[] numbers= { 2, 3, 4 ,5 };  
//var squareNumbers = numbers.Select( x => x * x );
//Console.WriteLine( string.Join (" ", squareNumbers ));

//var resultado = SumarHastaTres(0);

//Console.WriteLine($"El resultado es: {resultado}");

//int SumarHastaTres(int numeroInput)
//{
//    //inicio
//    numeroInput++;

//    if(numeroInput == 3)
//    {
//        return numeroInput;
//    }
//    else
//    {
//        return SumarHastaTres(numeroInput);
//    }
//    //final
//}


//LINQ

// NUESTRO ORIGEN DE DATOS
//int[] numbers = new int[10] {1,2,3,4,5,6,7,8,9,10};

////obtener datos con una consulta
//var pares =
//    from numero in numbers
//    where (numero % 2)==0
//    select numero;

//var impares =
//    from numero in numbers
//    where (numero % 2) != 0
//    select numero;

////ejecutar consulta
//foreach (var num in pares)
//{
//    Console.WriteLine(num + " ");
//}

//foreach (var num in impares)
//{
//    Console.WriteLine("\n"+num );
//}


// public class Generic <T>
//{

//}
//class vehiculo : Ivehiculo
//{
//    void Ivehiculo.Arrancar()
//    {
//        Console.WriteLine("arrancar");
//    }
//}
//interface Ivehiculo
//{
//   public void Arrancar();
//}

//collectionss
//var coches = new List<string>();
//coches.Add("Ford");
//coches.Add("BMW");
//coches.Add("Pegeuot");

//var coche2 = new List<string>() { "seat", "Volkawage", "fiat" };
//foreach(var el in coches)
//{
//    Console.WriteLine(el +" ");
//}

//List<Elemento> elemento = CrearLista();
//var query = from el in elemento where el.NumeroAtomico >20
//            select el;
//foreach(Elemento el in query)
//{
//    Console.WriteLine($" nombre : {el.Nombre}, numero atomico, {el.NumeroAtomico}") ;  
//}
//static List<Elemento> CrearLista()
//{
//    return new List<Elemento>
//    {
//        {new Elemento(){Simbolo = "k", Nombre ="potasio", NumeroAtomico = 19} },
//        {new Elemento(){Simbolo = "Ca", Nombre ="calcio", NumeroAtomico = 20} },
//        {new Elemento(){Simbolo = "T", Nombre ="titanio", NumeroAtomico = 22} }
//    };

//}
//public class Elemento
//{
//    public string Simbolo { get; set; }
//    public string Nombre { get; set; }
//    public int NumeroAtomico { get; set; }
//}

//using System.Drawing;
//using System.Runtime.CompilerServices;
//using System.Collections.Generic;
//using System.Collections.Concurrent;
//using System.Collections;


//ListarCoches();

//static void ListarCoches()
//{
//    var cars = new List<Car>
//{

//    { new Car (){ Name = "car4", Color = "brown", Speed = 50} },
//    { new Car (){ Name = "car5", Color = "blue", Speed = 30} },
//    { new Car (){ Name = "car6", Color = "black", Speed = 20} },
//    { new Car (){ Name = "car7", Color = "pink", Speed = 20} },
//    { new Car (){ Name = "car1", Color = "blue", Speed = 20} },
//    { new Car (){ Name = "car2", Color = "red", Speed = 50} },
//    { new Car (){ Name = "car3", Color = "yellow", Speed = 10} }
   

//};

//    cars.Sort();
//    foreach (Car coche in cars)
//    {
//        Console.WriteLine($" {coche.Color}, {coche.Name}, {coche.Speed} ");

//    }
//}



//class Car : IComparable<Car>
//{
//    public string Name { get; set; }
//    public string Color { get; set; }  
    
//    public  int Speed { get; set; }


//    public int CompareTo(Car other)
//    {
//        int compare;
//        compare = String.Compare(this.Color, other.Color, true);

//        if (compare == 0)
//        {
//            compare = this.Speed.CompareTo(other.Speed);
//            compare = -compare;
//        }
//        return compare;

//    }
//}

////Clase de Collection personalizada

//public class Colores : System.Collections.IEnumerable
//{
//    Colores[] _colors =
//    {
//        new Colores [] { Nombre = " rojo"},
//        new Colores [] { Nombre = " azul"},
//        new Colores [] { Nombre = " verde"}
//    };

//    public System.Collections.IEnumerable GetEnumerator()
//        {
//            return new ColoresEnumerator(_colores);
//        //return _colors.GetEnumerator();
//        }

//}

//public class Colores

//{
//    public string Nombre { get; set; }
//}