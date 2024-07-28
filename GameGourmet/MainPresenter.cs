using GameGourmet.Models;
using GameGourmet.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGourmet
{
    public class MainPresenter
    {
        private readonly IMainView view;
        private readonly RootViewModel viewModel;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            viewModel = new RootViewModel(view.AskQuestion, view.ConfirmFood, CreateNewFood, view.ShowVictory);
        }

        public void StartSearch()
        {
            viewModel.StartSearch();
        }

        private TreeNode<string> CreateNewFood(string oldFood)
        {
            string newFood = view.GetNewFood();
            if (string.IsNullOrEmpty(newFood)) return null;

            string characteristic = view.GetFoodCharacteristic(newFood, oldFood);
            if (string.IsNullOrEmpty(characteristic)) return null;

            var newNode = new TreeNode<string>(null, $"O seu prato é {characteristic}?");
            var yesNode = new TreeNode<string>(newNode, newFood);
            newNode.YesNode = yesNode;

            return newNode;
        }
    }
}
