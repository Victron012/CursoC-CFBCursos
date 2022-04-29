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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
            label1.Text = trackBar1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_Valor.Text = trackBar1.Value.ToString();
            label1.Text = trackBar1.Value.ToString();

        }

        private void btn_Definir_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = int.Parse(tb_Valor.Text);
            }catch(Exception)
            {
                MessageBox.Show("Insira um número!");
                return;
            }

                if (n >= trackBar1.Minimum & n <= trackBar1.Maximum)
            {
                trackBar1.Value = n;
                label1.Text = tb_Valor.Text;
            }
            else
            {
                MessageBox.Show("Número fora dos limites!");
            }
        }
    }
}
