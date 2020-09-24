using dsaexposed.models;
using System;
using System.Collections.Generic;

namespace dsaexposed
{
    public class TreeTraversal
    {
        public Node Root { get; set; }
        public void Init(bool isBinary = false)
        {
            int[] arr = { 25, 26, 27, 28, 29, 30, 31 };
            if (isBinary)
            {
                Console.Write($"{Environment.NewLine}Create BST");
                Root = CreateBinaryTree(arr, 0, arr.Length);
            }
            else
            {
                Console.Write($"{Environment.NewLine}Create Tree");
                Root = CreateTree(arr, 0, new Node());
                BreadthFirstSearch();
                BreadthFirstSearch(true);
            }
            DepthFirstSearch("in");
            DepthFirstSearch("pre");
            DepthFirstSearch("pre-i");
            DepthFirstSearch("post");
            
        }

        private Node CreateBinaryTree(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                //Fixit: mid = (H-L)/2 + L (avoids floating issue)
                Node root = new Node(arr[mid]);
                root.Left = CreateBinaryTree(arr, left, mid);
                root.Right = CreateBinaryTree(arr, mid + 1, right);
                return root;
            }
            return null;
        }

        public Node CreateTree(int[] arr, int index, Node current)
        {
            //Handle the empty array
            if (arr.Length < 1)
            {
                return new Node();
            }
            if (index < arr.Length)
            {

                current = new Node(arr[index]);
                current.Left = CreateTree(arr, 2 * index + 1, current.Left);
                current.Right = CreateTree(arr, 2 * index + 2, current.Right);
            }
            return current;
        }

        public void DepthFirstSearch(string type)
        {
            Console.Write($"{Environment.NewLine}{type.ToUpper()} Traversal(DFS) : ");
            switch (type.ToUpper())
            {
                case "PRE":
                    PreTraversal(Root);
                    break;
                case "PRE-I":
                    PreTraversal_Iterative(Root);
                    break;
                case "POST":
                    PostTraversal(Root);
                    break;
                case "IN":
                default:
                    InTraversal(Root);
                    break;
            }
        }

        public void BreadthFirstSearch(bool showLevel=false)
        {
            if(showLevel)
            {
                Console.WriteLine($"{Environment.NewLine}BFS level wise printing : ");
                BFSTraversalWithLevel(Root);
            } else
            {
                Console.Write($"{Environment.NewLine}BFS Traversal : ");
                BFSTraversal(Root);
            }
            
        }

        private void BFSTraversal(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while(q.Count >0)
            {
                Node current = q.Dequeue();
                Visit(current);
                if(current.Left != null)
                {
                    q.Enqueue(current.Left);
                }
                if(current.Right != null)
                {
                    q.Enqueue(current.Right);
                }
            }
        }

        private void BFSTraversalWithLevel(Node root)
        {
            SetLevels(root, 1);
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int currentLevel = 1;
            while (q.Count > 0)
            {
                Node current = q.Dequeue();
                if(current.Level > currentLevel)
                {
                    Console.WriteLine(Environment.NewLine);
                    currentLevel++;
                }
                Visit(current);
                if (current.Left != null)
                {
                    q.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    q.Enqueue(current.Right);
                }
            }
        }

        private void SetLevels(Node root, int i)
        {
            if (root == null)
                return;
            root.Level = i;
            if(root.Left != null) 
                SetLevels(root.Left, i + 1);
            if (root.Left != null)
                SetLevels(root.Right, i + 1);
        }

        private void PreTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            Visit(root);
            PreTraversal(root.Left);
            PreTraversal(root.Right);
        }

        private void InTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            InTraversal(root.Left);
            Visit(root);
            InTraversal(root.Right);
        }

        private void PreTraversal_Iterative(Node root)
        {
            if (root == null)
            {
                return;
            }
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while(stack.Count > 0)
            {
                Node current = stack.Pop();
                Visit(current);
                if (current.Right != null)
                    stack.Push(current.Right);
                if (current.Left != null)
                    stack.Push(current.Left);
            }
        }

        private void PostTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            PostTraversal(root.Left);
            PostTraversal(root.Right);
            Visit(root);
        }

        private void Visit(Node root)
        {
            Console.Write(root.Data + "-");
        }
    }
}
