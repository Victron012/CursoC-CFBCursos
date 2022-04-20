using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            string msg = mtb_Cpf.Text;
            MessageBox.Show(msg);
        }

        private void btn_MostrarCaracter_Click(object sender, EventArgs e)
        {
            string msg = mtb_Caracter.Text;
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_SomenteTexto.Checked)
            {
                mtb_Variavel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_Variavel.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = mtb_Variavel.Text;
            MessageBox.Show(msg);
        }

        private void btn_Pass_Click(object sender, EventArgs e)
        {
            //mtb_Senha.PasswordChar = PasswordPropertyTextAttribute.Default;
        }
    }
}
