using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Manejador
    {
        //SqlConnection con = new SqlConnection(AppConfig.CadenaConexion);
        private SqlConnection con;

        public Manejador()
        {
            con = new SqlConnection(AppConfig.CadenaConexion);
        }

        public Manejador(string cadenaConexion)
        {
            con = new SqlConnection(cadenaConexion);
        }
                
        //Abrir conexion de la base de datos
        private void Abrir_Conexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        //cerrar conexion de la base de datos
        private void Cerrar_Conexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        //Metosdos para ejecutar PRocedimientos Almacenados
        public void Ejecutar_SP(string NombreSP, List<Parametros> LParam)
        {
            SqlCommand cmd;

            try
            {
                Abrir_Conexion();
                cmd = new SqlCommand(NombreSP, con);
                cmd.CommandType = CommandType.StoredProcedure;

                if(LParam != null)
                {
                    foreach (var item in LParam)
                    {
                        if(item.Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(item.Nombre, item.Valor);
                        else
                            cmd.Parameters.Add(item.Nombre, item.TipoDato, item.Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();

                    //recuperar parametros de salida
                    for (int i = 0; i < LParam.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            LParam[i].Valor = cmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }
        }

        //Metodo devolver un objeto
        public object Dato(string Consulta)
        {
            object resp;
            SqlCommand cmd;

            try
            {
                Abrir_Conexion();
                cmd = new SqlCommand("ConsultaDB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Consulta", Consulta);
                resp = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Cerrar_Conexion();
            }

            return resp;
        }

        //Metodos para listado o consultas que devuelve una tabla
        public DataTable ListadoDT(string NombreSP, List<Parametros> LParam)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter(NombreSP, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if(LParam != null)
                {
                    foreach (var item in LParam)
                    {
                        da.SelectCommand.Parameters.AddWithValue(item.Nombre, item.Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        //Metodos para listado o consultas que devuelven varias tablas
        public DataSet ListadoDS(string NombreSP, List<Parametros> LParam)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                da = new SqlDataAdapter(NombreSP, con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (LParam != null)
                {
                    foreach (var item in LParam)
                    {
                        da.SelectCommand.Parameters.AddWithValue(item.Nombre, item.Valor);
                    }
                }
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ds;
        }

    }
}
