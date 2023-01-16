using Microsoft.Build.Framework;

namespace ApiBackend.Models.DataModels
{
    public class Chapter:BaseEntity
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set;}= new Course();

        [Required]
        public string Chapters { get; set; }    =string.Empty;
    }
}
