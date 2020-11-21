using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlaxmaNew
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.InicioSesionAdmin formAdmin = new ProyectoPlaxmaNew.Administrador.InicioSesionAdmin();
            formAdmin.Show();
        }

        private void BTN_Empleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Empleado.InicioSesionEmpleado fromEmpleado = new ProyectoPlaxmaNew.Empleado.InicioSesionEmpleado();
            fromEmpleado.Show();
        }
    }
}
