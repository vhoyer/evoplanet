using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo._0.Abertura
{
    public partial class Instru : Form
    {
        public Instru()
        {
            InitializeComponent();
        }
        int x = 0;
        private void btnProx_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                this.BackgroundImage = global::Jogo.Properties.Resources.Instru2;
                x = 1;
                btnProx.Text = "<<Voltar";
            } else
            {
                this.BackgroundImage = global::Jogo.Properties.Resources.Instru1;
                x = 0;
                btnProx.Text = "Proximo>>";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
