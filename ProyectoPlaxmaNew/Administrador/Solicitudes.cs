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
    public partial class Solicitudes : Form
    {
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
    }
}
