using System;
using System.Data;
using System.Data.SqlClient;
using Objetos;

namespace Datos
{
    public static class DAperturaCaja
    {
        public static bool DInsertModifApCaja(OAperturaCaja apcaja, DataTable inm)
        {
            bool result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                try
                {
                    SqlCommand miCmd = new SqlCommand("InsertModifApCaja", miCon);
                    miCmd.CommandType = CommandType.StoredProcedure;

                    if (apcaja.AperturaCajaID <= 0)
                        miCmd.Parameters.AddWithValue("@AperturaCajaID", DBNull.Value);
                    else
                        miCmd.Parameters.AddWithValue("@AperturaCajaID", apcaja.AperturaCajaID);

                    miCmd.Parameters.AddWithValue("@CajaID", apcaja.CajaID);
                    miCmd.Parameters.AddWithValue("@SucursalID", apcaja.SucursalID);
                    miCmd.Parameters.AddWithValue("@UsuarioID", apcaja.UsuarioID);
                    miCmd.Parameters.AddWithValue("@MontoIniBs", apcaja.Monto);
                    miCmd.Parameters.AddWithValue("@Observacion", apcaja.Observacion);
                    //Inmode
                    miCmd.Parameters.AddWithValue("@Inmode", inm);

                    IDataParameter ReturnValue;
                    ReturnValue = miCmd.CreateParameter();
                    ReturnValue.Direction = ParameterDirection.ReturnValue;
                    miCmd.Parameters.Add(ReturnValue);

                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToBoolean(ReturnValue.Value);
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

        public static int DInsertModifCierreCaja(OAperturaCaja apcaja, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCierreCaja", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@AperturaCajaID", apcaja.AperturaCajaID);
                //miCmd.Parameters.AddWithValue("@MontoFinalBs", apcaja.MontoFinalBs);
                //miCmd.Parameters.AddWithValue("@MontoFinalRealBs", apcaja.MontoFinalRealBs);
                //miCmd.Parameters.AddWithValue("@MontoFinalRealSus", apcaja.MontoFinalRealSus);
                //miCmd.Parameters.AddWithValue("@MontoFinalSus", apcaja.MontoFinalSus);
                //miCmd.Parameters.AddWithValue("@NomAdminResponsable", apcaja.NomAdminResponsable);
                //miCmd.Parameters.AddWithValue("@NomCajaResponsable", apcaja.NomCajaResponsable);
                //miCmd.Parameters.AddWithValue("@ObsCierre", apcaja.ObsCierre);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);;

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

      
    }
}
