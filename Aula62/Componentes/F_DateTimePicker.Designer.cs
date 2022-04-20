
namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.btn_PegarData = new System.Windows.Forms.Button();
            this.tb_Data = new System.Windows.Forms.TextBox();
            this.tb_Dia = new System.Windows.Forms.TextBox();
            this.tb_Mes = new System.Windows.Forms.TextBox();
            this.tb_Ano = new System.Windows.Forms.TextBox();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(13, 13);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(242, 20);
            this.dtp_Data.TabIndex = 0;
            // 
            // btn_PegarData
            // 
            this.btn_PegarData.Location = new System.Drawing.Point(263, 10);
            this.btn_PegarData.Name = "btn_PegarData";
            this.btn_PegarData.Size = new System.Drawing.Size(202, 23);
            this.btn_PegarData.TabIndex = 1;
            this.btn_PegarData.Text = "Obter data";
            this.btn_PegarData.UseVisualStyleBackColor = true;
            this.btn_PegarData.Click += new System.EventHandler(this.btn_PegarData_Click);
            // 
            // tb_Data
            // 
            this.tb_Data.Location = new System.Drawing.Point(13, 40);
            this.tb_Data.Name = "tb_Data";
            this.tb_Data.Size = new System.Drawing.Size(242, 20);
            this.tb_Data.TabIndex = 2;
            // 
            // tb_Dia
            // 
            this.tb_Dia.Location = new System.Drawing.Point(13, 67);
            this.tb_Dia.Name = "tb_Dia";
            this.tb_Dia.Size = new System.Drawing.Size(75, 20);
            this.tb_Dia.TabIndex = 3;
            // 
            // tb_Mes
            // 
            this.tb_Mes.Location = new System.Drawing.Point(94, 67);
            this.tb_Mes.Name = "tb_Mes";
            this.tb_Mes.Size = new System.Drawing.Size(79, 20);
            this.tb_Mes.TabIndex = 4;
            // 
            // tb_Ano
            // 
            this.tb_Ano.Location = new System.Drawing.Point(179, 67);
            this.tb_Ano.Name = "tb_Ano";
            this.tb_Ano.Size = new System.Drawing.Size(76, 20);
            this.tb_Ano.TabIndex = 5;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(261, 67);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(202, 23);
            this.btn_Alterar.TabIndex = 9;
            this.btn_Alterar.Text = "Trocar data";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Hoje
            // 
            this.btn_Hoje.Location = new System.Drawing.Point(263, 97);
            this.btn_Hoje.Name = "btn_Hoje";
            this.btn_Hoje.Size = new System.Drawing.Size(202, 23);
            this.btn_Hoje.TabIndex = 10;
            this.btn_Hoje.Text = "Hoje";
            this.btn_Hoje.UseVisualStyleBackColor = true;
            this.btn_Hoje.Click += new System.EventHandler(this.btn_Hoje_Click);
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btn_Hoje);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.tb_Ano);
            this.Controls.Add(this.tb_Mes);
            this.Controls.Add(this.tb_Dia);
            this.Controls.Add(this.tb_Data);
            this.Controls.Add(this.btn_PegarData);
            this.Controls.Add(this.dtp_Data);
            this.Name = "F_DateTimePicker";
            this.Text = "F_DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.Button btn_PegarData;
        private System.Windows.Forms.TextBox tb_Data;
        private System.Windows.Forms.TextBox tb_Dia;
        private System.Windows.Forms.TextBox tb_Mes;
        private System.Windows.Forms.TextBox tb_Ano;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Hoje;
    }
}