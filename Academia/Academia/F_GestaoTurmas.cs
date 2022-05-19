using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
        private int ContVagas(string tipo)
        {
            DataTable dt = new DataTable();
            string query = String.Format(@"
                    SELECT  
                        count(N_IDALUNO) as 'contVagas'
                    FROM
                        tb_alunos
                    WHERE
                        T_STATUS = 'A' and N_IDTURMA ={0}", id);
            dt = Banco.dql(query);
            if (tipo == "vagasLivres")
            {
                int vagas = int.Parse(Math.Round(n_MaxAlunos.Value, 0).ToString());
                vagas -= int.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
                return vagas;
            }
            else
            {
                int vagas = int.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
                return vagas;
            }
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
                        N_IDTURMA=" + id;
                DataTable dt = Banco.dql(query);
                tb_Turma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_Professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                cb_Horarios.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                n_MaxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_Status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");

                tb_Vagas.Text = ContVagas("vagasLivres").ToString();
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
            if (ContVagas("vagasPreenchidas") > n_MaxAlunos.Value)
            {
                MessageBox.Show("Número máximo de alunos inferior ao número de alunos já matriculados!");
                return;
            }
            turma = tb_Turma.Text;
            st = cb_Status.SelectedValue.ToString();
            horario = int.Parse(cb_Horarios.SelectedValue.ToString());
            prof = int.Parse(cb_Professor.SelectedValue.ToString());
            maxAlunos = int.Parse(n_MaxAlunos.Value.ToString());

            string query = String.Format("UPDATE tb_turmas SET T_DSCTURMA = '{0}', N_IDPROFESSOR = {1}, N_IDHORARIO = {2}, N_MAXALUNOS = {3}, T_STATUS = '{4}' WHERE N_IDTURMA = {5}", turma, prof, horario, maxAlunos, st, id);
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

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string turma, professor, maxAlunos, status, horario, dados="";
                int linhas;
                string nomeArquivo = Globais.caminho + @"\turmas.pdf";
                
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                string query = @"select 
                    tbt.T_DSCTURMA as 'DescTurma',
                    tbt.N_MAXALUNOS as 'MaxAlunos',
                    tbh.T_DSCHORARIO as 'Horario',
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
                DataTable dt = Banco.dql(query);

                linhas = dt.Rows.Count;

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.png");
                logo.ScaleToFit(140f, 120f);
                logo.Alignment = Element.ALIGN_CENTER;
                //logo.SetAbsolutePosition(100f, 700f); // X, -Y
                
                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

                PdfPTable tabela = new PdfPTable(5);
                tabela.DefaultCell.FixedHeight = 20;
                PdfPCell celula = new PdfPCell(new Phrase("Relatórios de Turmas"));
                celula.Colspan = 5;
                celula.FixedHeight = 40;
                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                tabela.AddCell(celula);

                tabela.AddCell("Turma");
                tabela.AddCell("Professor");
                tabela.AddCell("Máx. Alunos");
                tabela.AddCell("Horários");
                tabela.AddCell("Status");
                for (int i = 0; linhas > i; i++)
                { 
                    turma = dt.Rows[i].Field<string>("DescTurma");
                    professor = dt.Rows[i].Field<string>("Professor");
                    horario = dt.Rows[i].Field<string>("Horario");
                    maxAlunos = dt.Rows[i].Field<Int64>("MaxAlunos").ToString();
                    status = dt.Rows[i].Field<string>("Status");

                    tabela.AddCell(turma);
                    tabela.AddCell(professor);
                    tabela.AddCell(maxAlunos);
                    tabela.AddCell(horario);
                    tabela.AddCell(status);
                }
                doc.Open();
                doc.Add(logo);
                doc.Add(tabela);
                doc.Close();

                DialogResult res = MessageBox.Show("Deseja abrir o relatório", "Relatório", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
                }
            }
            catch
            {
                MessageBox.Show("Erro ao criar PDF turmas");
            }
        }
    }
}
