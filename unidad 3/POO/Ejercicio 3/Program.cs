using System;
using PetShop;

namespace PetShop // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShiftManager myShift = new ShiftManager();
        }
    }

    public abstract class Person
    {
        public int Name { get; set; }
        public string Address { get; set; }
    }

    public class Employee : Person
    {
        public int Id { get ; set; }
        public int Hours;
    }

    public class SalariedEmployee : Employee
    {
        public int Salary { get; set; }

    }

    public class ShiftManager : SalariedEmployee
    {
    }

    public class StoreManager : SalariedEmployee
    {
        
    }

   public class Contractor : Employee
    {
        public int HourlyPay { get; set; }
    }

    public class Groomer : Contractor
    {


    }
    public class Trainer : Contractor
    {

    }

   public class HourlyPayEmployee : SalariedEmployee
    {

        public int SalaryPay { get; set; }
    }

    public class Janitor : HourlyPayEmployee
    {

    }

    public class SalesClerk : HourlyPayEmployee
    { 
    
    }
    public class Customer : Person
    {

        public int CustomerId { get; set; }
        public int Pets { get; set; }
        
    }

    public class Supplier : Person
    {
        public int SupplierId { get; set; }
        public int Products { get; set; }
       
    }
    
}