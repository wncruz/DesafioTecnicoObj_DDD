using ProjetoDesafioObj.Infrastructures;
using ProjetoDesafioObj.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafioObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _consoleIO = new ConsoleIO();
            var dishService = new PratoService(_consoleIO);
            bool primeiraVez = true;

            while (true)
            {
                if (_consoleIO.AguardaOk() == DialogResult.OK)
                {
                    dishService.PerguntarQualPrato(primeiraVez);
                    primeiraVez = false;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
