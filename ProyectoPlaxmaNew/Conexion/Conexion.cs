using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPlaxmaNew.Conexion
{
    public class Conexion
    {
        SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");

        public Conexion()
        {
        }

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
        public string ObtenerNombreConID_Empleado(string id)
        {
            conexion.Open();
            string query = "";
            query = "SELECT Nombre_Emp FROM EMPLEADO WHERE ID_Empleado = '" + id + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            String respuesta = "Error al buscar";
            while (registros.Read())
            {
                respuesta = registros.GetString(0);
            }
            conexion.Close();
            return respuesta;
        }
        //___________________________________________________________________________________________________
        public string ObtenerID_Empleado(string id)
        {
            conexion.Open();
            string query = "";
            query = "SELECT ID_Empleado FROM EMPLEADO WHERE ID_Empleado = '" + id + "'";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            String respuesta = "Error al buscar";
            while (registros.Read())
            {
                respuesta = registros.GetString(0);
            }
            conexion.Close();
            return respuesta;
        }
        //___________________________________________________________________________________________________
        public string Insertar_Solicitud(string Solicitante, string NumeroEconomico, string Placas, string Reservaciones, string Destino, string FechaIn, string FechaFi, string Observaciones)
        {
            try
            {
                conexion.Open();
                string query = "";
                query = "EXEC Insertar_Uso '" + Solicitante + "', '" + NumeroEconomico + "', '" + Placas + "', '" + Reservaciones + "', '" + Destino + "', '" + FechaIn + "', '" + FechaFi + "', '" + Observaciones + "',''";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                conexion.Close();
            }
        }
        //___________________________________________________________________________________________________
        public List<String> obtenerCantidadRegistros()
        {
            var columnas = new List<String>();
            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Usuarios_Espera_y_Uso_Auto'";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                conexion.Close();
            }
            return columnas;
        }
        //___________________________________________________________________________________________________
        public SqlDataReader obtenerRegistros()
        {
            string query = "";
            string queryFiltro = "";
            conexion.Open();
            query = "SELECT *FROM Usuarios_Espera_y_Uso_Auto" + queryFiltro;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
        //___________________________________________________________________________________________________
        public List<String> obtenerCantidadAutos2()
        {
            var columnas = new List<String>();
            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='CARRO'";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                conexion.Close();
            }
            return columnas;
        }
        //___________________________________________________________________________________________________
        public SqlDataReader obtenerAutos2()
        {
            string query = "";
            string queryFiltro = "";
            conexion.Open();
            query = "SELECT *FROM CARRO" + queryFiltro;
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
        //___________________________________________________________________________________________________
        public bool obtenerAdmin(String usua, String contra)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LABSISINF;Initial Catalog=Registros_Plaxma;Integrated Security=True"))
            {
                conexion.Open();
                string query = "";
                query = "SELECT COUNT(*) FROM EMPLEADO WHERE Nombre_Emp = '" + usua + "' AND Contra= '" + contra + "'";
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
        public String Insertar_Uso(string empleado, string chofer, string automovil, string placas_automovil, string fecha_hora, string rutas_auto)
        {
            try
            {
                conexion.Open();
                String query = "EXEC Insertar_Uso " + empleado + ", '" + chofer + "', " + automovil + ", '" + placas_automovil + "', '" + fecha_hora + "', " + rutas_auto + ", ''";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                String mensaje = "Error al insertar datos";

                while (registros.Read())
                {
                    //Regresar mensaje del procedimiento almacenado
                    mensaje = registros.GetString(0);
                }
                return mensaje;
            }

            catch (SqlException ex)
            {
                return ex.Message;
                throw;

            }
            finally
            {
                conexion.Close();
            }

        }
        //___________________________________________________________________________________________________
        public String EliminarRegistro(String Empleado)
        {
            try
            {

                conexion.Open();
                string query = "DELETE FROM Usuarios_Espera_y_Uso_Auto WHERE Empleado = '" + Empleado + "'";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                conexion.Close();
            }
        }
        //___________________________________________________________________________________________________

        public List<String> obtenercantidadCarro()
        {
            var columnas = new List<String>();

            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='CARRO'";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                conexion.Close();
            }
            return columnas;
        }

        public List<String> obtenerBitacora()
        {
            var columnas = new List<String>();

            try
            {
                conexion.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='CARRO'";
                SqlCommand comando = new SqlCommand(query, conexion);
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
                conexion.Close();
            }
            return columnas;
        }

        public SqlDataReader obtenerCarro()
        {
            string query = "";
            conexion.Open();

            query = "SELECT *FROM CARRO";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }

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
    }
}
