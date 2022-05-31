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
    public partial class F_SelecionarTurma : Form
    {
        F_NovoAluno f = new F_NovoAluno();
        public F_SelecionarTurma(F_NovoAluno f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string query = @"
                SELECT  
                    tbt.N_IDTURMA as 'Id',
                tbt.T_DSCTURMA as 'Desc. Turma',
                tbt.N_MAXALUNOS as 'Max Alunos',
                tbt.N_MAXALUNOS - (   SELECT
                        count(N_IDALUNO)
                    FROM    
                        tb_alunos as tba
                    WHERE
                        tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A'
                ) as 'Vagas',
                tbh.T_DSCHORARIO as 'Horário',
                tbp.T_NOMEPROFESSOR as 'Professor',
                CASE
                    WHEN tbt.T_STATUS = 'A' THEN 'Ativa'
                    WHEN tbt.T_STATUS = 'P' THEN 'Paralisada'
                    WHEN tbt.T_STATUS = 'C' THEN 'Cancelada'
                END as 'Status'
                FROM 
                    tb_turmas as tbt
                INNER JOIN 
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO, 
                    tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
                WHERE
                    tbt.T_STATUS = 'A'
            ";
            DataTable dt = new DataTable();
            dt = Banco.dql(query);
            dgv_Turmas.DataSource = dt;
            dgv_Turmas.Columns[1].Width = 142;
        }

        private void dgv_Turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int vagas = 0;
            string turma = "", tag = "";

            vagas = int.Parse(dgv.SelectedRows[0].Cells[3].Value.ToString());
            turma = dgv.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[1].Value.ToString();
            tag = dgv_Turmas.SelectedRows[0].Cells[0].Value.ToString();
            if (vagas <= 0)
            {
                MessageBox.Show("Não há vagas para essa turma!");
            }
            else
            {
                f.tb_Turma.Text = turma;
                f.tb_Turma.Tag = tag;
                this.Close();
            }
            }
        }
    }
