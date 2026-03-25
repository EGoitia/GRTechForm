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
    public static class DInmode
    {
        /// <summary>
        /// procedimiento para Listar los Registros
        /// </summary>
        /// <returns>Objeto Registros</returns>
        public static List<OInmode> DListarInmode(string @codinmode)
        {
            List<OInmode> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarInmode", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodInmode", codinmode);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OInmode>();
                        while (miLector.Read())
                            Temp.Add(FillDataRecordInmode(miLector));
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos de Inmode
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Inmode</returns>
        private static OInmode FillDataRecordInmode(IDataRecord miRecord)
        {
            OInmode inm = new  OInmode();

            inm.NomInmode = miRecord.GetString(miRecord.GetOrdinal("NomInmode"));
            //inm.UsuarioID = miRecord.GetInt32(miRecord.GetOrdinal("UsuarioID"));
            //inm.NomUsu = miRecord.GetString(miRecord.GetOrdinal("NomUsu"));
            inm.TipoInmode = miRecord.GetString(miRecord.GetOrdinal("TipoInmode"));
            inm.NomInmode = miRecord.GetString(miRecord.GetOrdinal("NomInmode"));
            inm.FechaInmode = miRecord.GetDateTime(miRecord.GetOrdinal("FechaInmode"));
            inm.IPInmode = miRecord.GetString(miRecord.GetOrdinal("IPInmode"));
            inm.MacInmode = miRecord.GetString(miRecord.GetOrdinal("MacInmode"));
            inm.MaquinaInmode = miRecord.GetString(miRecord.GetOrdinal("MaquinaInmode"));
            inm.SistOperInmode = miRecord.GetString(miRecord.GetOrdinal("SistOperInmode"));
            inm.NavegInmode = miRecord.GetString(miRecord.GetOrdinal("NavegInmode"));
            inm.DetalleInmode = miRecord.GetString(miRecord.GetOrdinal("DetalleInmode"));

            return inm;
        }
    }
}
