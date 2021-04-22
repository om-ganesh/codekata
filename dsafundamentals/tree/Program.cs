using System;
using System.Collections.Generic;

namespace tree
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display all employee names from top-down organizational chart.
            // Also show Level of each employee (assuming root to be "1")
            Console.WriteLine("@HelloGybe Interview!!!");
            TrieNode company = CreateCompanyTree();
            company.ShowAll();

            Console.WriteLine("@IBM Interview!!!");
            int[] arr = { 12, 6, 127, 28, 9, 3, 111, 0 };
            VariousTreeOperations(arr);

            Console.Read();
        }

        public static void VariousTreeOperations(int[] arr)
        {

            Console.WriteLine($"Binary Tree Example");
            Node binaryTree = TreeHelper.CreateBinaryTree(arr);
            binaryTree.Visualize();
            binaryTree.Traverse(TreeTraversal.InTraversal);
            binaryTree.Traverse(TreeTraversal.PreTraversal);
            binaryTree.Traverse(TreeTraversal.PostTraversal);
            binaryTree.Traverse(TreeTraversal.BFSTraversal);
            //binaryTree.Traverse(TreeTraversal.BFSTraversalWithLabel);

            Console.WriteLine($"{Environment.NewLine}Binary Search Tree Example");
            Node binarySearchTree = TreeHelper.CreateBinarySearchTree(arr);
            binarySearchTree.Visualize();
            binarySearchTree.Traverse(TreeTraversal.InTraversal);
            binarySearchTree.Traverse(TreeTraversal.PreTraversal_Iterative);
            binarySearchTree.Traverse(TreeTraversal.PostTraversal);
            binarySearchTree.Traverse(TreeTraversal.BFSTraversal);

            Console.WriteLine($"{Environment.NewLine}Tree Example");
            Node tree = TreeHelper.CreateTree(arr);
            tree.Visualize();
            tree.Traverse(TreeTraversal.InTraversal);
            tree.Traverse(TreeTraversal.PreTraversal);
            tree.Traverse(TreeTraversal.PostTraversal);
            tree.Traverse(TreeTraversal.BFSTraversal);
            //tree.Traverse(TreeTraversal.BFSTraversalWithLabel);

            Console.WriteLine($"{Environment.NewLine}Search if the element {45} exists in Tree? {TreeHelper.Search(tree, 415)}");
        }

        public static TrieNode CreateCompanyTree()
        {
            TrieNode rootNode = new TrieNode("Company");
            rootNode.AddChildren(new List<TrieNode>
                {
                    new TrieNode("Haris", "CEO"),
                    new TrieNode("James", "CTO"),
                    new TrieNode("Sahas", "CFO")
                });

            rootNode.Children[1].AddChildren(new List<TrieNode>
                {
                    new TrieNode("Kul", "Security Manager"),
                    new TrieNode("Umesh", "Architect"),
                });

            rootNode.Children[0].AddChildren(new List<TrieNode>
                {
                    new TrieNode("Subash", "Manager"),
                    new TrieNode("Gita", "Marketing"),
                });

            return rootNode;
        }
    }
}
