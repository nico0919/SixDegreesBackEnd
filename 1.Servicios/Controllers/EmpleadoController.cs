using _2.Negocio;
using _4.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace _1.Servicios.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : Controller
    {

        private readonly IEmpleado _empleado;
        public EmpleadoController(IEmpleado empleado)
        {
            _empleado = empleado;
        }

        [HttpGet("ObtenerEmpleados")]
        public IActionResult ObtenerTodosEmeplados()
        {
            try
            {
                var empleados = _empleado.ObtenerTodosEmpleados();
                return Ok(empleados);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = $"Error interno del servidor, error: {ex.Message}" });
            }
        }
    }
}
