using System;
using System.Collections.Generic;

namespace tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Level { get; set; }

        public Node Parent { get; set; }

        public Node(int Data=0)
        {
            this.Data = Data;
            Left = null;
            Right = null;
        }

        public void Traverse(TreeTraversal dir = TreeTraversal.InTraversal)
        {
            Console.Write($"{Environment.NewLine}{dir} Traversal: ");
            switch (dir)
            {
                case TreeTraversal.PreTraversal:
                    PreTraversal(this);
                    break;
                case TreeTraversal.PreTraversal_Iterative:
                    PreTraversalIterative(this);
                    break;
                case TreeTraversal.PostTraversal:
                    PostTraversal(this);
                    break;
                case TreeTraversal.BFSTraversal:
                    BFSTraversal(this);
                    break;
                case TreeTraversal.BFSTraversalWithLabel:
                    BFSTraversalWithLevel(this);
                    break;
                default:
                    InTraversal(this);
                    break;
            }
        }

        private void InTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            InTraversal(node.Left);
            Visit(node);
            InTraversal(node.Right);
        }

        private void PreTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            Visit(node);
            InTraversal(node.Left);
            InTraversal(node.Right);
        }

        private void PostTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            InTraversal(node.Left);
            InTraversal(node.Right);
            Visit(node);
        }

        private void PreTraversalIterative(Node node)
        {
            if (node == null)
            {
                return;
            }
            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);
            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                Visit(current);
                if (current.Right != null)
                    stack.Push(current.Right);
                if (current.Left != null)
                    stack.Push(current.Left);
            }
        }

        private void BFSTraversal(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                Node current = q.Dequeue();
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

        private void BFSTraversalWithLevel(Node root)
        {
            SetLevels(root, 1);
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);
            int currentLevel = 1;
            while (q.Count > 0)
            {
                Node current = q.Dequeue();
                if (current.Level > currentLevel)
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

        public void Visualize(int indent = 0, char child = '0')
        {
            // Print me
            Console.WriteLine($"{new string(' ', indent * 2)}{child}:{this.Data}");
            if (this.Left != null)
            {
                this.Left.Visualize(indent + 1, 'L');
            }
            if (this.Right != null)
            {
                this.Right.Visualize(indent + 1, 'R');
            }
        }

        private void SetLevels(Node root, int i)
        {
            if (root == null)
                return;
            root.Level = i;
            if (root.Left != null)
                SetLevels(root.Left, i + 1);
            if (root.Left != null)
                SetLevels(root.Right, i + 1);
        }

        private void Visit(Node root)
        {
            Console.Write(root.Data + "-");
        }
    }

    public enum TreeTraversal
    {
        PreTraversal,
        InTraversal,
        PostTraversal,
        PreTraversal_Iterative,
        BFSTraversal,
        BFSTraversalWithLabel
    }
}
