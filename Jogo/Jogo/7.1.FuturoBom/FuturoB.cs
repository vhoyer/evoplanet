﻿using System;
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
    public partial class FuturoB : Form
    {

        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Mega Man II - Airman Stage"));
        public FuturoB(string nick)
        {
            InitializeComponent();
            this.nick = nick;
            Conquista = uso.DesfragmentarLinha(6, ';', nick);
            player.PlayLooping();
            string[] atrStr = uso.DesfragmentarLinha(4, ';', nick);
            Concluiu = Convert.ToInt16(uso.LerLinha(5, nick));

            int[] atr = {
                Convert.ToInt16(atrStr[0]),Convert.ToInt16(atrStr[1]),
                Convert.ToInt16(atrStr[2]),Convert.ToInt16(atrStr[3]),
                Convert.ToInt16(atrStr[4])
            };

            atrN = atr;
            feitos = uso.DesfragmentarLinha(6, ';', nick);
            barXP.Value = Convert.ToInt16(uso.LerLinha(7, nick));
            if (Concluiu == 1) btnEvoluir.Visible = true;
            Escrever();

        }

        Jogo.Usos uso = new Jogo.Usos();

        private string nick;
        string[] feitos;
        string[] Conquista;
        int Comida = 0;
        int Concluiu;
        int[] atrN;
        int Dinheiro = 0;

        private void btnMapa_Click(object sender, EventArgs e)
        {
            FuturoBMap abrir = new FuturoBMap(Comida, Dinheiro, atrN[1], atrN[0], nick);
            abrir.ShowDialog();
            int[] atr = abrir.MudarStatus();
            atrN[0] += atr[0]; atrN[1] += atr[1];
            atrN[2] += atr[2]; atrN[3] += atr[3];
            atrN[4] += atr[4];
            Comida = abrir.MudarComida();
            Dinheiro = abrir.MudarDinheiro();

            string[] x = uso.DesfragmentarLinhaConq(6, ';', nick);
            if (abrir.passou())
            {
                Conquista[3] = "1"; Conquista[4] = "1"; Conquista[5] = "1";

                if (x[3] == "0") x[3] = "1"; if (x[4] == "0") x[4] = "1"; if (x[5] == "0") x[5] = "1";
            }

            if ((atrN[2] >= 7) && (Conquista[0] == "0"))
            {

                MessageBox.Show("Chegou o dia da corrida. Você venceu!", "Conquista desbloqueada! - Corredor", MessageBoxButtons.OK);
                Conquista[0] = "1";

                if (x[0] == "0") x[0] = "1";
            }

            if ((atrN[3] >= 7) && (Conquista[1] == "0"))
            {

                MessageBox.Show("O primeiro ser a viajar além do nosso sistema solar voltou itacto!", "Conquista desbloqueada! - Além do planeta", MessageBoxButtons.OK);
                Conquista[1] = "1";

                if (x[1] == "0") x[1] = "1";
            }

            if ((atrN[4] >= 7) && (Conquista[2] == "0"))
            {

                MessageBox.Show("Todos na cidade te adoram!", "Conquista desbloqueada! - Conquistador", MessageBoxButtons.OK);
                Conquista[2] = "1";
                if (x[2] == "0") x[2] = "1";
            }
            uso.RescreverLinhaConq(7, nick, uso.ArraytoString(x));

            Escrever();

            if ((barXP.Value < 20) && (abrir.ChecarAcao()))
            {
                barXP.Value++;
            }
            if (atrN[0] <= 0)
            {

                MessageBox.Show("Você morreu, Mas agora tera outra chance de continuar!", "Game Over", MessageBoxButtons.OK);
                player.Stop();
                Jogo.Sperm Chance = new Jogo.Sperm(5, nick);
                Chance.Show();
                this.Close();

            }
            else
            {
                if (atrN[1] >= 10)
                {

                    MessageBox.Show("Você morreu, Mas agora tera outra chance de continuar!", "Game Over", MessageBoxButtons.OK);
                    player.Stop();
                    Jogo.Sperm Chance = new Jogo.Sperm(5, nick);
                    Chance.Show();
                    this.Close();
                }
            }

            if ((barXP.Value == 20) && (Concluiu == 0))
            {
                Concluiu = 1;
                MessageBox.Show("Você fez muitas coisas nessa era! Clique em evoluir para ir para outra era.", "Evolução!", MessageBoxButtons.OK);
                btnEvoluir.Visible = true;
            }
        }

        private void Escrever()
        {

            lblEnergia.Text = atrN[0].ToString() + " / 10";
            lblFome.Text = atrN[1].ToString() + " / 10";
            lblFor.Text = atrN[2].ToString();
            lblInt.Text = atrN[3].ToString();
            lblCar.Text = atrN[4].ToString();

        }

        #region "Menu"

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] x = uso.DesfragmentarLinha(3, ';', nick);
            uso.RescreverLinha(3, nick, "8;" + x[1]);
            uso.RescreverLinha(4, nick, uso.ArraytoString(atrN));
            uso.RescreverLinha(5, nick, Concluiu.ToString());
            uso.RescreverLinha(6, nick, uso.ArraytoString(Conquista));
            uso.RescreverLinha(7, nick, barXP.Value.ToString());
        }

        private void salvarESairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            string[] x = uso.DesfragmentarLinha(3, ';', nick);
            uso.RescreverLinha(3, nick, "8;" + x[1]);
            uso.RescreverLinha(4, nick, uso.ArraytoString(atrN));
            uso.RescreverLinha(5, nick, Concluiu.ToString());
            uso.RescreverLinha(6, nick, uso.ArraytoString(Conquista));
            uso.RescreverLinha(7, nick, barXP.Value.ToString());
            Jogo.Abertura voltar = new Jogo.Abertura(nick, uso.LerLinha(4, nick));
            voltar.Show();
            this.Close();
        }

        private void sairSemSalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            Jogo.Abertura voltar = new Jogo.Abertura(nick, uso.LerLinha(4, nick));
            voltar.Show();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btnEvoluir_Click(object sender, EventArgs e)
        {
            player.Stop();
            MessageBox.Show("A humanidade foi cada vez mais evoluindo e evoluindo... Varias conquistas como viajar para outros planetas, casas automaticas e coisas parecidas foram surgindo.", "Good End");
            Abertura evoluir = new Abertura(nick, "0;0;0;0;0");
            evoluir.Show();
            string[] Caps = uso.DesfragmentarLinha(3, ';', nick);
            uso.RescreverLinhaConq(5, nick, "1");
            uso.RescreverLinha(3, nick, "1;" + Caps[1]);
            uso.RescreverLinha(4, nick, "10;0;0;0;0");
            uso.RescreverLinha(5, nick, "0");
            uso.RescreverLinha(6, nick, "0;0;0;0;0;0");
            uso.RescreverLinha(7, nick, "0");
            this.Close();
        }

        private void instruçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstruFuturo x = new InstruFuturo();
            x.ShowDialog();
        }

        private void FuturoB_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
    }
}