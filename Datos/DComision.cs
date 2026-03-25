using Objetos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class DComision
    {
        public static int DInsertModifComision(OComision com, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifComision", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@PersonalID", com.PersonalID);
                miCmd.Parameters.AddWithValue("@Comision", com.Comision);
                miCmd.Parameters.AddWithValue("@TotBolsas", com.TotBolsas);
                miCmd.Parameters.AddWithValue("@TotMetros", com.TotMetros);
                miCmd.Parameters.AddWithValue("@TotPiezas", com.TotPiezas);
                miCmd.Parameters.AddWithValue("@TotVentas", com.TotVentas);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    miCon.Close();
                }
            }
            return result;
        }

        public static OComision DListarComision(int perid)
        {
            OComision Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarComision", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@PersonalID", perid);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new OComision();

                        if (miLector.Read())
                            Temp = FillDataRecordCom(miLector);
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OComision FillDataRecordCom(IDataRecord miRecord)
        {
            OComision com = new OComision();

            com.PersonalID = miRecord.GetInt32(miRecord.GetOrdinal("PersonalID"));
            com.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            com.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            com.Comision = miRecord.GetString(miRecord.GetOrdinal("Comision"));
            com.TotBolsas = miRecord.GetDecimal(miRecord.GetOrdinal("TotBolsas"));
            com.TotMetros = miRecord.GetDecimal(miRecord.GetOrdinal("TotMetros"));
            com.TotPiezas = miRecord.GetDecimal(miRecord.GetOrdinal("TotPiezas"));
            com.TotVentas = miRecord.GetDecimal(miRecord.GetOrdinal("TotVentas"));

            return com;
        }
    }
}
