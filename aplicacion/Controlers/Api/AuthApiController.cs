using aplicacion.Models;
using aplicacion.Services;
using Microsoft.AspNetCore.Mvc;

namespace aplicacion.Controllers.Api
{
    [ApiController]
    [Route("api/auth")]
    public class AuthApiController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthApiController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginApiRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new LoginApiResponse
                {
                    Exitoso = false,
                    Mensaje = "Datos de entrada invalidos.",
                    Token = null
                });
            }

            bool valido = _authService.ValidarUsuario(
                request.Usuario,
                request.Password
            );

            if (!valido)
            {
                return Unauthorized(new LoginApiResponse
                {
                    Exitoso = false,
                    Mensaje = "Usuario o password incorrectos.",
                    Token = null
                });
            }

            return Ok(new LoginApiResponse
            {
                Exitoso = true,
                Mensaje = "Autenticacion exitosa.",
                Token = "TOKEN_TEMPORAL"
            });
        }
    }
}

