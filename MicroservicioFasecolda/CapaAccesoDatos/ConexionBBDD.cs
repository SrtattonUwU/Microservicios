using CapaNegocio;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;

namespace CapaAccesoDatos
{
    public class ConexionBBDD : FuenteDatos
    {
        private SqlConnection conexion;


        public ConexionBBDD()
        {
            conexion = new SqlConnection(
                @"TrustServerCertificate=true;Password=canela789;Persist Security Info=True;User ID=sa;Initial Catalog=MS_Accidentes;Data Source=DESKTOP-RO5O1V8\SQLEXPRESS");
        }

        public List<AccidenteDTO> consultarInformacionAccidente(string placa)
        {
            conexion.Open();

            string query = "SELECT idAccidente, placa, fecha, severidad FROM accidentes WHERE placa = @placa";

            SqlCommand command = new SqlCommand(query, conexion);
            command.Parameters.AddWithValue("@placa", placa);
            
            SqlDataReader reader = command.ExecuteReader();

            List<AccidenteDTO> lista = new List<AccidenteDTO>();

            while (reader.Read()) 
            {
                var accidente = new AccidenteDTO
                {
                    Id = Convert.ToInt32(reader["idAccidente"]),
                    Placa = reader["placa"].ToString(),
                    Fecha = Convert.ToDateTime(reader["fecha"]),
                    Severidad = reader["severidad"].ToString()
                };

                lista.Add(accidente);
            }

            conexion.Close();

            return lista;

        }
    }
}
