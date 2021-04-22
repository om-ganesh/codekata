using System;

namespace tree
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Level { get; set; }

        public Node Parent { get; set; }

        public Node()
        {

            Left = null;
            Right = null;
        }

        public Node(int Data) : this()
        {
            this.Data = Data;
        }

    }
}
