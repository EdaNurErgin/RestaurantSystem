using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranSistemi
{
    internal class Prompt
    {   public static string ShowDialog(string text, string defaultValue)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 200,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = "Düzenle",
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350, Text = defaultValue };
                Button confirmation = new Button() { Text = "Tamam", Left = 270, Width = 100, Top = 90, DialogResult = DialogResult.OK };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : defaultValue;
            }
    }
}
