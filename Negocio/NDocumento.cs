using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using Objetos;
using Datos;
using System.Data;

namespace Negocio
{
    public static class NDocumento
    {
        private static List<ODocumento> LDocProv = null;
        private static List<ODocumento> LDocPer = null;
        private static List<ODocumento> LDocCli = null;
        private static List<ODocumento> LDocAct = null;

        private static List<ODocumento> lbusqdoc = null;

        public static int NInsertModifDoc(ODocumento doc, string opc, string cod, DataTable inm)
        {
            return DDocumento.DInsertModifDoc(doc, opc, cod, inm);
        }

        public static int NAnulRestauDoc(string cod, string nomtupla, int estado, OInmode inmod)
        {
            return DDocumento.DAnulRestauDoc(cod, nomtupla, estado, inmod);
        }

        public static List<ODocumento> NListarDoc(string opc, string cod)
        {
            if (opc == "Proveedor")
            {
                LDocProv = DDocumento.DListarDoc(opc, cod);
                return LDocProv;
            }
            else if (opc == "Personal")
            {
                LDocPer = DDocumento.DListarDoc(opc, cod);
                return LDocPer;
            }
            else if (opc == "Cliente")
            {
                LDocCli = DDocumento.DListarDoc(opc, cod);
                return LDocCli;
            }
            else  //Activos
            {
                LDocAct = DDocumento.DListarDoc(opc, cod);
                return LDocAct;
            }
        }

        public static List<ODocumento> NBuscarDoc(string busq, string opc)
        {
            //Buscamos por Nombre las palabras claves
            if (opc == "Proveedor")
            {
                lbusqdoc = LDocProv.FindAll(c => c.PalClave.ToUpper().Contains(busq.ToUpper()));
            }
            else if(opc == "Personal")
            {
                lbusqdoc = LDocPer.FindAll(c => c.PalClave.ToUpper().Contains(busq.ToUpper()));
            }
            else //Activo
            {
                lbusqdoc = LDocAct.FindAll(c => c.PalClave.ToUpper().Contains(busq.ToUpper()));
            }

            return lbusqdoc;
        }

        public static string NGenerarDoc(string CodDocumento, string dir, string formato)
        {
            byte[] docto = DDocumento.DBuscarDoc(CodDocumento);
            string sFile = dir + @"\Documentos\tmp" + GenerarNombreFichero() + formato;
            FileStream fs = new FileStream(sFile, FileMode.Create);
            //Y escribimos en disco el array de bytes que conforman
            //el fichero Word
            fs.Write(docto, 0, Convert.ToInt32(docto.Length));
            fs.Close();
            System.Diagnostics.Process obj = new System.Diagnostics.Process();
            obj.StartInfo.FileName = sFile;
            obj.Start();

            return sFile;
        }

        public static ODocumento NSeleccionarDocto(string cod, string opc)
        {
            ODocumento objdocto = null;

            if(opc == "Proveedor")
            {
                objdocto = LDocProv.Find(x => x.CodDocumento == cod);
            }
            else if(opc == "Personal")
            {
                objdocto = LDocPer.Find(x => x.CodDocumento == cod);
            }
            else if (opc == "Cliente")
            {
                objdocto = LDocCli.Find(x => x.CodDocumento == cod);
            }
            else  //Activo
            {
                objdocto = LDocAct.Find(x => x.CodDocumento == cod);
            }
            
            return objdocto;
        }
        
        private static string GenerarNombreFichero()
        {
            int ultimoTick = 0;
            while (ultimoTick == Environment.TickCount)
            {
                System.Threading.Thread.Sleep(1);
            }
            ultimoTick = Environment.TickCount;
            return DateTime.Now.ToString("yyyyMMddhhmmss") + "." +
            ultimoTick.ToString();
        }

        public static List<ODocumento> NCargarDoc(string opc)
        {
            if (opc == "Proveedor")
                return LDocProv;
            else if (opc == "Personal")
                return LDocPer;
            else if (opc == "Cliente")
                return LDocCli;
            else
                return LDocAct;
        }

    }
}
