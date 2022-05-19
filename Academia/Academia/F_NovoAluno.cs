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
    public partial class F_NovoAluno : Form
    {
        public F_NovoAluno()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            tb_Nome.Clear();
            tb_Telefone.Clear();
            cb_Status.SelectedIndex = 0;
            tb_Turma.Clear();
            tb_Plano.Clear();
            tb_Nome.Focus();
        }
        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");

            cb_Status.DataSource = new BindingSource(status, null);
            cb_Status.DisplayMember = "Value";
            cb_Status.ValueMember = "Key";
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Limpar();
            tb_Nome.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string nome, telefone, status;
            int turma, plano;

            nome = tb_Nome.Text;
            telefone = tb_Telefone.Text;
            status = cb_Status.SelectedValue.ToString();
            turma = int.Parse(tb_Turma.Tag.ToString());
            //plano = int.Parse(tb_Plano.Tag.ToString());
            try { 
            string query = String.Format(@"
                INSERT INTO tb_alunos 
                    (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA)
                VALUES
                    ('{0}', '{1}', '{2}', {3})", nome, telefone, status, turma);
            Banco.dml(query, "Aluno inserido com sucesso!");
            Limpar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SelTurma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma f_SelecionarTurma = new F_SelecionarTurma(this);
            f_SelecionarTurma.ShowDialog();
        }
    }
}
