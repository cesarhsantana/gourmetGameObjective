using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGourmet
{
    public class InputBox : Form
    {
        private TextBox textBox;
        private Button buttonOk;
        private Button buttonCancel;

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // InputBox
            // 
            ClientSize = new Size(468, 115);
            Name = "InputBox";
            ResumeLayout(false);
        }

        public string Value => textBox.Text;

        public InputBox(string prompt, string title)
        {

            Size = new Size(484, 154);

            Text = title;
            Label label = new Label() { Text = prompt, Left = 10, Top = 10, Width = 480 };
            textBox = new TextBox() { Left = 10, Top = 40, Width = 450 };
            buttonOk = new Button() { Text = "OK", Left = 150, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            buttonCancel = new Button() { Text = "Cancelar", Left = 270, Width = 100, Top = 70, DialogResult = DialogResult.Cancel };

            buttonOk.Click += (sender, e) => { Close(); };
            buttonCancel.Click += (sender, e) => { Close(); };

            Controls.Add(label);
            Controls.Add(textBox);
            Controls.Add(buttonOk);
            Controls.Add(buttonCancel);

            AcceptButton = buttonOk;
            CancelButton = buttonCancel;

            StartPosition = FormStartPosition.CenterParent;
        }
    }
}
