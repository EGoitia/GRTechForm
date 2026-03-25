using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleAsistencia
    {
        public static List<ODetalleAsistencia> DBuscarDAsis(string CodAsistencia)
        {
            List<ODetalleAsistencia> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetAsis", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodAsistencia", CodAsistencia);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleAsistencia>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetAsis(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos del Detalle Asistencia
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetalleAsistencia</returns>
        private static ODetalleAsistencia FillDataRecordDetAsis(IDataRecord miRecord)
        {
            ODetalleAsistencia dasis = new ODetalleAsistencia();

            dasis.Horario = miRecord.GetString(miRecord.GetOrdinal("Horario"));
            dasis.HrEntrada = miRecord.GetDateTime(miRecord.GetOrdinal("HrEntrada"));
            dasis.HrSalida = miRecord.GetDateTime(miRecord.GetOrdinal("HrSalida"));
            dasis.MarcEntrada = miRecord.GetDateTime(miRecord.GetOrdinal("MarcEntrada"));
            dasis.MarcSalida = miRecord.GetDateTime(miRecord.GetOrdinal("MarcSalida"));
            dasis.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            dasis.SalioTemp = miRecord.GetDecimal(miRecord.GetOrdinal("SalioTemp"));
            dasis.Tardanza = miRecord.GetDecimal(miRecord.GetOrdinal("Tardanza"));
            dasis.HrsExtras = miRecord.GetDecimal(miRecord.GetOrdinal("HrExtras"));
            dasis.HrsPermiso = miRecord.GetDecimal(miRecord.GetOrdinal("HrsPermiso"));
            dasis.HrsFalta = miRecord.GetDecimal(miRecord.GetOrdinal("HrsFalta"));
            dasis.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            dasis.Falta = miRecord.GetBoolean(miRecord.GetOrdinal("Falta"));
            dasis.Vacacion = miRecord.GetBoolean(miRecord.GetOrdinal("Vacacion"));
            dasis.Feriado = miRecord.GetBoolean(miRecord.GetOrdinal("Feriado"));
            dasis.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return dasis;
        }
    }
}
