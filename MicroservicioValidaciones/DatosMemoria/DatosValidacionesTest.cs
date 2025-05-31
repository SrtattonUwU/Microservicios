using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosMemoria
{
    public class DatosValidacionesTest : FuenteDatosValidaciones
    {
        public List<(string placa, string ccCliente, string resultado)> Registros { get; } = new();

        public bool guardarInformacionAccidentes(string placa, string ccCliente, string resultado)
        {
            Registros.Add((placa, ccCliente, resultado));
            return true;
        }
    }
}
