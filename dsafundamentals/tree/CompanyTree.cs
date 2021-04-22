using System;
using System.Collections.Generic;

namespace tree
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
}
