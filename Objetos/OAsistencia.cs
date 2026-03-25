using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objetos
{
    public class OAsistencia
    {
        private string codAsistencia = string.Empty;

        public string CodAsistencia
        {
            get { return codAsistencia; }
            set { codAsistencia = value; }
        }
        private string codInmode = string.Empty;

        public string CodInmode
        {
            get { return codInmode; }
            set { codInmode = value; }
        }
        private int gestion = 2012;

        public int Gestion
        {
            get { return gestion; }
            set { gestion = value; }
        }
        private int mes = 1;

        public int Mes
        {
            get { return mes; }
            set { mes = value; }
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
        private decimal totHrsPermiso = 0;

        public decimal TotHrsPermiso
        {
            get { return totHrsPermiso; }
            set { totHrsPermiso = value; }
        }
        private int totDiasPermiso = 0;

        public int TotDiasPermiso
        {
            get { return totDiasPermiso; }
            set { totDiasPermiso = value; }
        }
        private decimal totHrsTarde = 0;

        public decimal TotHrsTarde
        {
            get { return totHrsTarde; }
            set { totHrsTarde = value; }
        }
        private int totDiasTarde = 0;

        public int TotDiasTarde
        {
            get { return totDiasTarde; }
            set { totDiasTarde = value; }
        }
        private decimal totHrsTemprano = 0;

        public decimal TotHrsTemprano
        {
            get { return totHrsTemprano; }
            set { totHrsTemprano = value; }
        }
        private int totDiasTemprano = 0;

        public int TotDiasTemprano
        {
            get { return totDiasTemprano; }
            set { totDiasTemprano = value; }
        }
        private decimal totHrsFalta = 0;

        public decimal TotHrsFalta
        {
            get { return totHrsFalta; }
            set { totHrsFalta = value; }
        }
        private int totDiasFalta = 0;

        public int TotDiasFalta
        {
            get { return totDiasFalta; }
            set { totDiasFalta = value; }
        }
        private decimal totHrsExtras = 0;

        public decimal TotHrsExtras
        {
            get { return totHrsExtras; }
            set { totHrsExtras = value; }
        }
        private int totDiasExtras = 0;

        public int TotDiasExtras
        {
            get { return totDiasExtras; }
            set { totDiasExtras = value; }
        }
        private int totDiasVacacion = 0;

        public int TotDiasVacacion
        {
            get { return totDiasVacacion; }
            set { totDiasVacacion = value; }
        }
    }
}
