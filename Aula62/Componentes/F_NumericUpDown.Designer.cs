
namespace Componentes
{
    partial class F_NumericUpDown
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_Valor = new System.Windows.Forms.TextBox();
            this.btn_DefinirValor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 13);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // tb_Valor
            // 
            this.tb_Valor.Location = new System.Drawing.Point(65, 12);
            this.tb_Valor.Name = "tb_Valor";
            this.tb_Valor.Size = new System.Drawing.Size(43, 20);
            this.tb_Valor.TabIndex = 1;
            this.tb_Valor.Text = "0";
            // 
            // btn_DefinirValor
            // 
            this.btn_DefinirValor.Location = new System.Drawing.Point(12, 39);
            this.btn_DefinirValor.Name = "btn_DefinirValor";
            this.btn_DefinirValor.Size = new System.Drawing.Size(96, 23);
            this.btn_DefinirValor.TabIndex = 2;
            this.btn_DefinirValor.Text = "Definir valor";
            this.btn_DefinirValor.UseVisualStyleBackColor = true;
            this.btn_DefinirValor.Click += new System.EventHandler(this.btn_DefinirValor_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 78);
            this.Controls.Add(this.btn_DefinirValor);
            this.Controls.Add(this.tb_Valor);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "F_NumericUpDown";
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tb_Valor;
        private System.Windows.Forms.Button btn_DefinirValor;
    }
}