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
    public partial class DarAltaVehiculo : Form
    {
        public DarAltaVehiculo()
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

        private void BTN_AltaEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.DarAltaEmpleado formAltaE = new ProyectoPlaxmaNew.Administrador.DarAltaEmpleado();
            formAltaE.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
