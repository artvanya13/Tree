using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Binary_tree
    {

        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        Node root;
        
        public void BinarySearchTree()
        {
            root = null;
        }

        public void insert(int key)
        {
            root = insertRec(root, key);
        }
        Node insertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            return root;
        }

        public void inorder()
        {
            inorderRec(root);
        }

        // A utility function to
        // do inorder traversal of BST
        public void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }

        // Driver Code

    }

    /* public void add(int n)
    {
        Node temp = root;
        bool Isempty = false;

        while (Isempty == false)
        {
            if (currentnode < n)
            {
                currentnode = currentnode.left;
            }
        }
    } */
}