using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Componentes
{
    public partial class F_WebBrowser : Form
    {
        string home = "";
        public F_WebBrowser()
        {
            InitializeComponent();
        }
        private void Navegar()
        {
            string url = tb_Url.Text;

            if (url != "")
            {
                webBrowser1.Navigate(url);
            }
            else
            {
                MessageBox.Show("Digite um link!");
                tb_Url.Focus();
            }
            
        }
        private void btn_Ir_Click(object sender, EventArgs e)
        {
            Navegar();
        }

        private void tb_Url_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Navegar();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (home == "")
            {
                webBrowser1.GoHome();
            }
            else
            {
                webBrowser1.Navigate(home);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btn_Avancar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void webBroser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btn_Avancar.Enabled = webBrowser1.CanGoForward;
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btn_Voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoSearch();
        }

        private void btn_DefinirHome_Click(object sender, EventArgs e)
        {
            home = tb_Url.Text;       
        }
    }
}
