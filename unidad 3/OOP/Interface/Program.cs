using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(0);

            Console.WriteLine("Amount of gasoline to refuel");
           int gasoline= Convert.ToInt32(Console.ReadLine());
            myCar.Refuel(gasoline);
            myCar.Drive();
        }
    }

    public class Car:IVehiculo
    {
        public Car(int gasoline)
        {
            Gasoline = gasoline;    
        }

        public int Gasoline { get; set; }

        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine(" The car is driving ");
            }
           
            
        }

        public bool Refuel(int amountRefuel)
        {
            Gasoline += amountRefuel;
            return true;
           
        }
    
    }

    interface IVehiculo
    {
       
        public void Drive();
        public bool Refuel(int amountRefuel);   
    }

}
