using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DCuentasXCobrarPagar
    {
        public static List<OCuentasXCobrarPagar> DBuscarCuentaXCobPag(string opcion, string lugar, int desclugar, DateTime fecha)
        {
            List<OCuentasXCobrarPagar> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = null;
                
                if(opcion == "Cliente")
                    miCmd = new SqlCommand("BuscarCuentasXCobrar", miCon);
                else if(opcion == "Proveedor")
                    miCmd = new SqlCommand("BuscarCuentasXPagar", miCon);
                else //Personal
                    miCmd = new SqlCommand("BuscarCuentasXCobrarPer", miCon);

                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Lugar", lugar);
                miCmd.Parameters.AddWithValue("@DescLugar", desclugar);
                miCmd.Parameters.AddWithValue("@Fecha", fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCuentasXCobrarPagar>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataCuenCob(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OCuentasXCobrarPagar FillDataCuenCob(IDataRecord miRecord)
        {
            OCuentasXCobrarPagar alm = new OCuentasXCobrarPagar();

            alm.CliPerProvID = miRecord.GetInt32(miRecord.GetOrdinal("CliPerProvID"));
            alm.NomCliPerProv = miRecord.GetString(miRecord.GetOrdinal("NomCliPerProv"));
            alm.TotalSaldoBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalSaldoBs"));
            
            return alm;
        }
    }
}
