using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Person
    {
        public string Address { get; set; }
        public string Name { get; set; }
    }

    public class Student : Person, IStudentID, IClasses
    {
        public int StudentID { get; set; }
        public int CurrentClasses { get; set; }
        public int PastClasses { get; set; }

    }

    public class TeacherAssistant : Person, IStudentID, IEmployeeID, IClasses
    {
        public int CurrentClassesTaught { get; set; }

        public int PastClassesTaught { get; set; }
        public int CurrentClasses { get; set; }
        public int PastClasses { get; set; }
        public int StudentID { get; set; }

       public int EmployeeID { get; set; }
    }

    public class ResearchAssistant : Person, IStudentID, IEmployeeID
    {
        public int StudentID { get; set; }

        public int EmployeeID { get; set; }
    }

    public class Instructor : Person, IEmployeeID, ISponsor, IClasses
    {
        public int EmployeeID { get; set; }
        public int SponsorID { get; set; }
        public int CurrentClasses { get; set; }
        public int PastClasses { get; set; }

    }

    interface IStudentID
    {
        public int StudentID { get; set; }
    }

    interface IEmployeeID
    {
        public int EmployeeID { get; set; }    
    }

    interface ISponsor
    {
        public int SponsorID { get; set; }
    }

    interface IClasses
    {
        public int CurrentClasses { get; set; }
        public int PastClasses { get; set; }
    }
}