using Objetos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public static class DListarPersonalizado
    {
        private static Manejador man = null;

        public static DataTable ConsultarDT(string Consulta)
        {
            man = new Manejador(AppConfig.CadenaConexion);
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Consulta", Consulta));

            return man.ListadoDT("ConsultaDB", LParam);
        }

        public static DataSet ConsultarDS(string Consulta)
        {
            man = new Manejador(AppConfig.CadenaConexion);
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Consulta", Consulta));

            return man.ListadoDS("ConsultaDB", LParam);
        }

        public static object Dato(string Consulta)
        {
            Manejador man = new Manejador(AppConfig.CadenaConexion);
            object resp;

            try
            {
                resp = man.Dato(Consulta);
            }
            catch (Exception)
            {
                throw;
            }

            return resp;
        }

        public static bool AnulRestau(string Cod, string Tupla, string CodInm, string DetInm, string TipInm, bool Estado)
        {
            bool resp;
            List<Parametros> LParam = new List<Parametros>();

            try
            {
                //pasamos parametros de entrada
                LParam.Add(new Parametros("@Codigo", Cod));
                LParam.Add(new Parametros("@NomTupla", Tupla));
                LParam.Add(new Parametros("@Estado", Estado));
                LParam.Add(new Parametros("@Inmode", OInmode.DTInmode(CodInm, TipInm, DetInm)));
                //pasamos parametros de salida
                LParam.Add(new Parametros("@Mensaje", SqlDbType.Bit, 4));

                man = new Manejador(AppConfig.CadenaConexion);
                man.Ejecutar_SP("AnulRestau", LParam);

                resp = Convert.ToBoolean(LParam[4].Valor);
            }
            catch (Exception)
            {
                throw;
            }

            return resp;
        }

        public static bool AnulRestau_Nota(string Cod, string Tupla, string CodInm, string DetInm, string TipInm, bool Estado)
        {
            bool resp;
            List<Parametros> LParam = new List<Parametros>();

            try
            {
                //pasamos parametros de entrada
                LParam.Add(new Parametros("@Codigo", Cod));
                LParam.Add(new Parametros("@NomTupla", Tupla));
                LParam.Add(new Parametros("@Estado", Estado));
                LParam.Add(new Parametros("@Inmode", OInmode.DTInmode(CodInm, TipInm, DetInm)));
                //pasamos parametros de salida
                LParam.Add(new Parametros("@Mensaje", SqlDbType.Bit, 4));

                man.Ejecutar_SP("AnulRestauNota", LParam);

                resp = Convert.ToBoolean(LParam[4].Valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return resp;
        }



        public static DataTable ConsultarLocalDT(string Consulta)
        {
            man = new Manejador(AppConfig.CadenaConexionLocal);
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Consulta", Consulta));

            return man.ListadoDT("ConsultaDB", LParam);
        }

        public static DataSet ConsultarLocalDS(string Consulta)
        {
            man = new Manejador(AppConfig.CadenaConexionLocal);
            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@Consulta", Consulta));

            return man.ListadoDS("ConsultaDB", LParam);
        }

        public static object DatoLocal(string Consulta)
        {
            Manejador man = new Manejador(AppConfig.CadenaConexionLocal);
            object resp;

            try
            {
                resp = man.Dato(Consulta);
            }
            catch (Exception)
            {
                throw;
            }

            return resp;
        }
    }
}
