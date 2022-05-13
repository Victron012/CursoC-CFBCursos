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
    public partial class F_GestaoTurmas : Form
    {
        string id;
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }
        private void CarregarTurmas()
        {
            string query = @"select 
                tbt.N_IDTURMA as 'Id',
                tbt.T_DSCTURMA as 'Desc. Turma',
                tbt.N_MAXALUNOS as 'Max Alunos',
                tbh.T_DSCHORARIO as 'Horário',
                tbp.T_NOMEPROFESSOR as 'Professor',
                CASE
                    WHEN tbt.T_STATUS = 'A' THEN 'Ativa'
                    WHEN tbt.T_STATUS = 'P' THEN 'Paralisada'
                    WHEN tbt.T_STATUS = 'C' THEN 'Cancelada'
                END as 'Status'
             from 
                 tb_turmas as tbt
             inner join 
                 tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO, 
                 tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
            ";
            dgv_Turmas.DataSource = Banco.dql(query);
            dgv_Turmas.Columns[0].Width = 30;
            dgv_Turmas.Columns[1].Width = 95;
            dgv_Turmas.Columns[2].Width = 90;
            dgv_Turmas.Columns[3].Width = 90;
            dgv_Turmas.Columns[4].Width = 115;
            dgv_Turmas.Columns[5].Width = 64;
        }
        private void cbProfessor()
        {
            string query = @"
                SELECT 
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM    
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
            ";
            cb_Professor.Items.Clear();
            cb_Professor.DataSource = Banco.dql(query);
            cb_Professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_Professor.ValueMember = "N_IDPROFESSOR";
        }
        private void cbStatus()
        {
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");

            cb_Status.Items.Clear();
            cb_Status.DataSource =new BindingSource(st, null);
            cb_Status.DisplayMember="Value";
            cb_Status.ValueMember = "Key";
        }
        private void cbHorarios()
        {
            string query = @"
                SELECT 
                    *
                FROM    
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
            cb_Horarios.Items.Clear();
            cb_Horarios.DataSource = Banco.dql(query);
            cb_Horarios.DisplayMember = "T_DSCHORARIO";
            cb_Horarios.ValueMember = "N_IDHORARIO";
        }
        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            CarregarTurmas();
            cbProfessor();
            cbStatus();
            cbHorarios();
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
               id = dgv_Turmas.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string query = @"
                    SELECT 
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE 
                        N_IDTURMA="+id;
                DataTable dt = Banco.dql(query);
                tb_Turma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_Professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                cb_Horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                n_MaxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_Status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
            }
        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            F_NovaTurma f_NovaTurma = new F_NovaTurma();
            f_NovaTurma.ShowDialog();
            CarregarTurmas();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            string turma, st;
            int horario, prof, maxAlunos;

            turma = tb_Turma.Text;
            st = cb_Status.SelectedValue.ToString();
            horario = int.Parse(cb_Horarios.SelectedValue.ToString());
            prof = int.Parse(cb_Professor.SelectedValue.ToString());
            maxAlunos = int.Parse(n_MaxAlunos.Value.ToString());

            string query = String.Format("UPDATE tb_turmas SET T_DSCTURMA = '{0}', N_IDPROFESSOR = {1}, N_IDHORARIO = {2}, N_MAXALUNOS = {3}, T_STATUS = '{4}' WHERE N_IDTURMA = {5}",turma, prof, horario, maxAlunos, st, id);
            Banco.dml(query, "Turma atualizada com sucesso!");
            CarregarTurmas();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string query = "DELETE FROM tb_turmas WHERE N_IDTURMA =" + id;
                Banco.dml(query, "Turma excluida com sucesso!");
                CarregarTurmas();
            }
        }
    }
}
