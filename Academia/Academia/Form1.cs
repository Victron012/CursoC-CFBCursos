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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_Acesso.Text = "0";
            lb_NomeUsuario.Text = "---";
            pb_LedLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 2)
                {

                }
                else
                {
                    MessageBox.Show("Acesso negado!");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado!");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_GestaoUsuario f_GestaoUsuario = new F_GestaoUsuario();
                    f_GestaoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso negado!");
                }
            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }
    }
}
