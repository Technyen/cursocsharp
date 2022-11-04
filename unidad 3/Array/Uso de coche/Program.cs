//namespace UsoCoches
//{
//    class Program
//    {
//        static void Main (string[]args)
//        {
//            Coche coche1 = new Coche(); //crear objeto/instancia de tipo Coche.
//            // dar un estado inicial a nuestro coche.

//            Coche coche2 = new Coche();
//            Console.WriteLine(coche1.getRuedas());
//            Console.WriteLine(coche2.getInfoCoche());

//            Coche coche3 = new Coche(1000.25, 1220.35);
//            Console.WriteLine(coche3.getInfoCoche());

//        }
//    }
//}


//class Coche
//{
//    public Coche()
//    {
//        ruedas = 4;
//        largo = 2300.5;
//        ancho = 100.5;
//    }

//    public Coche(double largoCoche, double anchoCoche)
//    {
//        ruedas = 4;
//        largo = largoCoche;
//        ancho = anchoCoche;
//    }

//    public string getInfoCoche()
//    {
//        return " info del coche tiene ruedas "+ ruedas+ " ancho "+ ancho + " largo "+ largo;
//    }
//    public int getRuedas()
//    {
//        return ruedas;
//    }

//    private int ruedas;

//    private double largo;

//    private double ancho;

//    private bool climatizador;

//    private string tapiceria;

//}


//Circulo miCiruculo; // creacion de objeto de tipo circulo. variable/ojt de tipo circulo.

//miCiruculo = new Circulo(); //iniciacion de variable/objeto de tipo circulo. instanciar una clase.ejemplarizacion,craecion de ejemplar de clase

//Console.WriteLine(miCiruculo.calcularArea(2));

//Circulo miCirculo2 = new Circulo();
//Console.WriteLine(miCirculo2.calcularArea(3));




//class Circulo
//{
//     const double pi = 3.1416; // una propiedad del circulo. field campos de clase.

//    public double calcularArea(int radio) //metodo de clase Que pueden hacer los objetos ciruculo
//    {
//        return radio * pi * radio;
//    }


//}




//class AlmacenaObjetos
//{
//    public AlmacenaObjetos(int z)
//    {

//    }
//}
// static void mensajeEnPantalla()
//{

//    Console.WriteLine("mensaje void");

//}




//    mensajeEnPantalla();
//    Console.WriteLine("mensaje main");
//using System.Collections.Generic;

//List<int> numeros = new List<int>();

//int[] listNumber = new int[] { 1, 2, 3, 4, 5, 6, 7 };

//for (int i = 0; i < 7; i++)
//{
//    numeros.Add(listNumber[i]);
//}

//for (int i = 0; i < 7; i++)
//{
//    Console.WriteLine(numeros[i]);
//}


