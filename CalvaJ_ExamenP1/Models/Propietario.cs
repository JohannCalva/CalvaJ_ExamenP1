using System.ComponentModel.DataAnnotations;

namespace CalvaJ_ExamenP1.Models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [Range(12, 100)]
        public int Edad { get; set; }
        [Required]
        [EmailAddress]
        public string Correo { get; set; }
        [Required]
        [Phone]
        public string Telefono { get; set; }
        [Required]
        public decimal IngresoMensual { get; set; }
        [Required]
        public bool EsMayorEdad { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
    }
}
