
namespace Academia
{
    partial class F_GestaoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Turmas = new System.Windows.Forms.DataGridView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_NovoUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n_MaxAlunos = new System.Windows.Forms.NumericUpDown();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Professor = new System.Windows.Forms.ComboBox();
            this.cb_Horarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Turma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_MaxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Turmas
            // 
            this.dgv_Turmas.AllowUserToAddRows = false;
            this.dgv_Turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turmas.EnableHeadersVisualStyles = false;
            this.dgv_Turmas.Location = new System.Drawing.Point(12, 6);
            this.dgv_Turmas.MultiSelect = false;
            this.dgv_Turmas.Name = "dgv_Turmas";
            this.dgv_Turmas.ReadOnly = true;
            this.dgv_Turmas.RowHeadersVisible = false;
            this.dgv_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turmas.ShowEditingIcon = false;
            this.dgv_Turmas.Size = new System.Drawing.Size(505, 379);
            this.dgv_Turmas.TabIndex = 45;
            this.dgv_Turmas.SelectionChanged += new System.EventHandler(this.dgv_Usuarios_SelectionChanged);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(415, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(119, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Turma";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_NovoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 59);
            this.panel1.TabIndex = 44;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Imprimir.Location = new System.Drawing.Point(540, 3);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(119, 23);
            this.btn_Imprimir.TabIndex = 3;
            this.btn_Imprimir.Text = "Imprimir Turma";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(290, 3);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(119, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar Alterações";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_NovoUsuario
            // 
            this.btn_NovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NovoUsuario.Location = new System.Drawing.Point(165, 3);
            this.btn_NovoUsuario.Name = "btn_NovoUsuario";
            this.btn_NovoUsuario.Size = new System.Drawing.Size(119, 23);
            this.btn_NovoUsuario.TabIndex = 0;
            this.btn_NovoUsuario.Text = "Nova Turma";
            this.btn_NovoUsuario.UseVisualStyleBackColor = true;
            this.btn_NovoUsuario.Click += new System.EventHandler(this.btn_NovoUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Máximo Alunos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Status";
            // 
            // n_MaxAlunos
            // 
            this.n_MaxAlunos.Location = new System.Drawing.Point(526, 122);
            this.n_MaxAlunos.Name = "n_MaxAlunos";
            this.n_MaxAlunos.Size = new System.Drawing.Size(133, 20);
            this.n_MaxAlunos.TabIndex = 3;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_Status.Location = new System.Drawing.Point(665, 122);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(133, 21);
            this.cb_Status.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Professor";
            // 
            // cb_Professor
            // 
            this.cb_Professor.FormattingEnabled = true;
            this.cb_Professor.Location = new System.Drawing.Point(526, 66);
            this.cb_Professor.Name = "cb_Professor";
            this.cb_Professor.Size = new System.Drawing.Size(273, 21);
            this.cb_Professor.TabIndex = 2;
            // 
            // cb_Horarios
            // 
            this.cb_Horarios.FormattingEnabled = true;
            this.cb_Horarios.Location = new System.Drawing.Point(526, 180);
            this.cb_Horarios.Name = "cb_Horarios";
            this.cb_Horarios.Size = new System.Drawing.Size(273, 21);
            this.cb_Horarios.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Horários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Turma";
            // 
            // tb_Turma
            // 
            this.tb_Turma.Location = new System.Drawing.Point(526, 22);
            this.tb_Turma.Name = "tb_Turma";
            this.tb_Turma.Size = new System.Drawing.Size(272, 20);
            this.tb_Turma.TabIndex = 1;
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.tb_Turma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Horarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Professor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Turmas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_MaxAlunos);
            this.Controls.Add(this.cb_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_MaxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Turmas;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_NovoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown n_MaxAlunos;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Professor;
        private System.Windows.Forms.ComboBox cb_Horarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Turma;
    }
}