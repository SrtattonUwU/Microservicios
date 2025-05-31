using System.Net;
using LogicaNegocio;
using Newtonsoft.Json;

namespace CapaDatosAccidentes
{
    public class ConexionAPI : FuenteDatosAccidentes
    {
        public Dictionary<string, int> obtenerInformacionAccidente(string placa)
        {
            string url = "http://localhost:5250/api/Accidente/conteo/" + placa;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                WebResponse response = request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                
                string respuesta = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<string, int>>(respuesta);
            }
            catch
            {
                return new Dictionary<string, int>();
            }
        }
    }
}
