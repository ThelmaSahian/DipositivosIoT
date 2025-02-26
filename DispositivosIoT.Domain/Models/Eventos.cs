using System.ComponentModel.DataAnnotations;

namespace SensoresIoT.DispositivosIot.Domain.Models
{
    public class Eventos
    {
        [Key]
        [Required]
        public long IdEvento { get; set; }
        public int? IdTipo { get; set; }
        public int IdDispositivo { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int Valor { get; set; }
        public DateTime FechaHora { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime? FechaHoraModificacion { get; set; }
        public int? UsuarioModificion { get; set; }
    }
}
