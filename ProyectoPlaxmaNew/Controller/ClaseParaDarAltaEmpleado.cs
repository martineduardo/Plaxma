using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPlaxmaNew.Controller
{
    public class conexion4
    {
        SqlConnection conn4 = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");

        //___________________________________________________________________________________________________
        public List<String> ObtenerEmpleadosExistentes()
        {
            var columnas = new List<String>();
            try
            {
                conn4.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='EMPLEADO'";
                SqlCommand comando = new SqlCommand(query, conn4);
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
                conn4.Close();
            }
            return columnas;
        }
        //___________________________________________________________________________________________________
        public SqlDataReader ObtenerEmpleados()
        {
            string query = "";
            string queryFiltro = "";
            conn4.Open();
            query = "SELECT *FROM EMPLEADO" + queryFiltro;
            SqlCommand comando = new SqlCommand(query, conn4);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
        //___________________________________________________________________________________________________
        public void cerrarConexion()
        {
            try
            {
                conn4.Close();
            }
            catch (Exception)
            {

            }
        }
        //___________________________________________________________________________________________________
        public string Insertar_Empleado(string Identificacion, string Nombre, string Direccion, string Telefono, string Contraseña)
        {
            try
            {
                conn4.Open();
                string query = "";
                query = "EXEC Insertar_Empleados '" + Identificacion + "', '" + Nombre + "', '" + Direccion + "', '" +
                    Telefono + "', '" + Contraseña + "',''";
                SqlCommand comando = new SqlCommand(query, conn4);
                SqlDataReader registros = comando.ExecuteReader();
                String respuesta = "Error al insertar";
                while (registros.Read())
                {
                    respuesta = registros.GetString(0);
                }
                return respuesta;
            }
            catch (SqlException ex)
            {
                return ex.Message;
                throw;
            }
            finally
            {
                conn4.Close();
            }
        }
        //___________________________________________________________________________________________________
        public String EliminarRegistroEmp(String Empleado)
        {
            try
            {
                conn4.Open();
                string query = "DELETE FROM EMPLEADO WHERE ID_Empleado = '" + Empleado + "'";
                SqlCommand comando = new SqlCommand(query, conn4);
                comando.ExecuteNonQuery();
                return "El registro se eliminó correctamente";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    return "No sé puede eliminar el registro debido a que está relacionado.";
                }
                return ex.Message;
                throw;
            }
            finally
            {
                conn4.Close();
            }
        }
        //___________________________________________________________________________________________________
        public List<String> obtenerEmpleado()
        {
            var columnas = new List<String>();
            try
            {
                conn4.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='EMPLEADO'";
                SqlCommand comando = new SqlCommand(query, conn4);
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
                conn4.Close();
            }
            return columnas;
        }
    }
}
