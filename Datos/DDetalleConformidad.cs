using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleConformidad
    {
        /// <summary>
        /// Procedimiento para Buscar el Detalle Conformidad
        /// </summary>
        /// <param name="CodConformidad"></param>
        /// <returns>Lista Detalle Conformidad</returns>
        public static List<ODetalleConformidad> DBuscarDConf(string CodConformidad)
        {
            List<ODetalleConformidad> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetConf", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodConformidad", CodConformidad);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleConformidad>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetConf(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos del Detalle Conformidad
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetalleConformidad</returns>
        private static ODetalleConformidad FillDataRecordDetConf(IDataRecord miRecord)
        {
            ODetalleConformidad dconf = new ODetalleConformidad();

            dconf.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            dconf.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            dconf.NumNota = miRecord.GetString(miRecord.GetOrdinal("NumNota"));
            dconf.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            dconf.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            dconf.Peso = miRecord.GetDecimal(miRecord.GetOrdinal("Peso"));
            dconf.CantUnidMedida = miRecord.GetDecimal(miRecord.GetOrdinal("CantUnidMedida"));

            return dconf;
        }
    }
}
