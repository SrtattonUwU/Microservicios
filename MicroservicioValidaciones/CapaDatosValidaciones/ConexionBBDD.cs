using LogicaNegocio;
using Microsoft.Data.SqlClient;

namespace CapaDatosValidaciones
{
    public class ConexionBBDD : FuenteDatosValidaciones
    {
        private SqlConnection conexion;

        public ConexionBBDD()
        {
            conexion = new SqlConnection(
                @"TrustServerCertificate=true;Password=canela789;Persist Security Info=True;User ID=sa;Initial Catalog=MS_Validaciones;Data Source=DESKTOP-RO5O1V8\SQLEXPRESS");
        }

        public bool guardarInformacionAccidentes(string placa, string ccCliente, string resultado)
        {
            conexion.Open();

            string insert = string.Format("INSERT INTO validaciones (placa, ccCliente, resultado) VALUES (@placa, @ccCliente, @resultado)");

            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.Parameters.AddWithValue("@placa", placa);
            comando.Parameters.AddWithValue("@ccCliente", ccCliente);
            comando.Parameters.AddWithValue("@resultado", resultado);

            int rows = comando.ExecuteNonQuery();

            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            conexion.Close();
        }
    }
}
