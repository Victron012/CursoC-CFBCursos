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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            tb_Nome.Clear();
            tb_UserName.Clear();
            tb_Senha.Clear();
            cb_Status.Text = "";
            n_Nivel.Value = 0;
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome = tb_Nome.Text;
            usuario.username = tb_UserName.Text;
            usuario.senha = tb_Senha.Text;
            usuario.stauts = cb_Status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(n_Nivel.Value,0));

            Banco.NovoUsuario(usuario);

            LimparCampos();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
