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
    public static class DProyecciones
    {
        /// <summary>
        ///  Procedimiento para Insertar o Modificar Datos de Proyecciones
        /// </summary>
        /// <param name="proy"></param>
        /// <param name="dproy"></param>
        /// <param name="inm"></param>
        /// <returns></returns>
        public static int DInsertModifProy(OProyecciones proy, DataTable inm)
        {
            int result;
            
            try
            {
                using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
                {
                    SqlCommand miCmd = new SqlCommand("InsertModifProy", miCon);
                    miCmd.CommandType = CommandType.StoredProcedure;

                    if (proy.ProyeccionID == -1)
                        miCmd.Parameters.AddWithValue("@ProyeccionID", DBNull.Value);
                    else
                        miCmd.Parameters.AddWithValue("@ProyeccionID", proy.ProyeccionID);

                    miCmd.Parameters.AddWithValue("@NomProyeccion", proy.NomProyeccion);
                    miCmd.Parameters.AddWithValue("@SucursalID", proy.SucursalID);
                    miCmd.Parameters.AddWithValue("@VendedorID", proy.VendedorID);
                    miCmd.Parameters.AddWithValue("@Proyectado", proy.MontoProyectado);
                    miCmd.Parameters.AddWithValue("@DiasLaborales", proy.DiasLaborales);
                    miCmd.Parameters.AddWithValue("@Ejecutado", proy.MontoEjecutado);
                    miCmd.Parameters.AddWithValue("@PorcentAvance", proy.PorcentAvance);
                    miCmd.Parameters.AddWithValue("@FecIni", proy.FechaIni);
                    miCmd.Parameters.AddWithValue("@FecFin", proy.FechaFin);
                    //Detalle Proyeccion
                    miCmd.Parameters.AddWithValue("@DProy", proy.DetalleProyeccionDT);
                    //Inmode
                    miCmd.Parameters.AddWithValue("@Inmode", inm);

                    IDataParameter ReturnValue;
                    ReturnValue = miCmd.CreateParameter();
                    ReturnValue.Direction = ParameterDirection.ReturnValue;
                    miCmd.Parameters.Add(ReturnValue);

                    miCon.Open();
                    miCmd.ExecuteNonQuery();
                    result = Convert.ToInt32(ReturnValue.Value);
                    miCon.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

    }
}
