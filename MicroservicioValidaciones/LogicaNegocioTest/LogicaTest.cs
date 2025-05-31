using DatosMemoria;
using LogicaNegocio;

namespace LogicaNegocioTest
{
    [TestClass]
    public sealed class LogicaTest
    {
        [TestMethod]
        public void EvaluarSolicitudSoloLatasAceptar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "ABC123";
            string ccCliente = "123";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("aceptado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudHeridosAceptar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "XYZ789";
            string ccCliente = "456";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("aceptado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudMuertosAceptar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "QWE456";
            string ccCliente = "789";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("aceptado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudSoloLatasRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "JUY456";
            string ccCliente = "321";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudHeridosRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "MNB789";
            string ccCliente = "654";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudMuertosRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "QWA486";
            string ccCliente = "987";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudSoloLatasHeridosAceptar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "RTY852";
            string ccCliente = "147";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("aceptado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudSoloLatasHeridosRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "MGH425";
            string ccCliente = "741";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudSoloLatasMuertosRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "THN758";
            string ccCliente = "258";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudHeridosMuertosRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "PLM741";
            string ccCliente = "852";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }

        [TestMethod]
        public void EvaluarSolicitudSoloLatasHeridosMuertosRechazar()
        {
            var datosAccidentes = new DatosAccidentesTest();
            var datosValidaciones = new DatosValidacionesTest();
            var logica = new Logica(datosValidaciones, datosAccidentes);

            string placa = "QWH862";
            string ccCliente = "963";

            string resultado = logica.evaluarSolicitud(placa, ccCliente);

            Assert.AreEqual("rechazado", resultado);
        }
    }
}
