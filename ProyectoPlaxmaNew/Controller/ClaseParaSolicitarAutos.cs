using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoPlaxmaNew.Controller
{
    class ClaseParaSolicitarAutos
    {
    }

    public class conexion
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");

        //___________________________________________________________________________________________________
        public List<String> obtenerCantidadAutos2()
        {
            var columnas = new List<String>();
            try
            {
                conn.Open();
                string query = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='CARRO'";
                SqlCommand comando = new SqlCommand(query, conn);
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
                conn.Close();
            }
            return columnas;
        }
        //___________________________________________________________________________________________________
        public SqlDataReader obtenerAutos2()
        {
            string query = "";
            string queryFiltro = "";
            conn.Open();
            query = "SELECT *FROM CARRO" + queryFiltro;
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader registros = comando.ExecuteReader();
            return registros;
        }
        //___________________________________________________________________________________________________
        public string ObtenerNombreConID_Empleado(string id)
        {
            conn.Open();
            string query = "";
            query = "SELECT Nombre_Emp FROM EMPLEADO WHERE ID_Empleado = '" + id + "'";
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader registros = comando.ExecuteReader();
            String respuesta = "Error al buscar";
            while (registros.Read())
            {
                respuesta = registros.GetString(0);
            }
            conn.Close();
            return respuesta;
        }
        //___________________________________________________________________________________________________
        public string ObtenerID_Empleado(string id)
        {
            conn.Open();
            string query = "";
            query = "SELECT ID_Empleado FROM EMPLEADO WHERE ID_Empleado = '" + id + "'";
            SqlCommand comando = new SqlCommand(query, conn);
            SqlDataReader registros = comando.ExecuteReader();
            String respuesta = "Error al buscar";
            while (registros.Read())
            {
                respuesta = registros.GetString(0);
            }
            conn.Close();
            return respuesta;
        }
        //___________________________________________________________________________________________________
        public string Insertar_Solicitud(string Solicitante, string NumeroEconomico, string Placas, string Reservaciones, string Destino, string FechaIn, string FechaFi, string Observaciones)
        {
            try
            {
                conn.Open();
                string query = "";
                query = "EXEC Insertar_Uso '" + Solicitante + "', '" + NumeroEconomico + "', '" + Placas + "', '" + Reservaciones + "', '" + Destino + "', '" + FechaIn + "', '" + FechaFi + "', '" + Observaciones + "',''";
                SqlCommand comando = new SqlCommand(query, conn);
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
                conn.Close();
            }
        }
        //___________________________________________________________________________________________________
        public void cerrarConexion()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {

            }
        }
        //___________________________________________________________________________________________________
    }
}
