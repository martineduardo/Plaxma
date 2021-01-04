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

namespace ProyectoPlaxmaNew.Administrador
{
    public partial class Solicitudes : Form
    {
        Controller.conexion2 conn = new Controller.conexion2();

        public Solicitudes()
        {
            InitializeComponent();
        }

        private void BTN_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Menu_Principal formCerrarSesion = new ProyectoPlaxmaNew.Menu_Principal();
            formCerrarSesion.Show();
        }

        private void BTN_Bitacora_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.Bitacora formBitacora = new ProyectoPlaxmaNew.Administrador.Bitacora();
            formBitacora.Show();
        }

        private void BTN_AltaAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.DarAltaVehiculo formAltaV = new ProyectoPlaxmaNew.Administrador.DarAltaVehiculo();
            formAltaV.Show();
        }

        private void BTN_AltaEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.DarAltaEmpleado formAltaE = new ProyectoPlaxmaNew.Administrador.DarAltaEmpleado();
            formAltaE.Show();
        }

        public void cargarSolicitudesEmpleados()
        {
            var columnas = new List<String>();
            columnas = conn.ObtenerSolicitudesEmpleados();
            TablaCarro.Columns.Clear();
            int numeroColumnas = columnas.Count;
            for (var i = 0; i < numeroColumnas; i++)
            {
                TablaCarro.Columns.Add(i.ToString(), columnas[i]);
            }
            try
            {
                SqlDataReader Doggo = conn.ObtenerSolitudesEmp();
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

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            cargarSolicitudesEmpleados();
        }
    }
}
