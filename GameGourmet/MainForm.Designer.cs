namespace GameGourmet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            instrunctionLabel = new Label();
            startGameButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(instrunctionLabel);
            panel1.Controls.Add(startGameButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 115);
            panel1.TabIndex = 2;
            // 
            // instrunctionLabel
            // 
            instrunctionLabel.Anchor = AnchorStyles.Top;
            instrunctionLabel.AutoSize = true;
            instrunctionLabel.Location = new Point(152, 21);
            instrunctionLabel.Name = "instrunctionLabel";
            instrunctionLabel.Size = new Size(172, 15);
            instrunctionLabel.TabIndex = 0;
            instrunctionLabel.Text = "Pense em um prato de comida.";
            // 
            // startGameButton
            // 
            startGameButton.Anchor = AnchorStyles.Top;
            startGameButton.Location = new Point(181, 52);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(107, 46);
            startGameButton.TabIndex = 3;
            startGameButton.Text = "Começar";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 115);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label instrunctionLabel;
        private Button startGameButton;
    }
}