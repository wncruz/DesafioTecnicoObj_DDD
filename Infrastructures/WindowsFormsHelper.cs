using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDesafioObj.Infrastructures
{
    public static class WindowsFormsHelper
    {
        public static string ShowInputDialog(string prompt, string title)
        {
            Form inputForm = new Form()
            {
                Width = 400,
                Height = 200,
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = prompt, Width = 350 };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 350 };
            Button okButton = new Button() { Text = "OK", Left = 100, Width = 100, Top = 80 };
            Button cancelButton = new Button() { Text = "Cancelar", Left = 210, Width = 100, Top = 80 };

            string result = null;

            okButton.Click += (sender, e) =>
            {
                result = inputBox.Text;
                inputForm.Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                result = null;
                inputForm.Close();
            };

            inputForm.Controls.Add(textLabel);
            inputForm.Controls.Add(inputBox);
            inputForm.Controls.Add(okButton);
            inputForm.Controls.Add(cancelButton);
            inputForm.AcceptButton = okButton;
            inputForm.CancelButton = cancelButton;

            inputForm.ShowDialog();
            return result;
        }
    }
}
