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
    public partial class frmMapa : Form
    {
        public frmMapa(int Comida, int Dinheiro, int Fome, int Energia, string nick)
        {
            InitializeComponent();
            this.Comida = Comida;
            this.Dinheiro = Dinheiro;
            this.Fome = Fome;
            this.Energia = Energia;
            this.nick = nick;
        }

        int Comida;
        int Dinheiro;
        int Fome;
        int Energia;
        bool Explo = false;
        string nick;
        int[] atr = new int[5];
        bool Acao = false;

        private void button1_Click(object sender, EventArgs e)
        {
            frmFrogger froggi = new frmFrogger();
            froggi.ShowDialog();
            Explo = true;
            this.Close();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCasa_Click(object sender, EventArgs e)
        {
            Jogo.Casa casa = new Jogo.Casa(Comida, Fome);
            casa.ShowDialog();
            if (casa.fome() == 0)
            {
                atr[1] = -Fome;
            }
            else
            {
                if (casa.comeu())
                {
                    atr[1] = -Comida;
                }
                else
                {
                    atr[1] = 0;
                }
            }

            if (casa.energia())
            {
                atr[0] = 10 - Energia;
            }
            Comida = casa.comida();
            this.Close();
        }

        private void lblMercado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você comprou " + Dinheiro / 5 + " pães.");
            Comida += Dinheiro / 5;
            Dinheiro = 0;
        }

        private void lblTrabalhar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Você trabalha um pouco no mercadinho de peixe para conseguir dinheiro. Energia -1, Fome +1. Dinheiro +40G", "Trabalhador", MessageBoxButtons.OK);
            atr[1] = 1; atr[0] = -1; Dinheiro = Dinheiro + 40;
            Acao = true;
            this.Close();
        }

        private void lblMat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você estuda muito em sua teoria louca sobre mutiplicar riscos O.o . Energia -1, Fome +1, Inteligencia +1.", "Mutiplicação?", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[3] = 1;
            Acao = true;
            this.Close();
        }

        private void lblLinguas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você estuda muito sobre como se fala . Energia -1, Fome +1, Sabedoria +1.", "Comunicação por voz", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[4] = 1;
            Acao = true;
            this.Close();
        }

        public int[] MudarStatus()
        {

            return atr;

        }

        public bool ChecarAcao()
        {
            return Acao;
        }

        public int MudarComida()
        {
            return Comida;
        }

        public int MudarDinheiro()
        {
            return Dinheiro;
        }

        public bool Exploracao()
        {
            return Explo;
        }
    }
}
