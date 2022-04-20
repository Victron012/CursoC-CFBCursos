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
    public partial class F_ListView : Form
    {
        private void Limpar()
        {
            tb_Id.Clear();
            tb_Produto.Clear();
            tb_Qtde.Clear();
            tb_Preco.Clear();
            tb_Id.Focus();
        }
        public F_ListView()
        {
            InitializeComponent();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Id.Text != "")
            {
                if (tb_Produto.Text != "")
                {
                    if (tb_Qtde.Text != "")
                    {
                        if (tb_Preco.Text != "")
                        {
                            string[] pr = new string[4];
                            pr[0] = tb_Id.Text;
                            pr[1] = tb_Produto.Text;
                            pr[2] = tb_Qtde.Text;
                            pr[3] = tb_Preco.Text;

                            ListViewItem l = new ListViewItem(pr);//adiciona o array em uma linha da lista
                            lv_Produtos.Items.Add(l);

                            Limpar();
                        }
                        else
                        {
                            MessageBox.Show("Digite um preço");
                            tb_Preco.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite uma quantidade");
                        tb_Qtde.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Digite um produto");
                    tb_Produto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um id");
                tb_Id.Focus();
            }
        }

        private void btn_Rem_Click(object sender, EventArgs e)
        {
            try
            {

                lv_Produtos.Items.RemoveAt(lv_Produtos.SelectedIndices[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um produto");
            }
        }
        private void btn_Obter_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
                tb_Produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
                tb_Qtde.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
                tb_Preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
            }
            catch
            {
                MessageBox.Show("Selecione um produto");
            }
        }

        private void lv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Produtos.SelectedItems.Count > 0)
            {
                tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
                tb_Produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
                tb_Qtde.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
                tb_Preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
