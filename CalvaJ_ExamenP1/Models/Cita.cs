using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalvaJ_ExamenP1.Models
{
    public class Cita
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdMascota { get; set; }
        [ForeignKey("IdMascota")]
        public Mascota? Mascota { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public string Motivo { get; set; }
        [NotMapped]
        public int Tarifa { get {
                switch (Motivo)
                {
                    case "Revision":
                        return 20;
                    case "Vacunacion":
                        return 30;
                    case "Cirugia":
                        return 100;
                    default:
                        return 0;
                }
            } }
        [Required]
        public bool RequiereMedicacion { get; set; }
        
    }
}
