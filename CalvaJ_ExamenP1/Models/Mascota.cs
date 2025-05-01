using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalvaJ_ExamenP1.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public string Tipo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Raza { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public bool VacunasAlDia { get; set; }
        [Required]
        public int IdPropietario { get; set; }
        [ForeignKey("IdPropietario")]
        public Propietario? Propietario { get; set; }
    }
}
