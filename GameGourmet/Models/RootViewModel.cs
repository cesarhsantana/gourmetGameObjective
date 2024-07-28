using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGourmet.Models
{
    public class RootViewModel
    {
        private readonly TreeNode<string> root;
        private readonly Func<TreeNode<string>, bool> onNextString;
        private readonly Func<TreeNode<string>, bool> onGuess;
        private readonly Func<string, TreeNode<string>> onDefeat;
        private readonly Action<string> onVictory;

        public RootViewModel(Func<TreeNode<string>, bool> onNextNode, Func<TreeNode<string>, bool> onGuess, Func<string, TreeNode<string>> onDefeat, Action<string> onVictory)
        {
            this.onNextString = onNextNode;
            this.onGuess = onGuess;
            this.onDefeat = onDefeat;
            this.onVictory = onVictory;

            this.root = new TreeNode<string>(null, "O prato que você pensou é massa?");
            var yes = new TreeNode<string>(root, "Lasanha");
            var no = new TreeNode<string>(root, "Bolo de Chocolate");

            root.YesNode = yes;
            root.NoNode = no;
        }

        public void StartSearch()
        {
            Search(root);
        }

        private void Search(TreeNode<string> node)
        {
            if (node.IsLeaf())
            {
                MakeGuess(node);
            }
            else
            {
                bool clickedYes = onNextString(node);
                TreeNode<string> nextNode = node.GetNext(clickedYes);
                if (nextNode == null)
                    MakeGuess(node);
                else
                    Search(nextNode);
            }
        }

        private void MakeGuess(TreeNode<string> currentFoodNode)
        {
            bool result = onGuess(currentFoodNode);
            if (result)
            {
                onVictory(currentFoodNode.Value);
            }
            else
            {
                TreeNode<string> newFood = onDefeat(currentFoodNode.Value);
                if (newFood != null)
                {
                    newFood.NoNode = currentFoodNode;
                    newFood.Parent = currentFoodNode.Parent;

                    if (newFood.Parent.YesNode == currentFoodNode)
                        newFood.Parent.YesNode = newFood;
                    else
                        newFood.Parent.NoNode = newFood;

                    currentFoodNode.Parent = newFood;
                }
            }
        }
    }
}
