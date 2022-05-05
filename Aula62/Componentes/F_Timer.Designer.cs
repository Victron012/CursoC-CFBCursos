
namespace Componentes
{
    partial class F_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Iniciar1 = new System.Windows.Forms.Button();
            this.btn_Parar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reiniciar1 = new System.Windows.Forms.Button();
            this.img_Carro = new System.Windows.Forms.PictureBox();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.btn_Andar = new System.Windows.Forms.Button();
            this.timer_Carro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Iniciar1
            // 
            this.btn_Iniciar1.Location = new System.Drawing.Point(13, 13);
            this.btn_Iniciar1.Name = "btn_Iniciar1";
            this.btn_Iniciar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar1.TabIndex = 0;
            this.btn_Iniciar1.Text = "Inicíar";
            this.btn_Iniciar1.UseVisualStyleBackColor = true;
            this.btn_Iniciar1.Click += new System.EventHandler(this.btn_Iniciar1_Click);
            // 
            // btn_Parar1
            // 
            this.btn_Parar1.Location = new System.Drawing.Point(94, 13);
            this.btn_Parar1.Name = "btn_Parar1";
            this.btn_Parar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar1.TabIndex = 1;
            this.btn_Parar1.Text = "Parar";
            this.btn_Parar1.UseVisualStyleBackColor = true;
            this.btn_Parar1.Click += new System.EventHandler(this.btn_Parar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_Reiniciar1
            // 
            this.btn_Reiniciar1.Location = new System.Drawing.Point(176, 12);
            this.btn_Reiniciar1.Name = "btn_Reiniciar1";
            this.btn_Reiniciar1.Size = new System.Drawing.Size(75, 23);
            this.btn_Reiniciar1.TabIndex = 3;
            this.btn_Reiniciar1.Text = "Reiniciar";
            this.btn_Reiniciar1.UseVisualStyleBackColor = true;
            this.btn_Reiniciar1.Click += new System.EventHandler(this.btn_Reiniciar1_Click);
            // 
            // img_Carro
            // 
            this.img_Carro.Image = ((System.Drawing.Image)(resources.GetObject("img_Carro.Image")));
            this.img_Carro.Location = new System.Drawing.Point(12, 122);
            this.img_Carro.Name = "img_Carro";
            this.img_Carro.Size = new System.Drawing.Size(147, 40);
            this.img_Carro.TabIndex = 4;
            this.img_Carro.TabStop = false;
            // 
            // btn_Parar
            // 
            this.btn_Parar.Location = new System.Drawing.Point(93, 93);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar.TabIndex = 5;
            this.btn_Parar.Text = "Parar";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // btn_Andar
            // 
            this.btn_Andar.Location = new System.Drawing.Point(12, 93);
            this.btn_Andar.Name = "btn_Andar";
            this.btn_Andar.Size = new System.Drawing.Size(75, 23);
            this.btn_Andar.TabIndex = 6;
            this.btn_Andar.Text = "Andar";
            this.btn_Andar.UseVisualStyleBackColor = true;
            this.btn_Andar.Click += new System.EventHandler(this.btn_Andar_Click);
            // 
            // timer_Carro
            // 
            this.timer_Carro.Interval = 1;
            this.timer_Carro.Tick += new System.EventHandler(this.timer_Carro_Tick);
            // 
            // F_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Andar);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.img_Carro);
            this.Controls.Add(this.btn_Reiniciar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Parar1);
            this.Controls.Add(this.btn_Iniciar1);
            this.Name = "F_Timer";
            this.Text = "F_Timer";
            this.Load += new System.EventHandler(this.F_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Iniciar1;
        private System.Windows.Forms.Button btn_Parar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reiniciar1;
        private System.Windows.Forms.PictureBox img_Carro;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Button btn_Andar;
        private System.Windows.Forms.Timer timer_Carro;
    }
}