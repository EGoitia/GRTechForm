using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleCotizacion
    {
        /// <summary>
        /// Procedimiento para Buscar el Detalle de la Cotizacion
        /// </summary>
        /// <param name="CodCotizacion"></param>
        /// <returns></returns>
        public static List<ODetalleCotizacion> DBuscarDCot(string CodCotizacion)
        {
            List<ODetalleCotizacion> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetCot", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodCotizacion", CodCotizacion);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleCotizacion>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetCot(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para llenar los datos en el Objeto DetalleCotizacion
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>ODetalleCotizacion</returns>
        private static ODetalleCotizacion FillDataRecordDetCot(IDataRecord miRecord)
        {
            ODetalleCotizacion dcot = new ODetalleCotizacion();

            dcot.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            dcot.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            dcot.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            dcot.PUnitario = miRecord.GetDecimal(miRecord.GetOrdinal("PUnitario"));
            dcot.PTotal = miRecord.GetDecimal(miRecord.GetOrdinal("PTotal"));
            dcot.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            
            return dcot;
        }
    }
}
