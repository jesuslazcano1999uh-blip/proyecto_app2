using aplicacion.Models;
//Axel Ojeda Gallardo
namespace aplicacion.Services
{
    public class RecordatorioService
    {
        public RecordatorioApiResponse GuardarRecordatorio(RecordatorioApiRequest request)
        {
            if (string.IsNullOrEmpty(request.Titulo))
            {
                return new RecordatorioApiResponse { Exito = false, Mensaje = "El título es obligatorio" };
            }

            return new RecordatorioApiResponse
            {
                Exito = true,
                Mensaje = "Recordatorio procesado correctamente",
                IdCreado = 1
            };
        }
    }
}