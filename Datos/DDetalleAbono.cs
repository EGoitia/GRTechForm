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
    public static class DDetalleAbono
    {
        public static List<ODetalleAbono> DBuscarDAbono(string CodAbono, string TipoAbono)
        {
            List<ODetalleAbono> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetAbono", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodAbono", CodAbono);
                miCmd.Parameters.AddWithValue("@TipoAbono", TipoAbono);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleAbono>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetAbono(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos del Detalle del Abono al Proveedor
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetalleAbono</returns>
        private static ODetalleAbono FillDataRecordDetAbono(IDataRecord miRecord)
        {
            ODetalleAbono daprov = new ODetalleAbono();

            daprov.CodAbono = miRecord.GetString(miRecord.GetOrdinal("CodAbono"));
            daprov.CodKardex = miRecord.GetString(miRecord.GetOrdinal("CodKardex"));
            daprov.CodCompraVentaGasto = miRecord.GetString(miRecord.GetOrdinal("CodCompraVentaGasto"));
            daprov.NumNota = miRecord.GetString(miRecord.GetOrdinal("NumNota"));
            daprov.NomSucCaj = miRecord.GetString(miRecord.GetOrdinal("NomSucCaj"));
            daprov.TotalBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalBs"));
            daprov.TotalDsctoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalDsctoBs"));
            daprov.TotalPagadoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalPagadoBs"));
            daprov.TotalSaldoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalSaldoBs"));
            daprov.DsctoBs = miRecord.GetDecimal(miRecord.GetOrdinal("DsctoBs"));
            daprov.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            daprov.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return daprov;
        }
    }
}
