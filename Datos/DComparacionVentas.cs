using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DComparacionVentas
    {
        public static List<OComparacionVentasCompras> DBuscarRepComparCompraVentas(string opcion, int anio, string tipocomven, int sucid, 
                                                                                   bool busqesp, string tipobusq, int id)
        {
            List<OComparacionVentasCompras> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = null;
                if(opcion == "Compras")
                    miCmd = new SqlCommand("BuscarComparacionCompras", miCon);
                else
                    miCmd = new SqlCommand("BuscarComparacionVentas", miCon);

                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Anio", anio);
                miCmd.Parameters.AddWithValue("@BusqEspecif", busqesp);
                
                if(opcion == "Compras")
                    miCmd.Parameters.AddWithValue("@TipoCompra", tipocomven);
                else
                    miCmd.Parameters.AddWithValue("@TipoVenta", tipocomven);

                miCmd.Parameters.AddWithValue("@TipoBusq", tipobusq);
                miCmd.Parameters.AddWithValue("@ID", id);

                if(sucid == -1)
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucursalID", sucid);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OComparacionVentasCompras>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordCompVenta(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OComparacionVentasCompras> DBuscarRepComparVentasVendedores(string _consulta)
        {
            List<OComparacionVentasCompras> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = null;
                miCmd = new SqlCommand(_consulta, miCon);
                miCmd.CommandType = CommandType.Text;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OComparacionVentasCompras>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordCompVenta(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OComparacionVentasCompras FillDataRecordCompVenta(IDataRecord miRecord)
        {
            OComparacionVentasCompras cven = new OComparacionVentasCompras();

            cven.NomMes = miRecord.GetInt32(miRecord.GetOrdinal("Mes"));
            cven.Monto = miRecord.GetDecimal(miRecord.GetOrdinal("Monto"));
            try
            {
                cven.Descripcion = miRecord.GetString(miRecord.GetOrdinal("Descripcion"));
            }
            catch (Exception)
            {
                cven.Descripcion = "";
            }
            
                        
            return cven;
        }
    }
}
