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
    public partial class F_NumericUpDown : Form
    {
        private void Limpar()
        {
            tb_Valor.Clear();
            tb_Valor.Focus();
        }
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_DefinirValor_Click(object sender, EventArgs e)
        {
            decimal n = numericUpDown1.Value;
            try
            {
                n = decimal.Parse(tb_Valor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas números!");
                Limpar();
            }


            if (n < numericUpDown1.Minimum)
            {
                MessageBox.Show("Número abaixo do permitido! (0)");
            }
            else if (n > numericUpDown1.Maximum)
            {
                MessageBox.Show("Número acima do permitido! (100)");
            }
            else
            {
                numericUpDown1.Value = n;
                Limpar();
            }
        }
    }
}
