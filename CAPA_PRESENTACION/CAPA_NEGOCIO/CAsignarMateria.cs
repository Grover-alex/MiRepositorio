using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ACCESO;

namespace CAPA_NEGOCIO
{
    public class CAsignarMateria
    {
        CAcceso miAcceso = new CAcceso();
        public void LlenarComboBoxConModulos(ComboBox comboBox)
        {
            try
            {
                // Obtener la tabla de módulos del procedimiento almacenado
                DataTable tablaModulos = miAcceso.EjecutarProcedimientoAlmacenado("PAMostrarModulos");

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBox.Items.Clear();

                // Asignar el origen de datos al ComboBox y especificar qué mostrar y qué valor usar
                comboBox.DataSource = tablaModulos;
                comboBox.DisplayMember = "NOMBRE"; // Mostrar el nombre del docente
                comboBox.ValueMember = "ID_MODULO"; // Almacenar el ID_DOCENTE asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox con los módulos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarComboBoxConDocentes(ComboBox comboBox)
        {
            try
            {
                // Obtener la tabla de docentes del procedimiento almacenado
                DataTable tablaDocentes = miAcceso.EjecutarProcedimientoAlmacenado("PAMostrarDocentes");

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBox.Items.Clear();

                // Asignar el origen de datos al ComboBox y especificar qué mostrar y qué valor usar
                comboBox.DataSource = tablaDocentes;
                comboBox.DisplayMember = "NOMBRE"; // Mostrar el nombre del docente
                comboBox.ValueMember = "ID_DOCENTE"; // Almacenar el ID_DOCENTE asociado

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox con los docentes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarComboBoxConMateria(ComboBox comboBox)
        {
            try
            {
                // Obtener la tabla de módulos del procedimiento almacenado
                DataTable tablaMateria = miAcceso.EjecutarProcedimientoAlmacenado("PAMostrarMaterias");

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBox.Items.Clear();

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBox.Items.Clear();

                // Asignar el origen de datos al ComboBox y especificar qué mostrar y qué valor usar
                comboBox.DataSource = tablaMateria;
                comboBox.DisplayMember = "NOMBRE"; // Mostrar el nombre del docente
                comboBox.ValueMember = "ID_MATERIA"; // Almacenar el ID_DOCENTE asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox con los módulos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenarComboBoxConLaboratorios(ComboBox comboBox)
        {
            try
            {
                // Obtener la tabla de módulos del procedimiento almacenado
                DataTable tablalaboratorios = miAcceso.EjecutarProcedimientoAlmacenado("PAMostrarLaboratorios");

                // Limpiar el ComboBox antes de agregar los nuevos elementos
                comboBox.Items.Clear();

                // Asignar el origen de datos al ComboBox y especificar qué mostrar y qué valor usar
                comboBox.DataSource = tablalaboratorios;
                comboBox.DisplayMember = "NOMBRE"; // Mostrar el nombre del docente
                comboBox.ValueMember = "ID_LABORATORIO"; // Almacenar el ID_DOCENTE asociado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox con los módulos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AsignarLaboratorio(SqlParameter[] misParametros, int laboratorio)
        {
            // Guardar la asignación
            miAcceso.EjecutarProcedimientoAlmacenadoConParametros("PAGuardarImparte", misParametros);

            // Obtener el valor máximo del ID de IMPARTE
            DataTable resultTable = miAcceso.EjecutarProcedimientoAlmacenado("PAGetMaxIDImparte");
            if (resultTable.Rows.Count > 0)
            {
                int maxIDImparte = Convert.ToInt32(resultTable.Rows[0]["MaximoID"]);

                // Crear los parámetros para el procedimiento almacenado
                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@ID_IMPARTE", SqlDbType.Int);
                parametros[0].Value = maxIDImparte;
                parametros[1] = new SqlParameter("@ID_LABORATORIO", SqlDbType.Int);
                parametros[1].Value = laboratorio;

                // Llamar al procedimiento almacenado para crear las asignaciones
                miAcceso.EjecutarProcedimientoAlmacenadoConParametros("CrearAsignacionesPorIDIMPARTE01", parametros);
            }
            else
            {
                throw new Exception("No se encontró el ID_IMPARTE máximo.");
            }
        }
    }
}
