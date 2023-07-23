using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeFinancial.Shared.Models
{
    public class TipoPrestamos
    {
        [Key]
        public int TipoPrestamoId {get; set; }
        
        [Required(ErrorMessage = "El tipo de prestamo es requerido")]
        public string? NombreTipoPrestamo {get; set; }

    }
}