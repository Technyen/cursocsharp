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
            miClase.Invertir( miLista);

            foreach (var item in miLista)
            {
                Console.WriteLine(item);

            }

        }
         
        
    }
    public class MiClaseGenerica<T>
    {
        public List<T> Invertir(List<T> miLista)
        {
            miLista.Reverse();
            return miLista;
        }
    }
}