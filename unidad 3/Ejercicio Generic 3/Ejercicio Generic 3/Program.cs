AlmacenEmpleados<Secretario> empleados = new AlmacenEmpleados<Secretario>(3);

empleados.agregar(new Secretario(4500));
empleados.agregar(new Secretario(1000));
empleados.agregar(new Secretario(2500));

var sueldoNumero = (Secretario)empleados.getEmpleado(0);
Console.WriteLine(sueldoNumero.getSalario());


class AlmacenEmpleados<T> where T:IParaEmpleados
{
    public AlmacenEmpleados (int z)
    {
        datosEmpleados = new T[z];

    }

    private int i=0;

    private T[] datosEmpleados;

   public void agregar (T obj)
    {

        datosEmpleados[i] = obj;
        i++;
    }

    public T getEmpleado (int i)
    {
        return datosEmpleados[i];
    }

}


class Director : IParaEmpleados
{
    public Director (double salario)
    {
        this.salario = salario;
    }

    private double salario;

    public double getSalario()
    {
        return salario;
    }
}


class Secretario : IParaEmpleados
{
    public Secretario (double salario)
    {
        this.salario = salario;
    }
    private double salario;

    public double getSalario()
    {
        return salario;
    }
}

class Electricista : IParaEmpleados
{
    public Electricista (double salario)
    {
        this.salario = salario;
    }
    private double salario;
    public double getSalario()
    {
        return salario;
    }
}


interface IParaEmpleados
{

    double getSalario();
}