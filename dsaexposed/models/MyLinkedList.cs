using System;
using System.Collections.Generic;
using System.Text;

namespace dsaexposed.models
{
    class MyLinkedList<T>
    {
        Node<T> first;
        int size;

        public void AddNode(Node<T> node)
        {
            if (first == null)
            {
                first = node;
            } else
            {
                Node<T> temp = first;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
            size++;
        }

        public void RemoveDuplicates()
        {
            Dictionary<T, T> pairs = new Dictionary<T, T>();
            
            if(first==null || first.Next==null)
            {
                Console.WriteLine("No Duplicates");
                return;
            }
            //If there are more than 1 element then only proceed to find duplicates
            pairs.Add(first.Data, first.Data);
            Node<T> current = first.Next;
            Node<T> previous = first;
            while(current!=null)
            {
                if(pairs.ContainsKey(current.Data))
                {
                    previous.Next = current.Next;
                } else
                {
                    previous = current;
                    pairs.Add(current.Data, current.Data);
                }
                current = current.Next;
            }
        }

        public Node<T> FindMiddle()
        {
            Node<T> current = first;
            Node<T> jumped = first.Next;
            //TODO jumped can be null so throws exception
            while (jumped!= null || jumped.Next !=null)
            {
                current = current.Next;
                jumped = jumped.Next.Next;
            }

            return current;
        }


        public void RemoveNode(Node<T> node)
        {
            if (first == null)
            {
                Console.WriteLine("Empty linked list");
                return;
            }
            if (size == 1 && first.Data.Equals(node.Data))
            {
                Console.WriteLine("Deleted from the first position");
                first = null;
                return;
            }
                Node<T> current = first;
            Node<T> previous = first;
                while (current != null)
                {
                    if(current.Data.Equals(node.Data))
                {
                    Console.WriteLine("Element found and deleted");
                    previous.Next = current.Next;
                    size--;
                    break;
                }
                previous = current;
                current = current.Next;

                }

        }

        public void PrintAll()
        {
            if (first==null)
            {
                Console.WriteLine("No elements available.");
                return;
            }
            Node<T> temp = first;
            int i = 0;
            while(temp != null)
            {
                Console.WriteLine($"Node({i++}) = {temp.Data}");
                temp = temp.Next;
            }
        }

        public int GetSize()
        {
            return this.size;
        }

    }


    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node()
        {
            Next = null;
        }

        public Node(T data)
        {
            this.Data = data;
            Next = null;
        }
    }
}
