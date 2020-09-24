using dsaexposed.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace dsaexposed
{
    class MyLinkedListImplement
    {
        public static void Init()
        {
            MyLinkedList<Int32> linkedList = new MyLinkedList<Int32>();
            Console.WriteLine("Linked List : Initial Stage");
            linkedList.PrintAll();

            Console.WriteLine("Linked List : Add a element");
            linkedList.AddNode(new Node<int>(11));
            linkedList.PrintAll();

            Console.WriteLine("Linked List : Add 2 more elements");
            linkedList.AddNode(new Node<int>(1));
            linkedList.AddNode(new Node<int>(11));
            linkedList.PrintAll();

            Console.WriteLine("Try to remove not available element");
            linkedList.RemoveNode(new Node<int>(23));
            Console.WriteLine("Try to remove in between/last element");
            linkedList.RemoveNode(new Node<int>(11));
            linkedList.PrintAll();

            Console.WriteLine("After removing duplicates");
            linkedList.RemoveDuplicates();
            linkedList.AddNode(new Node<int>(21));
            linkedList.PrintAll();


            Console.WriteLine("Finding the middle of linked list");
            Node<int> middle = linkedList.FindMiddle();
            Console.WriteLine($"The middle element is {middle.Data}");
        }
    }
}
