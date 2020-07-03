using System;
using System.Collections;
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
    public partial class frmFrogger : Form
    {
        int velocidadeDoTronco = 10;
        private int cont = 1;
        bool acompanharOtronco = true;
        ArrayList ovelhas = new ArrayList();
        ArrayList troncosR = new ArrayList();
        ArrayList troncosL = new ArrayList();

        public frmFrogger()
        {
            InitializeComponent();
        }

        private void tmrOvelha_Tick(object sender, EventArgs e)
        {
            pctOvelha.Location = new Point(pctOvelha.Location.X + 10, pctOvelha.Location.Y);
            pctOvelha2.Location = new Point(pctOvelha2.Location.X + 10, pctOvelha2.Location.Y);
            pctOvelha3.Location = new Point(pctOvelha3.Location.X + 10, pctOvelha3.Location.Y);
            pctOvelha4.Location = new Point(pctOvelha4.Location.X + 10, pctOvelha4.Location.Y);
            pctOvelha5.Location = new Point(pctOvelha5.Location.X + 10, pctOvelha5.Location.Y);
            pctOvelha6.Location = new Point(pctOvelha6.Location.X + 10, pctOvelha6.Location.Y);
            pctOvelha7.Location = new Point(pctOvelha7.Location.X + 10, pctOvelha7.Location.Y);
            pctOvelha8.Location = new Point(pctOvelha8.Location.X + 10, pctOvelha8.Location.Y);
            pctOvelha9.Location = new Point(pctOvelha9.Location.X + 10, pctOvelha9.Location.Y);
            pctOvelha10.Location = new Point(pctOvelha10.Location.X + 10, pctOvelha10.Location.Y);

            if (cont % 2 == 0)
            {
                pctOvelha.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha2.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha3.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha4.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha5.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha6.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha7.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha8.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha9.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                pctOvelha10.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa_ANDANDO;
                cont++;

            }
            else
            {
                if (cont % 2 != 0)
                pctOvelha.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha2.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha3.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha4.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha5.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha6.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha7.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha8.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha9.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                pctOvelha10.Image = Jogo.Properties.Resources.ovelhinhaaaaaaaa;
                cont++;

            }

            if (pctOvelha.Location.X >= this.Size.Width)
            {
                pctOvelha.Location = new Point(pctOvelha.Location.X - this.Size.Width - pctOvelha.Size.Width, pctOvelha.Location.Y);
            }
            if (pctOvelha2.Location.X >= this.Size.Width)
            {
                pctOvelha2.Location = new Point(pctOvelha2.Location.X - this.Size.Width - pctOvelha2.Size.Width, pctOvelha2.Location.Y);
            }
            if (pctOvelha3.Location.X >= this.Size.Width)
            {
                pctOvelha3.Location = new Point(pctOvelha3.Location.X - this.Size.Width - pctOvelha3.Size.Width, pctOvelha3.Location.Y);
            }
            if (pctOvelha4.Location.X >= this.Size.Width)
            {
                pctOvelha4.Location = new Point(pctOvelha4.Location.X - this.Size.Width - pctOvelha4.Size.Width, pctOvelha4.Location.Y);
            }
            if (pctOvelha5.Location.X >= this.Size.Width)
            {
                pctOvelha5.Location = new Point(pctOvelha5.Location.X - this.Size.Width - pctOvelha5.Size.Width, pctOvelha5.Location.Y);
            }
            if (pctOvelha6.Location.X >= this.Size.Width)
            {
                pctOvelha6.Location = new Point(pctOvelha6.Location.X - this.Size.Width - pctOvelha6.Size.Width, pctOvelha6.Location.Y);
            }
            if (pctOvelha7.Location.X >= this.Size.Width)
            {
                pctOvelha7.Location = new Point(pctOvelha7.Location.X - this.Size.Width - pctOvelha7.Size.Width, pctOvelha7.Location.Y);
            }
            if (pctOvelha8.Location.X >= this.Size.Width)
            {
                pctOvelha8.Location = new Point(pctOvelha8.Location.X - this.Size.Width - pctOvelha8.Size.Width, pctOvelha8.Location.Y);
            }
            if (pctOvelha9.Location.X >= this.Size.Width)
            {
                pctOvelha9.Location = new Point(pctOvelha9.Location.X - this.Size.Width - pctOvelha9.Size.Width, pctOvelha9.Location.Y);
            }
            if (pctOvelha10.Location.X >= this.Size.Width)
            {
                pctOvelha10.Location = new Point(pctOvelha10.Location.X - this.Size.Width - pctOvelha10.Size.Width, pctOvelha10.Location.Y);
            }

        }

        private void pctTronco_Click(object sender, EventArgs e)
        {
          
        }

        private void tmrTronco_Tick(object sender, EventArgs e)
        {
            Point peDireito = new Point(pctMarcianinho.Location.X + pctMarcianinho.Size.Width, pctMarcianinho.Location.Y + pctMarcianinho.Size.Height);
            foreach (PictureBox pct in troncosR)
            {
                Point batata = new Point(pct.Location.X + pct.Size.Width, pct.Location.Y + pct.Size.Height);
                if (acompanharOtronco)
                {
                    if (pctMarcianinho.Location.X > pct.Location.X && peDireito.X < batata.X &&
                        pctMarcianinho.Location.Y > pct.Location.Y && peDireito.Y < batata.Y)
                    {
                        pctMarcianinho.Location = new Point(pctMarcianinho.Location.X + velocidadeDoTronco, pctMarcianinho.Location.Y);
                    }
                }
            } 
            foreach (PictureBox pct in troncosL)
            {
                Point batata = new Point(pct.Location.X + pct.Size.Width, pct.Location.Y + pct.Size.Height);
                if (acompanharOtronco)
                {
                    if (pctMarcianinho.Location.X > pct.Location.X && peDireito.X < batata.X &&
                        pctMarcianinho.Location.Y > pct.Location.Y && peDireito.Y < batata.Y)
                    {
                        pctMarcianinho.Location = new Point(pctMarcianinho.Location.X - velocidadeDoTronco, pctMarcianinho.Location.Y);
                    }
                }
            }

            pctTronco.Location = new Point(pctTronco.Location.X + 10, pctTronco.Location.Y);
            pctTronco2.Location = new Point(pctTronco2.Location.X - 10, pctTronco2.Location.Y);
            pctTronco3.Location = new Point(pctTronco3.Location.X + 10, pctTronco3.Location.Y);
            pctTronco4.Location = new Point(pctTronco4.Location.X - 10, pctTronco4.Location.Y);
            pctTronco5.Location = new Point(pctTronco5.Location.X - 10, pctTronco5.Location.Y);
            pctTronco6.Location = new Point(pctTronco6.Location.X - 10, pctTronco6.Location.Y);
            pctTronco7.Location = new Point(pctTronco7.Location.X - 10, pctTronco7.Location.Y);
            pctTronco8.Location = new Point(pctTronco8.Location.X + 10, pctTronco8.Location.Y);
            pctTronco10.Location = new Point(pctTronco10.Location.X + 10, pctTronco10.Location.Y);
            pctTronco11.Location = new Point(pctTronco11.Location.X + 10, pctTronco11.Location.Y);

            if (pctTronco.Location.X >= this.Size.Width)
            {
                pctTronco.Location = new Point(pctTronco.Location.X - this.Size.Width - pctTronco.Size.Width, pctTronco.Location.Y);
            }
            if (pctTronco2.Location.X <= -pctTronco2.Size.Width)
            {
                pctTronco2.Location = new Point(pctTronco2.Location.X + this.Size.Width + pctTronco2.Size.Width, pctTronco2.Location.Y);
            }
            if (pctTronco3.Location.X >= this.Size.Width)
            {
                pctTronco3.Location = new Point(pctTronco3.Location.X - this.Size.Width - pctTronco3.Size.Width, pctTronco3.Location.Y);
            }
            if (pctTronco4.Location.X <= -pctTronco4.Size.Width)
            {
                pctTronco4.Location = new Point(pctTronco4.Location.X + this.Size.Width + pctTronco4.Size.Width, pctTronco4.Location.Y);
            }
            if (pctTronco5.Location.X <= -pctTronco5.Size.Width)
            {
                pctTronco5.Location = new Point(pctTronco5.Location.X + this.Size.Width + pctTronco5.Size.Width, pctTronco5.Location.Y);
            }
            if (pctTronco6.Location.X <= -pctTronco6.Size.Width)
            {
                pctTronco6.Location = new Point(pctTronco6.Location.X + this.Size.Width + pctTronco6.Size.Width, pctTronco6.Location.Y);
            }
            if (pctTronco7.Location.X <= -pctTronco7.Size.Width)
            {
                pctTronco7.Location = new Point(pctTronco7.Location.X + this.Size.Width + pctTronco7.Size.Width, pctTronco7.Location.Y);
            }
            if (pctTronco8.Location.X >= this.Size.Width)
            {
                pctTronco8.Location = new Point(pctTronco8.Location.X - this.Size.Width - pctTronco8.Size.Width, pctTronco8.Location.Y);
            }
            if (pctTronco10.Location.X >= this.Size.Width)
            {
                pctTronco10.Location = new Point(pctTronco10.Location.X - this.Size.Width - pctTronco10.Size.Width, pctTronco10.Location.Y);
            }
            if (pctTronco11.Location.X >= this.Size.Width)
            {
                pctTronco11.Location = new Point(pctTronco11.Location.X - this.Size.Width - pctTronco11.Size.Width, pctTronco11.Location.Y);
            }
        }

        private void frmFrogger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pctMarcianinho.Left = pctMarcianinho.Left + 10;
            }
            if (e.KeyCode == Keys.Left)
            {
                pctMarcianinho.Left = pctMarcianinho.Left - 10;
            }
             if (e.KeyCode == Keys.Up)
            {
                pctMarcianinho.Top = pctMarcianinho.Top - 10;
            }
              if (e.KeyCode == Keys.Down)
            {
                pctMarcianinho.Top = pctMarcianinho.Top + 10;
            }
        }

        private bool Collided(PictureBox pctAlvo, PictureBox pctProjectil)
        {
            Point secPoint = new Point(pctProjectil.Location.X + pctProjectil.Size.Width, pctProjectil.Location.Y + pctProjectil.Size.Height);
            Point secPointAlvo = new Point(pctAlvo.Location.X + pctAlvo.Size.Width, pctAlvo.Location.Y + pctAlvo.Size.Height);

            if ( //Ponto Superior Esquerdo
                (pctProjectil.Location.X > pctProjectil.Location.X && pctProjectil.Location.X < secPointAlvo.X) &&
                (pctProjectil.Location.Y > pctAlvo.Location.Y && pctProjectil.Location.Y < secPointAlvo.Y)) 
            {
                return true;
            }
            if ( //Ponto Inferior Direito
                (secPoint.X > pctAlvo.Location.X && secPoint.X < secPointAlvo.X) &&
                (secPoint.Y > pctAlvo.Location.Y && secPoint.Y < secPointAlvo.Y))
            {
                return true;
            }
            if ( //Ponto Superior Direito
                (secPoint.X > pctAlvo.Location.X && secPoint.X < secPointAlvo.X) &&
                (pctProjectil.Location.Y > pctAlvo.Location.Y && pctProjectil.Location.Y < secPointAlvo.Y))
            {
                return true;
            }
            if ( //Ponto Inferior Esquerdo
                (pctProjectil.Location.X > pctAlvo.Location.X && pctProjectil.Location.X < secPointAlvo.X) &&
                (secPoint.Y > pctAlvo.Location.Y && secPoint.Y < secPointAlvo.Y))
            {
                return true;
            }
            return false;
        }

        private void pctMarcianinho_LocationChanged(object sender, EventArgs e)
        {
            //foreach (PictureBox pct in troncosR)
            //{
            //    if (dentro(pctAgua))
            //    {
            //        if (dentro(pct))
            //        {
            //            andar = true;
            //        }
            //        else
            //        {
            //            andar = false;
            //            pctMarcianinho.Location = new Point(369, 578);
            //        }
            //    }
            //}
            //foreach (PictureBox pct in troncosR)
            //{
            //    if (dentro(pctAgua))
            //    {
            //        if (dentro(pct))
            //        {
            //            andar = true;
            //        }
            //        else
            //        {
            //            andar = false;
            //            pctMarcianinho.Location = new Point(369, 578);
            //        }
            //    }
            //}
        }

        private bool dentro(PictureBox pct)
        {
            Point centro = new Point( pctMarcianinho.Location.X + pctMarcianinho.Size.Width / 2, pctMarcianinho.Location.Y + pctMarcianinho.Size.Height / 2 );
            Point secPoint = new Point(pct.Location.X + pct.Size.Width, pct.Location.Y + pct.Size.Height);

            if (centro.X > pct.Location.X && centro.X < secPoint.X && 
                centro.Y > pct.Location.Y && centro.Y < secPoint.Y)
            {
                return true;
            }
            return false;
        }

        private void tmrColisão_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox pct in ovelhas)
            {
                if (Collided(pct, pctMarcianinho))
                {
                    pctMarcianinho.Location = new Point(369, 578);
                }
            }

            if (dentro(pctGanha))
            {
                pctMarcianinho.Location = new Point(369, 578);
                this.Close();
            }
            //tronco
            //foreach (PictureBox pct in troncosR)
            //{
            //    if (dentro(pctAgua))
            //    {
            //        if (dentro(pct))
            //        {
            //            acompanharOtronco = true;
            //        }
            //        else
            //        {
            //            acompanharOtronco = false;
            //            pctMarcianinho.Location = new Point(369, 578);
            //        }
            //    }
            //}
            //foreach (PictureBox pct in troncosL)
            //{
            //    if (dentro(pctAgua))
            //    {
            //        if (dentro(pct))
            //        {
            //            acompanharOtronco = true;
            //        }
            //        else
            //        {
            //            acompanharOtronco = false;
            //            pctMarcianinho.Location = new Point(369, 578);
            //        }
            //    }
            //}
        }

        private void frmFrogger_Load(object sender, EventArgs e)
        {
            ovelhas.Add(pctOvelha);
            ovelhas.Add(pctOvelha2);
            ovelhas.Add(pctOvelha3);
            ovelhas.Add(pctOvelha4);
            ovelhas.Add(pctOvelha5);
            ovelhas.Add(pctOvelha6);
            ovelhas.Add(pctOvelha7);
            ovelhas.Add(pctOvelha8);
            ovelhas.Add(pctOvelha9);

            troncosR.Add(pctTronco);
            troncosL.Add(pctTronco2);
            troncosR.Add(pctTronco3);
            troncosL.Add(pctTronco4);
            troncosL.Add(pctTronco5);
            troncosL.Add(pctTronco6);
            troncosL.Add(pctTronco7);
            troncosR.Add(pctTronco8);
            troncosR.Add(pctTronco10);
            troncosR.Add(pctTronco11);
        }

    }
}
