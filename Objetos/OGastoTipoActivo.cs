using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OGastoTipoActivo
    {
        private int gastosTipoActivoID = -1;

        public int GastosTipoActivoID
        {
            get { return gastosTipoActivoID; }
            set { gastosTipoActivoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codCuenta = string.Empty;

        public string CodCuenta
        {
            get { return codCuenta; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    codCuenta = value;
                else
                    throw new Exception("Seleccione una Cuenta Contable");
            }
        }
        private string nomCuenta = string.Empty;

        public string NomCuenta
        {
            get { return nomCuenta; }
            set { nomCuenta = value; }
        }
        private int tipoActivoID = -1;

        public int TipoActivoID
        {
            get { return tipoActivoID; }
            set 
            {
                if (value > 0)
                    tipoActivoID = value;
                else
                    throw new Exception("Seleccione un Tipo de Activo Valido");
            }
        }
        private string nomTipoActivo = string.Empty;

        public string NomTipoActivo
        {
            get { return nomTipoActivo; }
            set { nomTipoActivo = value; }
        }
        private string nomGastoTipoActivo = string.Empty;

        public string NomGastoTipoActivo
        {
            get { return nomGastoTipoActivo; }
            set 
            {
                if ((!string.IsNullOrEmpty(value)) && (!string.IsNullOrWhiteSpace(value)))
                    nomGastoTipoActivo = value;
                else
                    throw new Exception("El nombre del gasto no puede estar vacio");
            }
        }
        private string detalle = string.Empty;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
