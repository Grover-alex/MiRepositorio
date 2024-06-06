using CAPA_ACCESO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_NEGOCIO
{
    public class CEstudiante
    {
        CAcceso miAcceso = new CAcceso();
        public void ConfirmarLaboratorio(DataTable mitabla,DateTime fecha, int id_Laboratorio)
        {
            // Definir los parámetros para el procedimiento almacenado
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@FECHA", SqlDbType.DateTime);
            parametros[0].Value = fecha;
            parametros[1] = new SqlParameter("@ID_LABORATORIO", SqlDbType.Int);
            parametros[1].Value = id_Laboratorio;
            mitabla = miAcceso.EjecutarProcedimientoAlmacenadoConParametrosYretorno("ObtenerAsignacionesPorFechaYLaboratorio",parametros);
        }
    }
}
