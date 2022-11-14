namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> miLista = new List<string>();
            miLista.Add("Juan");
            miLista.Add("Zolio");
            miLista.Add("Pedro");

            MiClaseGenerica<string> miClase = new MiClaseGenerica<string>();
            miClase.Invertir(miLista);

            foreach (var item in miLista)
            {
                Console.WriteLine(item);

            }
            miClase.Imprimir<string>("hola");
            miClase.Imprimir<int>(3);
            miClase.Imprimir<double>(1.2);
            miClase.Imprimir<MiClaseGenerica>();


        }


    }
    public class MiClaseGenerica<T>
    {
        public List<T> Invertir(List<T> miLista)
        {
            miLista.Reverse();
            return miLista;
        }

        public void Imprimir<U>(U miParam) where U : struct
        {
            Console.WriteLine("");
            
        }
    }
    
    
}