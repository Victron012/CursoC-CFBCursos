
namespace Componentes
{
    partial class F_TrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.btn_Definir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(29, 62);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(431, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tb_Valor
            // 
            this.tb_Valor.Location = new System.Drawing.Point(29, 114);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(151, 20);
            this.tb_Valor.TabIndex = 2;
            // 
            // btn_Definir
            // 
            this.btn_Definir.Location = new System.Drawing.Point(186, 114);
            this.btn_Definir.Name = "btn_Definir";
            this.btn_Definir.Size = new System.Drawing.Size(100, 23);
            this.btn_Definir.TabIndex = 3;
            this.btn_Definir.Text = "Definir";
            this.btn_Definir.UseVisualStyleBackColor = true;
            this.btn_Definir.Click += new System.EventHandler(this.btn_Definir_Click);
            // 
            // F_TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Definir);
            this.Controls.Add(this.tb_Valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "F_TrackBar";
            this.Text = "F_TrackBar";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Valor;
        private System.Windows.Forms.Button btn_Definir;
    }
}