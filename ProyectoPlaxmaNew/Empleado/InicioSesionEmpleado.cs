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
        public InicioSesionEmpleado()
        {
            InitializeComponent();
        }

        private void BTN_InicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Empleado.SolicitarVehiculo fromEmpleado = new ProyectoPlaxmaNew.Empleado.SolicitarVehiculo();
            fromEmpleado.Show();
        }
    }
}
