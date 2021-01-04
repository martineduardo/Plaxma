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
    public partial class DarAltaEmpleado : Form
    {
        Controller.conexion4 conn = new Controller.conexion4();
        public DarAltaEmpleado()
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

        private void BTN_Solicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.Solicitudes formSolicitud = new ProyectoPlaxmaNew.Administrador.Solicitudes();
            formSolicitud.Show();
        }

        private void BTN_AltaAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.DarAltaVehiculo formAltaV = new ProyectoPlaxmaNew.Administrador.DarAltaVehiculo();
            formAltaV.Show();
        }

        public void cargarTablaEmpleados()
        {
            var columnas = new List<String>();
            columnas = conn.ObtenerEmpleadosExistentes();
            TablaCarro.Columns.Clear();
            int numeroColumnas = columnas.Count;
            for (var i = 0; i < numeroColumnas; i++)
            {
                TablaCarro.Columns.Add(i.ToString(), columnas[i]);
            }
            try
            {
                SqlDataReader Doggo = conn.ObtenerEmpleados();
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

        private void DarAltaEmpleado_Load(object sender, EventArgs e)
        {
            cargarTablaEmpleados();
        }

        private void BTN_Insertar_Click(object sender, EventArgs e)
        {
            if (ID.Text.Equals("") || Nombre.Text.Equals("") || Direccion.Text.Equals("") 
                || Telefono.Text.Equals("") || Contra.Text.Equals(""))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                MessageBox.Show(conn.Insertar_Empleado((ID.Text), Nombre.Text, Direccion.Text, Telefono.Text, Contra.Text));
                this.Hide();
                ProyectoPlaxmaNew.Administrador.DarAltaEmpleado AltaEmp = new ProyectoPlaxmaNew.Administrador.DarAltaEmpleado();
                AltaEmp.Show();
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            conn.EliminarRegistroEmp(ID.Text);
            //MessageBox.Show("Registro Eliminado");
        }
    }
}
