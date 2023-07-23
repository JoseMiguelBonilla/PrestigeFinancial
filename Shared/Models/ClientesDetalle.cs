using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeFinancial.Shared.Models
{
    public class ClientesDetalle
    {
        [Key]
        public long DetalleId { get; set; }
        public long ClienteId { get; set; }
        public long PrestamoId {get; set; }
        public int TipoId {get; set; }
        public string? Telefono { get; set; }
        public string? NombreGarantes { get; set; }
        public string? CedulaGarantes { get; set; }    
        public string? TelefonoGarante { get; set; }
        public double MontoDeudor { get; set; }

        [ForeignKey("ClienteId")]
	    public ICollection<Prestamos> Prestamos { get; set; } = new List<Prestamos>();

    }
}