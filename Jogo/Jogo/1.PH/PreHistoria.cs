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

namespace Jogo
{
    public partial class PreHistoria : Form
    {
        public PreHistoria(string nick)
        {
            InitializeComponent();
            this.nick = nick;
        }

        Usos uso = new Usos();
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Donkey Kong Country - Island Swing"));

        private void PreHistoria_Load(object sender, EventArgs e)
        {
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
            this.canPaint = false;
            feitos = uso.DesfragmentarLinha(6, ';', nick);
            barXP.Value = Convert.ToInt16(uso.LerLinha(7, nick));
            if (Concluiu == 1) btnEvoluir.Visible = true;
            Escrever();
        }

        #region "Class Variables"
        private string nick;
        string[] feitos;
        string[] Conquista;
        int Comida = 0;
        int Concluiu;
        int[] atrN;
        bool canPaint;
        #endregion

        #region "Events Click"

        private void btnAbrirMapa_Click(object sender, EventArgs e)
        {

            PreHistoriaMap abrir = new PreHistoriaMap(Comida, atrN[1], atrN[0], Conquista, nick, canPaint);
            abrir.ShowDialog();
            int[] atr = abrir.MudarStatus();
            atrN[0] += atr[0]; atrN[1] += atr[1];
            atrN[2] += atr[2]; atrN[3] += atr[3];
            atrN[4] += atr[4];
            Comida = abrir.MudarComida();
            canPaint = abrir.setTinta();
            Escrever();

            if ((barXP.Value < 20) && (abrir.ChecarAcao()))
            {
                barXP.Value++;
            }
            if (atrN[0] <= 0)
            {

                MessageBox.Show("Você morreu, Mas agora tera outra chance de continuar!", "Game Over", MessageBoxButtons.OK);
                player.Stop();
                Sperm Chance = new Sperm(1, nick);
                Chance.Show();
                this.Close();

            }
            else
            {
                if (atrN[1] >= 10)
                {

                    MessageBox.Show("Você morreu, Mas agora tera outra chance de continuar!", "Game Over", MessageBoxButtons.OK);
                    player.Stop();
                    Sperm Chance = new Sperm(1, nick);
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
            string[] x = uso.DesfragmentarLinhaConq(1, ';', nick);
            switch (abrir.ChecarDino()) {
                case 1: Conquista[0] = "1";
                    if (x[0] == "0") x[0] = "1";
                    break;
                case 2: Conquista[1] = "1";
                    if (x[1] == "0") x[1] = "1";
                    break;
                case 3: Conquista[2] = "1";
                    if (x[2] == "0") x[2] = "1";
                    break;
            }
            uso.RescreverLinhaConq(1,nick,uso.ArraytoString(x));

            ChecarFeito(atrN[2], atrN[3], atrN[4]);
            Escrever();
        }

        private void btnEvoluir_Click(object sender, EventArgs e)
        {
            player.Stop();
            CSFinalPH evoluir = new CSFinalPH(nick);
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
            this.Close();
        }

        #endregion

        #region "Builders"

        private void Escrever() {

            if (Conquista[0] == "1") {
                pctrTira.Visible = true;
            }
            if (Conquista[1] == "1") {
                pctrTrice.Visible = true;
            }
            if (Conquista[2] == "1")
            {
                pctrPtero.Visible = true;
            }
            lblEnergia.Text = atrN[0].ToString() + " / 10";
            lblFome.Text = atrN[1].ToString() + " / 10";
            lblFor.Text = atrN[2].ToString();
            lblInt.Text = atrN[3].ToString();
            lblCar.Text = atrN[4].ToString();


        }

        private void ChecarFeito(int For, int Int, int Car)
        {
            string[] x = uso.DesfragmentarLinhaConq(1, ';', nick);
            if ((For>=7) && (Conquista[3] == "0"))
            {

                MessageBox.Show("Você estava olhando um coco e tentou recriar o formato dele em uma pedra, criando assim, a quase roda.", "Conquista desbloqueada! - Roda", MessageBoxButtons.OK);
                Conquista[3] = "1";

                if (x[3] == "0") x[3] = "1";
            }

            if ((Int >= 7) && (Conquista[4] == "0"))
            {

                MessageBox.Show("O vulcão acaba de entrar em erupção e queima umas árvores em volta. Vendo as chamas, você junta alguns gravetos e bate duas pedras próximo a eles, criando assim, o fogo.", "Conquista desbloqueada! - Fogo", MessageBoxButtons.OK);
                Conquista[4] = "1";

                if (x[4] == "0") x[4] = "1";
            }

            if ((Car >= 7) && (Conquista[5] == "0"))
            {

                MessageBox.Show("Encontraste um raro velociraptor e utilizando todo o teu carisma, domesticaste ele com sucesso.", "Conquista desbloqueada! - Encantador", MessageBoxButtons.OK);
                Conquista[5] = "1";
                if (x[5] == "0") x[5] = "1";
            }
            uso.RescreverLinhaConq(1, nick, uso.ArraytoString(x));

        }

        #endregion

        #region "Menu"

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] x = uso.DesfragmentarLinha(3, ';', nick);
            uso.RescreverLinha(3, nick,  "1;" + x[1]);
            uso.RescreverLinha(4, nick, uso.ArraytoString(atrN));
            uso.RescreverLinha(5, nick, Concluiu.ToString());
            uso.RescreverLinha(6, nick, uso.ArraytoString(Conquista));
            uso.RescreverLinha(7, nick, barXP.Value.ToString());
        }

        private void salvarESairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            string[] x = uso.DesfragmentarLinha(3, ';', nick);
            uso.RescreverLinha(3, nick,  "1;" + x[1]);
            uso.RescreverLinha(4, nick, uso.ArraytoString(atrN));
            uso.RescreverLinha(5, nick, Concluiu.ToString());
            uso.RescreverLinha(6, nick, uso.ArraytoString(Conquista));
            uso.RescreverLinha(7, nick, barXP.Value.ToString());
            Abertura voltar = new Abertura(nick, uso.LerLinha(4, nick));
            voltar.Show();
            this.Close();
        }

        private void sairSemSalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player.Stop();
            Abertura voltar = new Abertura(nick, uso.LerLinha(4, nick));
            voltar.Show();
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

        private void instruçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _1.PH.InstruPH x = new _1.PH.InstruPH();
            x.ShowDialog();
        }
    }
}
