using System;
using System.Collections.Generic;

namespace csharpproject
{
    class TreeMirror : IProblem
    {
        public void Execute()
        {
            //12
            //10 15
            //8 9 11 16
            Tree t1 = new Tree(12);
            t1.AddLeftChild(10);
            t1.AddRightChild(15);
            t1.LeftChild.AddLeftChild(8);
            t1.LeftChild.AddRightChild(9);
            t1.RightChild.AddLeftChild(11);
            t1.RightChild.AddRightChild(16);

            Tree t2 = new Tree(12);
            t2.AddLeftChild(15);
            t2.AddRightChild(10);
            t2.LeftChild.AddLeftChild(16);
            t2.LeftChild.AddRightChild(11);
            t2.RightChild.AddLeftChild(9);
            t2.RightChild.AddRightChild(8);
            //t2.LeftChild.LeftChild.AddLeftChild(44);

            Console.WriteLine("Trees T1 and T2 are same? " + t1.Equals(t2));
        }
    }



    class Tree
    {
        int data;
        Tree left;
        Tree right;

        public Tree(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
        public void AddLeftChild(int data)
        {
            Tree t = new Tree(data);
            this.left = t;
        }

        public int Data { get { return this.data; } }
        public Tree LeftChild { get { return this.left; } }
        public Tree RightChild { get { return this.right; } }

        public void AddRightChild(int data)
        {
            Tree t = new Tree(data);
            this.right = t;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Tree tree = (Tree)obj;
                bool isMirror = true;
                bool isLeftMirror = this.data == tree.data;
                bool isRightMirror = true;
                if(this.LeftChild != null || tree.RightChild != null)
                {
                    isLeftMirror = this.LeftChild != null && tree.RightChild != null && this.LeftChild.Equals(tree.RightChild);
                }
                if (this.RightChild != null || tree.LeftChild != null)
                {
                    isRightMirror = this.RightChild != null && tree.LeftChild != null && this.RightChild.Equals(tree.LeftChild);
                }
                return isMirror && isLeftMirror && isRightMirror;
            }
        }
    }
}
