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
            var userResult = _context.Users.Single(user => user.Email ==emailAdress );

            return userResult;
        }

        public List<Student>? GetStudentsByAge(int age)
        {
            var stuResult = _context.Students
        .Where(student => student.Age <= age)
        .ToList();
            return stuResult;
        }


    }
}







