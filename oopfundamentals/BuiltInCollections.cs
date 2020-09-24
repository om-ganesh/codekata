using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopfundamentals
{
    public class BuiltInCollections
    {
        public static void Init()
        {
            Console.WriteLine("Testing LinkedList");
            LinkedList<String> ll = new LinkedList<String>();
            //LinkedListNode<String> linkedListNode = new LinkedListNode<String>("subash");
            ll.AddFirst("test");
            ll.AddLast("Subash");
            ll.AddLast("Gita");
            ll.AddLast("yuvan");
            //ll.AddLast(new LinkedListNode<String>("yuvan"));
            //ll.AddBefore(linkedListNode, "gita");
            LinkedListNode<String> first = ll.First;
            
            while (first != null)
            {
                Console.WriteLine(first.Value);
                first = first.Next;
            }

            Console.WriteLine("Testing Circular Linked List using extension method.");
            first = ll.First;
            Console.WriteLine($"Without extension: {first.Previous ?? null: first.Previous.Value}; With extension method: {first.PreviousOrLast().Value}");

            Console.WriteLine("Removing duplicate names from List");
            List<String> names = new List<String> { "haris", "gaby", "nabin", "adam", "gaby" };
            names.ForEach(v => Console.WriteLine(v));
            names.Distinct().ToList().ForEach(v => Console.WriteLine(v));

        }

    }

    public static class CircularLinkedList
    {
        public static LinkedListNode<T> NextOrFirst<T>(this LinkedListNode<T> node)
        {
            if(node!=null && node.List!=null)
            {
                return node.Next ?? node.List.First;
            }
            return null;
        }

        public static LinkedListNode<T> PreviousOrLast<T>(this LinkedListNode<T> node)
        {
            if (node != null && node.List != null)
            {
                return node.Previous ?? node.List.Last;
            }
            return null;
        }
    }
}
