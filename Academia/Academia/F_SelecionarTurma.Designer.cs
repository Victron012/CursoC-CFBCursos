
namespace Academia
{
    partial class F_SelecionarTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Turmas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Turmas
            // 
            this.dgv_Turmas.AllowUserToAddRows = false;
            this.dgv_Turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turmas.EnableHeadersVisualStyles = false;
            this.dgv_Turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_Turmas.MultiSelect = false;
            this.dgv_Turmas.Name = "dgv_Turmas";
            this.dgv_Turmas.ReadOnly = true;
            this.dgv_Turmas.RowHeadersVisible = false;
            this.dgv_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turmas.ShowEditingIcon = false;
            this.dgv_Turmas.Size = new System.Drawing.Size(764, 426);
            this.dgv_Turmas.TabIndex = 46;
            this.dgv_Turmas.DoubleClick += new System.EventHandler(this.dgv_Turmas_DoubleClick);
            // 
            // F_SelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.dgv_Turmas);
            this.Name = "F_SelecionarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_SelecionarTurma";
            this.Load += new System.EventHandler(this.F_SelecionarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Turmas;
    }
}