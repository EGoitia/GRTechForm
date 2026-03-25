using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DCotizacion
    {
        public static string DInsertModifCotizacion(OCotizacion cotiz, DataTable inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifCotizacion", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if(cotiz.CodCotizacion == "-1")
                    miCmd.Parameters.AddWithValue("@CodCotizacion", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodCotizacion", cotiz.CodCotizacion);

                miCmd.Parameters.AddWithValue("@ClienteID", cotiz.ClienteID);
                miCmd.Parameters.AddWithValue("@VendedorID", cotiz.VendedorID);
                miCmd.Parameters.AddWithValue("@AlmacenID", cotiz.AlmacenID);
                miCmd.Parameters.AddWithValue("@CondComID", cotiz.CondComID);
                miCmd.Parameters.AddWithValue("@TC", cotiz.TC);
                miCmd.Parameters.AddWithValue("@Monto", cotiz.Monto);
                miCmd.Parameters.AddWithValue("@Dscto", cotiz.Dscto);
                miCmd.Parameters.AddWithValue("@DiasValidez", cotiz.DiasValidez);
                miCmd.Parameters.AddWithValue("@Referencia", cotiz.Referencia);
                miCmd.Parameters.AddWithValue("@Detalle", cotiz.Detalle);
                //Detalle Cotizacion
                miCmd.Parameters.AddWithValue("@DetalleCotizacion", cotiz.DetalleCotizacionDT);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
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
