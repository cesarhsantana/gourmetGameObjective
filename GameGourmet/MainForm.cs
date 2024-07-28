using GameGourmet.Models;
using GameGourmet.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameGourmet
{
    public partial class MainForm : Form, IMainView
    {
        private readonly MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            presenter.StartSearch();
        }

        public bool AskQuestion(TreeNode<string> node)
        {
            var result = MessageBox.Show(node.Value, "Pergunta", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }

        public bool ConfirmFood(TreeNode<string> node)
        {
            var result = MessageBox.Show($"O prato que você pensou é {node.Value}", "Confirmação", MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }

        public string GetNewFood()
        {
            var inputBox = new InputBox("Qual prato você pensou?", "Desisto");

            DialogResult result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                return inputBox.Value;
            }
            else
            {
                return null;
            }
           
        }

        public string GetFoodCharacteristic(string newFood, string oldFood)
        {
            var inputBox = new InputBox($"{newFood} é _____, mas {oldFood} não é.", "Característica");
            DialogResult result = inputBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                return inputBox.Value;
            }
            else
            {
                return null;
            }
   
        }

        public void ShowVictory(string Food)
        {
            MessageBox.Show($"Eu acertei! Você estava pensado em {Food}.", "Vitória", MessageBoxButtons.OK);
        }

       
    }
}
