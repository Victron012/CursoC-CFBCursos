
namespace Componentes
{
    partial class F_LinkLabel
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
            this.ll_Canal = new System.Windows.Forms.LinkLabel();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.ll_Calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_MultiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_Canal
            // 
            this.ll_Canal.AutoSize = true;
            this.ll_Canal.Location = new System.Drawing.Point(12, 61);
            this.ll_Canal.Name = "ll_Canal";
            this.ll_Canal.Size = new System.Drawing.Size(34, 13);
            this.ll_Canal.TabIndex = 0;
            this.ll_Canal.TabStop = true;
            this.ll_Canal.Text = "Canal";
            this.ll_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Canal_LinkClicked);
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Location = new System.Drawing.Point(13, 13);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(83, 13);
            this.lb_Nome.TabIndex = 1;
            this.lb_Nome.Text = "Digite seu nome";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(13, 30);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(100, 20);
            this.tb_Nome.TabIndex = 2;
            // 
            // ll_Calculadora
            // 
            this.ll_Calculadora.AutoSize = true;
            this.ll_Calculadora.Location = new System.Drawing.Point(73, 61);
            this.ll_Calculadora.Name = "ll_Calculadora";
            this.ll_Calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_Calculadora.TabIndex = 3;
            this.ll_Calculadora.TabStop = true;
            this.ll_Calculadora.Text = "Calculadora";
            this.ll_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Calculadora_LinkClicked);
            // 
            // ll_MultiplosLinks
            // 
            this.ll_MultiplosLinks.AutoSize = true;
            this.ll_MultiplosLinks.Location = new System.Drawing.Point(13, 91);
            this.ll_MultiplosLinks.Name = "ll_MultiplosLinks";
            this.ll_MultiplosLinks.Size = new System.Drawing.Size(126, 13);
            this.ll_MultiplosLinks.TabIndex = 4;
            this.ll_MultiplosLinks.TabStop = true;
            this.ll_MultiplosLinks.Text = "Google - Canal - Youtube";
            this.ll_MultiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_MultiplosLinks_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.ll_MultiplosLinks);
            this.Controls.Add(this.ll_Calculadora);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.ll_Canal);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_Canal;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.LinkLabel ll_Calculadora;
        private System.Windows.Forms.LinkLabel ll_MultiplosLinks;
    }
}