using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OCuenta_Ingresos_Egresos
    {
        private int cuenta_Ingreso_EgresoID = -1;

        public int Cuenta_Ingreso_EgresoID
        {
            get { return cuenta_Ingreso_EgresoID; }
            set { cuenta_Ingreso_EgresoID = value; }
        }
        private string tipoIngresoEgreso = string.Empty;

        public string TipoIngresoEgreso
        {
            get { return tipoIngresoEgreso; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) || (!string.IsNullOrWhiteSpace(value)))
                    tipoIngresoEgreso = value;
                else
                    throw new Exception("Tiene que seleccionar el Tipo");
            }
        }
        private string codCuenta = string.Empty;

        public string CodCuenta
        {
            get { return codCuenta; }
            set { codCuenta = value; }
        }

        
        private string nombre = string.Empty;

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                //validamos
                if((!string.IsNullOrWhiteSpace(value)) || (!string.IsNullOrEmpty(value)))
                    nombre = value;
                else
                    throw new Exception("El Nombre no puede estar vacío");
            }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
