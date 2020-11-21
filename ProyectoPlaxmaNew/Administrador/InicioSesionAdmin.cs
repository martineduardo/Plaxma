using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPlaxmaNew.Administrador
{
    public partial class InicioSesionAdmin : Form
    {
        public InicioSesionAdmin()
        {
            InitializeComponent();
        }

        private void BTN_InicioSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.MenuAdmin formMenuA = new ProyectoPlaxmaNew.Administrador.MenuAdmin();
            formMenuA.Show();
        }
    }
}
