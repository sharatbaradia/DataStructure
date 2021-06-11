using System;
using System.Collections.Generic;
using DataStructure.TreesAndGraphs;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arrayValues = new int[] { 25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90 };
            Tree tree = new Tree();
            Node<int> root = tree.BuildBinarySearchTree(arrayValues);
            Console.WriteLine("PreOrder Traversal");
            tree.printPreOrder(tree.root);
            Console.WriteLine("InOrder Traversal");
            tree.printInOrder(tree.root);
            Console.WriteLine("PostOrder Traversal");
            tree.printPostOrder(tree.root);

            /* Build tree from INorder and PreOrder Traversals*/

            char[] inOrder = new char[] { 'D', 'B', 'E', 'A', 'F', 'C' };
            char[] preOrder = new char[] { 'A', 'B', 'D', 'E', 'C', 'F' };
            Node<char> TreeRootNode = tree.BuildCharTreeFromTraversal(inOrder, preOrder, 0, inOrder.Length - 1);
            tree.printPreOrder(TreeRootNode);
            tree.printInOrder(TreeRootNode);
        }
    }
}
