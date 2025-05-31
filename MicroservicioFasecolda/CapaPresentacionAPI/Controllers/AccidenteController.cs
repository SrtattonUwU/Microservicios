using CapaAccesoDatos;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapaPresentacionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccidenteController : ControllerBase
    {
        private Logica logica = new Logica(new ConexionBBDD());

        [HttpGet]
        [Route("conteo/{placa}")]

        public ActionResult<Dictionary<string,int>> GetConteoPorPlaca(string placa)
        {
            var resultado = logica.obtenerInformacionAccidente(placa);
            if (resultado == null || resultado.Count == 0)
                return NotFound();

            return Ok(resultado);
        }
    }
}
