using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GRTechnology1._0
{
    public partial class Imagen : Form
    {
        public Imagen(byte[] img)
        {
            InitializeComponent();

            if (img != null)
            {
                MemoryStream m_MemoryStream = new MemoryStream(img);
                pbxImg.Image = new System.Drawing.Bitmap(m_MemoryStream);
            }
        }
    }
}
