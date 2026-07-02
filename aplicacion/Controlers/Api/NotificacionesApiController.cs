using aplicacion.Models;
using aplicacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace aplicacion.Controllers.Api
{
    [ApiController]
    [Route("api/notificaciones")]
    public class NotificacionesApiController : ControllerBase
    {
        private readonly NotificacionService _service;

        public NotificacionesApiController(NotificacionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Crear([FromBody] NotificacionApiRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new NotificacionApiResponse
                {
                    Exitoso = false,
                    Mensaje = "Datos inválidos.",
                    Id = null
                });
            }

            int id = _service.Guardar(
                request.Titulo,
                request.Descripcion,
                request.Fecha,
                request.Hora,
                request.Categoria
            );

            return Ok(new NotificacionApiResponse
            {
                Exitoso = true,
                Mensaje = "Notificación registrada correctamente.",
                Id = id
            });
        }
    }
}
