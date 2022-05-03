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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text;
            var tag = treeView1.SelectedNode.Tag;
            if (tag != null)
            {
                textBox2.Text = tag.ToString();

            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            TreeNode no = treeView1.SelectedNode.Nodes.Add(nome);
            no.Name = nome;
        }

        private void tbn_AddRaiz_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;

            TreeNode no = treeView1.Nodes.Add(nome);
            no.Name = nome;
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            try {   
                treeView1.SelectedNode.Remove();
            }
            catch
            {
                MessageBox.Show("Selecione um nó");   
            }

        }
    }
}
