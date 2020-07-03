using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmRoma : Form
    {
        public frmRoma(int Comida, int Dinheiro, int Fome, int Energia, string nick)
        {
            InitializeComponent();
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

        private void PicbColiseu_Click(object sender, EventArgs e)
        {
            FrmBatalha batalha = new FrmBatalha();
            batalha.ShowDialog();
            Dinheiro += batalha.dinheiro();
            Acao = true;
            this.Close();
        }

        private void PicBCasa_Click(object sender, EventArgs e)
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
        
        private void pctrTreinamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você treinou com soldados ROMANOS! Energia -2, Fome +2, Força +1", "A academia...", MessageBoxButtons.OK);
            atr[0] = (-2); atr[1] = 2; atr[2] = 1;
            Acao = true;
            this.Close();
        }

        private void pctrBiblio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você é bem inteligente! Energia -1, Fome +1, Inteligencia +1", "A biblioteca...", MessageBoxButtons.OK);
            atr[0] = (-1); atr[1] = 1; atr[3] = 1;
            Acao = true;
            this.Close();
        }

        private void pctrMercado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você comprou " + Dinheiro / 5 + " pães. Esta conhecido por essa região... Carisma +1");
            Comida += Dinheiro / 5;
            atr[4] = 1;
            Dinheiro = 0;
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
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

    }
}
