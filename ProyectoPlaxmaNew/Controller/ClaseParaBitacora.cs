using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPlaxmaNew.Controller
{
    public class conexion3
    {
        SqlConnection conn3 = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");

        //___________________________________________________________________________________________________
        public List<String> ObtenerDatosParaBitacora()
        {
            var columnas = new List<String>();
            try
            {
                conn3.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Bitacora'";
                SqlCommand comando = new SqlCommand(query, conn3);
                SqlDataReader registros = comando.ExecuteReader();
                while (registros.Read())
                {
                    columnas.Add(registros.GetString(0));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn3.Close();
            }
            return columnas;
        }
        //___________________________________________________________________________________________________
        public SqlDataReader ObtenerBitacora()
        {
            string query = "";
            string queryFiltro = "";
            conn3.Open();
            query = "SELECT *FROM Bitacora" + queryFiltro;
            SqlCommand comando = new SqlCommand(query, conn3);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
        //___________________________________________________________________________________________________
        public void cerrarConexion()
        {
            try
            {
                conn3.Close();
            }
            catch (Exception)
            {

            }
        }
        //___________________________________________________________________________________________________
    }
}
