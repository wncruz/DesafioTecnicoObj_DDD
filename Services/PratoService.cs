using ProjetoDesafioObj.Domins;
using ProjetoDesafioObj.Domins.Interface;
using ProjetoDesafioObj.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafioObj.Services
{
    public class PratoService : IPratoService
    {
        private readonly ConsoleIO _consoleIO;

        public PratoService(ConsoleIO consoleIO)
        {
            _consoleIO = consoleIO;
        }

        public void PerguntarQualPrato(bool _primeiraVez)
        {
            PerguntarSeMassa(_primeiraVez);
        }

        public void PerguntarSeMassa(bool _primeiraVez)
        {
            var response = _consoleIO.PerguntarSimNao("O prato que pensou é massa?", "Confirm");

            if (response == DialogResult.Yes)
            {
                PerguntarSeLasanha(_primeiraVez);
            }
            else
            {
                PerguntarSeBoloChocolate(_primeiraVez);
            }
        }

        public void PerguntarSeLasanha(bool _primeiraVez)
        {
            var response = _consoleIO.PerguntarSimNao("O prato que pensou é lasanha?", "Confirm");

            if (response == DialogResult.Yes)
            {
                MessageBox.Show("Acertei" + (_primeiraVez ? "!" : " de novo"), "Jogo Gourmet", MessageBoxButtons.OK);
            }
            else
            {
                PerguntaEntaoQualPrato("lasanha");
            }
        }

        public void PerguntarSeBoloChocolate(bool _primeiraVez)
        {
            var response = _consoleIO.PerguntarSimNao("O prato que pensou é Bolo de Chocolate?", "Confirm");

            if (response == DialogResult.Yes)
            {
                MessageBox.Show("Acertei" + (_primeiraVez ? "!" : " de novo"), "Jogo Gourmet", MessageBoxButtons.OK);
            }
            else
            {
                PerguntaEntaoQualPrato("Bolo de Chocolate");
            }
        }

        public void PerguntaEntaoQualPrato(string prato)
        {
            var nomePrato = _consoleIO.GetInput("Qual prato você pensou?", "Desisto");
            if (nomePrato != null)
            {
                var melhorQue = _consoleIO.GetInput(nomePrato + " é ________, mas " + prato + " não.", "Complete");
            }
        }

    }
}
