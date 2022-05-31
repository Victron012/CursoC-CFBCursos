using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academia
{
    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
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
            pb_Foto.ImageLocation = Globais.caminhoFotosPadrao;
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
            int turma; //plano

            nome = tb_Nome.Text;
            telefone = tb_Telefone.Text;
            status = cb_Status.SelectedValue.ToString();
            turma = int.Parse(tb_Turma.Tag.ToString());
            //plano = int.Parse(tb_Plano.Tag.ToString());

            if (nome == "" || telefone == "" || status == "" || turma == 0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            try
            {
                string query = String.Format(@"
                INSERT INTO tb_alunos 
                    (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_IMGALUNO)
                VALUES
                    ('{0}', '{1}', '{2}', {3}, '{4}')", nome, telefone, status, turma, destinoCompleto);
                Banco.dml(query, "Aluno inserido com sucesso!");
                try
                {
                    System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                    if (File.Exists(destinoCompleto))
                    {
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir arquivo");
                    }
                }
                catch { }

                Limpar();
            }
            catch (Exception ex)
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

        private void btn_Foto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
                if (File.Exists(destinoCompleto))
                {
                    if (MessageBox.Show("Arquivo já existe. Deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                pb_Foto.ImageLocation = origemCompleto;
            }
        }
    }
}
