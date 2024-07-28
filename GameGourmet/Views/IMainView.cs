using GameGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGourmet.Views
{
    public interface IMainView
    {
        bool AskQuestion(TreeNode<string> node);
        bool ConfirmFood(TreeNode<string> node);
        string GetNewFood();
        string GetFoodCharacteristic(string newFood, string oldFood);
        void ShowVictory(string Food);
    }
}
