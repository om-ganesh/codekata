using System;
using System.Collections.Generic;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("@HelloGybe Interview!!!");
            ShowTreeChildrenBreadthWise();

            Console.WriteLine("@IBM Interview!!!");
            TreeTraversal traversal = new TreeTraversal();
            traversal.Init();
            traversal.Init(true); //Create a binary search tree

            Console.Read();
        }

        public static void ShowTreeChildrenBreadthWise()
        {
            TreeNode rootNode = new TreeNode("Company", null, null);
            List<TreeNode> rootChild = new List<TreeNode>
            {
                new TreeNode("Haris", "CEO", rootNode),
                new TreeNode("James", "CTO", rootNode),
                new TreeNode("Sahas", "CFO", rootNode)
            };
            rootNode.Children = rootChild;

            CompanyTree companyTree = new CompanyTree(rootNode);

            List<TreeNode> ceoChild = new List<TreeNode>
            {
                new TreeNode("Subash", "Manager", rootNode.Children[0], null),
                new TreeNode("Gita", "Marketing", rootNode.Children[0], null),
            };
            rootNode.Children[0].Children = ceoChild;

            companyTree.ShowAll(rootNode);
        }
    }
}
