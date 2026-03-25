using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Objetos;

namespace Datos
{
    public static class DProducto
    {
        private static Manejador man = null;

        public static DataSet DVerifInsertProdDT(DataTable dt, DataTable dtinm)
        {
            man = new Manejador();
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@LPProd", dt));
            LParam.Add(new Parametros("@Inmode", dtinm));

            return man.ListadoDS("VerifInsertProd", LParam);
        }

        public static int DInsertarModifProd(OProducto prod, DataTable inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (prod.ProductoID == -1)
                    miCmd.Parameters.AddWithValue("@ProductoID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@ProductoID", prod.ProductoID);
                
                miCmd.Parameters.AddWithValue("@SubRubroID", prod.SubRubroID);
                miCmd.Parameters.AddWithValue("@RubroID", prod.RubroID);
                miCmd.Parameters.AddWithValue("@MarcaID", prod.MarcaID);
                miCmd.Parameters.AddWithValue("@ClasificacionID", prod.ClasificacionID);
                miCmd.Parameters.AddWithValue("@CodFabrica", prod.CodFabrica);
                miCmd.Parameters.AddWithValue("@SKU", prod.SKU);
                miCmd.Parameters.AddWithValue("@NomProd", prod.NomProd);
                miCmd.Parameters.AddWithValue("@Descripcion", prod.Descripcion);
                miCmd.Parameters.AddWithValue("@UnidMedida", prod.UnidMedida);
                miCmd.Parameters.AddWithValue("@CantUnidMedida", prod.CantUnidMedida);
                miCmd.Parameters.AddWithValue("@Moneda", prod.Moneda);
                miCmd.Parameters.AddWithValue("@StockMax", prod.StockMax);
                miCmd.Parameters.AddWithValue("@StockMin", prod.StockMin);
                miCmd.Parameters.AddWithValue("@PedidMin", prod.PedidMin);
                miCmd.Parameters.AddWithValue("@ValorComision", prod.ValorComision);
                miCmd.Parameters.AddWithValue("@Peso", prod.Peso);
                miCmd.Parameters.AddWithValue("@ModifPrec", prod.ModifPrec);
                miCmd.Parameters.AddWithValue("@FueraLinea", prod.FueraLinea);
                miCmd.Parameters.AddWithValue("@Vencimiento", prod.Vencimiento);
                miCmd.Parameters.AddWithValue("@Serial", prod.Serial);
                miCmd.Parameters.AddWithValue("@Comodin", prod.Comodin);
                miCmd.Parameters.AddWithValue("@PCosto", prod.PCosto);
                miCmd.Parameters.AddWithValue("@PVentaMenor", prod.PVentaMenor);
                miCmd.Parameters.AddWithValue("@PVentaMayor", prod.PVentaMayor);
                //Imagen
                miCmd.Parameters.AddWithValue("@Img", prod.Img);
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
                catch(SqlException ex)
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

        public static int DInsertModifProdLocal(DataTable dtprod)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexionLocal))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifProd_Local", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@LstProd", dtprod);

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

        public static bool DModifPreciosProd(int tipocliid, DataTable LProd, DataTable inm)
        {
            bool result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ModifPreciosProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@TipoClienteId", tipocliid);
                miCmd.Parameters.AddWithValue("@ListaProd", LProd);
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

        public static bool ExisteCodFab(string codfab)
        {
            DataTable dt = DListarPersonalizado.ConsultarDT("select 1 from Producto where CodFabrica='" + codfab.Trim() + "'");
            return dt.Rows.Count > 0;
        }
    }
}
