using CapaNegocio;

namespace CapaDatosMemoria
{
    public class DatosMemoria : FuenteDatos
    {
        private List<AccidenteDTO> accidentes;
        public DatosMemoria() 
        {
            AccidenteDTO accidente1 = new AccidenteDTO(1, "JKL456", new DateTime(2025, 3, 6), "solo latas");
            AccidenteDTO accidente2 = new AccidenteDTO(1, "OPI789", new DateTime(2025, 8, 18), "solo latas");
            AccidenteDTO accidente3 = new AccidenteDTO(1, "UYT258", new DateTime(2025, 12, 2), "heridos");
            AccidenteDTO accidente4 = new AccidenteDTO(1, "JKL456", new DateTime(2025, 3, 6), "muertos");
            AccidenteDTO accidente5 = new AccidenteDTO(1, "QWE741", new DateTime(2025, 1, 25), "solo latas");

            accidentes = new List<AccidenteDTO>();
            accidentes.Add(accidente1);
            accidentes.Add(accidente2);
            accidentes.Add(accidente3);
            accidentes.Add(accidente4);
            accidentes.Add(accidente5);
        }

        public List<AccidenteDTO> consultarInformacionAccidente(string placa)
        {
            return accidentes.Where(accidente => accidente.Placa == placa).ToList();
        }
    }
}
