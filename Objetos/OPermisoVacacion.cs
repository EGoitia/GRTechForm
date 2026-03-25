using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OPermisoVacacion
    {
        private int permVacaID = -1;

        public int PermVacaID
        {
            get { return permVacaID; }
            set { permVacaID = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private int personalID = -1;

        public int PersonalID
        {
            get { return personalID; }
            set { personalID = value; }
        }
        private string nomPer = string.Empty;

        public string NomPer
        {
            get { return nomPer; }
            set { nomPer = value; }
        }
        private int tipoPermisoID = -1;

        public int TipoPermisoID
        {
            get { return tipoPermisoID; }
            set { tipoPermisoID = value; }
        }
        private string nomTipoPermiso = string.Empty;

        public string NomTipoPermiso
        {
            get { return nomTipoPermiso; }
            set { nomTipoPermiso = value; }
        }
        private DateTime fechaPermisoInic = DateTime.Now;

        public DateTime FechaPermisoInic
        {
            get { return fechaPermisoInic; }
            set { fechaPermisoInic = value; }
        }
        private DateTime fechaPermisoFin = DateTime.Now;

        public DateTime FechaPermisoFin
        {
            get { return fechaPermisoFin; }
            set { fechaPermisoFin = value; }
        }
        private string observacion = string.Empty;

        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }
        private decimal totHrs = 0;

        public decimal TotHrs
        {
            get { return totHrs; }
            set { totHrs = value; }
        }
        private int totDias = 0;

        public int TotDias
        {
            get { return totDias; }
            set { totDias = value; }
        }
        private bool aCtaVacacion = false;

        public bool ACtaVacacion
        {
            get { return aCtaVacacion; }
            set { aCtaVacacion = value; }
        }
        private bool estado = false;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
