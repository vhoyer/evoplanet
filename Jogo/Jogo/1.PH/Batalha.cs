using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Jogo
{
    public partial class Batalha : Form
    {
        public Batalha(string nick, string[] ataque)
        {
            InitializeComponent();
            this.nick = nick;
            this.ataque = ataque;
        }

        Usos uso = new Usos();
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Pokemon Blue & Red - Main Theme"));
        SoundPlayer player2 = new SoundPlayer(Usos.EnderecoMusica("Donkey Kong Country - Island Swing"));

        #region "Class Variables"
        int Inimigo;
        int HPP, HPR, HPaP, HPaR;
        int cap = 0;
        string nick;
        string NomeInimigo;
        string[] ataque;
        #endregion

        #region "Events Click"
        private void lblClicar_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            this.Inimigo = x.Next(3) + 1;
            switch (this.Inimigo)
            {
                case 1: this.NomeInimigo = "Tiranossauro";
                    pctrVilao.Image = global::Jogo.Properties.Resources.Tiranossauro;
                    break;
                case 2: this.NomeInimigo = "Triceratops";
                    pctrVilao.Image = global::Jogo.Properties.Resources.Triceratops;
                    break;
                case 3: this.NomeInimigo = "Pterodáctilo";
                    pctrVilao.Image = global::Jogo.Properties.Resources.Pterodactilo;
                    break;
            }
            lblClicar.Visible = false;
            lblMensagem1.Text = "Espere...";
            pnl1.Refresh();
            player.Stop();
            player.PlayLooping();
            Thread.Sleep(3000);
            this.BackgroundImage = null;
            this.Refresh();
            for (int con = 0; con < 20; con++)
            {
                Thread.Sleep(100);
                if (con % 2 == 0)
                {
                    this.BackColor = Color.Black;
                }
                else
                {
                    this.BackColor = Color.White;
                }
                this.Refresh();
            }
            lblMensagem1.Text = "";
            pnl1.Refresh();
            Thread.Sleep(3000);
            int PosX = -213;
            int PosPX = 783;

            while (PosX < 430)
            {
                PosX += 5;
                PosPX -= 5;
                Thread.Sleep(10);
                pctrVilao.Refresh();
                pctrVilao.Location = new System.Drawing.Point(PosX, 12);
                pctrPlayer.Refresh();
                pctrPlayer.Location = new System.Drawing.Point(PosPX, 253);
            }
            Thread.Sleep(500);
            lblMensagem1.Text = this.NomeInimigo + " selvagem apareceu!";
            pnl1.Refresh();
            Thread.Sleep(2000);
            lblMensagem1.Text = "Vai eu!";
            pnl1.Refresh();
            Thread.Sleep(1000);
            lblMensagem1.Text = "";
            pnl1.Refresh();
            iniciar();
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            pnl3.Visible = true;
            pnl2.Visible = false;

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            pnl2.Visible = false;
            lblMensagem1.Text = nick + " taca a corda no " + NomeInimigo;
            pnl1.Refresh();
            Thread.Sleep(2500);
            if (HPaR <= 5) {
                MessageBox.Show(NomeInimigo + " foi capturado", "Temos que pegar!", MessageBoxButtons.OK);
                switch (Inimigo) {
                    case 1: cap = 1; break;
                    case 2: cap = 2; break;
                    case 3: cap = 3; break;
                }
                player.Stop();
                player2.PlayLooping();
                this.Close();

            } else
            {
                lblMensagem1.Text = NomeInimigo + " Consiguiu escapar!";
                pnl1.Refresh(); 
                Thread.Sleep(3000);
                TurnoAdversario();
            }
        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if ((random.Next(10) + 1) > 3)
            {
                pnl2.Visible = false;
                lblMensagem1.Text = nick + " Fugiu!";
                pnl1.Refresh();
                Thread.Sleep(1000);
                player.Stop();
                player2.PlayLooping();
                this.Close();
            }
            else
            {
                pnl2.Visible = false;
                lblMensagem1.Text = nick + " tentou fugir, mas não conseguiu";
                pnl1.Refresh();
                Thread.Sleep(3000);
                TurnoAdversario();
            }
        }

        private void btnAtk1_Click(object sender, EventArgs e)
        {

            pnl2.Visible = false; pnl3.Visible = false;
            lblMensagem1.Text = nick + " tacou uma pedra!";
            pnl1.Refresh();
            HPaR -= 5;


            if (HPaR > 0)
            {

                Exibir();
                Thread.Sleep(3000);
                TurnoAdversario();
            }
            else
            {
                HPaR = 0;
                Exibir();
                Thread.Sleep(3000);
                Perdedor(0);
            }
        }

        private void btnAtk2_Click(object sender, EventArgs e)
        {
            pnl2.Visible = false; pnl3.Visible = false;
            lblMensagem1.Text = nick + " Tacou uma pedra redonda!";
            pnl1.Refresh();
            HPaR -= 8;


            if (HPaR > 0)
            {

                Exibir();
                Thread.Sleep(3000);
                TurnoAdversario();
            }
            else
            {
                HPaR = 0;
                Exibir();
                Thread.Sleep(3000);
                Perdedor(0);
            }
        }

        private void btnAtk4_Click(object sender, EventArgs e)
        {
            pnl2.Visible = false; pnl3.Visible = false;
            lblMensagem1.Text = nick + " Cabeciou com o velociraptor";
            pnl1.Refresh();
            HPaR -= 8;


            if (HPaR > 0)
            {

                Exibir();
                Thread.Sleep(3000);
                TurnoAdversario();
            }
            else
            {
                HPaR = 0;
                Exibir();
                Thread.Sleep(3000);
                Perdedor(0);
            }
        }

        private void btnAtk3_Click(object sender, EventArgs e)
        {
            pnl2.Visible = false; pnl3.Visible = false;
            lblMensagem1.Text = nick + " Tacou fogo!";
            pnl1.Refresh();
            HPaR -= 9;


            if (HPaR > 0)
            {

                Exibir();
                Thread.Sleep(3000);
                TurnoAdversario();
            }
            else
            {
                HPaR = 0;
                Exibir();
                Thread.Sleep(3000);
                Perdedor(0);
            }
        }

        #endregion

        #region "Builders"

        private void Exibir() {
            lblPLayerHP.Text = HPaP.ToString() + " / " + HPP.ToString();
            barPlayerHP.Maximum = HPP;
            barPlayerHP.Value = HPaP;
            barRivalHP.Maximum = HPR;
            barRivalHP.Value = HPaR;
            lblPLayerHP.Refresh();
            barPlayerHP.Refresh();
            barRivalHP.Refresh();
        }

        private void TurnoAdversario() {

            Random ataque = new Random();
            switch (Inimigo)
            {
                case 1:
                    if ((ataque.Next(10) + 1) >= 3)
                    {

                        lblMensagem1.Text = "Tiranossauro pisa!";
                        pnl1.Refresh();
                        HPaP = HPaP - 3;
                    }
                    else
                    {
                        lblMensagem1.Text = "Tiranossauro morde!";
                        pnl1.Refresh();
                        HPaP = HPaP - 8;

                    }
                    break;

                case 2:
                    if ((ataque.Next(10) + 1) >= 3)
                    {

                        lblMensagem1.Text = "Triceratops bate!";
                        pnl1.Refresh();
                        HPaP = HPaP - 2;
                    }
                    else
                    {
                        lblMensagem1.Text = "Triceratops corre e chifra!";
                        pnl1.Refresh();
                        HPaP = HPaP - 10;

                    }
                    break;
                case 3:
                    if ((ataque.Next(10) + 1) >= 4)
                    {

                        lblMensagem1.Text = "Pterodáctilo bica!";
                        pnl1.Refresh();
                        HPaP = HPaP - 3;
                    }
                    else
                    {
                        lblMensagem1.Text = "Pterodáctilo cai com tudo!";
                        pnl1.Refresh();
                        HPaP = HPaP - 8;

                    }
                    break;
            }

            if (HPaP > 0)
            {
                Exibir();
                Thread.Sleep(3000);
                lblMensagem1.Text = "";
                pnl1.Refresh();
                pnl2.Visible = true;
            }
            else
            {
                HPaP = 0;
                Exibir();
                Thread.Sleep(3000);
                Perdedor(1);
            }
        }

        private void Perdedor(int n)
        {
            if (n == 0) {
                MessageBox.Show("Inimigo " + this.NomeInimigo + " desmaiou!", "WINNER", MessageBoxButtons.OK);

            } else
            {
                MessageBox.Show(nick + " Desmaiou", "LOSER", MessageBoxButtons.OK);
            }
            player.Stop();
            player2.PlayLooping();
            this.Close();
        }

        public int Capturou()
        {
            return cap;
        }

        private void iniciar()
        {
            if (ataque[3] == "1")
            {
                btnAtk2.Text = "Quase Roda";
                btnAtk2.Enabled = true;
            }
            if (ataque[4] == "1")
            {
                btnAtk3.Text = "Fogo";
                btnAtk3.Enabled = true;
            }
            if (ataque[5] == "1")
            {
                btnAtk4.Text = "Velociraptor";
                btnAtk4.Enabled = true;
            }
            barPlayerHP.Visible = true;
            barRivalHP.Visible = true;
            lblPlayerN.Text = nick;
            HPP = 20;
            HPaP = 20;

            btnAtk1.Text = "Tacar Pedra";
            lblRivalN.Text = this.NomeInimigo;
            switch (Inimigo)
            {
                case 1:
                    HPR = 20;
                    HPaR = 20; break;
                case 2:
                    HPR = 25;
                    HPaR = 25; break;
                case 3:
                    HPR = 17;
                    HPaR = 17; break;
            }
            Exibir();

            pnl2.Visible = true;

        }

        #endregion

    }
}
