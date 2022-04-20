
namespace Componentes
{
    partial class F_Progressbar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_Valor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Preencher = new System.Windows.Forms.Button();
            this.lb_Porcentagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 159);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(456, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // btn_Valor
            // 
            this.btn_Valor.Location = new System.Drawing.Point(12, 39);
            this.btn_Valor.Name = "btn_Valor";
            this.btn_Valor.Size = new System.Drawing.Size(100, 23);
            this.btn_Valor.TabIndex = 1;
            this.btn_Valor.Text = "Definir valor";
            this.btn_Valor.UseVisualStyleBackColor = true;
            this.btn_Valor.Click += new System.EventHandler(this.btn_Valor_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // btn_Preencher
            // 
            this.btn_Preencher.Location = new System.Drawing.Point(13, 127);
            this.btn_Preencher.Name = "btn_Preencher";
            this.btn_Preencher.Size = new System.Drawing.Size(75, 23);
            this.btn_Preencher.TabIndex = 3;
            this.btn_Preencher.Text = "Preencher";
            this.btn_Preencher.UseVisualStyleBackColor = true;
            this.btn_Preencher.Click += new System.EventHandler(this.btn_Preencher_Click);
            // 
            // lb_Porcentagem
            // 
            this.lb_Porcentagem.AutoSize = true;
            this.lb_Porcentagem.Location = new System.Drawing.Point(433, 137);
            this.lb_Porcentagem.Name = "lb_Porcentagem";
            this.lb_Porcentagem.Size = new System.Drawing.Size(21, 13);
            this.lb_Porcentagem.TabIndex = 4;
            this.lb_Porcentagem.Text = "0%";
            // 
            // F_Progressbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.lb_Porcentagem);
            this.Controls.Add(this.btn_Preencher);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Valor);
            this.Controls.Add(this.progressBar1);
            this.Name = "F_Progressbar";
            this.Text = "F_Progressbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_Valor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Preencher;
        private System.Windows.Forms.Label lb_Porcentagem;
    }
}