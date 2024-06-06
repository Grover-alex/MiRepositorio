using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ACCESO
{
    public class CAcceso
    {
        private string sqlConexion = $"Data Source=PCLAB508;Initial Catalog=DB_LABS;Integrated Security=True;";

        public DataTable obtenerTabla(string comando)
        {
            DataTable miTabla = new DataTable();

            using (SqlConnection miConexion = new SqlConnection(sqlConexion))
            {
                SqlCommand miComando = new SqlCommand(comando, miConexion);

                try
                {
                    miConexion.Open();
                    using (SqlDataReader miLector = miComando.ExecuteReader())
                    {
                        miTabla.Load(miLector);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un Error: " + ex.Message);
                }
            }



            return miTabla;
        }

        public DataTable EjecutarProcedimientoAlmacenado(string nombreProcedimiento)
        {
            DataTable miTabla = new DataTable();

            using (SqlConnection miConexion = new SqlConnection(sqlConexion))
            {
                SqlCommand miComando = new SqlCommand(nombreProcedimiento, miConexion);
                miComando.CommandType = CommandType.StoredProcedure;

                try
                {
                    miConexion.Open();
                    using (SqlDataReader miLector = miComando.ExecuteReader())
                    {
                        miTabla.Load(miLector);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }

            return miTabla;
        }

        public void EjecutarProcedimientoAlmacenadoConParametros(string nombreProcedimiento, SqlParameter[] parametros)
        {
            using (SqlConnection miConexion = new SqlConnection(sqlConexion))
            {
                SqlCommand miComando = new SqlCommand(nombreProcedimiento, miConexion);
                miComando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                miComando.Parameters.AddRange(parametros);

                try
                {
                    miConexion.Open();
                    miComando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }
        }

        public DataTable EjecutarProcedimientoAlmacenadoConParametrosYretorno(string nombreProcedimiento, SqlParameter[] parametros)
        {
            // Crear una tabla para almacenar los resultados
            DataTable tablaResultados = new DataTable();

            // Establecer la conexión con la base de datos
            using (SqlConnection miConexion = new SqlConnection(sqlConexion))
            {
                // Crear el comando para ejecutar el procedimiento almacenado
                SqlCommand miComando = new SqlCommand(nombreProcedimiento, miConexion);
                miComando.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                miComando.Parameters.AddRange(parametros);

                try
                {
                    // Abrir la conexión
                    miConexion.Open();

                    // Crear un adaptador de datos para ejecutar el comando y llenar la tabla con los resultados
                    SqlDataAdapter adaptador = new SqlDataAdapter(miComando);
                    adaptador.Fill(tablaResultados);
                }
                catch (Exception ex)
                {
                    // Capturar y lanzar cualquier excepción ocurrida durante la ejecución
                    throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }

            // Devolver la tabla con los resultados
            return tablaResultados;
        }
    }
}
