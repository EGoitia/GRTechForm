using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using Objetos;

namespace Datos
{
    public static class DVenta
    {

        public static List<OVenta> DListarRevVentasXCliente(int @SucID, int @CliID, DateTime @FIni, DateTime @FFin)
        {
            List<OVenta> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarRevVentasXCliente", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (SucID == -1)
                    miCmd.Parameters.AddWithValue("@SucID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@SucID", SucID);

                miCmd.Parameters.AddWithValue("@CliID", CliID);
                miCmd.Parameters.AddWithValue("@FIni", FIni);
                miCmd.Parameters.AddWithValue("@FFin", FFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OVenta>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRegulVen(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// Procedimiento para buscar Ventas
        /// </summary>
        /// <param name="Busqueda"></param>
        /// <param name="TipoBusq"></param>
        /// <param name="FechaBusq"></param>
        /// <param name="AlmacenID"></param>
        /// <returns></returns>
        public static List<OVenta> DBuscarVentas(string @Busqueda, string @TipoBusq, DateTime @FechaBusq, int @SucursalID)
        {
            List<OVenta> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarVen", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@Opcion", TipoBusq);
                miCmd.Parameters.AddWithValue("@Busqueda", Busqueda);
                miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);
                miCmd.Parameters.AddWithValue("@Fecha", FechaBusq);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OVenta>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordVen(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OVentasPorFecha> DBuscarVentasXFecha(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OVentasPorFecha> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarVentasXFecha", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaID", CajaID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OVentasPorFecha>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordVenPorFecha(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<OVentasPorFecha> DBuscarVenAbonProy(int @CajaID, DateTime @FecIni, DateTime @FecFin)
        {
            List<OVentasPorFecha> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarVenAbonProy", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@CajaD", CajaID);
                miCmd.Parameters.AddWithValue("@FecIni", FecIni);
                miCmd.Parameters.AddWithValue("@FecFin", FecFin);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OVentasPorFecha>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordVenAbonProy(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        /// <summary>
        /// procedimiento para buscar las deudas del Cliente
        /// </summary>
        /// <param name="ClienteID"></param>
        /// <param name="SucursalID"></param>
        /// <returns></returns>
        public static List<OVenta> DBuscarDeudasCli(int @ClienteID, int @SucursalID, string @Opcion)
        {
            List<OVenta> Temp = null;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("BuscarDeudasCli", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (ClienteID == -1) //si el cliente es -1 buscamos todos los clientes
                    miCmd.Parameters.AddWithValue("@ClienteID", DBNull.Value);
                else //buscamos por cliente en especifico
                    miCmd.Parameters.AddWithValue("@ClienteID", ClienteID);

                if (SucursalID == -1) //si sucursal es -1 buscamos por empresa
                    miCmd.Parameters.AddWithValue("@SucursalID", DBNull.Value);
                else //buscamos por sucursal
                    miCmd.Parameters.AddWithValue("@SucursalID", SucursalID);

                miCmd.Parameters.AddWithValue("@Opcion", Opcion);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OVenta>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRegulVen(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static string DInsertModifVenta(OVenta ven, DataTable inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertModifVen", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.CommandTimeout = 300;


                if (ven.CodVenta == null || ven.CodVenta == "-1")
                    miCmd.Parameters.AddWithValue("@CodVenta", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodVenta", ven.CodVenta);

                miCmd.Parameters.AddWithValue("@CodCotizacion", ven.CodCotizacion);
                miCmd.Parameters.AddWithValue("@CodPedido", ven.CodPedido);
                miCmd.Parameters.AddWithValue("@TipoVentaID", ven.TipoVentaID);
                miCmd.Parameters.AddWithValue("@ClienteID", ven.ClienteID);
                miCmd.Parameters.AddWithValue("@AlmacenID", ven.AlmacenID);
                miCmd.Parameters.AddWithValue("@VendedorID", ven.VendedorID);
                miCmd.Parameters.AddWithValue("@Referencia", ven.Referencia);
                miCmd.Parameters.AddWithValue("@TC", ven.TC);
                miCmd.Parameters.AddWithValue("@Monto", ven.Monto);
                miCmd.Parameters.AddWithValue("@Dscto", ven.Dscto);
                miCmd.Parameters.AddWithValue("@Anticipo", ven.Anticipo);
                miCmd.Parameters.AddWithValue("@Detalle", ven.Detalle);
                //Detalle Venta
                miCmd.Parameters.AddWithValue("@DetalleVenta", ven.DetalleVentaDT);
                //Detalle Pago
                miCmd.Parameters.AddWithValue("@DetallePago", ven.DetallePagoDT); 
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

        public static string DInsertModifPedido(OVenta ven, DataTable inm)
        {
            string result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd;
                miCmd = new SqlCommand("InsertModifPedido", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.CommandTimeout = 300;


                if (ven.CodVenta == "-1")
                    miCmd.Parameters.AddWithValue("@CodPedido", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@CodPedido", ven.CodVenta);

                miCmd.Parameters.AddWithValue("@ClienteID", ven.ClienteID);
                miCmd.Parameters.AddWithValue("@SucursalID", ven.AlmacenID);
                miCmd.Parameters.AddWithValue("@VendedorID", ven.VendedorID ?? (Object)DBNull.Value);
                miCmd.Parameters.AddWithValue("@Referencia", ven.Referencia);
                miCmd.Parameters.AddWithValue("@TC", ven.TC);
                miCmd.Parameters.AddWithValue("@Monto", ven.Monto);
                miCmd.Parameters.AddWithValue("@Dscto", ven.Dscto);
                miCmd.Parameters.AddWithValue("@Anticipo", ven.Anticipo);
                miCmd.Parameters.AddWithValue("@Detalle", ven.Detalle);
                //Detalle Pedido
                miCmd.Parameters.AddWithValue("@DetallePedido", ven.DetalleVentaDT);
                //Detalle Pago
                miCmd.Parameters.AddWithValue("@DetallePago", ven.DetallePagoDT); 
                //Detalle Ubicacion
                miCmd.Parameters.AddWithValue("@Ubicacion", ven.UbicacionDT);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", inm);

                try
                {
                    miCon.Open();
                    result = miCmd.ExecuteScalar().ToString();
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
       
        /// <summary>
        /// Cargamos datos de las Ventas
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objetos Venta</returns>
        private static OVenta FillDataRecordVen(IDataRecord miRecord)
        {
            OVenta ven = new OVenta();

            ven.CodVenta = miRecord.GetString(miRecord.GetOrdinal("CodVenta"));
            ven.VendedorID = miRecord.GetInt32(miRecord.GetOrdinal("VendedorID"));
            
            return ven;
        }

        private static OVenta FillDataRecordRegulVen(IDataRecord miRecord)
        {
            OVenta ven = new OVenta();

            ven.CodVenta = miRecord.GetString(miRecord.GetOrdinal("CodVenta"));
           
            ven.ClienteID = miRecord.GetInt32(miRecord.GetOrdinal("ClienteID"));
            
            ven.VendedorID = miRecord.GetInt32(miRecord.GetOrdinal("VendedorID"));
         
            return ven;
        }

        private static OVentasPorFecha FillDataRecordVenPorFecha(IDataRecord miRecord)
        {
            OVentasPorFecha ven = new OVentasPorFecha();

            ven.CodVenta = miRecord.GetString(miRecord.GetOrdinal("CodVenta"));
            ven.TipoVenta = miRecord.GetString(miRecord.GetOrdinal("TipoVenta"));
            ven.NumVenta = miRecord.GetString(miRecord.GetOrdinal("NumVenta"));
            ven.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            ven.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            ven.TotalBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalBs"));
            ven.TipoPago = miRecord.GetString(miRecord.GetOrdinal("TipoPago"));
            ven.ImporteBs = miRecord.GetDecimal(miRecord.GetOrdinal("ImporteBs"));
            ven.ImporteSus = miRecord.GetDecimal(miRecord.GetOrdinal("ImporteSus"));
            
            return ven;
        }

        private static OVentasPorFecha FillDataRecordVenAbonProy(IDataRecord miRecord)
        {
            OVentasPorFecha ven = new OVentasPorFecha();

            ven.TipoVenta = miRecord.GetString(miRecord.GetOrdinal("TipoVenta"));
            ven.NumVenta = miRecord.GetString(miRecord.GetOrdinal("NumVenta"));
            ven.Fecha = miRecord.GetDateTime(miRecord.GetOrdinal("Fecha"));
            ven.Referencia = miRecord.GetString(miRecord.GetOrdinal("Referencia"));
            ven.TotalBs = miRecord.GetDecimal(miRecord.GetOrdinal("TotalBs"));

            return ven;
        }
    }
}
