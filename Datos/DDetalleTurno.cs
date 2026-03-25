using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleTurno
    {
        public static List<ODetalleTurno> DBuscarDetTurno(int TurnoID)
        {
            List<ODetalleTurno> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetTurno", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if(TurnoID == -1)
                    miCmd.Parameters.AddWithValue("@TurnoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@TurnoID", TurnoID);

                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleTurno>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetTurno(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }
       
        private static ODetalleTurno FillDataRecordDetTurno(IDataRecord miRecord)
        {
            ODetalleTurno dturno = new ODetalleTurno();

            dturno.HorarioID = miRecord.GetInt32(miRecord.GetOrdinal("HorarioID"));
            dturno.NomDia = miRecord.GetString(miRecord.GetOrdinal("NomDia"));
            dturno.NomHorario = miRecord.GetString(miRecord.GetOrdinal("NomHorario"));
            dturno.HrEntrada = miRecord.GetDateTime(miRecord.GetOrdinal("HrEntrada"));
            dturno.HrSalida = miRecord.GetDateTime(miRecord.GetOrdinal("HrSalida"));
            dturno.InicioEntr = miRecord.GetDateTime(miRecord.GetOrdinal("InicioEntr"));
            dturno.FinEntr = miRecord.GetDateTime(miRecord.GetOrdinal("FinEntr"));
            dturno.InicioSal = miRecord.GetDateTime(miRecord.GetOrdinal("InicioSal"));
            dturno.FinSal = miRecord.GetDateTime(miRecord.GetOrdinal("FinSal"));
            dturno.MinTolerEnt = miRecord.GetInt32(miRecord.GetOrdinal("MinTolerEnt"));
            dturno.MinTolerSal = miRecord.GetInt32(miRecord.GetOrdinal("MinTolerSal"));
            dturno.ValorDiaTrab = miRecord.GetInt32(miRecord.GetOrdinal("ValorDiaTrab"));
            dturno.EstadoDTurno = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return dturno;
        }
    }
}
