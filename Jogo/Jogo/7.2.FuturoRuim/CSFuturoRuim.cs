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

namespace Jogo._7._2.FuturoRuim
{
    public partial class CSFuturoRuim : Form
    {
        public CSFuturoRuim(string nick)
        {
            InitializeComponent();
            this.nick = nick;
        }
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Twilight Princess - Midna's Theme"));
        string nick;

        private void btnComecar_Click(object sender, EventArgs e)
        {
            lblText1.Visible = false; pctrText1.Visible = false;
            btnComecar.Visible = false;
            lblCap.Visible = true; lblNameCap.Visible = true;
            timerGo.Start();
        }

        private void timerGo_Tick(object sender, EventArgs e)
        {
            FuturoR comecar = new FuturoR(nick);
            player.Stop();
            comecar.Show();
            this.Close();
        }

        private void CSFuturoRuim_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
    }
}
