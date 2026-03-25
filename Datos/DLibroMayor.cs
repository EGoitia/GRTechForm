using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos
{
    public class DLibroMayor
    {
        /// <summary>
        /// Lista Libro Mayor
        /// </summary>
        /// <param name="fecini"></param>
        /// <param name="fecfin"></param>
        /// <param name="TipoLibro"></param>
        /// <returns></returns>
        public static List<OLibroMayor> DListarLibroMayor(DateTime @fecini, DateTime @fecfin, string @TipoLibro, string @TipoRep)
        {
            List<OLibroMayor> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarLibroMayorDet", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@FecIni", fecini);
                miCmd.Parameters.AddWithValue("@FecFin", fecfin);
                miCmd.Parameters.AddWithValue("@TipoLibro", TipoLibro);
                miCmd.Parameters.AddWithValue("@TipoRep", TipoRep);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OLibroMayor>();

                        while (miLector.Read())
                        {
                            if (TipoRep == "Resumido")
                                Temp.Add(FillDataRecordLibMay(miLector));
                            else
                                Temp.Add(FillDataRecordLibMayDet(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OLibroMayor FillDataRecordLibMay(IDataRecord miRecord)
        {
            OLibroMayor libmay = new OLibroMayor();

            libmay.NomCuentaCont = miRecord.GetString(miRecord.GetOrdinal("NomCuentaCont"));
            libmay.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            libmay.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            libmay.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));
            
            return libmay;
        }

        private static OLibroMayor FillDataRecordLibMayDet(IDataRecord miRecord)
        {
            OLibroMayor libmay = new OLibroMayor();

            libmay.NomCuentaCont = miRecord.GetString(miRecord.GetOrdinal("NomCuentaCont"));
            libmay.NomSuc = miRecord.GetString(miRecord.GetOrdinal("NomSuc"));
            libmay.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            libmay.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            libmay.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            libmay.MontoSus = miRecord.GetDecimal(miRecord.GetOrdinal("MontoSus"));

            return libmay;
        }
    }
}
