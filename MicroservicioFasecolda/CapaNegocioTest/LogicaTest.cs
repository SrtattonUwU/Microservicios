using CapaDatosMemoria;
using CapaNegocio;

namespace CapaNegocioTest
{
    [TestClass]
    public sealed class LogicaTest
    {
        private Logica logica = new Logica(new DatosMemoria());

        [TestMethod]
        public void ProbarConsultarCantidadAccidentesPorPlaca()
        {
            logica.obtenerInformacionAccidente("JKL456");
            logica.obtenerInformacionAccidente("OPI789");
            logica.obtenerInformacionAccidente("UYT258");
            logica.obtenerInformacionAccidente("QWE741");

        }
    }
}
