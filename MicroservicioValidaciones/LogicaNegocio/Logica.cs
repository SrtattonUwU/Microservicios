namespace LogicaNegocio
{
    public class Logica
    {
        private FuenteDatosValidaciones datosValidaciones;
        private FuenteDatosAccidentes datosAccidentes;
        public Logica(){}

        public Logica(FuenteDatosValidaciones datosValidaciones, FuenteDatosAccidentes datosAccidentes)
        {
            this.datosValidaciones = datosValidaciones;
            this.datosAccidentes = datosAccidentes;
        }

        public Logica(FuenteDatosAccidentes datosAccidentes)
        {
            this.datosAccidentes = datosAccidentes;
        }

        public string evaluarSolicitud(string placa, string ccCliente){
            var accidentes = datosAccidentes.obtenerInformacionAccidente(placa);
            int puntaje = 0;

            foreach (var accidente in accidentes)
            {
                string tipo = accidente.Key.ToLower();
                int cantidad = accidente.Value;

                if (tipo == "solo latas")
                {
                    puntaje += 100 * cantidad;
                }
                else if (tipo == "heridos")
                {
                    puntaje += 200 * cantidad;
                }
                else if (tipo == "muertos")
                {
                    puntaje += 300 * cantidad;
                }
            }
            
            string resultado = (puntaje >= 400) ? "rechazado" : "aceptado";

            datosValidaciones.guardarInformacionAccidentes(placa, ccCliente, resultado);

            return resultado;

        }

    }
}
