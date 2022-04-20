
namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_Transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparLista = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.btn_AddTransporte = new System.Windows.Forms.Button();
            this.tb_Transporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_Transportes
            // 
            this.clb_Transportes.FormattingEnabled = true;
            this.clb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Aviao",
            "Navio",
            "Onibus",
            "Trem"});
            this.clb_Transportes.Location = new System.Drawing.Point(13, 13);
            this.clb_Transportes.Name = "clb_Transportes";
            this.clb_Transportes.Size = new System.Drawing.Size(144, 225);
            this.clb_Transportes.TabIndex = 0;
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(163, 13);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(242, 24);
            this.btn_MostrarSelecionados.TabIndex = 1;
            this.btn_MostrarSelecionados.Text = "Mostrar Seleionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_LimparLista
            // 
            this.btn_LimparLista.Location = new System.Drawing.Point(164, 43);
            this.btn_LimparLista.Name = "btn_LimparLista";
            this.btn_LimparLista.Size = new System.Drawing.Size(241, 33);
            this.btn_LimparLista.TabIndex = 2;
            this.btn_LimparLista.Text = "Limpar Lista";
            this.btn_LimparLista.UseVisualStyleBackColor = true;
            this.btn_LimparLista.Click += new System.EventHandler(this.btn_LimparLista_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Location = new System.Drawing.Point(163, 82);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(241, 27);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // btn_AddTransporte
            // 
            this.btn_AddTransporte.Location = new System.Drawing.Point(163, 215);
            this.btn_AddTransporte.Name = "btn_AddTransporte";
            this.btn_AddTransporte.Size = new System.Drawing.Size(242, 23);
            this.btn_AddTransporte.TabIndex = 4;
            this.btn_AddTransporte.Text = "Adicionar Transporte";
            this.btn_AddTransporte.UseVisualStyleBackColor = true;
            this.btn_AddTransporte.Click += new System.EventHandler(this.btn_AddTransporte_Click);
            // 
            // tb_Transporte
            // 
            this.tb_Transporte.Location = new System.Drawing.Point(164, 187);
            this.tb_Transporte.Name = "tb_Transporte";
            this.tb_Transporte.Size = new System.Drawing.Size(241, 22);
            this.tb_Transporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Transporte);
            this.Controls.Add(this.btn_AddTransporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_LimparLista);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.clb_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparLista;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.Button btn_AddTransporte;
        private System.Windows.Forms.TextBox tb_Transporte;
        private System.Windows.Forms.Label label1;
    }
}