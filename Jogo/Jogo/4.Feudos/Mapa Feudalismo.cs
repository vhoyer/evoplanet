using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feudo
{
    public partial class frmMapa_Feudalismo : Form
    {
        public frmMapa_Feudalismo(int Comida, int Dinheiro, int Fome, int Energia, int For, int Int, string nick)
        {
            InitializeComponent();
            this.Comida = Comida;
            this.Dinheiro = Dinheiro;
            this.Fome = Fome;
            this.Energia = Energia;
            this.nick = nick;
            this.For = For;
            this.Int = Int;
        }

        int Comida;
        int Dinheiro;
        int Fome;
        int Energia;
        string nick;
        int[] atr = new int[5];
        bool Acao = false;
        int For, Int;
        bool evo;

        private void btnVoltarFeudalismo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTowerDefense frm = new frmTowerDefense(For, Int, nick);
            frm.ShowDialog();
            evo = frm.Evo();
            this.Close();
        }

        private void btnIgreja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você estuda grande em grupo os ensinamentos da biblia. Energia -1, Fome +1, Inteligencia +1, Carisma +1.", "Padre", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[3] = 1; atr[4] = 1;
            Acao = true;
            this.Close();
        }

        private void btnArtesanato_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você faz umas artes bonitas e dificeis. Conseguiu dinheiro com isso. Fome +1, Força +1, Carisma +1. Dinheiro +40G", "Artista", MessageBoxButtons.OK);
            atr[1] = 1; atr[2] = 1; atr[4] = 1; Dinheiro = Dinheiro + 40;
            Acao = true;
            this.Close();
        }

        private void btnCasa_Click(object sender, EventArgs e)
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

        private void btnMercadinho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você comprou " + Dinheiro / 5 + " pães.");
            Comida += Dinheiro / 5;
            Dinheiro = 0;
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

        public bool Evo()
        {
            return evo;
        }

    }
}
