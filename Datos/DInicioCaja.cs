using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Datos
{
    public static class DInicioCaja
    { 
        private static Manejador man;

        public static DataTable ObtenerIniCajaUsuarioSucursal()
        {
            man = new Manejador();

            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@UsuarioID", OConexionGlobal.UsuarioID));
            LParam.Add(new Parametros("@SucursalID", OConexionGlobal.SucursalID));

            return man.ListadoDT("ListarInicioCaja", LParam);
        }

        public static bool TieneInicioCajaUsuarioSucursal()
        {
            try
            {
                man = new Manejador();
                object resp = man.Dato(string.Format("SELECT 1 FROM Inicio_Caja WHERE Cerrado=0 AND Estado=1 " +
                            "AND UsuarioID={0} AND SucursalID={1}",
                            OConexionGlobal.UsuarioID, OConexionGlobal.SucursalID));

                return resp != null;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public static int InsertModif_InicioCaja(DataTable Inmode, OInicioCaja OIni)
        {
            int id;
            man = new Manejador();
            List<Parametros> LParam = new List<Parametros>();

            try
            {
                //pasamos parametros de entrada
                if (OIni.SucursalID != null)
                    LParam.Add(new Parametros("@SucursalID", OIni.SucursalID));
                else
                    LParam.Add(new Parametros("@SucursalID", DBNull.Value));

                if (OIni.UsuarioID != null)
                    LParam.Add(new Parametros("@UsuarioID", OIni.UsuarioID));
                else
                    LParam.Add(new Parametros("@UsuarioID", DBNull.Value));

                if (OIni.CajaID != null)
                    LParam.Add(new Parametros("@CajaID", OIni.CajaID));
                else
                    LParam.Add(new Parametros("@CajaID", DBNull.Value));

                LParam.Add(new Parametros("@Monto", OIni.Monto));
                LParam.Add(new Parametros("@Inmode", Inmode));
                //pasamos parametros de salida
                LParam.Add(new Parametros("@Mensaje", SqlDbType.Int, 5));

                man.Ejecutar_SP("InsertInicioCaja", LParam);

                id = Convert.ToInt32(LParam[5].Valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return id;
        }
    }
}
