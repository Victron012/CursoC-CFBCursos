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
    public partial class F_Veiculos : Form
    {
        private F_Principal fp;
        public F_Veiculos(String v, F_Principal f)
        {
            InitializeComponent();
            fp = f;
            tb_ListaVeiculo.Text = v;
            tb_ListaVeiculo.BackColor = Color.Blue;
            f.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_ListaVeiculos.Text = tb_ListaVeiculo.Text;
        }
    }
}
