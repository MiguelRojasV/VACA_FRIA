using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VACA_FRIA.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Telefono { get; set; }
        [Required]
        public string? Direccion { get; set; }
        [Required]

        public string? Foto { get; set; }
        [Required]

        [NotMapped]
        [Display(Name = "Cargar Foto")]
        public IFormFile? FotoFile { get; set; }
    }
}
