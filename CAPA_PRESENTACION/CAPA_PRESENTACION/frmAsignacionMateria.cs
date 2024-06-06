using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ACCESO;
using CAPA_NEGOCIO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAPA_PRESENTACION
{
    public partial class frmAsignacionMateria : Form
    {
        public frmAsignacionMateria()
        {
            InitializeComponent();
        }

        private void frmAsignacionMateria_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        CAsignarMateria miAsignarMateria = new CAsignarMateria();
        public void cargarDatos()
        {
            miAsignarMateria.LlenarComboBoxConModulos(this.comboBoxModulo);
            miAsignarMateria.LlenarComboBoxConDocentes(this.comboBoxDocente);
            miAsignarMateria.LlenarComboBoxConMateria(this.comboBoxMateria);
            miAsignarMateria.LlenarComboBoxConLaboratorios(this.comboBoxLaboratorio);
        }
        private void button1_Click(object sender, EventArgs e)
        {
                // Definir los parámetros para el procedimiento almacenado
                SqlParameter[] parametros = new SqlParameter[4];
                parametros[0] = new SqlParameter("@ID_DOCENTE", SqlDbType.Int);
                parametros[0].Value = (int)this.comboBoxDocente.SelectedValue;
                parametros[1] = new SqlParameter("@ID_MATERIA", SqlDbType.Int);
                parametros[1].Value = (int)this.comboBoxMateria.SelectedValue;
                parametros[2] = new SqlParameter("@ID_MODULO", SqlDbType.Int);
                parametros[2].Value = (int)this.comboBoxModulo.SelectedValue;

                // Definir el valor del turno según la selección del usuario
                string turno;
                if (this.rdbMañana.Checked)
                {
                    turno = "08:00:00";
                }
                else if (this.rdbMedioDia.Checked)
                {
                    turno = "11:15:00";
                }
                else if (this.rdbTarde.Checked)
                {
                    turno = "15:00:00";
                }
                else
                {
                    turno = "19:00:00";
                }
                parametros[3] = new SqlParameter("@TURNO", SqlDbType.Time);
                parametros[3].Value = TimeSpan.Parse(turno);

            int laboratorio = (int)this.comboBoxLaboratorio.SelectedValue;

            try
            {
                // Llamar a la función para asignar laboratorio
                miAsignarMateria.AsignarLaboratorio(parametros, laboratorio);
                // Si la función se ejecuta sin errores, se llega aquí
                MessageBox.Show("Asignación de laboratorio exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción durante la ejecución de la función, se llega aquí
                MessageBox.Show("Error al asignar laboratorio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
