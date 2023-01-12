using Microsoft.EntityFrameworkCore;
using ApiBackend.Models.DataModels;

namespace ApiBackend.DataAccess
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext>options):base(options) 
        {
            
        }  

        //TODO: Add DBsets(tables of our Data base)
        public DbSet<User>? users { get; set; }
    }
}
