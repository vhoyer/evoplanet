using System;
using System.Collections;
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
    public partial class Sperm : Form
    {
        SoundPlayer player = new SoundPlayer(Usos.EnderecoMusica("Kirby Super Star - Gourmet Race"));
        string[] placar = new string[]
        {
            "=D", "Criador da cura do AIDS","Melhor que o Tarantino",
            "Proximo Miquelangelo","Ganhador do Nobel","Outro Eistein",
            "Outro Hitler","Raquel","Outro Avilmar","Gandalf",
            "Pessoa que ama java","Um Bombeiro","Outro Bombeiro",
            "Aluno de Web","Ganhador do Oscar","Um médico"
        };
        Placar plc;
        Usos uso = new Usos();

        //227; 292 >> 227; 125 (167)

        public Sperm(int Cap,string nick)
        {
            player.Play();
            InitializeComponent();
            this.Cap = Cap;
            this.nick = nick;
            placar[0] = this.nick;
            plc = new Placar(placar);

            lstPosition.DataSource = placar;
        }
        string nick;
        int Cap;

        #region "nado do personagem"
        private void Nadar()
        {
            Random rnd = new Random();
            int step = rnd.Next(9) + 1;
            int pos = pbSpermMain.Location.Y;

            if (pos - step > 125)
            {
                pbSpermMain.Location = new Point(227, pos - step);
                pgsBar.Value += step;
                plc.table.Rows[0][1] = pgsBar.Value;
            }
            else
            {
                tmr.Stop();
                btnNadar1.Visible = false;
                btnNadar2.Visible = false; 
                pbSpermMain.Location = new Point(227, 125);
                pgsBar.Value = pgsBar.Maximum;
                MessageBox.Show("Parabêns, você acaba de ganhar o direito de renascer! \n\n=D", "Ganhou!");

                uso.RescreverLinha(4, nick, "10;0;0;0;0");
                player.Stop();
                switch (Cap) {

                    case 1: PreHistoria PH = new PreHistoria(nick);
                        PH.Show();
                        break;
                    case 2: frmMeso meso = new frmMeso(nick);
                        meso.Show();
                        break;
                    case 3: Teste.frmRomaInicio Roma = new Teste.frmRomaInicio(nick);
                        Roma.Show(); 
                        break;
                    case 4: Feudo.frmFeudalismo feudo = new Feudo.frmFeudalismo(nick);
                        feudo.Show();
                        break;
                    case 9: _7._2.FuturoRuim.FuturoR r = new _7._2.FuturoRuim.FuturoR(nick);
                        r.Show();
                        break;
                    case 8: _7._1.FuturoBom.FuturoB b = new _7._1.FuturoBom.FuturoB(nick);
                        b.Show();
                        break;
                }
                this.Close();
            }
        }

        private void btnNadar1_Click(object sender, EventArgs e)
        {
            if (!tmr.Enabled)
            {
                tmr.Start();
            }
            pbSpermMain.Image = Jogo.Properties.Resources.sperm1;
            btnNadar1.Visible = false;
            btnNadar2.Visible = true;
            Nadar();
        }

        private void btnNadar2_Click(object sender, EventArgs e)
        {
            pbSpermMain.Image = Jogo.Properties.Resources.sperm2;
            btnNadar2.Visible = false;
            btnNadar1.Visible = true;
            Nadar();
        }
        #endregion

        private void tmr_Tick(object sender, EventArgs e)
        {
            int pos = pbSpermMain.Location.Y;

            if (pos <= 125)
            {
                tmr.Stop();
            }
            if (pos + 2 < 292)
            {
                pgsBar.Value -= 2;
                plc.table.Rows[0][1] = pgsBar.Value;
                pbSpermMain.Location = new Point(227, pbSpermMain.Location.Y + 2);
            }
            Random rnd = new Random();
            for (int i = 1; i < plc.table.Rows.Count; i++)
            {
                int step = rnd.Next(9) + 1;
                plc.table.Rows[i][1] = Convert.ToInt32(plc.table.Rows[i][1]) + step;
                if (Convert.ToInt32(plc.table.Rows[i][1]) >= pgsBar.Maximum)
                {
                    tmr.Stop();
                    btnNadar1.Visible = false;
                    btnNadar2.Visible = false;
                    lstPosition.DataSource = plc.Update();
                    MessageBox.Show("Aparentemente, você acaba de perder para " + plc.Update()[0].Substring(3) + "\n\nD=", "Perdeu!");
                    uso.RescreverLinha(4, nick, "0;0;0;0;0");
                    uso.RescreverLinha(5, nick, "0");
                    uso.RescreverLinha(6, nick, "0;0;0;0;0;0");
                    uso.RescreverLinha(7, nick, "0");
                    player.Stop();
                    Abertura Retorno = new Abertura(nick, uso.LerLinha(4, nick));
                    Retorno.Show();
                    this.Close();
                }
            }

            lstPosition.DataSource = plc.Update();
        }
    }
}
