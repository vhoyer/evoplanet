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
    public partial class CSFinalPH : Form
    {
        public CSFinalPH(string nick)
        {
            player.PlayLooping();
            InitializeComponent();
            this.nick = nick;

        }

        private string nick;
        int Cena = 0;
        Usos uso = new Usos();
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Twilight Princess - Midna's Theme"));

        private void btnPrx_Click(object sender, EventArgs e)
        {
            if (Cena < 7) { Cena++; }

            Exibir();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Cena--;
            Exibir();

        }
        
        private void Exibir()
        {

            switch (Cena)
            {

                case 0:
                    lblText1.Visible = true; lblText2.Visible = false;
                    pctrText1.Visible = true; pctrText2.Visible = false;
                    btnVoltar.Visible = false;
                    break;
                case 1: 
                    lblText1.Visible = false; lblText2.Visible = true; lblText3.Visible = false;
                    pctrText1.Visible = false; pctrText2.Visible = true; pctrText3.Visible = false;
                    btnVoltar.Visible = true;
                    break;
                case 2: 
                    lblText2.Visible = false; lblText3.Visible = true; lblText4.Visible = false;
                    pctrText2.Visible = false; pctrText3.Visible = true; pctrText4.Visible = false;
                    break;
                case 3: 
                    lblText3.Visible = false; lblText4.Visible = true; lblText5.Visible = false;
                    pctrText3.Visible = false; pctrText4.Visible = true; pctrText5.Visible = false;
                    break;
                case 4: 
                    lblText4.Visible = false; lblText5.Visible = true; lblText6.Visible = false;
                    pctrText4.Visible = false; pctrText5.Visible = true; pctrText6.Visible = false;
                    break;
                case 5:
                    lblText5.Visible = false; lblText6.Visible = true; lblText7.Visible = false;
                    pctrText5.Visible = false; pctrText6.Visible = true; pctrText7.Visible = false;
                    btnPrx.Text = "Prosseguir >>";
                    break;
                case 6:
                    lblText6.Visible = false; lblText7.Visible = true;
                    pctrText6.Visible = false; pctrText7.Visible = true;
                    btnPrx.Text = "Começar";
                    break;
                case 7: lblText7.Visible = false; pctrText7.Visible = false;
                    btnPrx.Visible = false; btnVoltar.Visible = false;
                    lblCap.Visible = true; lblNameCap.Visible = true;
                    timerGo.Start();
                    break;
            }

        }

        private void timerGo_Tick(object sender, EventArgs e)
        {
            frmMeso comecar = new frmMeso(nick);
            player.Stop();
            comecar.Show();
            this.Close();
        }
    }
}
