using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using Objetos;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Datos
{
    public static class DUsuario
    {
        private static Manejador man = null;

        /// <summary>
        /// procedimiento para Listar datos de los Usuarios
        /// </summary>
        /// <returns>Lista Usuarios</returns>
        public static List<OUsuario> DListarUsuarios()
        {
            List<OUsuario> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarUsuarios", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<OUsuario>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordUsu(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static List<ORestriccionUsuario> DListarRestriccionUsu(int usuid)
        {
            List<ORestriccionUsuario> Temp = null;

            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("ListarRestriccionUsu", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@UsuarioID", usuid);
                miCon.Open();

                using (SqlDataReader miLector = miCmd.ExecuteReader())
                {
                    if (miLector.HasRows)
                    {
                        Temp = new List<ORestriccionUsuario>();

                        while (miLector.Read())
                        {
                            Temp.Add(FillDataRecordRestrUsu(miLector));
                        }
                    }
                    miLector.Close();
                }
                miCon.Close();
            }
            return Temp;
        }

        public static int DAnulRestauUsu(string cod, string nomtupla, int estado, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("AnulRestau", miCon);
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
                    miCon.Close();
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return result;
        }

        public static int DInsertModifUsu(OUsuario us, DataTable DTInmode)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifUsuario", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                if (us.UsuarioID == -1)
                    miCmd.Parameters.AddWithValue("@UsuarioID", DBNull.Value);
                else
                    miCmd.Parameters.AddWithValue("@UsuarioID", us.UsuarioID);

                miCmd.Parameters.AddWithValue("@NomPer", us.NomPer);
                miCmd.Parameters.AddWithValue("@PersonalID", us.PersonalID);
                miCmd.Parameters.AddWithValue("@TipoUsuario", us.TipoUsuario);
                miCmd.Parameters.AddWithValue("@NomUsu", us.NomUsu);
                miCmd.Parameters.AddWithValue("@Contrasenia", us.Contrasenia);
                miCmd.Parameters.AddWithValue("@Estado", us.Estado);
                //Cajas
                miCmd.Parameters.AddWithValue("@Cajas", us.CajasDT);
                //Sucursales
                miCmd.Parameters.AddWithValue("@Sucursal", us.SucursalesDT);
                //Inmode
                miCmd.Parameters.AddWithValue("@Inmode", DTInmode);

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

        public static int DInsertModifRestriccionUsu(ORestriccionUsuario rusu, OInmode inm)
        {
            int result;
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexion))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifRestriccionUsu", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;

                miCmd.Parameters.AddWithValue("@UsuID", rusu.UsuarioID);
                miCmd.Parameters.AddWithValue("@IPConexion", rusu.IPConexion);
                miCmd.Parameters.AddWithValue("@MacConexion", rusu.MacConexion);
                miCmd.Parameters.AddWithValue("@MaquinaConexion", rusu.MaquinaConexion);
                miCmd.Parameters.AddWithValue("@NavegadorConexion", rusu.NavegadorConexion);
                miCmd.Parameters.AddWithValue("@Observacion", rusu.Observacion);
                miCmd.Parameters.AddWithValue("@SOConexion", rusu.SOConexion);
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

        /// <summary>
        /// Procedimiento para Conectarse al Sistema
        /// </summary>
        /// <param name="usu"></param>
        /// <param name="IP"></param>
        /// <param name="Mac"></param>
        /// <param name="Maquina"></param>
        /// <returns></returns>
        public static DataTable DConectarse(string @NomUsu, string @Contrasenia, string @IP, string @Mac, string @Maquina)
        {
            DataTable DTSuc = null;
            try
            {
                man = new Manejador();
                List<Parametros> LParam = new List<Parametros>();
                LParam.Add(new Parametros("@NomUsu", NomUsu));
                LParam.Add(new Parametros("@Contrasenia", Contrasenia));
                LParam.Add(new Parametros("@IP", IP));
                LParam.Add(new Parametros("@Mac", Mac));
                LParam.Add(new Parametros("@Maquina", Maquina));

                DataSet DSResp = man.ListadoDS("Conectarse", LParam);

                if (DSResp.Tables[0].Rows.Count > 0)
                {
                    try
                    {
                        if (DSResp.Tables[0].Rows[0]["Img"] != System.DBNull.Value)
                            OConexionGlobal.LogoEmp = (byte[])DSResp.Tables[0].Rows[0]["Img"];
                        else
                        {
                            Image img = Image.FromFile(Application.StartupPath + "\\Imagenes\\Logo.jpg");
                            MemoryStream ms = new MemoryStream();
                            img.Save(ms, img.RawFormat);
                            OConexionGlobal.LogoEmp = ms.GetBuffer();
                            ms.Close();
                        }
                    }
                    catch (Exception)
                    {
                        OConexionGlobal.LogoEmp = null;
                    }

                    OConexionGlobal.PersonalID = (int)DSResp.Tables[0].Rows[0]["PersonalID"];
                    OConexionGlobal.NomPer = DSResp.Tables[0].Rows[0]["NomPer"].ToString();
                    OConexionGlobal.EmpresaID = (int)DSResp.Tables[0].Rows[0]["EmpresaID"];
                    OConexionGlobal.NomEmp = DSResp.Tables[0].Rows[0]["NomEmp"].ToString();
                    OConexionGlobal.UsuarioID = (int)DSResp.Tables[0].Rows[0]["UsuarioID"];
                    OConexionGlobal.NomUsu = DSResp.Tables[0].Rows[0]["NomUsu"].ToString();
                    OConexionGlobal.TipoUsu = DSResp.Tables[0].Rows[0]["NomRol"].ToString();
                    OConexionGlobal.Detalle_Rol = DSResp.Tables[1];

                    DTSuc = new DataTable();
                    DTSuc.Columns.Add("SucursalID");
                    DTSuc.Columns.Add("NomSuc");
                    DTSuc.Columns.Add("Ciudad");
                    DTSuc.Columns.Add("Telf");
                    DTSuc.Columns.Add("Zona");
                    DTSuc.Columns.Add("Barrio");
                    DTSuc.Columns.Add("Direccion");

                    foreach (DataRow item in DSResp.Tables[0].Rows)
                    {
                        DataRow DrSuc = DTSuc.NewRow();
                        DrSuc["SucursalID"] = item["SucursalID"];
                        DrSuc["NomSuc"] = item["NomSuc"];
                        DrSuc["Telf"] = item["Telf"];
                        DrSuc["Ciudad"] = item["Ciudad"];
                        DrSuc["Zona"] = item["Zona"];
                        DrSuc["Barrio"] = item["Barrio"];
                        DrSuc["Direccion"] = item["Direccion"];
                        DTSuc.Rows.Add(DrSuc);
                    }
                }
                else
                    throw new Exception("El Nombre o Contraseña son inválidos");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return DTSuc;
        }

        /// <summary>
        /// Cargamos datos de los Usuarios
        /// </summary>
        /// <param name="miRecord"></param>
        /// <returns>objeto Usuario</returns>
        private static OUsuario FillDataRecordUsu(IDataRecord miRecord)
        {
            OUsuario usu = new OUsuario();

            usu.UsuarioID = miRecord.GetInt32(miRecord.GetOrdinal("UsuarioID"));
            usu.NomPer = miRecord.GetString(miRecord.GetOrdinal("NomPer"));
            usu.NomUsu = miRecord.GetString(miRecord.GetOrdinal("NomUsu"));
            usu.Contrasenia = miRecord.GetString(miRecord.GetOrdinal("Contrasenia"));
            usu.TipoUsuario = miRecord.GetInt32(miRecord.GetOrdinal("RolID"));
            usu.Estado = miRecord.GetBoolean(miRecord.GetOrdinal("Estado"));

            return usu;
        }

        private static ORestriccionUsuario FillDataRecordRestrUsu(IDataRecord miRecord)
        {
            ORestriccionUsuario usu = new ORestriccionUsuario();

            usu.UsuarioID = miRecord.GetInt32(miRecord.GetOrdinal("UsuarioID"));
            usu.CodInmode = miRecord.GetString(miRecord.GetOrdinal("CodInmode"));
            usu.IPConexion = miRecord.GetString(miRecord.GetOrdinal("IPConexion"));
            usu.MacConexion = miRecord.GetString(miRecord.GetOrdinal("MacConexion"));
            usu.MaquinaConexion = miRecord.GetString(miRecord.GetOrdinal("MaquinaConexion"));
            usu.NavegadorConexion = miRecord.GetString(miRecord.GetOrdinal("NavegadorConexion"));
            usu.SOConexion = miRecord.GetString(miRecord.GetOrdinal("SOConexion"));
            usu.Observacion = miRecord.GetString(miRecord.GetOrdinal("Observacion"));

            return usu;
        }
    }
}
