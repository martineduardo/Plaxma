using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPlaxmaNew.Model
{
    public class Conexion
    {
        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");

        //___________________________________________________________________________________________________
        public bool obtenerEmpleado(String usua, String contra)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True"))
            {
                conexion.Open();
                string query = "";
                query = "SELECT COUNT(*) FROM EMPLEADO WHERE ID_Empleado = '" + usua + "' AND Contra= '" + contra + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
                int contador = Convert.ToInt32(comando.ExecuteScalar());
                if (contador == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        //___________________________________________________________________________________________________
        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception)
            {

            }
        }
        //___________________________________________________________________________________________________
    }
}
