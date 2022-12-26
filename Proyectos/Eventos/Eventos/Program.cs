using System.Runtime.CompilerServices;

namespace Eventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suscriptor suscriptor = new Suscriptor(1,2);
            suscriptor.ResultadoSuma();
            suscriptor.ResultadoResta(); 
            
        }
    }

    public class Publisher
    {
        public delegate void MyHandlerType();
        public event MyHandlerType myEvent;
        
        public void Sumar(int a, int b) 
        {
            if (myEvent != null) 
            {
                myEvent();
                Console.WriteLine($"la suma es {a + b} :");

            }
            else
            {
                Console.WriteLine("No tienes una suscripcion al evento");
            }
        }
        public void Restar(int a, int b)
        {
            if (myEvent != null)
            {
                myEvent();
                Console.WriteLine($"la resta es {a - b} :");

            }
            else
            {
                Console.WriteLine("No tienes una suscripcion al evento");
            }
        }
    }

}