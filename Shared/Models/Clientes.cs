using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestigeFinancial.Shared.Models
{
    public class Clientes 
    {
        [Key]
        
        public long ClienteId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Direccion { get; set; }
        public string? Ocupacion { get; set; }
        public long PrestamoId {get; set; }
        public string? Contacto { get; set; }
        public double EstadoDeudor { get; set;}

	    [ForeignKey("ClienteId")]
	    public ICollection<ClientesDetalle> ClientesDetalle { get; set; } = new List<ClientesDetalle>();

    }
}