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
using Jogo;

namespace Feudo
{
    public partial class frmTowerDefense : Form
    {
        public frmTowerDefense(int For, int Int, string nick)
        {
            InitializeComponent();
            this.For = For;
            this.Int = Int;
            this.nick = nick;
        }
        Usos uso = new Usos();
        SoundPlayer player = new SoundPlayer();
        int For, Int;
        string nick;
        bool evo = false;

        private void btnPlantarMandioca_Click(object sender, EventArgs e)
        {
            lblMercadorias.Text = "Mandiocas: " + mandioca;
            lblMercadorias.Refresh();
            mandioca = mandioca + 1;
            if (!tmrDelayMandioca.Enabled)
            {
                btnPlantarMandioca.Enabled = false;
                tmrDelayMandioca.Start();
                barDelayMandioca.Increment(10);
            }
        }
        int mandioca = 1, exercito;

        private void tmrDelayMandioca_Tick(object sender, EventArgs e)
        {
            if (!(barDelayMandioca.Value == barDelayMandioca.Maximum))
            {
                //comandos que irão executar no tick do timer
                barDelayMandioca.Increment(10); //incrementa a barra
            }
            else
            {
                btnPlantarMandioca.Enabled = true;
                barDelayMandioca.Value = 0;
                tmrDelayMandioca.Stop();
            }
        }
        private void btnFertilizante_Click_1(object sender, EventArgs e)
        {
            //if(mandioca >= 5)
            //{
            //mandioca = mandioca - 5;

            //Acelera o timer (diminue o intervalo do timer)
            //variavel "diminuir" diminue o intervalo do timer deixando o "plantar mandioca" mais rápido
            int diminuir = 100;
            if (tmrDelayMandioca.Interval > 100)
            {
                tmrDelayMandioca.Interval -= diminuir;
            }
            else
            {
                btnFertilizante.Enabled = false;
            }
            //}
            //if(mandioca<20)
            //{
            //  MessageBox.Show("Número de mandiocas insuficiente!");
            //}
        }

        private void btnFazerGuerreiro_Click(object sender, EventArgs e)
        {

            if (mandioca >= 5)
            {
                mandioca = mandioca - 5;
                lblMercadorias.Text = "Mandiocas: " + mandioca;
                lblMercadorias.Refresh();
                exercito++;
                lblExercito.Text = "Exército:" + exercito;
                lblExercito.Refresh();
            }
            else
            {
                MessageBox.Show("Número de mandiocas insuficiente!");
            }
        }

        private void btnFazerBarbaro_Click(object sender, EventArgs e)
        {
            if (mandioca >= 10)
            {
                lblMercadorias.Text = "Mandiocas: " + mandioca;
                lblMercadorias.Refresh();
                mandioca = mandioca - 10;
                exercito = exercito + 3;
                lblExercito.Text = "Exército:" + exercito;
                lblExercito.Refresh();
            }
            else
            {
                MessageBox.Show("Número de mandiocas insuficiente!");
            }
        }

        private void btnArqueiro_Click(object sender, EventArgs e)
        {
            if (mandioca >= 15)
            {
                lblMercadorias.Text = "Mandiocas: " + mandioca;
                lblMercadorias.Refresh();
                mandioca = mandioca - 15;
                exercito = exercito + 5;
                lblExercito.Text = "Exército:" + exercito;
                lblExercito.Refresh();
            }
            else
            {
                MessageBox.Show("Número de mandiocas insuficiente!");
            }
        }

        private void btnIniciarPlano_Click(object sender, EventArgs e)
        {
            if (progressBarPlanoSecreto.Value == 3 && For >= 7 && Int >= 7)
            {
                MessageBox.Show("Depois de muito preparo, ocorre o que os senhores feudais não esperavam, você e um exército de servos se juntam durante a noite e vão de castelo em castelo, mansão em mansão até que todos saibam que vocês cometeram a Revolução! Nada de viver a custa de senhores! Após a revolução bem sucedida você e os sobreviventes se juntam e começam a construirem suas casas perto um do outro, vivendo de comércio, criando assim, as cidades.");
                player.Stop();
                Jogo._6.Presente.Presente1 evoluir = new Jogo._6.Presente.Presente1(nick);
                evoluir.Show();
                string[] Caps = uso.DesfragmentarLinha(3, ';', nick);
                if (Convert.ToInt32(Caps[1]) <= 2)
                {
                    Caps[1] = "2";
                }
                uso.RescreverLinha(3, nick, "2;" + Caps[1]);
                uso.RescreverLinha(4, nick, "10;0;0;0;0");
                uso.RescreverLinha(5, nick, "0");
                uso.RescreverLinha(6, nick, "0;0;0;0;0;0");
                uso.RescreverLinha(7, nick, "0");
                string[] Conq = uso.DesfragmentarLinhaConq(4, ';', nick);
                uso.RescreverLinhaConq(4, nick, Conq[0] + ";" + Conq[1] + ";" + Conq[2] + ";1;1;1");
                evo = true;
                this.Close();
            }
            //if(mandioca >= 20)
            //{
            lblMercadorias.Text = "Mandiocas: " + mandioca;
            lblMercadorias.Refresh();
            //mandioca = mandioca - 20;
            if (progressBarPlanoSecreto.Value != 3)
            {
                progressBarPlanoSecreto.Value = progressBarPlanoSecreto.Value + 1;
            } else if (For < 7 && Int < 7)
            {
                progressBarPlanoSecreto.Value = 0;
            }


            //}
            //else
            //{
            //  MessageBox.Show("Número de mandiocas insuficiente!");
            //}

        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            if(txtAtaqueBatalha.Text != ""){

                AtaqueBatalha = Convert.ToInt32(txtAtaqueBatalha.Text);

                exercito = exercito - AtaqueBatalha;
                lblExercito.Text = "Exército:" + exercito;
                lblExercito.Refresh();
                if (AtaqueBatalha <= 3)
                {
                    MessageBox.Show("Foi uma bela batalha, porém seus soldados não aguentaram o suficiente!", "Resultado da batalha");
                }
                else if (AtaqueBatalha > 3 && AtaqueBatalha <= 5)
                {
                    if (BarVidaInimigo.Value - 20 > 0)
                    {
                        MessageBox.Show("Você e seus soldados vão para o campo de batalha e são emboscados!", "Resultado da batalha");
                        BarVidaInimigo.Value = BarVidaInimigo.Value - 20;
                    }
                    else BarVidaInimigo.Value = 0;
                }
                else if (AtaqueBatalha > 5 && AtaqueBatalha <= 10)
                {
                    if (BarVidaInimigo.Value - 40 > 0)
                    {
                        MessageBox.Show("Que batalha!Por essa o inimigo não esperava!", "Resultado da batalha");
                        BarVidaInimigo.Value = BarVidaInimigo.Value - 40;
                    }
                    else BarVidaInimigo.Value = 0;
                }
                else if (AtaqueBatalha > 10 && AtaqueBatalha <= 15)
                {
                    if (BarVidaInimigo.Value - 80 > 0)
                    {
                        MessageBox.Show("Que desastre para o inimigo!Seu exército atropela os inimigos!", "Resultado da batalha");
                        BarVidaInimigo.Value = BarVidaInimigo.Value - 80;
                    }
                    else BarVidaInimigo.Value = 0;
                }
                else if (AtaqueBatalha > 15)
                {
                    MessageBox.Show("O que foi isso? Uma briga de criança? Seu exército vence facilmente o inimigo!", "Resultado da batalha");
                    BarVidaInimigo.Value = BarVidaInimigo.Value - 100;
                }
                else if (BarVidaInimigo.Value <= 0)
                {
                    MessageBox.Show("Incrível! Você venceu o inimigo! Mas o mais importante, que tal realizarmos nosso plano SUPER secreto? +30 Mandidollars, + 2 Força, +2 Inteligência, +2 Carisma");
                    tmrAtaqueInimigo.Stop();
                }
            }
        }

        private void txtAtaqueBatalha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtAtaqueBatalha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTowerDefense_Load(object sender, EventArgs e)
        {

        }

        private void tmrAtaqueInimigo_Tick(object sender, EventArgs e)
        {
            BarDelayAtaqueInimigo.Increment(10);
            if (BarDelayAtaqueInimigo.Value == BarDelayAtaqueInimigo.Maximum)
            {
                if (exercito > 0 && exercito <= 5)
                {
                    exercito = exercito - exercito;
                    MessageBox.Show("Parece que você e seu exército não estava preparado para sofrer o ataque, se prepare melhor na proxima vez! Você perdeu todo o seu exército.", "Ataque inimigo!");
                }
                else if (exercito > 5 && exercito <= 10)
                {
                    exercito = exercito - 5;
                    MessageBox.Show("Seu inimigo ataca! Porém não muito efetivo, você perdeu 5 de seus soldados!", "O inimigo ataca!");
                }
                else if (exercito > 10)
                {
                    MessageBox.Show("Parece que você conseguiu surpreender o ataque inimigo! Você perdeu nenhum de seus soldados", "O inimigo ataca!");
                }

                BarDelayAtaqueInimigo.Value = 0;
            }
        }
        private void BarDelayAtaqueInimigo_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int AtaqueBatalha;

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            lblMercadorias.Refresh();
            lblExercito.Refresh();
        }

        private void BarVidaInimigo_Click(object sender, EventArgs e)
        {

        }

        public bool Evo()
        {
            return evo;
        }
    }
}
