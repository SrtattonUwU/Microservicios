using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface FuenteDatosValidaciones
    {
        public bool guardarInformacionAccidentes(string placa, string ccCliente, string resultado);
    }
}
