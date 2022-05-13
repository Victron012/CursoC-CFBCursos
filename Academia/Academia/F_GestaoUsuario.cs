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
    public partial class F_GestaoUsuario : Form
    {
        public F_GestaoUsuario()
        {
            InitializeComponent();
        }
        private void CarregarUsuarios()
        {
            dgv_Usuarios.DataSource = Banco.ObterUsuariosId();
            dgv_Usuarios.Columns[0].Width = 85;
            dgv_Usuarios.Columns[1].Width = 180;
            dgv_Usuarios.Columns[2].Width = 190;
            dgv_Usuarios.Columns[3].Width = 155;
        }
        private void F_GestaoUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterUsuario(id);

                tb_IdUsuario.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_Nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                tb_UserName.Text = dt.Rows[0].Field<string>("T_USERNAME");
                tb_Senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO");
                cb_Status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO");
                n_Nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                DataGridView dgv = dgv_Usuarios;
                int contLinhas = dgv.SelectedRows.Count;
                if (contLinhas > 0)
                {
                    string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    Banco.ExcluirUsuario(id);

                    CarregarUsuarios();
                }
            }
        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            CarregarUsuarios();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_Usuarios.SelectedRows[0].Index;
            Usuario usuario = new Usuario();
            usuario.id = int.Parse(tb_IdUsuario.Text);
            usuario.nome = tb_Nome.Text;
            usuario.username = tb_UserName.Text;
            usuario.senha = tb_Senha.Text;
            usuario.stauts = cb_Status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_Nivel.Value, 0));

            Banco.AlterarUsuario(usuario);
            CarregarUsuarios();
            dgv_Usuarios.CurrentCell = dgv_Usuarios[0, linha];
        }

        private void tb_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }
    }
}
