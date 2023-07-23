using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeFinancial.Shared.Models
{
    public class Prestamos
    {
        [Key]

        [Required(ErrorMessage ="El prestamoId es requerido")]
        public long PrestamoId {get; set; }

        [Required(ErrorMessage ="El ClienteId es requerido")]
        public long ClienteId { get; set; }

        [Required(ErrorMessage ="El Monto es requerido")]
        public double Monto {get; set; }

        [Required(ErrorMessage ="El Interes es requerido")]
        public decimal Interes {get; set; }

        [Required(ErrorMessage ="El Numero de cuotas son requeridas")]
        public int NumeroCuotas {get; set; }
        public string? Deudor {get; set; }
        public DateTime FechaPrestamo { get; set; } = DateTime.Today;
        public double Deuda {get; set; }

    }
}