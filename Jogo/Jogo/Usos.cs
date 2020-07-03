using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    class Usos
    {
        public Usos() { }
        public string EnderecoCadastro()
        {

            string DebugE = (System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            string[] tirar = { @"Jogo\bin\Debug" };
            string[] ender = DebugE.Split(tirar, StringSplitOptions.RemoveEmptyEntries);
            return ender[0] + @"\Cadastros\";

        }

        public static string EnderecoMusica(string NomeDaMusica)
        {

            string DebugE = (System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            string[] tirar = { @"Jogo\bin\Debug" };
            string[] ender = DebugE.Split(tirar, StringSplitOptions.RemoveEmptyEntries);
            return ender[0] + @"\Trilha Sonora\" + NomeDaMusica + ".wav";

        }

        public string ArquivoDoCadastro(string nick)
        {

            return EnderecoCadastro() + nick + ".txt";

        }

        public bool NomeExiste(string nick)
        {
            try
            {

                System.IO.StreamReader Checar = new System.IO.StreamReader(ArquivoDoCadastro(nick));
                Checar.Close();

                return true;
            }
            catch
            {

                return false;

            }

        }

        public string ArraytoString(string[] _array)

        {

            string retorno = "";
            
            for (int i = 0; i < (_array.Length) - 1; i++)

            {

                retorno += _array[i] + ";";

            }

            retorno += _array[_array.Length - 1];

            return retorno;

        }




        public string ArraytoString(int[] _array)

        {

            string[] array = new string[_array.Length];
            
            for (int i = 0; i < _array.Length; i++)

            {

                array[i] = _array[i].ToString();

            }

            string retorno = "";

            for (int i = 0; i < _array.Length; i++)

            {

                retorno += array[i] + ";";

            }

            return retorno;

        }

        public string[] DesfragmentarLinha(int Linha, char Tirar, string nick)
        {
            System.IO.StreamReader ler = new System.IO.StreamReader(ArquivoDoCadastro(nick));
            for (int con=0; con<Linha-1; con++) {
                ler.ReadLine();
            }
            string line = ler.ReadLine();
            ler.Close();
            return line.Split(Tirar);
            
        }

        public string[] DesfragmentarLinhaConq(int Linha, char Tirar, string nick)
        {
            System.IO.StreamReader ler = new System.IO.StreamReader(EnderecoCadastro() + nick + "_Conquista.txt");
            for (int con = 0; con < Linha - 1; con++)
            {
                ler.ReadLine();
            }
            string line = ler.ReadLine();
            ler.Close();
            return line.Split(Tirar);

        }

        public void RescreverLinha(int Linha, string nick, string New) {

            System.IO.StreamReader ler = new System.IO.StreamReader(ArquivoDoCadastro(nick));
            string[] guardar = new string[7];
            for(int con=0; con< 7; con++) {

                guardar[con] = ler.ReadLine();

            }

            ler.Close();
            guardar[Linha - 1] = New;
            System.IO.File.WriteAllLines(ArquivoDoCadastro(nick), guardar);
        }

        public void RescreverLinhaConq(int Linha, string nick, string New)
        {

            System.IO.StreamReader ler = new System.IO.StreamReader(EnderecoCadastro() + nick + "_Conquista.txt");
            string[] guardar = new string[7];
            for (int con = 0; con < 7; con++)
            {

                guardar[con] = ler.ReadLine();

            }

            ler.Close();
            guardar[Linha - 1] = New;
            System.IO.File.WriteAllLines(EnderecoCadastro() + nick + "_Conquista.txt", guardar);
        }

        public string LerLinha(int Linha, string nick)
        {

            System.IO.StreamReader ler = new System.IO.StreamReader(ArquivoDoCadastro(nick));
            for (int con = 0; con < Linha - 1; con++)
            {
                ler.ReadLine();
            }
            
            string line = ler.ReadLine();
            ler.Close();
            return line;
        }
        }
}
