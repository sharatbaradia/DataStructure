using System;
using System.Collections.Generic;

namespace DataStructure.TreesAndGraphs
{
    public class Tree
    {
        public Tree() { }
 
        public Node<int> root { get; set; }
        int preOrderCnt = 0;

        public void Add(int val)
        {
            Node<int> node = new Node<int>(val);
            Node<int> previous = null;
            if (root != null)
            {
                Node<int> curr = root;
                while (curr != null)
                {
                    previous = curr;
                    if (val > curr.Data)
                    {
                        curr = curr.Right;
                    }
                    else
                    {
                        curr = curr.Left;
                    }
                }
                if (val > previous.Data)
                {
                    previous.Right = node;
                }
                else
                {
                    previous.Left = node;
                }
            }
            else
            {
                root = node;
            }
        }

        public void printPreOrder(Node<int> node)
        {
            if (node == null) return;
            Console.WriteLine(node.Data);
            printPreOrder(node.Left);
            printPreOrder(node.Right);
        }

        public void printInOrder(Node<int> node)
        {
            if (node == null) return;
            printInOrder(node.Left);
            Console.WriteLine(node.Data);
            printInOrder(node.Right);
        }

        public void printPostOrder(Node<int> node)
        {
            if (node == null) return;
            printPostOrder(node.Left);
            printPostOrder(node.Right);
            Console.WriteLine(node.Data);
        }

        public void printPreOrder(Node<char> node)
        {
            if (node == null) return;
            Console.WriteLine(node.Data);
            printPreOrder(node.Left);
            printPreOrder(node.Right);
        }

        public void printInOrder(Node<char> node)
        {
            if (node == null) return;
            printInOrder(node.Left);
            Console.WriteLine(node.Data);
            printInOrder(node.Right);
        }

        public void printPostOrder(Node<char> node)
        {
            if (node == null) return;
            printPostOrder(node.Left);
            printPostOrder(node.Right);
            Console.WriteLine(node.Data);
        }


        public Node<int> BuildBinarySearchTree(int[] arrayValues)
        {
            for(int i = 0; i< arrayValues.Length; i++)
            {
                Add(arrayValues[i]);
            }
            return root;
        }

        public Node<char> BuildCharTreeFromTraversal(char[] inorder, char[] preorder, int inStart, int inEnd)
        {

            if (inStart > inEnd)
            {
                return null;
            }

            Node<char> node = new Node<char>(preorder[preOrderCnt++]);

            if(inStart == inEnd)
            {
                return node;
            }

            int index = SearchCharIndex(inorder, node.Data);

            node.Left = BuildCharTreeFromTraversal(inorder, preorder, inStart, index-1);
            node.Right = BuildCharTreeFromTraversal(inorder, preorder, index+1, inEnd);

            return node;

        }

        public int SearchCharIndex(char[] arrayValues, char charToSearch)
        {
            int index = 0;
            for(int i =0; i< arrayValues.Length; i++)
            {
                if (arrayValues[i] == charToSearch)
                {
                    break;
                }
                index++;
            }
            return index;
        }
    }
}
