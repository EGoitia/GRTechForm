using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleGasto
    {
        public static List<ODetalleGasto> DListarDetGasto(string @Codigo, string @Opcion)
        {
            List<ODetalleGasto> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarDetGasto", miCon);
                miCmd.Parameters.AddWithValue("@Codigo", Codigo);
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleGasto>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetGasto(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static ODetalleGasto FillDataRecordDetGasto(IDataRecord miRecord)
        {
            ODetalleGasto caj = new ODetalleGasto();

            caj.GastoID = miRecord.GetInt32(miRecord.GetOrdinal("GastoID"));
            caj.NomGasto = miRecord.GetString(miRecord.GetOrdinal("NomGasto"));
            caj.MontoGastoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoGastoBs"));
            caj.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return caj;
        }
    }
}
