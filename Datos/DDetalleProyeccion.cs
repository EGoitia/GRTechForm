using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleProyeccion
    {
        public static List<ODetalleProyecciones> DBuscarDProy(int proyid, int sucid, int perid, DateTime fecini, DateTime fecfin)
        {
            List<ODetalleProyecciones> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetProy", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                
                if(proyid == -1)
                    miCmd.Parameters.AddWithValue("@ProyeccionID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ProyeccionID", proyid);

                if(sucid == -1)
                    miCmd.Parameters.AddWithValue("@SucID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucID", sucid);

                if(perid == -1)
                    miCmd.Parameters.AddWithValue("@PerID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@PerID", perid);

                miCmd.Parameters.AddWithValue("@FecIni", fecini);
                miCmd.Parameters.AddWithValue("@FecFin", fecfin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleProyecciones>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetProy(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }
   
        private static ODetalleProyecciones FillDataRecordDetProy(IDataRecord miRecord)
        {
            ODetalleProyecciones dtrasp = new ODetalleProyecciones();

            dtrasp.Dia = miRecord.GetString(miRecord.GetOrdinal("Dia"));
            dtrasp.ValorDia = miRecord.GetDecimal(miRecord.GetOrdinal("ValorDia"));
            dtrasp.Fecha = miRecord.GetString(miRecord.GetOrdinal("Fecha"));
            dtrasp.RealSucursal = miRecord.GetDecimal(miRecord.GetOrdinal("RealSucursal"));
            dtrasp.RealAcumulado = miRecord.GetDecimal(miRecord.GetOrdinal("RealAcumulado"));
            dtrasp.ProyectDiario = miRecord.GetDecimal(miRecord.GetOrdinal("ProyectDiario"));
            dtrasp.ProyectAcumulado = miRecord.GetDecimal(miRecord.GetOrdinal("ProyectAcumulado"));
            dtrasp.Diferencia = miRecord.GetDecimal(miRecord.GetOrdinal("Diferencia"));
            dtrasp.Porcentaje = miRecord.GetDecimal(miRecord.GetOrdinal("Porcentaje"));
            dtrasp.Contra = miRecord.GetDecimal(miRecord.GetOrdinal("Contra"));
            dtrasp.Favor = miRecord.GetDecimal(miRecord.GetOrdinal("Favor"));
            dtrasp.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            dtrasp.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return dtrasp;
        }
    }
}
