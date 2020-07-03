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
    public partial class FrmBatalha : Form
    {
        int ani, dano, danoNoMarciano,DanoComEscudo, Dinheiro;
        Random rnd = new Random();
        public FrmBatalha()
        {
          
            InitializeComponent();
        }

        private void PicbMarciano_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ani++;

            if (!(ani % 2 == 0))
            {
                pictureBox1.Image = Jogo.Properties.Resources.Leao1;
            }
            else if (ani % 2 == 0)
	        {
		        pictureBox1.Image = Jogo.Properties.Resources.Leao2;
	        }

            if (pictureBox1.Location.X >= 245)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 10, pictureBox1.Location.Y);
            }
            else
            {
                timer1.Stop();
            }

            if (pictureBox1.Location.X >= 300)
            {
                pictureBox2.Visible = false;
                picBescudo.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                picBescudo.Visible = true;
            }

            if (PrgBvidaDoAnimal.Value == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                picBescudo.Visible = false;
            }
        }

        private void FrmBatalha_Load(object sender, EventArgs e)
        {
         
        }
        int anima;
        private void tmrAtake_Tick(object sender, EventArgs e)
        {
            anima++;
            if (anima == 1)
            {
                PicbMarciano.Image = global::Jogo.Properties.Resources.MarcianoAtacandoRoma;
            }
            if (anima == 5)
            {
                PicbMarciano.Image = global::Jogo.Properties.Resources.MarcianoParado;
                anima = 0;
                tmrAtake.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //depois trocar o valor do rnd.next(força*2)
            tmrAtake.Start();
            dano = rnd.Next(50);
            danoNoMarciano = rnd.Next(47);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 40, pictureBox1.Location.Y);
            if (PrgBvidaDoAnimal.Value >= dano )
            {
                PrgBvidaDoAnimal.Value = PrgBvidaDoAnimal.Value - dano;
            }
            else
            {
                PrgBvidaDoAnimal.Value = 0;
            }

            if (PrgBVidaMarciano.Value >= danoNoMarciano)
            {   
                PrgBVidaMarciano.Value = PrgBVidaMarciano.Value - danoNoMarciano ;
            }
            else
            {
                PrgBVidaMarciano.Value = 0;
            }

            if (pictureBox1.Location.X >= 245)
            {
                timer1.Start();
            }

            if ((PrgBvidaDoAnimal.Value == 0) && (PrgBVidaMarciano.Value == 0))
            {
                if (MessageBox.Show("TREINE MAIS , VOCE CONSEGUIRA", "EMPATE!!!", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else if (PrgBvidaDoAnimal.Value == 0)
            {
                if (MessageBox.Show("+ 20 Marcidollars", "MUITO BOOM!!!", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Dinheiro = 20;
                    this.Close();
                }
            }
            else if (PrgBVidaMarciano.Value == 0)
            {
                if (MessageBox.Show("TREINE MAIS , VOCE CONSEGUIRA", "BAD!!!", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
            
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DanoComEscudo = rnd.Next(25);
            if (PrgBVidaMarciano.Value >= DanoComEscudo)
            {
                PrgBVidaMarciano.Value = PrgBVidaMarciano.Value - DanoComEscudo;
            }
        }

        public int dinheiro() {
            return Dinheiro;
        }
        
    }
}
