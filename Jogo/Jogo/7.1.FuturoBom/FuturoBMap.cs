using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo._7._1.FuturoBom
{
    public partial class FuturoBMap : Form
    {
        public FuturoBMap(int Comida, int Dinheiro, int Fome, int Energia, string nick)
        {
            InitializeComponent();
            this.Comida = Comida;
            this.Dinheiro = Dinheiro;
            this.Fome = Fome;
            this.Energia = Energia;
            this.nick = nick;
        }
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Mega Man II - Airman Stage"));
        int Comida;
        int Dinheiro;
        int Fome;
        int Energia;
        string nick;
        int[] atr = new int[5];
        bool Acao = false;

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

        private void lblTrabalhar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Seu trabalho é muito bem feito! Energia -1, Dinheiro +40G!");
            Dinheiro += 40; atr[0] = (-1);
            Acao = true;
            this.Close();
        }

        private void lblMercado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você comprou " + Dinheiro / 5 + " pães.");
            Comida += Dinheiro / 5;
            Dinheiro = 0;
        }

        private void lblInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você esta estudando para poderem viajar pelo espaço! Energia -1, Fome +1, Inteligencia +1.", "Espaço, ai vamos nós!", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[3] = 1;
            Acao = true;
            this.Close();
        }

        private void lblCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você ajudou velhinhos! Energia -1, Fome +1, Carisma +1.", "Caridoso", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[4] = 1;
            Acao = true;
            this.Close();
        }


        private void lblFor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você praticando para um corrida! Energia -1, Fome +1, Força +1.", "Boa sorte!", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[2] = 1;
            Acao = true;
            this.Close();
        }
        bool Passou = false;
        private void lblJogo_Click(object sender, EventArgs e)
        {
            MegaMarte x = new MegaMarte();
            player.Stop();
            x.ShowDialog();
            player.PlayLooping();
            Passou = x.passou();
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

        public bool passou()
        {
            return Passou;
        }
    }
}
