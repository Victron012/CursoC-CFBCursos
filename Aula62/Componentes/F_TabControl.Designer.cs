
namespace Componentes
{
    partial class F_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Componentes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_NomeTab = new System.Windows.Forms.TextBox();
            this.btn_NovaTab = new System.Windows.Forms.Button();
            this.btn_RemoverTab = new System.Windows.Forms.Button();
            this.btn_PosicaoTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tab_Componentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Componentes
            // 
            this.tab_Componentes.Controls.Add(this.button1);
            this.tab_Componentes.Controls.Add(this.label1);
            this.tab_Componentes.Controls.Add(this.textBox1);
            this.tab_Componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_Componentes.Name = "tab_Componentes";
            this.tab_Componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Componentes.Size = new System.Drawing.Size(768, 342);
            this.tab_Componentes.TabIndex = 0;
            this.tab_Componentes.Text = "Componentes";
            this.tab_Componentes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_NomeTab
            // 
            this.tb_NomeTab.Location = new System.Drawing.Point(16, 13);
            this.tb_NomeTab.Name = "tb_NomeTab";
            this.tb_NomeTab.Size = new System.Drawing.Size(100, 20);
            this.tb_NomeTab.TabIndex = 1;
            // 
            // btn_NovaTab
            // 
            this.btn_NovaTab.Location = new System.Drawing.Point(122, 12);
            this.btn_NovaTab.Name = "btn_NovaTab";
            this.btn_NovaTab.Size = new System.Drawing.Size(128, 23);
            this.btn_NovaTab.TabIndex = 2;
            this.btn_NovaTab.Text = "Nova Tab";
            this.btn_NovaTab.UseVisualStyleBackColor = true;
            this.btn_NovaTab.Click += new System.EventHandler(this.btn_NovaTab_Click);
            // 
            // btn_RemoverTab
            // 
            this.btn_RemoverTab.Location = new System.Drawing.Point(256, 13);
            this.btn_RemoverTab.Name = "btn_RemoverTab";
            this.btn_RemoverTab.Size = new System.Drawing.Size(128, 23);
            this.btn_RemoverTab.TabIndex = 3;
            this.btn_RemoverTab.Text = "Remover Tab";
            this.btn_RemoverTab.UseVisualStyleBackColor = true;
            this.btn_RemoverTab.Click += new System.EventHandler(this.btn_RemoverTab_Click);
            // 
            // btn_PosicaoTab
            // 
            this.btn_PosicaoTab.Location = new System.Drawing.Point(122, 41);
            this.btn_PosicaoTab.Name = "btn_PosicaoTab";
            this.btn_PosicaoTab.Size = new System.Drawing.Size(128, 23);
            this.btn_PosicaoTab.TabIndex = 4;
            this.btn_PosicaoTab.Text = "Posição Tab";
            this.btn_PosicaoTab.UseVisualStyleBackColor = true;
            this.btn_PosicaoTab.Click += new System.EventHandler(this.btn_PosicaoTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 41);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // F_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_PosicaoTab);
            this.Controls.Add(this.btn_RemoverTab);
            this.Controls.Add(this.btn_NovaTab);
            this.Controls.Add(this.tb_NomeTab);
            this.Controls.Add(this.tabControl1);
            this.Name = "F_TabControl";
            this.Text = "F_TabControl";
            this.tabControl1.ResumeLayout(false);
            this.tab_Componentes.ResumeLayout(false);
            this.tab_Componentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox tb_NomeTab;
        private System.Windows.Forms.Button btn_NovaTab;
        private System.Windows.Forms.Button btn_RemoverTab;
        private System.Windows.Forms.Button btn_PosicaoTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tab_Componentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}