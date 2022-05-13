using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class F_NovoProfessor : Form
    {
        
        public F_NovoProfessor()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            tb_Nome.Clear();
            tb_Telefone.Clear();
            tb_Nome.Focus();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) VALUES ('" + tb_Nome.Text + "', '" + tb_Telefone.Text + "')";
            Banco.dml(query, "Usuário inserido com sucesso");
            Limpar();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }
    }
}
