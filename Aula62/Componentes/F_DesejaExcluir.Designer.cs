
namespace Componentes
{
    partial class F_DesejaExcluir
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
            this.btn_Sim = new System.Windows.Forms.Button();
            this.btn_Nao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sim
            // 
            this.btn_Sim.Location = new System.Drawing.Point(31, 61);
            this.btn_Sim.Name = "btn_Sim";
            this.btn_Sim.Size = new System.Drawing.Size(75, 23);
            this.btn_Sim.TabIndex = 0;
            this.btn_Sim.Text = "Sim";
            this.btn_Sim.UseVisualStyleBackColor = true;
            this.btn_Sim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Nao
            // 
            this.btn_Nao.Location = new System.Drawing.Point(112, 61);
            this.btn_Nao.Name = "btn_Nao";
            this.btn_Nao.Size = new System.Drawing.Size(75, 23);
            this.btn_Nao.TabIndex = 1;
            this.btn_Nao.Text = "Não";
            this.btn_Nao.UseVisualStyleBackColor = true;
            this.btn_Nao.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deseja realmente excluir a tab?";
            // 
            // F_DesejaExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Nao);
            this.Controls.Add(this.btn_Sim);
            this.Name = "F_DesejaExcluir";
            this.Text = "F_DesejaExcluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sim;
        private System.Windows.Forms.Button btn_Nao;
        private System.Windows.Forms.Label label1;
    }
}