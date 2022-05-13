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
    public partial class F_Horarios : Form
    {
        public F_Horarios()
        {
            InitializeComponent();
        }

        private void CarregarHorarios()
        {
            string query = @"
                SELECT 
                    N_IDHORARIO as 'Id',
                    T_DSCHORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY T_DSCHORARIO
            ";
            dgv_Horarios.DataSource = Banco.dql(query);
            dgv_Horarios.Columns[0].Width = 60;
            dgv_Horarios.Columns[1].Width = 230;
        }

        private void F_Horarios_Load(object sender, EventArgs e)
        {
            CarregarHorarios();
        }

        private void dgv_Horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;

            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv_Horarios.SelectedRows[0].Cells[0].Value.ToString();
                string query = @"
                    SELECT 
                        *
                    FROM
                        tb_horarios
                    WHERE
                        N_IDHORARIO =" + id;
                dt = Banco.dql(query);
                tb_Id.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                tb_Horario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");

            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            F_NovoHorario f_NovoHorario = new F_NovoHorario();
            f_NovoHorario.ShowDialog();
            CarregarHorarios();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "UPDATE tb_horarios SET T_DSCHORARIO = '" + tb_Horario.Text + "' WHERE N_IDHORARIO = '" + tb_Id.Text + "'";
            Banco.dml(query, "Usuário atualizado com sucesso!");
            CarregarHorarios();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja resalmente excluir?", "Excluir", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                string query = "DELETE FROM tb_horarios WHERE N_IDHORARIO = '" + tb_Id.Text + "'";
                Banco.dml(query, "Usuário excluido com sucesso!");
                CarregarHorarios();
            }
        }

        private void tb_Horario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Salvar_Click(sender, e);
            }
        }
    }
}
