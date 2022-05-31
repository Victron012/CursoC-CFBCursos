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

        private void AbrirForm(int nivel, Form f)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
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
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            AbrirForm(1, f_NovoUsuario);
        }

        private void gestãoDeUsuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_GestaoUsuario f_GestaoUsuario = new F_GestaoUsuario();
            AbrirForm(1, f_GestaoUsuario);
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                F_NovoAluno f_NovoAluno = new F_NovoAluno();
                AbrirForm(1, f_NovoAluno);
            }
            else
            {
                MessageBox.Show("É necessário estar logado");
            }
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();

            AbrirForm(2,f_Horarios);
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            AbrirForm(2, f_GestaoProfessores);
        }

        private void novoProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoProfessor f_NovoProfessor = new F_NovoProfessor();
            AbrirForm(2, f_NovoProfessor);
        }

        private void gestãoTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            AbrirForm(2, f_GestaoTurmas);
        }

        private void novaTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovaTurma f_NovaTurma = new F_NovaTurma();
            AbrirForm(2, f_NovaTurma);
        }

        private void gestãoAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoAlunos f_GestaoAlunos = new F_GestaoAlunos();
            AbrirForm(2, f_GestaoAlunos);
        }
    }
}
