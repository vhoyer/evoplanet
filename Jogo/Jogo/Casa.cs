using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Casa : Form
    {
        public Casa(int Comida, int Fome)
        {
            InitializeComponent();
            this.Comida = Comida;
            this.Fome = Fome;
        }

        private void Casa_Load(object sender, EventArgs e)
        {
            lblComida.Text = "Comida: " + Comida; 
        }

        #region "Class Variables"
        int Comida;
        int Fome;
        bool Dormiu = false;
        bool Comeu = false;
        #endregion

        #region "Events Click"

        private void btnComer_Click(object sender, EventArgs e)
        {
            if (Comida >= Fome)
            {
                this.Comida -= Fome;
                Fome = 0;
            } else
            { 
                    Fome -= this.Comida;
                    this.Comida = 0;
                
            }
            lblComida.Text = "Comida: " + Comida;
            Comeu = true;
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            Dormiu = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region "Builders"

        public int fome()
        {
            return Fome;

        }

        public bool energia()
        {
            return Dormiu;
        }

        public int comida() {

            return Comida;
        }

        public bool comeu() {
            return Comeu;
        }

        #endregion

    }
}
