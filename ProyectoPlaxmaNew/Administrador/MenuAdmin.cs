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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void BTN_Solicitudes_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProyectoPlaxmaNew.Administrador.Solicitudes formSolicitud = new ProyectoPlaxmaNew.Administrador.Solicitudes();
            formSolicitud.Show();
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
