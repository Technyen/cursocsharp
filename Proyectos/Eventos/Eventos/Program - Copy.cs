using System.Runtime.CompilerServices;

namespace Eventos
{


    public class Suscriptor
    {
        Publisher publisher;
        private readonly int A;
        private readonly int B;

        public void MyEventHandler()
        {
            Console.WriteLine(" Se imprime el resultado de la operacion");
        }
        public Suscriptor (int a, int b)
        {
            publisher = new Publisher ();
            A = a;
            B = b;
            publisher.myEvent += MyEventHandler;
        }

        public void ResultadoSuma()
        {
            publisher.Sumar(A, B); 
        }
        public void ResultadoResta()
        {
            publisher.Restar(A, B);
        }
    }
}