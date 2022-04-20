using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes
{
    public partial class F_Progressbar : Form
    {
        private void Limpar()
        {
            textBox1.Clear();
            textBox1.Focus();
        }
        public F_Progressbar()
        {
            InitializeComponent();
        }

        private void btn_Valor_Click(object sender, EventArgs e)
        {
            int n = progressBar1.Value;
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas números");
                Limpar();
            }

            if (n < progressBar1.Minimum)
            {
                MessageBox.Show("Número abaixo do permitido ("+ progressBar1.Minimum.ToString()+")");
                Limpar();
            }
            else if(n> progressBar1.Maximum)
            {
                MessageBox.Show("Número acima do permitido (" + progressBar1.Maximum.ToString()+")");
                Limpar();
            }
            else
            {
                progressBar1.Value = n;
                Limpar();
            }
        }

        private void btn_Preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            for (int i = 0; i <= progressBar1.Maximum-1; i++)
            {
                progressBar1.Value = i;
                lb_Porcentagem.Text = i.ToString() + "%";
                Thread.Sleep(900);
                if (i == progressBar1.Maximum-1)
                {
                    Thread.Sleep(1000);
                    MessageBox.Show("Erro");
                }
            }   
        }
    }
}
