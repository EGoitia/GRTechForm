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
    public static class DDetalleTraspaso
    {
        /// <summary>
        /// Procedimiento para Buscar el Detalle del Traspaso
        /// </summary>
        /// <param name="CodTraspaso"></param>
        /// <returns>Lista Detalle Traspaso</returns>
        public static List<ODetalleTraspaso> DBuscarDTraspaso(string CodTraspaso)
        {
            List<ODetalleTraspaso> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetTrasp", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodTraspaso", CodTraspaso);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleTraspaso>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetTrasp(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de los Detalle del Traspaso
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetalleTraspaso</returns>
        private static ODetalleTraspaso FillDataRecordDetTrasp(IDataRecord miRecord)
        {
            ODetalleTraspaso dtrasp = new ODetalleTraspaso();

            dtrasp.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            dtrasp.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            dtrasp.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            dtrasp.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            dtrasp.Peso = miRecord.GetDecimal(miRecord.GetOrdinal("Peso"));
            dtrasp.CantUnidMedida = miRecord.GetDecimal(miRecord.GetOrdinal("CantUnidMedida"));

            try
            {
                dtrasp.Img = (byte[])miRecord["Img"];
            }
            catch
            { }

            return dtrasp;
        }
    }
}
