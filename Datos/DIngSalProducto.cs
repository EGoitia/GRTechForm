using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DIngSalProducto
    {
        public static string DInsertModifIngSalProd(OIngSalProducto @ingsal, DataTable @inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertModifIngSalProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                
                if (ingsal.CodIngSalProd == "-1")
                    miCmd.Parameters.AddWithValue("@CodIngSalProd", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodIngSalProd", ingsal.CodIngSalProd);
                
                miCmd.Parameters.AddWithValue("@CodCompraProd", ingsal.CodCompraProd);
                miCmd.Parameters.AddWithValue("@AlmacenID", ingsal.AlmacenID);
                miCmd.Parameters.AddWithValue("@ProveedorID", ingsal.ProveedorID);
                miCmd.Parameters.AddWithValue("@TipoIngSalProdID", ingsal.TipoIngSalProdID);
                miCmd.Parameters.AddWithValue("@Recibido", ingsal.Recibido);
                miCmd.Parameters.AddWithValue("@Concepto", ingsal.Concepto);
                miCmd.Parameters.AddWithValue("@EsIngreso", ingsal.EsIngreso);
                //Detalle IngSalProducto
                miCmd.Parameters.AddWithValue("@DetalleIngSalProd", ingsal.DetalleIngSalProd);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
                }
                catch(Exception ex)
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

        public static string DInsertModifIngSalProd(OIngSalProducto @ingsal, DataTable @lote_serial, DataTable @inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertModifIngSalProd_Lote_Serial", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (ingsal.CodIngSalProd == "-1")
                    miCmd.Parameters.AddWithValue("@CodIngSalProd", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodIngSalProd", ingsal.CodIngSalProd);

                miCmd.Parameters.AddWithValue("@CodCompraProd", ingsal.CodCompraProd);
                miCmd.Parameters.AddWithValue("@AlmacenID", ingsal.AlmacenID);
                miCmd.Parameters.AddWithValue("@ProveedorID", ingsal.ProveedorID);
                miCmd.Parameters.AddWithValue("@TipoIngSalProdID", ingsal.TipoIngSalProdID);
                miCmd.Parameters.AddWithValue("@Recibido", ingsal.Recibido);
                miCmd.Parameters.AddWithValue("@Concepto", ingsal.Concepto);
                miCmd.Parameters.AddWithValue("@EsIngreso", ingsal.EsIngreso);
                //Detalle IngSalProd
                miCmd.Parameters.AddWithValue("@DetalleIngSalProd", ingsal.DetalleIngSalProd);
                //Detalle IngSalProd
                miCmd.Parameters.AddWithValue("@DetalleLoteSerial", lote_serial);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
                }
                catch (Exception ex)
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

        public static string DInsertIngInventarioIni(int @almacenID, DataTable @inventario_ini, DataTable @inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertIngInventarioIni", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@AlmacenID", almacenID);
                miCmd.Parameters.AddWithValue("@Inventario_Ini", inventario_ini);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = Convert.ToString(miCmd.ExecuteScalar());
                }
                catch (Exception ex)
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

        public static List<OIngSalProducto> DListarIngSalProd(string @Opcion, int @AlmacenID, DateTime @fec)
        {
            List<OIngSalProducto> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarIngSalProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@AlmacenID", AlmacenID);
                miCmd.Parameters.AddWithValue("@Fecha", fec);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OIngSalProducto>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordIngSalProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }
        
        public static List<OIngSalProducto> DBuscarIngSalProd(string @Tipo, string @Opcion, string @Busqueda, int @AlmacenID, DateTime Fecha)
        {
            List<OIngSalProducto> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarIngSalProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Tipo", Tipo);
                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@AlmacenID", AlmacenID);
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OIngSalProducto>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordIngSalProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OIngSalProducto> DBuscarNotasIngRegul(string @CodCompraProd)
        {
            List<OIngSalProducto> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarNotasIngRegul", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CodCompraProd", @CodCompraProd);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OIngSalProducto>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordIngSalProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OIngSalProducto FillDataRecordIngSalProd(IDataRecord miRecord)
        {
            OIngSalProducto ingsal = new OIngSalProducto();

            ingsal.CodIngSalProd = miRecord.GetString(miRecord.GetOrdinal("CodIngSalProd"));
            
            ingsal.AlmacenID = miRecord.GetInt32(miRecord.GetOrdinal("AlmacenID"));
           
            ingsal.ProveedorID = miRecord.GetInt32(miRecord.GetOrdinal("ProveedorID"));
            
            ingsal.Recibido = miRecord.GetString(miRecord.GetOrdinal("Recibido"));
            ingsal.Concepto = miRecord.GetString(miRecord.GetOrdinal("Concepto"));

            return ingsal;
        }
    }
}
