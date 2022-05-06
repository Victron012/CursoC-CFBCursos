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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form f)
        {
            InitializeComponent();
            form1 = (Form1)f;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string senha = tb_Senha.Text;

            if(username == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
                tb_Username.Focus();
                tb_Senha.Clear();
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME = '" + username + "' and T_SENHAUSUARIO = '" + senha + "'";
            dt = Banco.Consulta(sql);
            if (dt.Rows.Count ==1)
            {
                form1.lb_Acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_NomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
                form1.pb_LedLogado.Image = Properties.Resources.led_verde;
                Globais.nivel = int.Parse(dt.Rows[0].ItemArray[5].ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido!");
                tb_Username.Focus();
                tb_Senha.Clear();
            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                btn_Logar_Click(sender, e);
            }
        }

        private void tb_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Logar_Click(sender, e);
            }
        }
    }
}
