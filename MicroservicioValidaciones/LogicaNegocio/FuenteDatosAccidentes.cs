using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public interface FuenteDatosAccidentes
    {
        public Dictionary<string, int> obtenerInformacionAccidente(string placa);
    }
}
