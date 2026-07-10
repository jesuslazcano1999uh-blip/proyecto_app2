using Microsoft.AspNetCore.Mvc;
using aplicacion.Models;
using aplicacion.Services;

//Axel Ojeda Gallardo
namespace aplicacion.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordatorioApiController : ControllerBase
    {
        private readonly RecordatorioService _service;

        public RecordatorioApiController(RecordatorioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Crear([FromBody] RecordatorioApiRequest request)
        {
            var resultado = _service.GuardarRecordatorio(request);

            if (!resultado.Exito) return BadRequest(resultado);

            return Ok(resultado);
        }
    }
}
