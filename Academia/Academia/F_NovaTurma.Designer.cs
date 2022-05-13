
namespace Academia
{
    partial class F_NovaTurma
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
            this.tb_Turma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Horarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Professor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.n_MaxAlunos = new System.Windows.Forms.NumericUpDown();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_NovaTurma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n_MaxAlunos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Turma
            // 
            this.tb_Turma.Location = new System.Drawing.Point(15, 25);
            this.tb_Turma.Name = "tb_Turma";
            this.tb_Turma.Size = new System.Drawing.Size(272, 20);
            this.tb_Turma.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Turma";
            // 
            // cb_Horarios
            // 
            this.cb_Horarios.FormattingEnabled = true;
            this.cb_Horarios.Location = new System.Drawing.Point(15, 183);
            this.cb_Horarios.Name = "cb_Horarios";
            this.cb_Horarios.Size = new System.Drawing.Size(273, 21);
            this.cb_Horarios.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Horários";
            // 
            // cb_Professor
            // 
            this.cb_Professor.FormattingEnabled = true;
            this.cb_Professor.Location = new System.Drawing.Point(15, 69);
            this.cb_Professor.Name = "cb_Professor";
            this.cb_Professor.Size = new System.Drawing.Size(273, 21);
            this.cb_Professor.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Professor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Máximo Alunos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Status";
            // 
            // n_MaxAlunos
            // 
            this.n_MaxAlunos.Location = new System.Drawing.Point(15, 125);
            this.n_MaxAlunos.Name = "n_MaxAlunos";
            this.n_MaxAlunos.Size = new System.Drawing.Size(133, 20);
            this.n_MaxAlunos.TabIndex = 53;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_Status.Location = new System.Drawing.Point(154, 125);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(133, 21);
            this.cb_Status.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_NovaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 50);
            this.panel1.TabIndex = 61;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(193, 15);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(112, 15);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_NovaTurma
            // 
            this.btn_NovaTurma.Location = new System.Drawing.Point(31, 15);
            this.btn_NovaTurma.Name = "btn_NovaTurma";
            this.btn_NovaTurma.Size = new System.Drawing.Size(75, 23);
            this.btn_NovaTurma.TabIndex = 0;
            this.btn_NovaTurma.Text = "Nova Turma";
            this.btn_NovaTurma.UseVisualStyleBackColor = true;
            this.btn_NovaTurma.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_NovaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 276);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Turma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Horarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Professor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.n_MaxAlunos);
            this.Controls.Add(this.cb_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovaTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Turma";
            this.Load += new System.EventHandler(this.F_NovaTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_MaxAlunos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Turma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Horarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Professor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown n_MaxAlunos;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_NovaTurma;
    }
}