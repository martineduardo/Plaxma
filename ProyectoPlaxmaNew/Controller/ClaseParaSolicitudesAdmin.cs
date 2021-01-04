using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPlaxmaNew.Controller
{
    public class conexion2
    {
        SqlConnection conn2 = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");

        //___________________________________________________________________________________________________
        public List<String> ObtenerSolicitudesEmpleados()
        {
            var columnas = new List<String>();
            try
            {
                conn2.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Bitacora'";
                SqlCommand comando = new SqlCommand(query, conn2);
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
                conn2.Close();
            }
            return columnas;
        }
        //___________________________________________________________________________________________________
        public SqlDataReader ObtenerSolitudesEmp()
        {
            string query = "";
            string queryFiltro = "";
            conn2.Open();
            query = "SELECT *FROM Bitacora" + queryFiltro;
            SqlCommand comando = new SqlCommand(query, conn2);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
        //___________________________________________________________________________________________________
        public void cerrarConexion()
        {
            try
            {
                conn2.Close();
            }
            catch (Exception)
            {

            }
        }
        //___________________________________________________________________________________________________
    }
}
