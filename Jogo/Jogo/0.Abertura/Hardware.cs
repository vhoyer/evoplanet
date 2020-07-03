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

namespace Jogo
{
    public partial class Hardware : Form
    {
        ArrayList Pnls = new ArrayList();
        Point pntOrigemCaneta = new Point();
        int X = 10;

        public Hardware()
        {
            InitializeComponent();
            Pnls.Add(pnlWebMesa);
            Pnls.Add(pnlWebTeclado);
            Pnls.Add(pnlWeb);
            Pnls.Add(pnlTeclado);
            Pnls.Add(pnlMesa);
            Pnls.Add(pnlAgradecimentos);
            Pnls.Add(pnlAnima);
        }

        private void Hardware_Load(object sender, EventArgs e)
        {
            foreach (Panel pnl in Pnls)
            {
                pnl.Location = new Point(15, 45);
                pnl.Visible = false;
            }
            pnlMenu.Location = new Point(this.Size.Width, 0);

            pctACaneta.BackColor = Color.Transparent;
            pctACaneta.Parent = pctAMesa;
            pntOrigemCaneta = pctACaneta.Location;
        }

        #region "SideMenu"
        private void openMenu()
        {
            int mov = 2;
            while (pnlMenu.Location.X - mov > this.Size.Width - pnlMenu.Size.Width)
            {
                pnlMenu.Location = new Point(pnlMenu.Location.X - mov, pnlMenu.Location.Y);
                mov += mov / 2;
                System.Threading.Thread.Sleep(50);
            }
            pnlMenu.Location = new Point(634, pnlMenu.Location.Y);
        }

        private void closeMenu()
        {
            int mov = 2;
            while (pnlMenu.Location.X + mov < this.Size.Width)
            {
                pnlMenu.Location = new Point(pnlMenu.Location.X + mov, pnlMenu.Location.Y);
                mov += mov / 2;
                System.Threading.Thread.Sleep(50);
            }
            pnlMenu.Location = new Point(this.Size.Width, pnlMenu.Location.Y);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void Hardware_MouseEnter(object sender, EventArgs e)
        {
            closeMenu();
        }

        #region "SideMenu_Btn's HighLight"
        private void btnMesa_MouseEnter(object sender, EventArgs e)
        {
            btnMesa.ForeColor = Color.Black;
        }

        private void btnMesa_MouseLeave(object sender, EventArgs e)
        {
            btnMesa.ForeColor = Color.WhiteSmoke;
        }

        private void btnWebMesa_MouseEnter(object sender, EventArgs e)
        {
            btnWebMesa.ForeColor = Color.Black;
        }

        private void btnWebMesa_MouseLeave(object sender, EventArgs e)
        {
            btnWebMesa.ForeColor = Color.WhiteSmoke;
        }

        private void btnTeclado_MouseEnter(object sender, EventArgs e)
        {
            btnTeclado.ForeColor = Color.Black;
        }

        private void btnTeclado_MouseLeave(object sender, EventArgs e)
        {
            btnTeclado.ForeColor = Color.WhiteSmoke;
        }

        private void btnWebTeclado_MouseEnter(object sender, EventArgs e)
        {
            btnWebTeclado.ForeColor = Color.Black;
        }

        private void btnWebTeclado_MouseLeave(object sender, EventArgs e)
        {
            btnWebTeclado.ForeColor = Color.WhiteSmoke;
        }

        private void btnAnima_MouseEnter(object sender, EventArgs e)
        {
            btnAnima.ForeColor = Color.Black;
        }

        private void btnAnima_MouseLeave(object sender, EventArgs e)
        {
            btnAnima.ForeColor = Color.WhiteSmoke;
        }

        private void btnEtep_MouseEnter(object sender, EventArgs e)
        {
            btnAgrad.ForeColor = Color.Black;
        }

        private void btnEtep_MouseLeave(object sender, EventArgs e)
        {
            btnAgrad.ForeColor = Color.WhiteSmoke;
        }

        private void btnGoogle_MouseEnter(object sender, EventArgs e)
        {
            btnGoogle.ForeColor = Color.Black;
        }

        private void btnGoogle_MouseLeave(object sender, EventArgs e)
        {
            btnGoogle.ForeColor = Color.WhiteSmoke;
        }
        #endregion

        #region "BtnsSideMenu"
        private void btnWebMesa_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlWebMesa);
        }

        private void btnWebTeclado_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlWebTeclado);
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlWeb);
        }

        private void btnEtep_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlAgradecimentos);
        }

        private void btnAnima_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlAnima);
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlTeclado);
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            pnlVisible(pnlMesa);
        }
        #endregion
        #endregion

        private void pnlVisible(Panel pnl)
        {
            string nome = "";
            foreach (Panel pnl1 in Pnls)
            {
                if (pnl1.Visible)
                {
                    nome = pnl1.Name;
                }
                pnl1.Visible = false;
            }

            if (nome != pnl.Name)
            {
                pnl.Visible = true; 
            }
        }

        private void pnls_MouseEnter(object sender, EventArgs e)
        {
            closeMenu();
        }

        private void tmrAnima_Tick(object sender, EventArgs e)
        {
            if (pctACaneta.Location.X < pntOrigemCaneta.X + X * 4)
            {
                X = 10;
            }
            else
            {
                X = -10;
            }

            pctACaneta.Location = new Point(pctACaneta.Location.X + X, pctACaneta.Location.Y);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
