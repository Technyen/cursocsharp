using ApiBackend.DataAccess;
using ApiBackend.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ApiBackend.Services
{
    public class Service
    {

        private readonly UniversityDBContext _context;
        public Service(UniversityDBContext context)
        {
            _context = context;
        }
        public User GetUserByEmail(string emailAdress)
        {
            var userResult = _context.users.Single(user => user.Email ==emailAdress );

            return userResult;
        }

        public List<Student>? GetStudentsByAge(int age)
        {
           // var stuResult = _context.Students.SelectMany(student => student.Age  <= 18);
            var  stuResult = from student in _context.Students where student.Age <=18 select student;
            //var audiList = from car in cars where car.Contains("Audi") select car;
            return (List<Student>?)stuResult;
        }


    }
}







