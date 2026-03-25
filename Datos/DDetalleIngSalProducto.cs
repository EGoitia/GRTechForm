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
    public static class DDetalleIngSalProducto
    {
        /// <summary>
        /// Procedimiento para Buscar el Detalle del Traspaso
        /// </summary>
        /// <param name="CodTraspaso"></param>
        /// <returns>Lista Detalle Traspaso</returns>
        public static List<ODetalleIngSalProducto> DBuscarDIngSalProd(string CodIngSalProd)
        {
            List<ODetalleIngSalProducto> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDetIngSalProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodIngSalProd", CodIngSalProd);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleIngSalProducto>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordDetIngSalProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Cargamos datos del Detalle del IngSal de Producto
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos DetalleTraspaso</returns>
        private static ODetalleIngSalProducto FillDataRecordDetIngSalProd(IDataRecord miRecord)
        {
            ODetalleIngSalProducto dingsal = new ODetalleIngSalProducto();

            dingsal.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            dingsal.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            dingsal.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            dingsal.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            dingsal.Peso = miRecord.GetDecimal(miRecord.GetOrdinal("Peso"));
            dingsal.CantUnidMedida = miRecord.GetDecimal(miRecord.GetOrdinal("CantUnidMedida"));
            dingsal.PUnitario = miRecord.GetDecimal(miRecord.GetOrdinal("PUnitario"));
            dingsal.PTotal = miRecord.GetDecimal(miRecord.GetOrdinal("PTotal"));
            
            try
            {
                dingsal.Img = (byte[])miRecord["Img"];
            }
            catch
            { }

            return dingsal;
        }
    }
}
