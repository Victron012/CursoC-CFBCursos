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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string s in clb_Transportes.CheckedItems)
            {
                txt += s + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_LimparLista_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
        }

        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            object Trem = "Trem";
            clb_Transportes.Items.Clear();
            /*clb_Transportes.Items.Add("Carro", false);
            clb_Transportes.Items.Add("Aviao", false);
            clb_Transportes.Items.Add("Navio", false);
            clb_Transportes.Items.Add("Onibus", false);
            clb_Transportes.Items.Add(Trem, false);*/

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Aviao");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");

            clb_Transportes.Items.AddRange(tr.ToArray());//converte para array

        }

        private void btn_AddTransporte_Click(object sender, EventArgs e)
        {
            string transp = tb_Transporte.Text.ToString();
            if (tb_Transporte.Text != "")
            {
                if (clb_Transportes.Items.Contains(transp))
                {
                    MessageBox.Show("Veículo já existe na lista");
                }
                else
                {
                    clb_Transportes.Items.Add(transp, false);
                }
                tb_Transporte.Clear();
            }
            else
            {
                MessageBox.Show("Digite um veículo");
            }
        }
    }
}
