
namespace Academia
{
    partial class F_NovoAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.tb_Turma = new System.Windows.Forms.TextBox();
            this.tb_Plano = new System.Windows.Forms.TextBox();
            this.btn_SelTurma = new System.Windows.Forms.Button();
            this.btn_SelPlano = new System.Windows.Forms.Button();
            this.pb_Foto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Foto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Turma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plano";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(16, 30);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(193, 20);
            this.tb_Nome.TabIndex = 5;
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(226, 30);
            this.tb_Telefone.Mask = "(99) 99999-9999";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(105, 20);
            this.tb_Telefone.TabIndex = 6;
            // 
            // cb_Status
            // 
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(16, 76);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(141, 21);
            this.cb_Status.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 48);
            this.panel1.TabIndex = 8;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(292, 13);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(211, 13);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(130, 13);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // tb_Turma
            // 
            this.tb_Turma.Location = new System.Drawing.Point(165, 75);
            this.tb_Turma.Name = "tb_Turma";
            this.tb_Turma.ReadOnly = true;
            this.tb_Turma.Size = new System.Drawing.Size(123, 20);
            this.tb_Turma.TabIndex = 9;
            this.tb_Turma.Tag = "0";
            // 
            // tb_Plano
            // 
            this.tb_Plano.Location = new System.Drawing.Point(15, 126);
            this.tb_Plano.Name = "tb_Plano";
            this.tb_Plano.ReadOnly = true;
            this.tb_Plano.Size = new System.Drawing.Size(164, 20);
            this.tb_Plano.TabIndex = 10;
            // 
            // btn_SelTurma
            // 
            this.btn_SelTurma.Location = new System.Drawing.Point(292, 73);
            this.btn_SelTurma.Name = "btn_SelTurma";
            this.btn_SelTurma.Size = new System.Drawing.Size(38, 23);
            this.btn_SelTurma.TabIndex = 11;
            this.btn_SelTurma.Text = "...";
            this.btn_SelTurma.UseVisualStyleBackColor = true;
            this.btn_SelTurma.Click += new System.EventHandler(this.btn_SelTurma_Click);
            // 
            // btn_SelPlano
            // 
            this.btn_SelPlano.Location = new System.Drawing.Point(185, 124);
            this.btn_SelPlano.Name = "btn_SelPlano";
            this.btn_SelPlano.Size = new System.Drawing.Size(38, 23);
            this.btn_SelPlano.TabIndex = 12;
            this.btn_SelPlano.Text = "...";
            this.btn_SelPlano.UseVisualStyleBackColor = true;
            // 
            // pb_Foto
            // 
            this.pb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Foto.Location = new System.Drawing.Point(352, 13);
            this.pb_Foto.Name = "pb_Foto";
            this.pb_Foto.Size = new System.Drawing.Size(85, 113);
            this.pb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Foto.TabIndex = 13;
            this.pb_Foto.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // btn_Foto
            // 
            this.btn_Foto.Location = new System.Drawing.Point(352, 133);
            this.btn_Foto.Name = "btn_Foto";
            this.btn_Foto.Size = new System.Drawing.Size(85, 23);
            this.btn_Foto.TabIndex = 14;
            this.btn_Foto.Text = "Add Foto";
            this.btn_Foto.UseVisualStyleBackColor = true;
            this.btn_Foto.Click += new System.EventHandler(this.btn_Foto_Click);
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 208);
            this.Controls.Add(this.btn_Foto);
            this.Controls.Add(this.pb_Foto);
            this.Controls.Add(this.btn_SelPlano);
            this.Controls.Add(this.btn_SelTurma);
            this.Controls.Add(this.tb_Plano);
            this.Controls.Add(this.tb_Turma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_SelTurma;
        private System.Windows.Forms.Button btn_SelPlano;
        public System.Windows.Forms.TextBox tb_Turma;
        public System.Windows.Forms.TextBox tb_Plano;
        private System.Windows.Forms.PictureBox pb_Foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Foto;
    }
}