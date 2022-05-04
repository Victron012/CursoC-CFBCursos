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
    public partial class F_DesejaExcluir : Form
    {
        public F_DesejaExcluir()
        {
            InitializeComponent();
        }
        public char d = 'N';
        private void button1_Click(object sender, EventArgs e)
        {
            d = 'S';
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d = 'N';
            this.Close();
        }
    }
}
