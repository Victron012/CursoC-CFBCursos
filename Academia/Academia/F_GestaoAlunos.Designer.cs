
namespace Academia
{
    partial class F_GestaoAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Turmas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Alunos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btn_Financeiro = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(526, 19);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(272, 20);
            this.tb_Nome.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nome";
            // 
            // cb_Turmas
            // 
            this.cb_Turmas.FormattingEnabled = true;
            this.cb_Turmas.Location = new System.Drawing.Point(526, 120);
            this.cb_Turmas.Name = "cb_Turmas";
            this.cb_Turmas.Size = new System.Drawing.Size(273, 21);
            this.cb_Turmas.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Turmas";
            // 
            // dgv_Alunos
            // 
            this.dgv_Alunos.AllowUserToAddRows = false;
            this.dgv_Alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alunos.EnableHeadersVisualStyles = false;
            this.dgv_Alunos.Location = new System.Drawing.Point(12, 3);
            this.dgv_Alunos.MultiSelect = false;
            this.dgv_Alunos.Name = "dgv_Alunos";
            this.dgv_Alunos.ReadOnly = true;
            this.dgv_Alunos.RowHeadersVisible = false;
            this.dgv_Alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Alunos.ShowEditingIcon = false;
            this.dgv_Alunos.Size = new System.Drawing.Size(505, 379);
            this.dgv_Alunos.TabIndex = 61;
            this.dgv_Alunos.SelectionChanged += new System.EventHandler(this.dgv_Alunos_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Telefone";
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_Status.Location = new System.Drawing.Point(665, 70);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(133, 21);
            this.cb_Status.TabIndex = 56;
            // 
            // btn_Financeiro
            // 
            this.btn_Financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Financeiro.Location = new System.Drawing.Point(568, 14);
            this.btn_Financeiro.Name = "btn_Financeiro";
            this.btn_Financeiro.Size = new System.Drawing.Size(119, 23);
            this.btn_Financeiro.TabIndex = 3;
            this.btn_Financeiro.Text = "Financeiro";
            this.btn_Financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(318, 14);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(119, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar Alterações";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Controls.Add(this.btn_Financeiro);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 59);
            this.panel1.TabIndex = 60;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(193, 14);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(119, 23);
            this.btn_Novo.TabIndex = 4;
            this.btn_Novo.Text = "Novo Aluno";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(443, 14);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(119, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Aluno";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Status";
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(526, 71);
            this.tb_Telefone.Mask = "(99) 99999-9999";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(133, 20);
            this.tb_Telefone.TabIndex = 68;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(526, 156);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(271, 23);
            this.btn_Imprimir.TabIndex = 69;
            this.btn_Imprimir.Text = "Imprimir Carteirinha";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Clique duplo para alterar a foto";
            // 
            // pb_Foto
            // 
            this.pb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Foto.Location = new System.Drawing.Point(526, 187);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(85, 113);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Foto.TabIndex = 71;
            this.pb_Foto.TabStop = false;
            this.pb_Foto.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.pb_Foto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Turmas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Alunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Turmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Alunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btn_Financeiro;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_Foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}