using System.ComponentModel.DataAnnotations;

namespace EjercicioAPI.Models.DataModels
{
    public class User:Curso
    {
        [Required,StringLength(50)]
        public string Name { set; get; } = string.Empty;
        [Required,StringLength(50)]
        public string LastName { set; get; }= string.Empty;

        [Required,EmailAddress]
        public string EmailAddress { set; get; }=   string.Empty;
        [Required]
        public string Password { set; get; }=string.Empty;
    }
}
