using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DIngrEgre
    {

        public static string DInsertModifIngrEgre(OIngresoEgreso rec, DataTable inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifIngrEgre", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if (rec.CodIngrEgre == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodIngrEgre", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodIngrEgre", rec.CodIngrEgre);

                miCmd.Parameters.AddWithValue("@Concepto", rec.Concepto);
                miCmd.Parameters.AddWithValue("@Detalle", rec.Detalle);
                miCmd.Parameters.AddWithValue("@TipoIngrEgre", rec.TipoIngrEgre);
                miCmd.Parameters.AddWithValue("@CajaID", rec.CajaID);
                miCmd.Parameters.AddWithValue("@SucursalID", rec.SucursalID);
                miCmd.Parameters.AddWithValue("@UsuarioID", OConexionGlobal.UsuarioID);
                miCmd.Parameters.AddWithValue("@Cuenta_Ingreso_EgresoID", rec.Cuenta_Ingreso_EgresoID);
                miCmd.Parameters.AddWithValue("@VariosPersonActivID", rec.VariosPersonActivID);
                miCmd.Parameters.AddWithValue("@MontoBs", rec.Monto);
                miCmd.Parameters.AddWithValue("@TC", rec.TC);
                //Tipo Pago
                miCmd.Parameters.AddWithValue("@DetallePago", rec.TipoPagoDT);
                //Recibo
                miCmd.Parameters.AddWithValue("@Recibo", rec.ReciboDT);
                //Factura
                miCmd.Parameters.AddWithValue("@Factura", rec.FacturaDT);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);
                
                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    miCon.Close();
                }
            }
            return result;
        }

        public static int DInsertReciboDevolPagAnticip(OIngresoEgreso rec, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertReciboDevolPagAnticip", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                
                miCmd.Parameters.AddWithValue("@CodVenta", rec.CodIngrEgre);
                miCmd.Parameters.AddWithValue("@Concepto", rec.Concepto);
                miCmd.Parameters.AddWithValue("@Detalle", rec.Detalle);
                miCmd.Parameters.AddWithValue("@TC", rec.TC);
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
