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
    public static class DDetalleVenta
    {
        /// <summary>
        /// Procedimiento para Buscar el Detalle de Venta
        /// </summary>
        /// <param name="CodVen"></param>
        /// <returns>Lista Detalle Venta</returns>
        public static List<ODetalleVenta> DBuscarDVen(string @CodVenta)
        {
            List<ODetalleVenta> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetVen", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodVenta", CodVenta);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleVenta>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetVen(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos del Detalle de Venta
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetalleVenta</returns>
        private static ODetalleVenta FillDataRecordDetVen(IDataRecord miRecord)
        {
            ODetalleVenta dingsal = new ODetalleVenta();

            dingsal.CodKardexProd = miRecord.GetString(miRecord.GetOrdinal("CodKardexProd"));
            dingsal.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            dingsal.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            dingsal.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            dingsal.Peso = miRecord.GetDecimal(miRecord.GetOrdinal("Peso"));
            dingsal.CantUnidMedida = miRecord.GetDecimal(miRecord.GetOrdinal("CantUnidMedida"));
            dingsal.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            dingsal.PUnitario = miRecord.GetDecimal(miRecord.GetOrdinal("PUnitario"));
            dingsal.PTotal = miRecord.GetDecimal(miRecord.GetOrdinal("PTotal"));
            dingsal.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            try
            {
                dingsal.Img = (byte[])miRecord["Img"];
            }
            catch
            { }

            return dingsal;
        }
    }
}
