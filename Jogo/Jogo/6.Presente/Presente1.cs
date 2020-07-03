using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace Jogo._6.Presente
{
    public partial class Presente1 : Form
    {
        public Presente1(string nick)
        {
            InitializeComponent();
            this.nick = nick;
            player.PlayLooping();
        }
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Animal Crossing - Title Theme"));
        string nick;
        int x=0;
        int ajuda = 0;

        private void Presente1_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case 0: lblTexto.Text = "Estou indo, Estou indo...";
                    lblTexto.Refresh();
                    Thread.Sleep(10);
                    int PosEu = 792;
                    while (PosEu != 382)
                    {
                        PosEu -= 10;
                        pctrEu.Location = new Point(PosEu, 326);
                        pctrEu.Refresh();
                        Thread.Sleep(50);
                    }
                    break;
                case 1: lblTexto.Text = "Não esta esquecendo de nada?"; button1.Visible = false;
                    btnSim.Visible = true; btnNao.Visible = true; break;
                case 2: lblTexto.Visible = false;
                    lblTexto.Refresh();
                    pctrPreto.Visible = true;
                    pctrPreto.Refresh();
                    this.BackgroundImage = global::Jogo.Properties.Resources.Janela;
                    pctrEu.Visible = false;
                    pictureBox1.Visible = false;
                    Thread.Sleep(2000);
                    pctrPreto.Visible = false;
                    lblTexto.Visible = true;
                    lblTexto.Text = "hmmm... que biscoito gostoso!";
                    break;
                case 3:lblTexto.Text = "Não é biscoito, é bolacha! e joga fora esse papel logo";
                    break;
                case 4: lblTexto.Text = "Vai jogar fora o papel?";
                    button1.Visible = false;
                    btnSim.Visible = true; btnNao.Visible = true;
                    break;
                case 5: lblTexto.Text = "Ah... Que viagem demorada...";
                    break;
                case 6:
                    lblTexto.Visible = false;
                    lblTexto.Refresh();
                    pctrPreto.Visible = true;
                    pctrPreto.Refresh();
                    this.BackgroundImage = global::Jogo.Properties.Resources.Ajuda_a_mosa;
                    pctrEu.Visible = false;
                    lblTexto.Text = "Ei moço, meu colar caiu ai perto, pode pegar para mim?";
                    button1.Visible = false;
                    Thread.Sleep(2000);
                    pctrRosto.Visible = true;
                    pctrPreto.Visible = false;
                    lblTexto.Visible = true;
                    btnSim.Visible = true; btnNao.Visible = true;
                    break;
                case 7: lblTexto.Text = "Seus feitos nessa era ja determinam o seu futuro. Você deve evoluir";
                    button1.Text = "Evoluir >>";
                    break;
                case 8: Usos uso = new Usos();
                    string[] w = uso.DesfragmentarLinha(3, ';', nick);
                    if (ajuda > 0)
                    {
                        if (w[1] == "9") {
                            w[1] = "7";
                        } else if (w[1] == "6")
                        { 
                            w[1] = "8";
                        }
                        uso.RescreverLinha(3, nick, "8;" + w[1]);
                        _7._1.FuturoBom.CSFuturoBom x = new _7._1.FuturoBom.CSFuturoBom(nick);
                        x.Show();
                            
                    }
                    else
                    {
                        if (w[1] == "8")
                        {
                            w[1] = "7";
                        }
                        else if (w[1] == "6")
                        {
                            w[1] = "9";
                        }
                        uso.RescreverLinha(3, nick, "9;" + w[1]);
                        _7._2.FuturoRuim.CSFuturoRuim x = new _7._2.FuturoRuim.CSFuturoRuim(nick);
                        x.Show();
                    }
                    player.Stop();
                    this.Close();
                    break;
            }
            x++;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            if (x == 2)
            {
                lblTexto.Text = "A claro, o abajur. Vamos!";
                pictureBox1.Image = global::Jogo.Properties.Resources.AbajurDesligado;
                ajuda++;
                btnSim.Visible = false; btnNao.Visible = false;
                button1.Visible = true;

            }
            if (x == 5)
            {
                lblTexto.Text = "Ok Ok... *Joga pela janela*";
                btnSim.Visible = false; btnNao.Visible = false;
                button1.Visible = true;
                ajuda--;
            }
            if (x == 7)
            {
                lblTexto.Text = "Claro! Pegue de volta.";
                btnSim.Visible = false; btnNao.Visible = false;
                button1.Visible = true;
                ajuda++;
            }
        }

        private void btnNão_Click(object sender, EventArgs e)
        {
            if (x == 2)
            {
                lblTexto.Text = "Ah, não é nada, vamos!";
                btnSim.Visible = false; btnNao.Visible = false;
                button1.Visible = true;
                ajuda--;
            }

            if (x == 5)
            {
                lblTexto.Text = "Preciso de um lixo antes, não acha?*";
                btnSim.Visible = false; btnNao.Visible = false;
                button1.Visible = true;
                ajuda++;
            }
            if (x == 7)
            {
                lblTexto.Text = "Estou muito oculpado no momento, desculpe.";
                pctrRosto.Image = global::Jogo.Properties.Resources.Triste;
                btnSim.Visible = false; btnNao.Visible = false;
                button1.Visible = true;
                ajuda--;
            }
        }

    }
}
