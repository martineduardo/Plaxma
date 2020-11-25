using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlaxmaNew.Empleado
{
    public partial class InicioSesionEmpleado : Form
    {
        Conexion.Conexion conn = new Conexion.Conexion();
        public InicioSesionEmpleado()
        {
            InitializeComponent();
        }

        private void Personalizar() 
        {
            TxtUsuario.Visible = false;
        }

        private void BTN_InicioSesion_Click(object sender, EventArgs e)
        {
            String Usuario = "";
            String Contra = "";
            Usuario = TxtUsuario.Text;
            Contra = TxtContraseña.Text;

            if (TxtUsuario.Text == "" && TxtContraseña.Text == "")
            {
                MessageBox.Show("Llene todos los campos por favor", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (conn.obtenerEmpleado(Usuario, Contra) == false)
                {
                    MessageBox.Show("Usuario o contraseña erronea");
                    conn.cerrarConexion();
                }
                else
                {
                    this.Hide();
                    ProyectoPlaxmaNew.Empleado.SolicitarVehiculo fromEmpleado = new ProyectoPlaxmaNew.Empleado.SolicitarVehiculo(TxtUsuario.Text);
                    fromEmpleado.Show();
                }
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO") 
            {
                TxtUsuario.Text = "";
            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "USUARIO";
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "CONTRASEÑA")
            {
                TxtContraseña.Text = "";
                TxtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "CONTRASEÑA";
                TxtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Menu_Principal fromEmpleado = new ProyectoPlaxmaNew.Menu_Principal();
            fromEmpleado.Show();
        }
    }
}
