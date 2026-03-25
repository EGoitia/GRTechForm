using System.Windows.Forms;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuFiltroResumIngrEgre : UserControl
    {
        public CntrlUsuFiltroResumIngrEgre()
        {
            InitializeComponent();
        }

        public string ConsultaSQL()
        {
            string consulta = "EXEC ResumIngrEgre '" + dtFechaIni.Value.ToShortDateString() + "', '" + dtFechaFin.Value.ToShortDateString() + "'";
            return consulta;
        }

    }
}
