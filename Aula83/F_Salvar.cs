using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula83
{
    public partial class F_Salvar : Form
    {
        public F_Salvar()
        {
            InitializeComponent();
        }

        public char d;

        private void btn_NaoSalvar_Click(object sender, EventArgs e)
        {
            d = 'N';
            this.Close();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
           d = 'S';
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            d = 'C';
            this.Close();
        }
    }
}
