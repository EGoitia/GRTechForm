using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Objetos;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DMovVentasXProd
    {
        public static List<OMovVentasXProd> DListarMovVenXProd(string opcion, int descopcion, string lugar, int desclugar,
                                                               DateTime fecini, DateTime fecfin, string ordenado)
        {
            List<OMovVentasXProd> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarMovVentaProd2", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", opcion);
                miCmd.Parameters.AddWithValue("@DescOpcion", descopcion);
                miCmd.Parameters.AddWithValue("@Lugar", lugar);
                miCmd.Parameters.AddWithValue("@DescLugar", desclugar);
                miCmd.Parameters.AddWithValue("@FecIni", fecini);
                miCmd.Parameters.AddWithValue("@FecFin", fecfin);
                miCmd.Parameters.AddWithValue("@Ordenado", ordenado);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OMovVentasXProd>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordVen(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OMovVentasXProd FillDataRecordVen(IDataRecord miRecord)
        {
            OMovVentasXProd mov = new OMovVentasXProd();

            mov.NumVenta = miRecord.GetString(miRecord.GetOrdinal("NumVenta"));
            mov.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            mov.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            mov.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            mov.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            mov.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            mov.PCosto = miRecord.GetDecimal(miRecord.GetOrdinal("PCosto"));
            mov.PVenta = miRecord.GetDecimal(miRecord.GetOrdinal("PUnitario"));
            mov.Dscto = miRecord.GetDecimal(miRecord.GetOrdinal("Dscto"));
            mov.CostoTot = mov.Cantidad * mov.PCosto;
            mov.VentaTot = mov.Cantidad * mov.PVenta;
            mov.Utilidad = mov.VentaTot - mov.Dscto - mov.CostoTot;
            
            return mov;
        }
    }
}
