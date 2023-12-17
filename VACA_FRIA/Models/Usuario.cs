using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VACA_FRIA.Dtos;

namespace VACA_FRIA.Models
{
    public class Usuario
    {
        [Key]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public RolEnum Rol { get; set; }
    }
}
