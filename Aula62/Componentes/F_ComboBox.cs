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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Transportes.Text);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Clear();
        }

        private void btn_Resetar_Click(object sender, EventArgs e)
        {
            cb_Transportes.Items.Clear();
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");
            cb_Transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string transp = tb_Transporte.Text;
            if (transp != "")
            {
                if (cb_Transportes.Items.Contains(transp))
                {
                    MessageBox.Show("Esse transporte já existe");
                }
                else
                {
                    cb_Transportes.Items.Add(transp);
                }
                tb_Transporte.Clear();
            }
            else
            {
                MessageBox.Show("Digite um veiculo");
            }

        }

        private void cb_Transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Transporte.Text = cb_Transportes.Text;
        }
    }
}
