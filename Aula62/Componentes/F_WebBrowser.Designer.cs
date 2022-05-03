
namespace Componentes
{
    partial class F_WebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_Url = new System.Windows.Forms.TextBox();
            this.btn_Ir = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Avancar = new System.Windows.Forms.Button();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_DefinirHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(712, 382);
            this.webBrowser1.TabIndex = 0;
            // 
            // tb_Url
            // 
            this.tb_Url.Location = new System.Drawing.Point(13, 13);
            this.tb_Url.Name = "tb_Url";
            this.tb_Url.Size = new System.Drawing.Size(687, 20);
            this.tb_Url.TabIndex = 1;
            this.tb_Url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Url_KeyDown);
            // 
            // btn_Ir
            // 
            this.btn_Ir.Location = new System.Drawing.Point(33, 39);
            this.btn_Ir.Name = "btn_Ir";
            this.btn_Ir.Size = new System.Drawing.Size(75, 23);
            this.btn_Ir.TabIndex = 2;
            this.btn_Ir.Text = "Ir";
            this.btn_Ir.UseVisualStyleBackColor = true;
            this.btn_Ir.Click += new System.EventHandler(this.btn_Ir_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(114, 39);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(195, 39);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Avancar
            // 
            this.btn_Avancar.Location = new System.Drawing.Point(276, 39);
            this.btn_Avancar.Name = "btn_Avancar";
            this.btn_Avancar.Size = new System.Drawing.Size(75, 23);
            this.btn_Avancar.TabIndex = 5;
            this.btn_Avancar.Text = "Avançar";
            this.btn_Avancar.UseVisualStyleBackColor = true;
            this.btn_Avancar.Click += new System.EventHandler(this.btn_Avancar_Click);
            // 
            // btn_Parar
            // 
            this.btn_Parar.Location = new System.Drawing.Point(357, 39);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar.TabIndex = 6;
            this.btn_Parar.Text = "Parar";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(438, 39);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 7;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(519, 39);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 8;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_DefinirHome
            // 
            this.btn_DefinirHome.Location = new System.Drawing.Point(600, 39);
            this.btn_DefinirHome.Name = "btn_DefinirHome";
            this.btn_DefinirHome.Size = new System.Drawing.Size(75, 23);
            this.btn_DefinirHome.TabIndex = 9;
            this.btn_DefinirHome.Text = "Definir Home";
            this.btn_DefinirHome.UseVisualStyleBackColor = true;
            this.btn_DefinirHome.Click += new System.EventHandler(this.btn_DefinirHome_Click);
            // 
            // F_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.btn_DefinirHome);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.btn_Avancar);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Ir);
            this.Controls.Add(this.tb_Url);
            this.Controls.Add(this.webBrowser1);
            this.Name = "F_WebBrowser";
            this.Text = "F_WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_Url;
        private System.Windows.Forms.Button btn_Ir;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Avancar;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_DefinirHome;
    }
}