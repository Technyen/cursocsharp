using Microsoft.EntityFrameworkCore;
using EjercicioAPI.DataAccess;
using EjercicioAPI.Models.DataModels;

namespace EjercicioAPI.DataAccess
{
    public class EjercicioDBContext:DbContext
    {
        public EjercicioDBContext(DbContextOptions<EjercicioDBContext> options) : base(options) 
        {

        }
        public DbSet<User>? Users { get; set; }
    }
}
