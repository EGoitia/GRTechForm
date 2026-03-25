using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "    Este asistente le guiará por el proceso de cierre de Mes. \n" +
                           "\n Se generarán automáticamente los comprobantes de existencias, \n" +
                           "regularizacion, cierre y apertura en el periodo siguiente. \n" +
                           "\n Todos estos comprobantes";
        }
    }
}
