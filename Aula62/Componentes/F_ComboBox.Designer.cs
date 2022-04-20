
namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_Transportes = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionado = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Resetar = new System.Windows.Forms.Button();
            this.tb_Transporte = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Transportes
            // 
            this.cb_Transportes.FormattingEnabled = true;
            this.cb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem"});
            this.cb_Transportes.Location = new System.Drawing.Point(13, 13);
            this.cb_Transportes.Name = "cb_Transportes";
            this.cb_Transportes.Size = new System.Drawing.Size(197, 24);
            this.cb_Transportes.TabIndex = 0;
            this.cb_Transportes.SelectedIndexChanged += new System.EventHandler(this.cb_Transportes_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionado
            // 
            this.btn_MostrarSelecionado.Location = new System.Drawing.Point(217, 13);
            this.btn_MostrarSelecionado.Name = "btn_MostrarSelecionado";
            this.btn_MostrarSelecionado.Size = new System.Drawing.Size(222, 23);
            this.btn_MostrarSelecionado.TabIndex = 1;
            this.btn_MostrarSelecionado.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionado.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionado.Click += new System.EventHandler(this.btn_MostrarSelecionado_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(217, 43);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(222, 23);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "Limpar elementos";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Resetar
            // 
            this.btn_Resetar.Location = new System.Drawing.Point(217, 73);
            this.btn_Resetar.Name = "btn_Resetar";
            this.btn_Resetar.Size = new System.Drawing.Size(222, 23);
            this.btn_Resetar.TabIndex = 3;
            this.btn_Resetar.Text = "Resetar elementos";
            this.btn_Resetar.UseVisualStyleBackColor = true;
            this.btn_Resetar.Click += new System.EventHandler(this.btn_Resetar_Click);
            // 
            // tb_Transporte
            // 
            this.tb_Transporte.Location = new System.Drawing.Point(217, 141);
            this.tb_Transporte.Name = "tb_Transporte";
            this.tb_Transporte.Size = new System.Drawing.Size(222, 22);
            this.tb_Transporte.TabIndex = 4;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(217, 170);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(222, 23);
            this.btn_Adicionar.TabIndex = 5;
            this.btn_Adicionar.Text = "Adicionar transporte";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adicionar transportes";
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.tb_Transporte);
            this.Controls.Add(this.btn_Resetar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_MostrarSelecionado);
            this.Controls.Add(this.cb_Transportes);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionado;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Resetar;
        private System.Windows.Forms.TextBox tb_Transporte;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label label1;
    }
}