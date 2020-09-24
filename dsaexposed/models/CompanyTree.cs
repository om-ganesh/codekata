using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaexposed.models
{
    //Create a organization chart for your company and print the names from top down approach (names of managers comes before staff)
    public class CompanyTree
    {
        public TreeNode root { get; set; }

        public CompanyTree(TreeNode node)
        {
            root = node;
        }

        public void ShowAll(TreeNode root)
        {
            TreeNode first = root;
            Queue<TreeNode> names = new Queue<TreeNode>();
            names.Enqueue(first);

            while (names.Count > 0)// foreach (TreeNode child in first.Children)
            {
                TreeNode current = names.Dequeue();
                Console.WriteLine(current.Name);

                current?.Children?.ForEach(c => names.Enqueue(c));
            }
        }

    }

    public class TreeNode
    {

        public string Name { get; set; }
        public string Title { get; set; }
        public TreeNode Parent { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(string name, string title, TreeNode parent)
        {
            Name = name;
            Title = title;
            Parent = parent;
            Children = null;
        }

        public TreeNode(string name, string title, TreeNode parent, List<TreeNode> children)
        {
            Name = name;
            Title = title;
            Parent = parent;
            Children = children;
        }


    }
}
