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
    public partial class Abertura : Form
    {
        public Abertura(string nick, string status)
        {
            InitializeComponent();

            this.nick = nick;
            this.cap = status;
        }

        private string nick, cap;
        Usos uso = new Usos();
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Smash Bros Melee - Menu 1"));

        private void Abertura_Load(object sender, EventArgs e)
        {
            lblExibirNick.Text = "Usuario: " + nick;
            if (cap== "0;0;0;0;0") {

                btnContinuar.Enabled = false;

            }
            player.PlayLooping();

        }

        #region "Events Click"

        private void btnSair_Click(object sender, EventArgs e)
        {
            player.Stop();
            Login voltar = new Login(false);
            voltar.Show();
            this.Close();
        }

        private void btnCred_Click(object sender, EventArgs e)
        {
            Creditos Exibir = new Creditos();
            Exibir.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string[] Cap = uso.DesfragmentarLinha(3, ';', nick);
            player.Stop();
            switch (Convert.ToInt16(Cap[0]))
            {

                case 1: PreHistoria comecar = new PreHistoria(nick);
                    comecar.Show();
                    break;
                case 2:  frmMeso comecar2 = new frmMeso(nick);
                    comecar2.Show();
                    break;
                case 3: Teste.frmRomaInicio comecar3 = new Teste.frmRomaInicio(nick);
                    comecar3.Show();
                    break;
                case 4: Feudo.frmFeudalismo comecar4 = new Feudo.frmFeudalismo(nick);
                    comecar4.Show();
                    break;
                case 8: _7._1.FuturoBom.FuturoB comecar8 = new _7._1.FuturoBom.FuturoB(nick);
                    comecar8.Show();
                    break;
                case 9:
                    _7._2.FuturoRuim.FuturoR comecar9 = new _7._2.FuturoRuim.FuturoR(nick);
                    comecar9.Show();
                    break;
            }

            this.Close();
        }

        private void btnCapitulos_Click(object sender, EventArgs e)
        {
            Capitulos abrir = new Capitulos(nick);
            abrir.ShowDialog();
            if (abrir.voltou() == false) this.Close();
        }

        private void btnInstr_Click(object sender, EventArgs e)
        {
            _0.Abertura.Instru x = new _0.Abertura.Instru();
            x.ShowDialog();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            CSNewGame Comecar = new CSNewGame(nick);
            player.Stop();
            string[] Caps = uso.DesfragmentarLinha(3,';',nick);
            uso.RescreverLinha(3, nick, "1;" + Caps[1]);
            uso.RescreverLinha(4, nick, "10;0;0;0;0");
            uso.RescreverLinha(5, nick, "0");
            uso.RescreverLinha(6, nick, "0;0;0;0;0;0");
            uso.RescreverLinha(7, nick, "0");
            Comecar.Show();
            this.Close();

        }

        #endregion

    }
}
