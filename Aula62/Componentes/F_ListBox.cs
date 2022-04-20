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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();

        private void AtualizaLista()
        {
            lb_Carros.DataSource = null;
            lb_Carros.DataSource = carros;
        }
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("Hrv");
            carros.Add("Golf");
            carros.Add("Focus");
            carros.Add("Civic");

            lb_Carros.DataSource=carros;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string car = tb_Carro.Text;
            if (car != "")
            {
                if (lb_Carros.Items.Contains(car))
                {
                    MessageBox.Show("Carro já existe");
                    tb_Carro.Focus();
                }
                else
                {
                    carros.Add(car);
                    AtualizaLista();
                    //lb_Carros.Items.Add(car);
                    tb_Carro.Clear();
                    tb_Carro.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um carro");
                tb_Carro.Focus();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            string car = tb_Carro.Text;
            if (car != "")
            {
                if (lb_Carros.Items.Contains(car))
                {
                    carros.Remove(car);
                    AtualizaLista();
                    tb_Carro.Clear();
                    tb_Carro.Focus();
                }
                else
                {
                    MessageBox.Show("Carro não existe");
                    tb_Carro.Focus();
                }
            }
            else
            {
                if (lb_Carros.Text != "")
                {
                    carros.Remove(lb_Carros.Text);
                    AtualizaLista();
                    tb_Carro.Clear();
                    tb_Carro.Focus();
                }
                else { 
                MessageBox.Show("Digite um carro");
                tb_Carro.Focus();
                }
            }
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            if (lb_Carros.Text != "") { 
                MessageBox.Show(lb_Carros.Text);
            }
            else
            {
                MessageBox.Show("Selecione um carro");
            }
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizaLista();
            tb_Carro.Clear();
            tb_Carro.Focus();
        }
    }
}
