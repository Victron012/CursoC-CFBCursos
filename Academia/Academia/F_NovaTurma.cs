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
    public partial class F_NovaTurma : Form
    {
        public F_NovaTurma()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            tb_Turma.Clear();
            cb_Horarios.SelectedIndex = -1;
            cb_Professor.SelectedIndex = -1;
            cb_Status.SelectedIndex = -1;
            n_MaxAlunos.Value = 0;
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
            cb_Status.DataSource = new BindingSource(st, null);
            cb_Status.DisplayMember = "Value";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void F_NovaTurma_Load(object sender, EventArgs e)
        {
            cbHorarios();
            cbProfessor();
            cbStatus();
            Limpar();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string turma, st;
            int horario, prof, maxAlunos;

            turma = tb_Turma.Text;
            st = cb_Status.SelectedValue.ToString();
            horario = int.Parse(cb_Horarios.SelectedValue.ToString());
            prof = int.Parse(cb_Professor.SelectedValue.ToString());
            maxAlunos = int.Parse(n_MaxAlunos.Value.ToString());
            
            string query = String.Format("INSERT INTO tb_turmas (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS) VALUES ('{0}',{1},{2},{3},'{4}')", turma ,prof,horario, maxAlunos, st);
            Banco.dml(query, "Turma criada com sucesso!");
            Limpar();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
