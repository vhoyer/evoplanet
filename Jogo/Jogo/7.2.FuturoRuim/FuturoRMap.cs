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

namespace Jogo._7._2.FuturoRuim
{
    public partial class FuturoRMap : Form
    {
        public FuturoRMap(int Comida, int Dinheiro, int Fome, int Energia, string nick)
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
        string nick;
        int[] atr = new int[5];
        bool Acao = false;
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Megaman II - Wily Stage 2"));
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

            MessageBox.Show("Achou alguns materiais reutilizaveis! Energia -1, Materiais +40!");
            Dinheiro += 40; atr[0] = (-1);
            Acao = true;
            this.Close();
        }

        private void lblMercado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você trocou os materiais por " + Dinheiro / 5 + "mg de ração.");
            Comida += Dinheiro / 5;
            Dinheiro = 0;
        }

        private void lblInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você esta procurando algum tipo de planta. Energia -1, Fome +1, Inteligencia +1.", "Saudade saúde", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[3] = 1;
            Acao = true;
            this.Close();
        }

        private void lblCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você ajudou crianças orfãs! Energia -1, Fome +1, Carisma +1.", "Caridoso", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[4] = 1;
            Acao = true;
            this.Close();
        }


        private void lblFor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você passou correndo pelo laboratório abandonado a procura de algum sinal de vida. Energia -1, Fome +1, Força +1.", "S.O.S.", MessageBoxButtons.OK);
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
