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

namespace Jogo._7._1.FuturoBom
{
    public partial class CSFuturoBom : Form
    {
        public CSFuturoBom(string nick)
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
            FuturoB comecar = new FuturoB(nick);
            player.Stop();
            comecar.Show();
            this.Close();
        }

        private void CSFuturoBom_Load(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
    }
}
