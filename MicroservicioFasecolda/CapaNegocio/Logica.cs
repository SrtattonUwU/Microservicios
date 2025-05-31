using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public  class Logica
    {
        private FuenteDatos repositorio;

        public Logica(FuenteDatos repositorio)
        {
            this.repositorio = repositorio;
        }

        public Dictionary<string, int> obtenerInformacionAccidente(string placa)
        {
            var accidentes = repositorio.consultarInformacionAccidente(placa);

            Dictionary<string, int> conteos = new Dictionary<string, int>();

            foreach (var acc in accidentes)
            {
                string tipo = acc.Severidad?.Trim().ToLower() ?? "desconocido";

                if (conteos.ContainsKey(tipo))
                    conteos[tipo]++;
                else
                    conteos[tipo] = 1;
            }

            return conteos;

        }

    }
}
