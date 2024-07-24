using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafioObj.Infrastructures
{
    public class ConsoleIO
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Mensagem");
        }

        public DialogResult AguardaOk()
        {
            return MessageBox.Show("Pense em um prato que gosta.", "Jogo Gourmet", MessageBoxButtons.OKCancel);
        }

        public DialogResult PerguntarSimNao(string question, string title)
        {
            return MessageBox.Show(question, title, MessageBoxButtons.YesNo);
        }

        public string GetInput(string prompt, string title)
        {
            return WindowsFormsHelper.ShowInputDialog(prompt, title);
        }
    }
}
