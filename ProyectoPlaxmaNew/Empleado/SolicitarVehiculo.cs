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
    public partial class SolicitarVehiculo : Form
    {
        public SolicitarVehiculo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Menu_Principal formCerrarSesion = new ProyectoPlaxmaNew.Menu_Principal();
            formCerrarSesion.Show();
        }
    }
}
