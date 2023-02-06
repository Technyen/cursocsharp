using System.ComponentModel.DataAnnotations;

namespace ApiBackend.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
