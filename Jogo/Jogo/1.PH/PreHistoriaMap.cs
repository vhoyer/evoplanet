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
    public partial class PreHistoriaMap : Form
    {
        public PreHistoriaMap(int Comida, int Fome, int Energia,string[] Batalha ,string nick, bool canPaint)
        {
            InitializeComponent();
            this.Comida = Comida;
            this.Fome = Fome;
            this.Energia = Energia;
            this.nick = nick;
            this.Batalha = Batalha;
            this.canPaint = canPaint;

        }

        #region "Class Variables"
        int Captu;
        int Comida;
        int Fome;
        int Energia;
        int[] atr = new int[5];
        string nick;
        string[] Batalha;
        bool Acao = false;
        bool canPaint;
        #endregion

        #region "Events Click"

        private void lblFloresta_Click(object sender, EventArgs e)
        {
            Random frase = new Random();
            string Exibir = "";
            switch (frase.Next(2) + 1)
            {
                case 1: Exibir = "Você caçou um javali. Comida +2, Energia -1, Fome +1 ";
                    Comida = Comida + 2; atr[0] = (-1); atr[1] = 1;
                    break;
                case 2:
                    Exibir = "Você caçou um mamule. Comida +7, Energia -1, Fome +1 ";
                    Comida = Comida + 7; atr[0] = (-1); atr[1] = 1;
                    break;

            }
            Acao = true;
            canPaint = true;
            MessageBox.Show(Exibir, "Bela caçada!", MessageBoxButtons.OK);
            this.Close();
        }

        private void lblConstru_Click(object sender, EventArgs e)
        {
            atr[0] = (-1);
            atr[1] = 2;
            atr[2] = 1;
            MessageBox.Show("Você ajudou na construção de um bela estrutura! Energia -1, Fome +2, Força +1", "Qual será o resultado?", MessageBoxButtons.OK);
            Acao = true;
            canPaint = false;
            this.Close();
        }

        private void lblVulc_Click(object sender, EventArgs e)
        {
            atr[0] = (-1);
            atr[1] = 1;
            atr[3] = 1;
            MessageBox.Show("Você vez um sacrificio para o Deus Pedra Pedregulho Pedrosa e ele deu-lhe sabedoria! Energia -1, Fome +1, Inteligencia +1", "PEDRA PEDREGULHA PEDROSA", MessageBoxButtons.OK);
            Acao = true;
            canPaint = false;
            this.Close();
        }

        private void lblBar_Click(object sender, EventArgs e)
        {
            atr[0] = (-2);
            atr[1] = 1;
            atr[4] = 1;
            MessageBox.Show("Você fez muitas amizades nesse momento! Energia -2, Fome +1, Carisma +1", "Entenderam a piada?", MessageBoxButtons.OK);
            Acao = true;
            canPaint = false;
            this.Close();
        }

        private void lblCasa_Click(object sender, EventArgs e)
        {
            Casa casa = new Casa(Comida, Fome);
            casa.ShowDialog();
            if (casa.fome() == 0) {
                atr[1] = -Fome;
            }
            else
            {
                if (casa.comeu()) {
                    atr[1] = -Comida;
                } else
                {
                    atr[1] = 0;
                }
            }

            if (casa.energia()) {
                atr[0] = 10-Energia;
            }
            Comida = casa.comida();
            canPaint = false;
            this.Close();
         }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCampo_Click(object sender, EventArgs e)
        {
            Batalha batalha = new Batalha(nick, Batalha);
            batalha.ShowDialog();
            Captu = batalha.Capturou();
            Acao = true;
            canPaint = false;
            if (Captu == 0) {
                Comida = Comida + 4;
            }
            atr[0] = (-1); atr[1] = 1;
            this.Close();
        }

        private void lblMuseu_Click(object sender, EventArgs e)
        {
            frmMuseumverna museu = new frmMuseumverna(canPaint, nick);
            museu.ShowDialog();
            canPaint = false;
            this.Close();
        }

        #endregion

        #region "Builders"

        public bool ChecarAcao()
        {
            return Acao;
        }

        public int[] MudarStatus()
        {


            return atr;

        }

        public int MudarComida()
        {
            return Comida;
        }

        public int ChecarDino() {

            return Captu;
        }

        public bool setTinta() {

            return canPaint;

        }

        #endregion


    }
}
