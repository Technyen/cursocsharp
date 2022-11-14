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


            MiClaseGenerica miClase = new MiClaseGenerica();
            miClase.MyProperty = 5;
            MiClaseGenerica resultado = miClase.Modificar(miClase);

            


        }


    }
    public class MiClaseGenerica
    {
        public int MyProperty { get; set; }
        public int Modificar(int numb)
        {
           numb = numb + 1;
            return numb;
            
        }

        public MiClaseGenerica Modificar(MiClaseGenerica miClase)
        {
            miClase.MyProperty = miClase.MyProperty + 1;
            return miClase;

        }

    }
}