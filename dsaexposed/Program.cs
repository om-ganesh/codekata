using dsaexposed;
using dsaexposed.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaexposed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Illustrating DSA!");

            //TODO
            //MyLinkedListImplement.Init();
            SortingMerge.Init();

            BinarySearcher.Init();

            SortingAlgo.Init();

            Console.WriteLine("@HelloGybe Interview!!!");
            ShowTreeChildrenBreadthWise.Init();

            Console.WriteLine("@IBM Asked!!!");
            TreeTraversal traversal = new TreeTraversal();
            traversal.Init();
            traversal.Init(true); //Create a binary search tree

            Console.Read();
        }
    }
}
