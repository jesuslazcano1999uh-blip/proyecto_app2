using System.ComponentModel.DataAnnotations;

namespace aplicacion.Models
{
    public class NotificacionApiRequest
    {
        [Required]
        public string Titulo { get; set; }

        public string? Descripcion { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public TimeSpan Hora { get; set; }

        [Required]
        public string Categoria { get; set; }
    }
}
