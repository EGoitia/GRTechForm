using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleCierreCaja
    {
        public static List<ODetalleCierreCaja> DListarDetCierreCaja(string Opcion, int AperCajaID, OInmode inm)
        {
            List<ODetalleCierreCaja> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = null;

                if(Opcion == "Buscar")
                    miCmd = new SqlCommand("BuscarDetCierreCaja", miCon);
                else if(Opcion == "Procesar")
                    miCmd = new SqlCommand("ProcDetCierreCaja", miCon);
                else
                    miCmd = new SqlCommand("ModifDetCierreCaja", miCon);
                
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@AperturaCajaID", AperCajaID);

                if(Opcion == "Modificar")
                {
                    //Inmode
                    miCmd.Parameters.AddWithValue("@CodInmode", inm.CodInmode);
                    miCmd.Parameters.AddWithValue("@UsuarioID", inm.UsuarioID);
                    miCmd.Parameters.AddWithValue("@TipoInmode", inm.TipoInmode);
                    miCmd.Parameters.AddWithValue("@NomInmode", inm.NomInmode);
                    miCmd.Parameters.AddWithValue("@IPInmode", inm.IPInmode);
                    miCmd.Parameters.AddWithValue("@MacInmode", inm.MacInmode);
                    miCmd.Parameters.AddWithValue("@MaquinaInmode", inm.MaquinaInmode);
                    miCmd.Parameters.AddWithValue("@SistOperInmode", inm.SistOperInmode);
                    miCmd.Parameters.AddWithValue("@NavegInmode", inm.NavegInmode);
                    miCmd.Parameters.AddWithValue("@DetalleInmode", inm.DetalleInmode);
                }

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleCierreCaja>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordCieCaja(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }
    
        /// <summary>
        /// Cargamos datos de los Movimientos de Cajas
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Caja</returns>
        private static ODetalleCierreCaja FillDataRecordCieCaja(IDataRecord miRecord)
        {
            ODetalleCierreCaja mcaj = new ODetalleCierreCaja();
            try
            {
                mcaj.Descripcion = miRecord.GetString(miRecord.GetOrdinal("Descripcion"));
                mcaj.MontoTotalBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoTotalBs"));
                mcaj.PagadoBs = miRecord.GetDecimal(miRecord.GetOrdinal("PagadoBs"));
                mcaj.PagadoSus = miRecord.GetDecimal(miRecord.GetOrdinal("PagadoSus"));
            }
            catch (Exception)
            {   }

            return mcaj;
        }

    }
}
