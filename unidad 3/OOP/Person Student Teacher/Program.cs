using System;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class ProgramStudentProfessorTest
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            Tearcher myTeacher = new Tearcher();
            myStudent.Greet();
            myTeacher.Greet();
            myStudent.ShowAge ();
            myTeacher.Explain();
            myStudent.Study();
            myStudent.SetAge(21);
            myStudent.ShowAge();
        }
    }

    public class Person
    {
      public  int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }


        public void SetAge( int ageInput)
        {
            age=ageInput;
        }
    }


    public class Tearcher:Person
    {
        public void Explain()
        {
            Console.WriteLine(" I'm explaining");
        }
    }


    public class Student:Person
    {
        
       
        public void Study()
        {
            Console.WriteLine(" I'm studying");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is " +age + " years old" );
        }

    }


}