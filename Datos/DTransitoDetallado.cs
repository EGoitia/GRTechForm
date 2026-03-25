using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DTransitoDetallado
    {
        public static List<OTransitoDetallado> DBuscarTransitoDetallado(string @Opcion, int @DescOpcion, string @Lugar, int @DescLugar, DateTime @FecIni, DateTime @FecFin)
        {
            List<OTransitoDetallado> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarSalTransitoFisValorDetallado", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@DescOpcion", DescOpcion);
                miCmd.Parameters.AddWithValue("@Lugar", Lugar);
                miCmd.Parameters.AddWithValue("@DescLugar", DescLugar);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OTransitoDetallado>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordTranDet(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OTransitoDetallado FillDataRecordTranDet(IDataRecord miRecord)
        {
            OTransitoDetallado trandet = new OTransitoDetallado();

            trandet.CodCompra = miRecord.GetString(miRecord.GetOrdinal("CodCompraProd"));
            trandet.NumCompra = miRecord.GetString(miRecord.GetOrdinal("NumCompraProd"));
            trandet.FechaCompra = miRecord.GetDateTime(miRecord.GetOrdinal("FechaCompra"));
            trandet.DetalleCompra = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            trandet.NomCaja = miRecord.GetString(miRecord.GetOrdinal("NomCaja"));
            trandet.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            trandet.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            trandet.CantidadCompra = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            trandet.PCostoCompra = miRecord.GetDecimal(miRecord.GetOrdinal("PUnitario"));
            trandet.PTotalCompra = miRecord.GetDecimal(miRecord.GetOrdinal("PTotal"));
            trandet.FechaIngreso = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            trandet.NumIngreso = miRecord.GetString(miRecord.GetOrdinal("NumIngSalProducto"));
            trandet.DetalleIngreso = miRecord.GetString(miRecord.GetOrdinal("Concepto"));
            trandet.Almacen = miRecord.GetString(miRecord.GetOrdinal("NomAlmacen"));
            trandet.CantidadIngreso = miRecord.GetDecimal(miRecord.GetOrdinal("CantidadIng"));
            trandet.CantidadTransito = miRecord.GetDecimal(miRecord.GetOrdinal("Transito"));
            trandet.TransitoValorado = miRecord.GetDecimal(miRecord.GetOrdinal("TransitoValorado"));
            
            trandet.TotTransitoValor = miRecord.GetDecimal(miRecord.GetOrdinal("TotTransitoValor"));
            trandet.TotCompra = miRecord.GetDecimal(miRecord.GetOrdinal("TotCompra"));
            trandet.TotTransito = miRecord.GetDecimal(miRecord.GetOrdinal("TotTransito"));
            trandet.TotIngresado = miRecord.GetDecimal(miRecord.GetOrdinal("TotIngresado"));
            
            return trandet;
        }
    }
}
