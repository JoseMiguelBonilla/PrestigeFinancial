using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeFinancial.Shared.Models
{
    public class TiposTelefonos
    {
        [Key]
        public int TipoId {get; set; }
        
        [Required(ErrorMessage = "La Descripcion es requerida")]
        public string? Descripcion {get; set; }

    }
}