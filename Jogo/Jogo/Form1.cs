using System;
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
    public partial class Login : Form
    {
        public Login(bool primeiro)
        {
            InitializeComponent();
            this.primeiro = primeiro;
        }

        private bool primeiro;

        #region "Events Click"
        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarConta criar = new CriarConta();
            criar.ShowDialog();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usos uso = new Usos();

            if ((txtNome.Text == "") || (txtSenha.Text == ""))
            {

                MessageBox.Show("Campo(s) não preenchidos.", "Error 401", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                if (uso.NomeExiste(txtNome.Text))
                {

                    System.IO.StreamReader ler = new System.IO.StreamReader(uso.ArquivoDoCadastro(txtNome.Text));

                    ler.ReadLine(); string CheckSenha = ler.ReadLine();

                    if ((uso.NomeExiste(txtNome.Text)) && CheckSenha == txtSenha.Text)
                    {

                        Abertura comecar = new Abertura(txtNome.Text, uso.LerLinha(4,txtNome.Text));
                        comecar.Show();
                        if (primeiro) this.Hide(); else this.Close();

                    }
                    else
                    {

                        MessageBox.Show("Senha errada, tente novamente.", "Error 405", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {

                    MessageBox.Show("Nome não existe.", "Error 403", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
