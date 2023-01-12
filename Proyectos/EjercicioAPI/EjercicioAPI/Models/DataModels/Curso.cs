using System.ComponentModel.DataAnnotations;

namespace EjercicioAPI.Models.DataModels
{
    public class Curso
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string DescriptionCorta { get; set; } = string.Empty;
        public string DescriptionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;

        public string Requisitos { get; set; }= string.Empty;   
        public Nivel Nivel { get; set; }    
      
    }
    public enum Nivel { Basico, Intermedio, Avanzado };

}
