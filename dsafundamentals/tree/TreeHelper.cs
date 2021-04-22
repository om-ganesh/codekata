using System;
using System.Collections.Generic;

namespace tree
{
    public class TreeHelper
    {
        /// <summary>
        /// Creates Binary Tree from array, root at middle and splitting recursively in two halves
        /// </summary>
        /// <returns></returns>
        public static Node CreateBinaryTree(int[] arr)
        {
            return CreateBT(arr, 0, arr.Length);
        }

        private static Node CreateBT(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                Node root = new Node(arr[mid]);
                root.Left = CreateBT(arr, left, mid);
                root.Right = CreateBT(arr, mid + 1, right);
                return root;
            }
            return null;
        }

        /// <summary>
        /// Create Binary Search Tree (starting from root as array[0])
        /// </summary>
        /// <returns></returns>
        public static Node CreateBinarySearchTree(int[] data)
        {
            if (data.Length < 1)
            {
                return null;
            }
            Node root = new Node(data[0]);
            for (int i = 1; i < data.Length; i++)
            {
                InsertInBST(root, data[i]);
            }
            return root;
        }

        private static void InsertInBST(Node node, int data)
        {
            if (data > node.Data)
            {
                if (node.Right != null)
                {
                    InsertInBST(node.Right, data);
                }
                else
                {
                    node.Right = new Node(data);
                }
            }
            else
            {
                if (node.Left != null)
                {
                    InsertInBST(node.Left, data);
                }
                else
                {
                    node.Left = new Node(data);
                }
            }
        }

        /// <summary>
        /// Create Tree (Starting from root as array[0])
        /// </summary>
        /// <returns></returns>
        public static Node CreateTree(int[] arr, int index=0, Node current=null)
        {
            if (index < arr.Length)
            {
                current = new Node(arr[index]);
                current.Left = CreateTree(arr, 2 * index + 1, current.Left);
                current.Right = CreateTree(arr, 2 * index + 2, current.Right);
            }
            return current;
        }

        public static bool Search(Node tree, int val)
        {
            if (tree == null)
            {
                return false;
            }
            if (tree.Data == val)
            {
                return true;
            }
            else if (val > tree.Data)
            {
                Search(tree.Right, val);
            }
            else
            {
                Search(tree.Left, val);
            }
            return false;
        }
    }
}
