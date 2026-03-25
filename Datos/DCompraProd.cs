using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DCompraProd
    {
        public static int DAnulRestauCompraProd(string @cod, string @nomtupla, int @estado, OInmode @inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("AnulRestauNota", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Codigo", cod);
                miCmd.Parameters.AddWithValue("@NomTupla", nomtupla);
                miCmd.Parameters.AddWithValue("@Estado", estado);
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

        public static string DInsertModifCompraProd(OCompraProd @comprod, DataTable @inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertModifCompraProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (comprod.CodCompraProd == string.Empty)
                    miCmd.Parameters.AddWithValue("@CodCompraProd", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodCompraProd", @comprod.CodCompraProd);

                miCmd.Parameters.AddWithValue("@ProveedorID", @comprod.ProveedorID);
                miCmd.Parameters.AddWithValue("@TipoCompraID", @comprod.TipoCompraID);
                miCmd.Parameters.AddWithValue("@AlmacenID", @comprod.SucursalID);
                miCmd.Parameters.AddWithValue("@Referencia", @comprod.Referencia);
                miCmd.Parameters.AddWithValue("@Detalle", @comprod.Detalle);
                miCmd.Parameters.AddWithValue("@TC", @comprod.TC);
                miCmd.Parameters.AddWithValue("@Monto", @comprod.MontoBs);
                miCmd.Parameters.AddWithValue("@Dscto", @comprod.DsctoBs);
                miCmd.Parameters.AddWithValue("@Facturado", @comprod.Facturado);
                miCmd.Parameters.AddWithValue("@IngresoDirecto", @comprod.IngresoDirecto);
                //Detalle Factura
                miCmd.Parameters.AddWithValue("@Detalle_Factura", @comprod.Detalle_FacturaDT);
                //Detalle Recibo
                miCmd.Parameters.AddWithValue("@Detalle_Recibo", @comprod.Detalle_ReciboDT);
                //Detalle Compra
                miCmd.Parameters.AddWithValue("@Detalle_Compra", @comprod.Detalle_CompraDT);
                //Detalle Gasto
                miCmd.Parameters.AddWithValue("@Detalle_Gastos", @comprod.Detalle_GastosDT);
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

        public static List<OCompraProd> DListarCompraProd(int @CajaID, DateTime @fec)
        {
            List<OCompraProd> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarCompraProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@Fecha", fec);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCompraProd>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordComProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OCompraProd> DListarRevComProv(int @SucID, int @ProvID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OCompraProd> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarRevComXProv", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                if (SucID == -1)
                    miCmd.Parameters.AddWithValue("@SucID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucID", SucID);

                miCmd.Parameters.AddWithValue("@ProvID", ProvID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCompraProd>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRevComProv(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OCompraProd> DListarCompraProdTransito(int @SucID)
        {
            List<OCompraProd> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarCompraProdTransito", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@SucID", SucID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCompraProd>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordComProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OCompraProd> DBuscarCompraProd(string @Tipo, string @Busqueda, int @CajaID, DateTime @Fecha)
        {
            List<OCompraProd> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarCompraProd", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Tipo", Tipo);
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@Fecha", Fecha);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCompraProd>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordComProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OCompraPorFecha> DBuscarCompraProdXFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OCompraPorFecha> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarCompraProdXFecha", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCompraPorFecha>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordComProdPorFecha(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OCompraProd> DBuscarDeudasProv(int @ProveedorID, int @SucursalID)
        {
            List<OCompraProd> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDeudasProv", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@ProveedorID", ProveedorID);
                miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OCompraProd>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRegulComProd(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        private static OCompraProd FillDataRecordComProd(IDataRecord miRecord)
        {
            OCompraProd cprod = new OCompraProd();

            cprod.CodCompraProd = miRecord.GetString(miRecord.GetOrdinal("CodCompraProd"));
           
            cprod.ProveedorID = miRecord.GetInt32(miRecord.GetOrdinal("ProveedorID"));
            
            cprod.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            cprod.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            //totales
            cprod.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
            cprod.DsctoBs = miRecord.GetDecimal(miRecord.GetOrdinal("DsctoBs"));
            
            cprod.Facturado = miRecord.GetBoolean(miRecord.GetOrdinal("Facturado"));

            return cprod;
        }

        private static OCompraProd FillDataRecordRegulComProd(IDataRecord miRecord)
        {
            OCompraProd cprod = new OCompraProd();

            cprod.CodCompraProd = miRecord.GetString(miRecord.GetOrdinal("CodCompraProd"));
            
            cprod.ProveedorID = miRecord.GetInt32(miRecord.GetOrdinal("ProveedorID"));
           
            cprod.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            cprod.Detalle = miRecord.GetString(miRecord.GetOrdinal("Detalle"));
            //totales
           cprod.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));
           cprod.DsctoBs = miRecord.GetDecimal(miRecord.GetOrdinal("DsctoBs"));

            return cprod;
        }

        private static OCompraProd FillDataRecordRevComProv(IDataRecord miRecord)
        {
            OCompraProd com = new OCompraProd();

            com.CodCompraProd = miRecord.GetString(miRecord.GetOrdinal("CodCompraProd"));
            
            com.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            com.MontoBs = miRecord.GetDecimal(miRecord.GetOrdinal("MontoBs"));

            return com;
        }

        private static OCompraPorFecha FillDataRecordComProdPorFecha(IDataRecord miRecord)
        {
            OCompraPorFecha cprod = new OCompraPorFecha();

            cprod.CodCompraProd = miRecord.GetString(miRecord.GetOrdinal("CodCompraProd"));
            cprod.NumCompraProd = miRecord.GetString(miRecord.GetOrdinal("NumCompraProd"));
            cprod.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            cprod.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            cprod.TotalBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalBs"));
            cprod.TipoCompra = miRecord.GetString(miRecord.GetOrdinal("TipoCompra"));
            cprod.TipoPago = miRecord.GetString(miRecord.GetOrdinal("TipoPago"));
            cprod.ImporteBs = miRecord.GetDecimal(miRecord.GetOrdinal("ImporteBs"));
            cprod.ImporteSus = miRecord.GetDecimal(miRecord.GetOrdinal("ImporteSus"));

            return cprod;
        }
    }
}
