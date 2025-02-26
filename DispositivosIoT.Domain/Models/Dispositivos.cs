using System.ComponentModel.DataAnnotations;

namespace SensoresIoT.DispositivosIot.Domain.Models
{
    public class Dispositivos
    {
        [Key]
        [Required]
        public long DispositivoID { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificion { get; set; }

    }
}
