using System;
using System.Collections.Generic;
using System.Text;

namespace dsaexposed.models
{
    public class MyLinkedList<T>
    {
        Node<T> first;
        int size;

        public Node<T> First { get { return this.first; } }

        public static Node<T> CreateInstance(T[] arr)
        {
            Node<T> head = null;
            for(int i=arr.Length-1;i>=0;i--)
            {
                Node<T> temp = new Node<T>(arr[i]);
                if (head == null)
                {
                    head = temp;
                }
                else
                {
                    temp.Next = head;
                    head = temp;
                }

            }
            return head;
        }
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

        public void Reverse()
        {
            Node<T> pre = new Node<T>();
            Node<T> current = first;

            while(current!=null)
            {
                //LOGIC: During reverse, point current to empty/pre and move pre to current, and then current to next
                //WE would need extra node to perform this operation
                
                //1. Since, Current will point to pre (we have to save where current is pointing to)
                Node<T> next = current.Next;

                //2. Now point current to pre and move pre pointing to current
                current.Next = pre;
                pre = current;
                
                //3. Finally move current to next, which will be current for coming iteration
                current = next;
            }
            first = pre;
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

        public void PrintAll(Node<T> node = null)
        {
            if(node == null)
            {
                node = first;
                if (first == null)
                {
                    Console.WriteLine("No elements available.");
                    return;
                }
            }
            
            Node<T> temp = node;
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


    public class Node<T>
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
