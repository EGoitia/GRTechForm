using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class ODetallePersonal
    {
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
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private int aFPID = -1;

        public int AFPID
        {
            get { return aFPID; }
            set { aFPID = value; }
        }
        private string nomAFP = string.Empty;

        public string NomAFP
        {
            get { return nomAFP; }
            set { nomAFP = value; }
        }
        private decimal diasTrabSemanal = 0;

        public decimal DiasTrabSemanal
        {
            get { return diasTrabSemanal; }
            set { diasTrabSemanal = value; }
        }
        private DateTime fechaFiniquito = DateTime.Now;

        public DateTime FechaFiniquito
        {
            get { return fechaFiniquito; }
            set { fechaFiniquito = value; }
        }
        private string causalFiniquito = string.Empty;

        public string CausalFiniquito
        {
            get { return causalFiniquito; }
            set { causalFiniquito = value; }
        }
        private string tipoTrabajador = string.Empty;

        public string TipoTrabajador
        {
            get { return tipoTrabajador; }
            set { tipoTrabajador = value; }
        }
        private string tipoContrato = string.Empty;

        public string TipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value; }
        }
        private string numContrato = string.Empty;

        public string NumContrato
        {
            get { return numContrato; }
            set { numContrato = value; }
        }
        private string nomSeguro = string.Empty;

        public string NomSeguro
        {
            get { return nomSeguro; }
            set { nomSeguro = value; }
        }
        private string codAfiliacion = string.Empty;

        public string CodAfiliacion
        {
            get { return codAfiliacion; }
            set { codAfiliacion = value; }
        }
        private string exCodAfiliacion = string.Empty;

        public string ExCodAfiliacion
        {
            get { return exCodAfiliacion; }
            set { exCodAfiliacion = value; }
        }
        private int seguroSimples = 0;

        public int SeguroSimples
        {
            get { return seguroSimples; }
            set { seguroSimples = value; }
        }
        private int seguroMaternales = 0;

        public int SeguroMaternales
        {
            get { return seguroMaternales; }
            set { seguroMaternales = value; }
        }
        private int seguroInvalidez = 0;

        public int SeguroInvalidez
        {
            get { return seguroInvalidez; }
            set { seguroInvalidez = value; }
        }
        private string profesion = string.Empty;

        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        private string tituloProf = string.Empty;

        public string TituloProf
        {
            get { return tituloProf; }
            set { tituloProf = value; }
        }
        private string nivelProf = string.Empty;

        public string NivelProf
        {
            get { return nivelProf; }
            set { nivelProf = value; }
        }
        private DateTime fecTitulacion = DateTime.Now;

        public DateTime FecTitulacion
        {
            get { return fecTitulacion; }
            set { fecTitulacion = value; }
        }
        private string formaPago = string.Empty;

        public string FormaPago
        {
            get { return formaPago; }
            set { formaPago = value; }
        }
        private string banco = string.Empty;

        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        private string codPagElectr = string.Empty;

        public string CodPagElectr
        {
            get { return codPagElectr; }
            set { codPagElectr = value; }
        }
        private string cuentaCorriente = string.Empty;

        public string CuentaCorriente
        {
            get { return cuentaCorriente; }
            set { cuentaCorriente = value; }
        }
    }
}
