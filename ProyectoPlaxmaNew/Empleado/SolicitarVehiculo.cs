using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ProyectoPlaxmaNew.Empleado
{
    public partial class SolicitarVehiculo : Form
    {

        Conexion.Conexion conn = new Conexion.Conexion();
        string x;

        public SolicitarVehiculo(string y)
        {
            InitializeComponent();
            x = y;
        }

        public void cargarAutos()
        {
            var columnas = new List<String>();
            columnas = conn.obtenerCantidadAutos2();
            TablaCarro.Columns.Clear();
            int numeroColumnas = columnas.Count;
            for (var i = 0; i < numeroColumnas; i++)
            {
                TablaCarro.Columns.Add(i.ToString(), columnas[i]);
            }
            try
            {
                SqlDataReader Doggo = conn.obtenerAutos2();
                int numeroFila = 0;
                int filas = Doggo.FieldCount;
                while (Doggo.Read())
                {
                    TablaCarro.Rows.Add();

                    for (int i = 0; i < numeroColumnas; i++)
                    {
                        TablaCarro[i, numeroFila].Value = Doggo[i].ToString();
                    }
                    numeroFila++;
                }
                conn.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarCARROS()
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");
            string query = "";
            query = "Select NumeroEconomico from CARRO";
            SqlCommand cnn = new SqlCommand(query, cn);
            cn.Open();
            SqlDataReader dr = cnn.ExecuteReader();
            while (dr.Read() == true)
            {
                cb.Items.Add(dr[0]);
            }
        }

        public void EstablecesPlacas(string Combo)
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOP-MUVK1MG1;Initial Catalog=Registros_Plaxma;Integrated Security=True");
            string query = "";
            query = "select Placas from CARRO where NumeroEconomico='" + Combo + "'";
            SqlCommand des = new SqlCommand(query, conn);
            conn.Open();
            //SqlDataReader xdr = des.ExecuteReader();
            var Respuesta = des.ExecuteScalar();
            txtReserv.Text = Respuesta.ToString();
            txtReserv.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Menu_Principal formCerrarSesion = new ProyectoPlaxmaNew.Menu_Principal();
            formCerrarSesion.Show();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var = cb.SelectedItem.ToString();
            EstablecesPlacas(var);
        }

        private void SolicitarVehiculo_Load(object sender, EventArgs e)
        {
            cargarAutos();
            CargarCARROS();
            label7.Text = conn.ObtenerNombreConID_Empleado(x);
            txtEmpleado.Text = conn.ObtenerID_Empleado(x);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtEmpleado.Text.Equals("") || txtNE.Text.Equals("") || cb.Text.Equals("") || txtReserv.Text.Equals("") || txtDestino.Text.Equals("") || txtFechaIn.Text.Equals("") || txtFechaFi.Text.Equals("") || txtObserv.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                if (txtEmpleado.Enabled)
                {
                    MessageBox.Show(conn.Insertar_Solicitud((txtEmpleado.Text), cb.Text, (txtReserv.Text), txtNE.Text, txtDestino.Text, txtFechaIn.Text, txtFechaFi.Text, txtObserv.Text));
                    this.Hide();
                    ProyectoPlaxmaNew.Empleado.SolicitarVehiculo Carro = new ProyectoPlaxmaNew.Empleado.SolicitarVehiculo(txtEmpleado.Text);
                    Carro.Show();
                }
                else
                {

                }
            }
        }
    }
}
