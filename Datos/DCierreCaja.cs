using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Datos
{
    public static class DCierreCaja
    {
        public static DataTable ObtenerCierreCajaUsuarioSucursal()
        {
            Manejador man = new Manejador();

            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@UsuarioID", OConexionGlobal.UsuarioID));
            LParam.Add(new Parametros("@SucursalID", OConexionGlobal.SucursalID));

            return man.ListadoDT("ListarInicioCaja", LParam);
        }

        public static int Insert_CierreCaja(DataTable Inmode, OCierreCaja cierre)
        {
            Manejador man = new Manejador();

            int id;
            List<Parametros> LParam = new List<Parametros>();

            try
            {
                //pasamos parametros de entrada

                LParam.Add(new Parametros("@InicioID", cierre.InicioID));
                LParam.Add(new Parametros("@UsuarioID", OConexionGlobal.UsuarioID));
                LParam.Add(new Parametros("@EntregEfectivoBs", cierre.EntregEfectivoBs));
                LParam.Add(new Parametros("@EntregEfectivoSus", cierre.EntregEfectivoSus));
                LParam.Add(new Parametros("@EntregTarjetaBs", cierre.EntregTarjetaBs));
                LParam.Add(new Parametros("@EntregTransfBs", cierre.EntregTransfBs));
                LParam.Add(new Parametros("@EntregDepositoBs", cierre.EntregDeposBs));
                LParam.Add(new Parametros("@EntregChequeBs", 0));
                LParam.Add(new Parametros("@Observaciones", cierre.Observaciones));
                LParam.Add(new Parametros("@Inmode", Inmode));
                //pasamos parametros de salida
                LParam.Add(new Parametros("@Mensaje", SqlDbType.Int, 10));

                man.Ejecutar_SP("InsertCierreCaja", LParam);

                id = Convert.ToInt32(LParam[10].Valor);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return id;
        }

        public static DataTable ObtenerCierreCajaByID(int id)
        {
            Manejador man = new Manejador();

            List<Parametros> LParam = new List<Parametros>();
            LParam.Add(new Parametros("@ID", id));

            return man.ListadoDT("ObtenerCierreCajaByID", LParam);
        }
    }
}
