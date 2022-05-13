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
    public partial class F_GestaoProfessores : Form
    {
        public F_GestaoProfessores()
        {
            InitializeComponent();
        }
        private void CarregarProfessores()
        {
            string query = @"SELECT N_IDPROFESSOR as 'Id', 
                                T_NOMEPROFESSOR as 'Nome',
                                T_TELEFONE as 'Telefone' FROM tb_professores";
            dgv_Usuarios.DataSource = Banco.dql(query);
            dgv_Usuarios.Columns[0].Width = 85;
            dgv_Usuarios.Columns[1].Width = 190;
            dgv_Usuarios.Columns[2].Width = 197;
        }

        private void F_GestaoProfessores_Load(object sender, EventArgs e)
        {
            CarregarProfessores();
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string query = "SELECT * FROM tb_professores WHERE N_IDPROFESSOR = "+id;
                dt = Banco.dql(query);

                tb_Id.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                tb_Nome.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                tb_Telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
            }
        }

        private void btn_NovoProfessor_Click(object sender, EventArgs e)
        {
            F_NovoProfessor f_NovoProfessor = new F_NovoProfessor();
            f_NovoProfessor.ShowDialog();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string id = dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString();
            string query = "UPDATE tb_professores SET T_NOMEPROFESSOR = '" +tb_Nome.Text +"', T_TELEFONE = '"+tb_Telefone.Text+"' WHERE N_IDPROFESSOR = "+id;
            Banco.dql(query);
            CarregarProfessores();
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            string id = dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString();
            string query = "DELETE FROM tb_professores WHERE N_IDPROFESSOR = "+id;
            Banco.dml(query, "Professor excluido com sucesso!");
            CarregarProfessores();
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
