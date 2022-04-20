
namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.mtb_Senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.mtb_Caracter = new System.Windows.Forms.MaskedTextBox();
            this.btn_MostrarCaracter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_SomenteTexto = new System.Windows.Forms.CheckBox();
            this.mtb_Variavel = new System.Windows.Forms.MaskedTextBox();
            this.btn_Pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtb_Senha
            // 
            this.mtb_Senha.Location = new System.Drawing.Point(12, 32);
            this.mtb_Senha.Name = "mtb_Senha";
            this.mtb_Senha.PasswordChar = '*';
            this.mtb_Senha.Size = new System.Drawing.Size(188, 20);
            this.mtb_Senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha";
            // 
            // mtb_Cpf
            // 
            this.mtb_Cpf.Culture = new System.Globalization.CultureInfo("");
            this.mtb_Cpf.Location = new System.Drawing.Point(12, 103);
            this.mtb_Cpf.Mask = "000.000.000-00";
            this.mtb_Cpf.Name = "mtb_Cpf";
            this.mtb_Cpf.Size = new System.Drawing.Size(188, 20);
            this.mtb_Cpf.TabIndex = 2;
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Location = new System.Drawing.Point(206, 103);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Mostrar.TabIndex = 3;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // mtb_Caracter
            // 
            this.mtb_Caracter.Culture = new System.Globalization.CultureInfo("");
            this.mtb_Caracter.Location = new System.Drawing.Point(12, 155);
            this.mtb_Caracter.Mask = "000.000.000-00";
            this.mtb_Caracter.Name = "mtb_Caracter";
            this.mtb_Caracter.Size = new System.Drawing.Size(188, 20);
            this.mtb_Caracter.TabIndex = 4;
            this.mtb_Caracter.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_MostrarCaracter
            // 
            this.btn_MostrarCaracter.Location = new System.Drawing.Point(206, 155);
            this.btn_MostrarCaracter.Name = "btn_MostrarCaracter";
            this.btn_MostrarCaracter.Size = new System.Drawing.Size(75, 23);
            this.btn_MostrarCaracter.TabIndex = 5;
            this.btn_MostrarCaracter.Text = "Mostrar";
            this.btn_MostrarCaracter.UseVisualStyleBackColor = true;
            this.btn_MostrarCaracter.Click += new System.EventHandler(this.btn_MostrarCaracter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Include Literals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exclude Prompt And Literals";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_SomenteTexto
            // 
            this.cb_SomenteTexto.AutoSize = true;
            this.cb_SomenteTexto.Location = new System.Drawing.Point(207, 230);
            this.cb_SomenteTexto.Name = "cb_SomenteTexto";
            this.cb_SomenteTexto.Size = new System.Drawing.Size(94, 17);
            this.cb_SomenteTexto.TabIndex = 10;
            this.cb_SomenteTexto.Text = "Somente texto";
            this.cb_SomenteTexto.UseVisualStyleBackColor = true;
            // 
            // mtb_Variavel
            // 
            this.mtb_Variavel.Culture = new System.Globalization.CultureInfo("");
            this.mtb_Variavel.Location = new System.Drawing.Point(12, 230);
            this.mtb_Variavel.Mask = "000.000.000-00";
            this.mtb_Variavel.Name = "mtb_Variavel";
            this.mtb_Variavel.Size = new System.Drawing.Size(188, 20);
            this.mtb_Variavel.TabIndex = 11;
            // 
            // btn_Pass
            // 
            this.btn_Pass.Location = new System.Drawing.Point(207, 32);
            this.btn_Pass.Name = "btn_Pass";
            this.btn_Pass.Size = new System.Drawing.Size(75, 23);
            this.btn_Pass.TabIndex = 12;
            this.btn_Pass.Text = "Mostrar";
            this.btn_Pass.UseVisualStyleBackColor = true;
            this.btn_Pass.Click += new System.EventHandler(this.btn_Pass_Click);
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 450);
            this.Controls.Add(this.btn_Pass);
            this.Controls.Add(this.mtb_Variavel);
            this.Controls.Add(this.cb_SomenteTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_MostrarCaracter);
            this.Controls.Add(this.mtb_Caracter);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.mtb_Cpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_Senha);
            this.Name = "F_MaskedTextBox";
            this.Text = "F_MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_Cpf;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.MaskedTextBox mtb_Caracter;
        private System.Windows.Forms.Button btn_MostrarCaracter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_SomenteTexto;
        private System.Windows.Forms.MaskedTextBox mtb_Variavel;
        private System.Windows.Forms.Button btn_Pass;
    }
}