
namespace Componentes
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00",
            ""}, -1);
            this.lv_Produtos = new System.Windows.Forms.ListView();
            this.col_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_Produto = new System.Windows.Forms.TextBox();
            this.tb_Qtde = new System.Windows.Forms.TextBox();
            this.tb_Preco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Rem = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Produtos
            // 
            this.lv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Id,
            this.col_Produto,
            this.col_Qtde,
            this.col_Preco});
            this.lv_Produtos.FullRowSelect = true;
            this.lv_Produtos.HideSelection = false;
            this.lv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_Produtos.Location = new System.Drawing.Point(9, 12);
            this.lv_Produtos.MultiSelect = false;
            this.lv_Produtos.Name = "lv_Produtos";
            this.lv_Produtos.Size = new System.Drawing.Size(497, 85);
            this.lv_Produtos.TabIndex = 0;
            this.lv_Produtos.UseCompatibleStateImageBehavior = false;
            this.lv_Produtos.View = System.Windows.Forms.View.Details;
            this.lv_Produtos.SelectedIndexChanged += new System.EventHandler(this.lv_Produtos_SelectedIndexChanged);
            // 
            // col_Id
            // 
            this.col_Id.Text = "Id";
            this.col_Id.Width = 40;
            // 
            // col_Produto
            // 
            this.col_Produto.Text = "Produto";
            this.col_Produto.Width = 250;
            // 
            // col_Qtde
            // 
            this.col_Qtde.Text = "Quantidade";
            this.col_Qtde.Width = 80;
            // 
            // col_Preco
            // 
            this.col_Preco.Text = "Preço";
            this.col_Preco.Width = 120;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(12, 309);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(40, 20);
            this.tb_Id.TabIndex = 1;
            // 
            // tb_Produto
            // 
            this.tb_Produto.Location = new System.Drawing.Point(59, 309);
            this.tb_Produto.Name = "tb_Produto";
            this.tb_Produto.Size = new System.Drawing.Size(242, 20);
            this.tb_Produto.TabIndex = 2;
            // 
            // tb_Qtde
            // 
            this.tb_Qtde.Location = new System.Drawing.Point(308, 309);
            this.tb_Qtde.Name = "tb_Qtde";
            this.tb_Qtde.Size = new System.Drawing.Size(84, 20);
            this.tb_Qtde.TabIndex = 3;
            // 
            // tb_Preco
            // 
            this.tb_Preco.Location = new System.Drawing.Point(399, 309);
            this.tb_Preco.Name = "tb_Preco";
            this.tb_Preco.Size = new System.Drawing.Size(100, 20);
            this.tb_Preco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 349);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Rem
            // 
            this.btn_Rem.Location = new System.Drawing.Point(12, 379);
            this.btn_Rem.Name = "btn_Rem";
            this.btn_Rem.Size = new System.Drawing.Size(75, 23);
            this.btn_Rem.TabIndex = 10;
            this.btn_Rem.Text = "Remover";
            this.btn_Rem.UseVisualStyleBackColor = true;
            this.btn_Rem.Click += new System.EventHandler(this.btn_Rem_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(12, 408);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(75, 23);
            this.btn_Obter.TabIndex = 11;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 448);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Rem);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Preco);
            this.Controls.Add(this.tb_Qtde);
            this.Controls.Add(this.tb_Produto);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lv_Produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Produtos;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_Produto;
        private System.Windows.Forms.ColumnHeader col_Qtde;
        private System.Windows.Forms.ColumnHeader col_Preco;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_Produto;
        private System.Windows.Forms.TextBox tb_Qtde;
        private System.Windows.Forms.TextBox tb_Preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Rem;
        private System.Windows.Forms.Button btn_Obter;
    }
}