using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OActivo
    {
        private Int32 activoID = -1;

        public Int32 ActivoID
        {
            get { return activoID; }
            set { activoID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private string codImagen = string.Empty;

        public string CodImagen
        {
            get { return codImagen; }
            set { codImagen = value; }
        }
        private byte[] img;

        public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }
        private string codImagenQR = string.Empty;

        public string CodImagenQR
        {
            get { return codImagenQR; }
            set { codImagenQR = value; }
        }
        private byte[] imgQR;

        public byte[] ImgQR
        {
            get { return imgQR; }
            set { imgQR = value; }
        }
        private Int32 tipoActivoID = -1;

        public Int32 TipoActivoID
        {
            get { return tipoActivoID; }
            set 
            {
                if (value > 0)
                    tipoActivoID = value;
                else
                    throw new Exception("Seleccione un Tipo de Activo");
            }
        }
        private string nomTipoActivo = string.Empty;

        public string NomTipoActivo
        {
            get { return nomTipoActivo; }
            set { nomTipoActivo = value; }
        }
        private Int32 sucursalID = -1;

        public Int32 SucursalID
        {
            get { return sucursalID; }
            set 
            {
                if (value > 0)
                    sucursalID = value;
                else
                    throw new Exception("Seleccione una Sucursal");
            }
        }
        private string nomSuc = string.Empty;

        public string NomSuc
        {
            get { return nomSuc; }
            set { nomSuc = value; }
        }
        private int proveedorID = -1;

        public int ProveedorID
        {
            get { return proveedorID; }
            set 
            {
                if (value > 0)
                    proveedorID = value;
                else
                    throw new Exception("Seleccione un Proveedor");
            }
        }
        private string nomProv = string.Empty;

        public string NomProv
        {
            get { return nomProv; }
            set { nomProv = value; }
        }
        private int personalRespID = -1;

        public int PersonalRespID
        {
            get { return personalRespID; }
            set 
            {
                if (value > 0)
                    personalRespID = value;
                else
                    throw new Exception("Seleccione un Personal Responsable del Activo");
            }
        }
        private string nomPersonalResp = string.Empty;

        public string NomPersonalResp
        {
            get { return nomPersonalResp; }
            set { nomPersonalResp = value; }
        }
        private string nomActivo = string.Empty;

        public string NomActivo
        {
            get { return nomActivo; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    nomActivo = value;
                else
                    throw new Exception("El nombre del Activo no puede estar vacio");
            }
        }
        private string serial = string.Empty;

        public string Serial
        {
            get { return serial; }
            set { serial = value; }
        }
        private string formaAdquisicion = string.Empty;

        public string FormaAdquisicion
        {
            get { return formaAdquisicion; }
            set { formaAdquisicion = value; }
        }
        private DateTime fechaAdquisicion = DateTime.Now;

        public DateTime FechaAdquisicion
        {
            get { return fechaAdquisicion; }
            set { fechaAdquisicion = value; }
        }
        private string documento = string.Empty;

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        private string marca = string.Empty;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string modelo = string.Empty;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private decimal costo = 0;

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private decimal costoDeprec = 0;

        public decimal CostoDeprec
        {
            get { return costoDeprec; }
            set { costoDeprec = value; }
        }
        private decimal mesesVidaUtil = 0;

        public decimal MesesVidaUtil
        {
            get { return mesesVidaUtil; }
            set { mesesVidaUtil = value; }
        }
        private decimal mesesRestantes = 0;

        public decimal MesesRestantes
        {
            get { return mesesRestantes; }
            set { mesesRestantes = value; }
        }
        private decimal mesesGarantia = 0;

        public decimal MesesGarantia
        {
            get { return mesesGarantia; }
            set { mesesGarantia = value; }
        }
        private string observacion = string.Empty;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        private decimal valResidual = 0;

        public decimal ValResidual
        {
            get { return valResidual; }
            set { valResidual = value; }
        }
        private string descripcion = string.Empty;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private bool depreciable = false;

        public bool Depreciable
        {
            get { return depreciable; }
            set { depreciable = value; }
        }
        private bool garantia = false;

        public bool Garantia
        {
            get { return garantia; }
            set { garantia = value; }
        }
        private bool contabilizado = false;

        public bool Contabilizado
        {
            get { return contabilizado; }
            set { contabilizado = value; }
        }
        private string estado = string.Empty;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
