using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject.Utility
{
    class StackLinkedList<TYPE>
    {
        Node first;

        public StackLinkedList()
        {
            first = null;
        }


        //pushing is adding node at first in linked list
        public void push(TYPE str)
        {
            Node temp = new Node(str);
            temp.next = first;
            first = temp;
        }

        //poping is removing first node from linked list
        public TYPE pop()
        {
            if (first == null)
                throw new Exception("Stack is empty");
            TYPE val = first.value;
            first = first.next;
            return val;
        }

        public bool IsEmpty()
        {
            return first == null;
        }


        class Node
        {
            public TYPE value { get; set; }
            public Node next { get; set; }

            public Node(TYPE val)
            {
                this.value = val;
                this.next = null;
            }
        }
    }
}
