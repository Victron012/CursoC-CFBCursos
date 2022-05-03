
namespace Componentes
{
    partial class F_TreeView
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("HRV");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Fit");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Golf");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Polo");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Volkswagem", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbn_AddRaiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(27, 13);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "hrv";
            treeNode19.Text = "HRV";
            treeNode20.Name = "fit";
            treeNode20.Text = "Fit";
            treeNode21.Name = "honda";
            treeNode21.Tag = "TagHonda";
            treeNode21.Text = "Honda";
            treeNode22.Name = "golf";
            treeNode22.Tag = "TagGolf";
            treeNode22.Text = "Golf";
            treeNode23.Name = "polo";
            treeNode23.Tag = "TagPolo";
            treeNode23.Text = "Polo";
            treeNode24.Name = "volkswagem";
            treeNode24.Tag = "TagVolksWagem";
            treeNode24.Text = "Volkswagem";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(176, 345);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(218, 52);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(142, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar Filho";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(218, 81);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(142, 23);
            this.btn_Remover.TabIndex = 2;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 20);
            this.textBox2.TabIndex = 4;
            // 
            // tbn_AddRaiz
            // 
            this.tbn_AddRaiz.Location = new System.Drawing.Point(218, 23);
            this.tbn_AddRaiz.Name = "tbn_AddRaiz";
            this.tbn_AddRaiz.Size = new System.Drawing.Size(142, 23);
            this.tbn_AddRaiz.TabIndex = 5;
            this.tbn_AddRaiz.Text = "Adicionar Raiz";
            this.tbn_AddRaiz.UseVisualStyleBackColor = true;
            this.tbn_AddRaiz.Click += new System.EventHandler(this.tbn_AddRaiz_Click);
            // 
            // F_TreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbn_AddRaiz);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.treeView1);
            this.Name = "F_TreeView";
            this.Text = "F_TreeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button tbn_AddRaiz;
    }
}