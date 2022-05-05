using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Timer : Form
    {
        int num;
        int posXInitial;
        int posX;
        int posYInitial;
        int posY;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            label1.Text = num.ToString();
            posXInitial = img_Carro.Location.X;
            posX = posXInitial;
            posYInitial = img_Carro.Location.Y;
            posY = posYInitial;
        }

        private void btn_Iniciar1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Parar1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;
        }

        private void btn_Reiniciar1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            label1.Text = num.ToString();
            timer1.Start();
        }

        private void timer_Carro_Tick(object sender, EventArgs e)
        {
            if(posX >= 641)
            {
                posX = posXInitial;
                posY += 20;
            }
            if (posY >= 398) {
                posX = posXInitial;
                posY = posYInitial;
            }
            posX++;
            img_Carro.Location = new Point(posX,posY);
        }

        private void btn_Andar_Click(object sender, EventArgs e)
        {
            timer_Carro.Start();
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            timer_Carro.Stop();
        }
    }
}
