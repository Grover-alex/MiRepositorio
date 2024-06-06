using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAPA_PRESENTACION
{
    public partial class frmEstudiantesMenu : Form
    {
        public frmEstudiantesMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = Fecha.Value.Date;

            // Definir el valor del turno según la selección del usuario
            string turno;
            if (0 == this.Turno.SelectedIndex)
            {
                turno = "08:00:00";
            }
            else if (1 == this.Turno.SelectedIndex)
            {
                turno = "11:15:00";
            }
            else if (2 == this.Turno.SelectedIndex)
            {
                turno = "15:00:00";
            }
            else
            {
                turno = "19:00:00";
            }
            // Combinar la fecha y la hora en un objeto DateTime
            DateTime fechaYHoraSeleccionada = fechaSeleccionada.Add(TimeSpan.Parse(turno));

            // Mostrar el resultado
            MessageBox.Show($"Fecha y hora seleccionada: {fechaYHoraSeleccionada}");
        }
    }
}
