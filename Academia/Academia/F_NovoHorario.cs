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
    public partial class F_NovoHorario : Form
    {
        public F_NovoHorario()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            tb_Horario.Clear();
            tb_Horario.Focus();
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('" + tb_Horario.Text + "')";
            Banco.dml(query);
            Limpar();
        }

        private void pn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Horario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }
    }
}
