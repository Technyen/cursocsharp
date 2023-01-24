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


        public User GetUserByAge (int age)
        {
            var userResultByAge = _context.users.TakeWhile(user =>user.Age <= 18);

            return (User)userResultByAge;
        }
    }
}







