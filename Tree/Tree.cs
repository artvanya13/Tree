using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node root;
        public Tree(int element)
        {
            root = new Node(element);
        }

        public void InOrderTraversal(Node current)
        {
            if (current != null)
            {
                InOrderTraversal(current.left);
                Console.WriteLine(current.element);
                InOrderTraversal(current.right);
            }
        }

        public void PostOrderTraversal(Node current)
        {
            if (current != null)
            {
                InOrderTraversal(current.left);
                InOrderTraversal(current.right);
                Console.WriteLine(current.element);
            }
        }

        public void PreOrderTraversal(Node current)
        {
            if (current != null)
            {
                Console.WriteLine(current.element);
                InOrderTraversal(current.left);
                InOrderTraversal(current.right);
            }
        }
        public bool Add(int number)
        {
            bool added = false;
            Node newNode = new Node(number);
            Node currentNode = root;


            while (!added)
            {
                if (number < currentNode.element)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else if (number > currentNode.element)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
                else
                {
                    return false;
                }
            }
            return added;
        }
    }
}