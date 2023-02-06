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
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; } 
        public DbSet<Category>? Categories { get; set; }    
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }  
    }
}
