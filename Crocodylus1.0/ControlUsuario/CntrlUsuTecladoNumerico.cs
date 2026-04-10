using System;
using System.Windows.Forms;

namespace GRTechnology1._0.ControlUsuario
{
    public partial class CntrlUsuTecladoNumerico : UserControl
    {
        public event Action<string> OnNumeroPresionado;
        public event Action OnEnter;
        public event Action OnBorrar;
        public event Action OnBorrarTodo;

        public CntrlUsuTecladoNumerico()
        {
            InitializeComponent();
        }

        private void BtnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (OnNumeroPresionado != null)
                OnNumeroPresionado.Invoke(btn.Text);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (OnEnter != null)
                OnEnter();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (OnBorrar != null)
                OnBorrar();
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            if (OnBorrarTodo != null)
                OnBorrarTodo.Invoke();
        }

    }
}
