using System.ComponentModel.DataAnnotations;

//Axel Ojeda Gallardo



namespace aplicacion.Models
{
    public class Recordatorio
    {
        [Key]
        public int IdRecordatorio { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
