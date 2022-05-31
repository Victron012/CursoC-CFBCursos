using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Academia
{
    public partial class F_GestaoAlunos : Form
    {
        private int turmaAtual;
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }
        private void CarregarAlunos()
        {
            string query = @"
                SELECT 
                    tba.N_IDALUNO as Id,
                    tba.T_NOMEALUNO as Aluno,
                    tba.T_TELEFONE as Telefone,
                    tbt.T_DSCTURMA as Turma,
                CASE
                    WHEN tba.T_STATUS = 'A' THEN 'Ativa'
                    WHEN tba.T_STATUS = 'B' THEN 'Bloqueado'
                    WHEN tba.T_STATUS = 'C' THEN 'Cancelado'
                END as Status
                FROM
                    tb_alunos as tba
                INNER JOIN
                    tb_turmas as tbt on tbt.N_IDTURMA = tba.N_IDTURMA            
            ";
            dgv_Alunos.DataSource = Banco.dql(query);
            dgv_Alunos.Columns[0].Width = 50;
            dgv_Alunos.Columns[1].Width = 115;
            dgv_Alunos.Columns[2].Width = 110;
            dgv_Alunos.Columns[3].Width = 110;
            dgv_Alunos.Columns[4].Width = 100;
        }
        private void CarregarStatus()
        {
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("B", "Bloqueado");
            st.Add("C", "Cancelado");

            cb_Status.Items.Clear();
            cb_Status.DataSource = new BindingSource(st, null);
            cb_Status.DisplayMember = "Value";
            cb_Status.ValueMember = "Key";
        }
        private void CarregarTurmas()
        {
            string query = @"
                SELECT 
                    N_IDTURMA,
                    (tbt.T_DSCTURMA ||
                        ' / Vagas:'||(
                                    (N_MAXALUNOS)-(
                                                        SELECT
                                                            count(tba.N_IDALUNO)
                                                        FROM
                                                            tb_alunos as tba
                                                        WHERE
                                                            tba.T_STATUS='A' and tba.N_IDTURMA=tbt.N_IDTURMA 
                                                    )
                                   )
                    ) as 'Turma'
                FROM
                    tb_turmas as tbt
                WHERE
                    tbt.T_STATUS = 'A'
            ";
            Banco.dql(query);
            try
            {
                cb_Turmas.Items.Clear();
            }
            catch { }
            cb_Turmas.DataSource = Banco.dql(query);
            cb_Turmas.DisplayMember = "Turma";
            cb_Turmas.ValueMember = "N_IDTURMA";
        }
        private bool ContVagas(int i)
        {
            int id = i, vagas;
            DataTable dt = new DataTable();
            string query = String.Format(@"
                SELECT 
                    (N_MAXALUNOS) -
                        (
                            SELECT
                                count(tba.N_IDALUNO)
                            FROM
                                tb_alunos as tba
                            WHERE
                                tba.T_STATUS='A' and tba.N_IDTURMA={0}
                        ) as 'contVagas'
                FROM
                    tb_turmas as tbt
                WHERE
                    tbt.T_STATUS = 'A' AND tbt.N_IDTURMA = {1}", id, id);
            dt = Banco.dql(query);
            vagas = int.Parse(dt.Rows[0].Field<Int64>("contVagas").ToString());
            if (vagas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
            CarregarTurmas();
            CarregarStatus();
            CarregarAlunos();
        }

        private void dgv_Alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                int id = int.Parse(dgv_Alunos.SelectedRows[0].Cells[0].Value.ToString());
                string query = @"
                    SELECT
                        T_NOMEALUNO,
                        T_TELEFONE,
                        N_IDTURMA,
                        T_STATUS,
                        T_IMGALUNO
                    FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO = " + id;
                DataTable dt = Banco.dql(query);
                tb_Nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                tb_Telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                cb_Turmas.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTURMA");
                cb_Status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                turmaAtual = int.Parse(dt.Rows[0].Field<Int64>("N_IDTURMA").ToString());
                pb_Foto.ImageLocation = dt.Rows[0].Field<string>("T_IMGALUNO");
                destinoCompleto = dt.Rows[0].Field<string>("T_IMGALUNO");
            }
        }
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            f_NovoAluno.ShowDialog();
        }
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, telefone, status, foto;
                int id, turma;

                nome = tb_Nome.Text;
                telefone = tb_Telefone.Text;
                status = cb_Status.SelectedValue.ToString();
                turma = int.Parse(cb_Turmas.SelectedValue.ToString());
                id = int.Parse(dgv_Alunos.SelectedRows[0].Cells[0].Value.ToString());
                foto = pb_Foto.ImageLocation;
                if (turmaAtual != turma)
                {
                    if (!ContVagas(turma))
                    {
                        MessageBox.Show("Não há vagas para essa turma!");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                        if (File.Exists(destinoCompleto))
                        {
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir arquivo");
                        }
                    }
                    catch { }
                    string query = String.Format(@"
                            UPDATE 
                                tb_alunos
                            SET 
                                T_NOMEALUNO = '{0}',
                                T_TELEFONE = '{1}', 
                                T_STATUS = '{2}',
                                N_IDTURMA = {3},
                                T_IMGALUNO = '{4}'
                            WHERE
                                N_IDALUNO = {5};", nome, telefone, status, turma, foto, id);

                    Banco.dml(query, "Aluno atualizado com sucesso!");
                    CarregarAlunos();
                    CarregarTurmas();
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar aluno" + ex);
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar exclusão?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(dgv_Alunos.SelectedRows[0].Cells[0].Value.ToString());

                try
                {
                    if (File.Exists(pb_Foto.ImageLocation)&& pb_Foto.ImageLocation != Globais.caminhoFotosPadrao)
                    {
                        File.Delete(pb_Foto.ImageLocation);
                    }

                string query = @"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO = " + id;
                    Banco.dml(query, "Aluno excluido com sucesso!");
                    CarregarAlunos();
                    CarregarTurmas();
                }
                catch
                {
                    MessageBox.Show("Erro ao excluir aluno");
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
                if (File.Exists(destinoCompleto))
                {
                    if (MessageBox.Show("Arquivo já existe. Deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                pb_Foto.ImageLocation = origemCompleto;
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, telefone, status, turma, foto, dados="";
                int linhas, id;
                string nomeArquivo;
                id = int.Parse(dgv_Alunos.SelectedRows[0].Cells[0].Value.ToString());

                string query = @"select 
                    tba.T_NOMEALUNO as 'Nome',
                    tba.T_TELEFONE as 'Telefone',
                    tbt.T_DSCTURMA as 'Turma',
                    tba.T_IMGALUNO as 'Foto',
                    CASE
                        WHEN tba.T_STATUS = 'A' THEN 'Ativa'
                        WHEN tba.T_STATUS = 'P' THEN 'Paralisada'
                        WHEN tba.T_STATUS = 'C' THEN 'Cancelada'
                    END as 'Status'
                 from 
                     tb_alunos as tba
                 inner join 
                     tb_turmas as tbt on tbt.N_IDTURMA = tba.N_IDTURMA
                  WHERE 
                     N_IDALUNO = " + id;
                DataTable dt = Banco.dql(query);

                nome = dt.Rows[0].Field<string>("Nome");
                nomeArquivo = Globais.caminho + @"\carteirinhas\"+nome+".pdf";
                
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                linhas = dt.Rows.Count;

                Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Regular);

                PdfPTable tabela = new PdfPTable(5);
                tabela.DefaultCell.FixedHeight = 20;
                PdfPCell celula = new PdfPCell(new Phrase("Carteirinha"));
                celula.Colspan = 5;
                celula.FixedHeight = 30;
                celula.HorizontalAlignment = Element.ALIGN_CENTER;
                celula.VerticalAlignment = Element.ALIGN_MIDDLE;
                tabela.AddCell(celula);

                
                for (int i = 0; linhas > i; i++)
                {
                    nome = dt.Rows[i].Field<string>("Nome");
                    telefone = dt.Rows[i].Field<string>("Telefone");
                    turma = dt.Rows[i].Field<string>("Turma");
                    status = dt.Rows[i].Field<string>("Status");
                    foto = dt.Rows[i].Field<string>("Foto");
                    
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(foto);
                    img.Alignment = Element.ALIGN_JUSTIFIED;

                    PdfPCell celNome = new PdfPCell(new Phrase("Nome: " + nome));
                    celNome.Colspan = 4;
                    celNome.FixedHeight = 25;
                    celNome.HorizontalAlignment = Element.ALIGN_LEFT;
                    celNome.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabela.AddCell(celNome);

                    PdfPCell celImg = new PdfPCell(img);
                    celImg.Rowspan = 5;
                    celImg.FixedHeight = 25;
                    celImg.HorizontalAlignment = Element.ALIGN_LEFT;
                    celImg.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabela.AddCell(celImg);

                    PdfPCell celTelefone = new PdfPCell(new Phrase("Telefone: " + telefone));
                    celTelefone.Colspan = 4;
                    celTelefone.FixedHeight = 25;
                    celTelefone.HorizontalAlignment = Element.ALIGN_LEFT;
                    celTelefone.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabela.AddCell(celTelefone);

                    PdfPCell celTurma = new PdfPCell(new Phrase("Turma: " + turma));
                    celTurma.Colspan = 4;
                    celTurma.FixedHeight = 25;
                    celTurma.HorizontalAlignment = Element.ALIGN_LEFT;
                    celTurma.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabela.AddCell(celTurma);

                    PdfPCell celStatus = new PdfPCell(new Phrase("Status: " + status));
                    celStatus.Colspan = 4;
                    celStatus.FixedHeight = 25;
                    celStatus.HorizontalAlignment = Element.ALIGN_LEFT;
                    celStatus.VerticalAlignment = Element.ALIGN_MIDDLE;
                    tabela.AddCell(celStatus);

                }
                doc.Open();
                doc.Add(tabela);
                doc.Close();

                DialogResult res = MessageBox.Show("Deseja abrir o relatório", "Relatório", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(nomeArquivo);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao criar PDF turmas");
            }
        }
    }
}
