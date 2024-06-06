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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstudiates_Click(object sender, EventArgs e)
        {
            frmEstudiantesMenu miEstudiante = new frmEstudiantesMenu();
            miEstudiante.ShowDialog();
        }

        private void btnAuxiliares_Click(object sender, EventArgs e)
        {
            frmAuxiliaresMenu miAuxiliaresMenu = new frmAuxiliaresMenu();
            miAuxiliaresMenu.ShowDialog();
        }
    }
}
