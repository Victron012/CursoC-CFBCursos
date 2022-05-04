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
    public partial class F_TabControl : Form
    {
        public F_TabControl()
        {
            InitializeComponent();
            definirMaximo();
        }

        private void btn_NovaTab_Click(object sender, EventArgs e)
        {
            var nome = tb_NomeTab.Text;
            if(nome != "")
            {
                TabPage pag = new TabPage();
                pag.Text = nome;
                pag.Name = "Tab_" + nome;
                pag.TabIndex = tabControl1.TabPages.Count;
                tabControl1.TabPages.Add(pag);
                tb_NomeTab.Clear();
                definirMaximo();
            }
            else
            {
                MessageBox.Show("Insira um nome para a Tab!");
                tb_NomeTab.Focus();
            }
        }

        private void btn_RemoverTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == null)
            {
                MessageBox.Show("Selecione uma Tab!");
                return;
            }
            F_DesejaExcluir f_DesejaExcluir = new F_DesejaExcluir();
            f_DesejaExcluir.ShowDialog();

            char ret = f_DesejaExcluir.d;
            if (ret == 'S') {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                definirMaximo();
            }
        }

        private void btn_PosicaoTab_Click(object sender, EventArgs e)
        {
            var n = numericUpDown1.Value;
            if (n < tabControl1.TabPages.Count)
            {
                tabControl1.SelectedIndex = int.Parse(n.ToString());
            }
        }
        private void definirMaximo()
        {
            numericUpDown1.Maximum = tabControl1.TabPages.Count-1;
        }
    }
}
