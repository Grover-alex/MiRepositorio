using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class frmAuxiliaresMenu : Form
    {
        public frmAuxiliaresMenu()
        {
            InitializeComponent();
        }

        private void btnAsignacion_Click(object sender, EventArgs e)
        {
            frmAsignacionMateria miAsignacionMateria = new frmAsignacionMateria();
            miAsignacionMateria.ShowDialog();
        }

        private void frmAuxiliaresMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
