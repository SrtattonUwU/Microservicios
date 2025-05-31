using LogicaNegocio;

namespace DatosMemoria
{
    public class DatosAccidentesTest : FuenteDatosAccidentes
    {
        public Dictionary<string, int> obtenerInformacionAccidente(string placa)
        {
            return placa switch
            {
                "ABC123" => new Dictionary<string, int> { { "solo latas", 1 } },
                "XYZ789" => new Dictionary<string, int> { { "heridos", 1 } },
                "QWE456" => new Dictionary<string, int> { { "muertos", 1 } },
                "JUY456" => new Dictionary<string, int> { { "solo latas", 4 } },
                "MNB789" => new Dictionary<string, int> { { "heridos", 2 } },
                "QWA486" => new Dictionary<string, int> { { "muertos", 2 } },
                "RTY852" => new Dictionary<string, int> { { "solo latas", 1 }, { "heridos", 1 } },
                "MGH425" => new Dictionary<string, int> { { "solo latas", 4 }, { "heridos", 2 } },
                "THN758" => new Dictionary<string, int> { { "solo latas", 1 }, { "muertos", 1 } },
                "PLM741" => new Dictionary<string, int> { { "heridos", 1 }, { "muertos", 1 } },
                "QWH862" => new Dictionary<string, int> { { "solo latas", 1 }, { "heridos", 1 }, { "muertos", 1 } },
                _ => new Dictionary<string, int>()
            };

        }

    }
}
