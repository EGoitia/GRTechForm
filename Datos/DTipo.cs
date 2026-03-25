using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DTipo
    {
        public static int InsertModif_Tipo(OTipo OTip, DataTable Inmode)
        {
            Manejador man = new Manejador();
            int id;
            List<Parametros> LParam = new List<Parametros>();

            try
            {
                //pasamos parametros de entrada
                if (OTip.TipoID == -1)
                    LParam.Add(new Parametros("@TipoID", DBNull.Value));
                else
                    LParam.Add(new Parametros("@TipoID", OTip.TipoID));

                LParam.Add(new Parametros("@NomTipo", OTip.NomTipo));
                LParam.Add(new Parametros("@Tupla", OTip.Tupla));
                LParam.Add(new Parametros("@Inmode", Inmode));
                //pasamos parametros de salida
                LParam.Add(new Parametros("@Mensaje", SqlDbType.Int, 4));

                man.Ejecutar_SP("InsertModifTipo", LParam);

                id = Convert.ToInt32(LParam[4].Valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return id;
        }

        public static void InsertModif_TipoLocal(DataTable dtTipo)
        {
            using (SqlConnection miCon = new SqlConnection(AppConfig.CadenaConexionLocal))
            {
                SqlCommand miCmd = new SqlCommand("InsertModifTipo_Local", miCon);
                miCmd.CommandType = CommandType.StoredProcedure;
                miCmd.Parameters.AddWithValue("@LstTipo", dtTipo);

                IDataParameter ReturnValue;
                ReturnValue = miCmd.CreateParameter();
                ReturnValue.Direction = ParameterDirection.ReturnValue;
                miCmd.Parameters.Add(ReturnValue);

                try
                {
                    miCon.Open();
                    miCmd.ExecuteNonQuery();
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
        }
    
        public static DataTable Listar_TipoDT(string tupla)
        {
            Manejador man = new Manejador();
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Tupla", tupla));

            return man.ListadoDT("ListarTipo", LParam);
        }

        public static DataSet Listar_TipoDS(string tupla)
        {
            Manejador man = new Manejador();
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Tupla", tupla));

            return man.ListadoDS("ListarTipo", LParam);
        }
    }
}
