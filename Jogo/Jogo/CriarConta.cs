using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.Windows.Forms;

namespace Jogo
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        Usos uso = new Usos();

        #region "Events Click"

        private void btnCriar_Click(object sender, EventArgs e)
        {

            if ((txtNome.Text == "") || (txtSenha.Text == "") || (txtConfirmar.Text == "")) {

                MessageBox.Show("Campo(s) não preenchidos.", "Error 401", MessageBoxButtons.OK,MessageBoxIcon.Error);

            } else
            {


                string endereco = uso.ArquivoDoCadastro(txtNome.Text);
                string endereco2 = uso.ArquivoDoCadastro(txtNome.Text + "_Conquista");
                if (uso.NomeExiste(txtNome.Text) == false)

                {

                    if (txtSenha.Text != txtConfirmar.Text)
                    {

                        MessageBox.Show("Campo Senha e campo Confirmar Senha não são compativeis.", "Error 402", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {

                        string[] cadastro = { txtNome.Text, txtSenha.Text, "1;1", "0;0;0;0;0", "0", "0;0;0;0;0;0", "0" };
                        System.IO.File.AppendAllLines(endereco, cadastro);
                        string[] conquista = { "0;0;0;0;0;0", "0;0;0;0;0;0", "0;0;0;0;0;0", "0;0;0;0;0;0", "0;0;0;0;0;0", "0;0;0;0;0;0" };
                        System.IO.File.AppendAllLines(endereco2, conquista);
                        MessageBox.Show("Obrigado por cadastrar-se.", "=D", MessageBoxButtons.OK);
                        this.Close();


                    }

                }
                else
                {

                    MessageBox.Show("Nome de cadastro ja existente, tente novamete.", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
