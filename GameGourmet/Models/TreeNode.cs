using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGourmet.Models
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Parent { get; set; }
        public TreeNode<T> YesNode { get; set; }
        public TreeNode<T> NoNode { get; set; }

        public TreeNode(TreeNode<T> parent, T value)
        {
            Parent = parent;
            Value = value;
        }

        public bool IsLeaf()
        {
            return YesNode == null && NoNode == null;
        }
        public TreeNode<T> GetNext(bool yes)
        {
            if (yes)
            {
                return YesNode;
            }
            else
            {
                return NoNode;
            }
        }

    }
}
