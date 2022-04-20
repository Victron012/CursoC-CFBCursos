
namespace Aula60
{
    partial class Form1
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
            this.lb_Texto = new System.Windows.Forms.Label();
            this.btn_Texto = new System.Windows.Forms.Button();
            this.tb_Texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Texto
            // 
            this.lb_Texto.AutoSize = true;
            this.lb_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Texto.Location = new System.Drawing.Point(37, 176);
            this.lb_Texto.Name = "lb_Texto";
            this.lb_Texto.Size = new System.Drawing.Size(214, 25);
            this.lb_Texto.TabIndex = 0;
            this.lb_Texto.Text = "youtube.com/cfbcursos";
            // 
            // btn_Texto
            // 
            this.btn_Texto.BackColor = System.Drawing.Color.Black;
            this.btn_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Texto.ForeColor = System.Drawing.Color.Red;
            this.btn_Texto.Location = new System.Drawing.Point(42, 124);
            this.btn_Texto.Name = "btn_Texto";
            this.btn_Texto.Size = new System.Drawing.Size(196, 49);
            this.btn_Texto.TabIndex = 1;
            this.btn_Texto.Text = "Ok";
            this.btn_Texto.UseVisualStyleBackColor = false;
            this.btn_Texto.Click += new System.EventHandler(this.btn_Texto_Click);
            // 
            // tb_Texto
            // 
            this.tb_Texto.Location = new System.Drawing.Point(42, 84);
            this.tb_Texto.Name = "tb_Texto";
            this.tb_Texto.Size = new System.Drawing.Size(196, 20);
            this.tb_Texto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Texto);
            this.Controls.Add(this.btn_Texto);
            this.Controls.Add(this.lb_Texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Texto;
        private System.Windows.Forms.Button btn_Texto;
        private System.Windows.Forms.TextBox tb_Texto;
    }
}

