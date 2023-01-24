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
        public DbSet<Course>? courses { get; set; } 
        public DbSet<Category>? categories { get; set; }    
        
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }  
    }
}
