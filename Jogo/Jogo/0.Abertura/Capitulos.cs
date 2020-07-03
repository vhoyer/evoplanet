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
    public partial class Capitulos : Form
    {
        public Capitulos(string nick)
        {
            InitializeComponent();
            this.nick = nick;
        }
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Smash Bros Melee - Menu 1"));
        Usos uso = new Usos();
        string nick;
        bool x = false;
        private void Capitulos_Load(object sender, EventArgs e)
        {
            string[] atual = uso.DesfragmentarLinha(3 , ';', nick);
            switch (Convert.ToInt32(atual[1])) {

                case 2:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    break;

                case 3:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    btnRoma.Enabled = true; lblRoma.Visible = true;
                    break;

                case 4:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    btnRoma.Enabled = true; lblRoma.Visible = true;
                    btnFeud.Enabled = true; lblFeud.Visible = true;
                    break;
                case 6:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    btnRoma.Enabled = true; lblRoma.Visible = true;
                    btnFeud.Enabled = true; lblFeud.Visible = true;
                    btnPresente.Enabled = true; lblPresente.Visible = true;
                    break;
                case 7:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    btnRoma.Enabled = true; lblRoma.Visible = true;
                    btnFeud.Enabled = true; lblFeud.Visible = true;
                    btnPresente.Enabled = true; lblPresente.Visible = true;
                    btnFuturo1.Enabled = true; lblFut1.Visible = true;
                    btnFuturo2.Enabled = true; lblFut2.Visible = true;
                    break;
                case 8:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    btnRoma.Enabled = true; lblRoma.Visible = true;
                    btnFeud.Enabled = true; lblFeud.Visible = true;
                    btnPresente.Enabled = true; lblPresente.Visible = true;
                    btnFuturo1.Enabled = true; lblFut1.Visible = true;
                    break;
                case 9:
                    btnMeso.Enabled = true; lblMeso.Visible = true;
                    btnRoma.Enabled = true; lblRoma.Visible = true;
                    btnFeud.Enabled = true; lblFeud.Visible = true;
                    btnPresente.Enabled = true; lblPresente.Visible = true;
                    btnFuturo2.Enabled = true; lblFut2.Visible = true;
                    break;

            }
            string[] x = uso.DesfragmentarLinhaConq(5, ';', nick);
            if (x[0] == "1")
            {
                btnHardware.Visible = true;
                lblHard.Visible = true;
            }
        }

        private void btnPH_Click(object sender, EventArgs e)
        {
            Comecar("1");
            CSNewGame x = new CSNewGame(nick);
            x.Show();
            this.Close();
        }

        private void btnMeso_Click(object sender, EventArgs e)
        {
            Comecar("2");
            CSFinalPH x = new CSFinalPH(nick);
            x.Show();
            this.Close();
        }

        private void btnRoma_Click(object sender, EventArgs e)
        {
            Comecar("3");
            _3.Roma.CSNewRoma x = new _3.Roma.CSNewRoma(nick);
            x.Show();
            this.Close();
        }

        private void btnFeud_Click(object sender, EventArgs e)
        {
            Comecar("4");
            _4.Feudos.CSNewFeudo x = new _4.Feudos.CSNewFeudo(nick);
            x.Show();
            this.Close();
        }

        private void btnPresente_Click(object sender, EventArgs e)
        {
            Comecar("6");
            _6.Presente.CSNewPresente x = new _6.Presente.CSNewPresente(nick);
            x.Show();
            this.Close();
        }

        private void Comecar(string x)
        {
           
            string[] Caps = uso.DesfragmentarLinha(3, ';', nick);
            uso.RescreverLinha(3, nick, x + ";" + Caps[1]);
            uso.RescreverLinha(4, nick, "10;0;0;0;0");
            uso.RescreverLinha(5, nick, "0");
            uso.RescreverLinha(6, nick, "0;0;0;0;0;0");
            uso.RescreverLinha(7, nick, "0");
            player.Stop();
        }

        public bool voltou()
        {
            return x;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            x = true;
            this.Close();
        }

        private void btnFuturo1_Click(object sender, EventArgs e)
        {
            Comecar("8");
            _7._1.FuturoBom.CSFuturoBom x = new _7._1.FuturoBom.CSFuturoBom(nick);
            x.Show();
            this.Close();
        }

        private void btnFuturo2_Click(object sender, EventArgs e)
        {
            Comecar("9");
            _7._2.FuturoRuim.CSFuturoRuim x = new _7._2.FuturoRuim.CSFuturoRuim(nick);
            x.Show();
            this.Close();
        }

        private void btnHardware_Click(object sender, EventArgs e)
        {
            Hardware hard = new Hardware();
            hard.ShowDialog();
        }
    }
}
