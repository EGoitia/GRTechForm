using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DDetalleCompraProd
    {
        public static List<ODetalleCompraProd> DBuscarDCompraProd(string CodCompraProd)
        {
            List<ODetalleCompraProd> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDCompraProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodCompraProd", CodCompraProd);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ODetalleCompraProd>();

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

        private static ODetalleCompraProd FillDataRecordDetIngSalProd(IDataRecord miRecord)
        {
            ODetalleCompraProd dcomprod = new ODetalleCompraProd();

            dcomprod.ProductoID = miRecord.GetInt32(miRecord.GetOrdinal("ProductoID"));
            dcomprod.NomProd = miRecord.GetString(miRecord.GetOrdinal("NomProd"));
            dcomprod.Cantidad = miRecord.GetDecimal(miRecord.GetOrdinal("Cantidad"));
            dcomprod.CantidadRegul = miRecord.GetDecimal(miRecord.GetOrdinal("CantidadRegul"));
            dcomprod.UnidMedida = miRecord.GetString(miRecord.GetOrdinal("UnidMedida"));
            dcomprod.Peso = miRecord.GetDecimal(miRecord.GetOrdinal("Peso"));
            dcomprod.CantUnidMedida = miRecord.GetDecimal(miRecord.GetOrdinal("CantUnidMedida"));
            dcomprod.PUnitario = miRecord.GetDecimal(miRecord.GetOrdinal("PUnitario"));
            dcomprod.PTotal = miRecord.GetDecimal(miRecord.GetOrdinal("PTotal"));
            dcomprod.Incremento = miRecord.GetDecimal(miRecord.GetOrdinal("Incremento"));
            dcomprod.IncrementoCosto = miRecord.GetDecimal(miRecord.GetOrdinal("IncrementoCosto"));
            dcomprod.CostoTotal = miRecord.GetDecimal(miRecord.GetOrdinal("CostoTotal"));
            dcomprod.CostoUnitTotal = miRecord.GetDecimal(miRecord.GetOrdinal("CostoUnitTotal"));

            try
            {
                dcomprod.Img = (byte[])miRecord["Img"];
            }
            catch
            { }

            return dcomprod;
        }
    }
}
