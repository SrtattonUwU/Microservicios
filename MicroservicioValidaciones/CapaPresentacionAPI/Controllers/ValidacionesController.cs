using CapaDatosAccidentes;
using CapaDatosValidaciones;
using LogicaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace CapaPresentacionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidacionesController : ControllerBase
    {
        private Logica logica = new Logica( new ConexionBBDD(), new ConexionAPI());

        [HttpPost]
        [Route("conteo/{placa}/{ccCliente}")]

        public string Post(string placa, string ccCliente)
        {
            return logica.evaluarSolicitud(placa, ccCliente);
        }
    }
}
