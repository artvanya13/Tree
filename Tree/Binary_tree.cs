using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Binary_tree
    {
        private Node root;

        public Binary_tree(int n)
        {
            root = new Node(n);
        }

        public void add(int n)
        {
            Node currentnode = root;
            bool Isempty = false;

            while (Isempty == false)
            {
                if (currentnode < n)
                {
                    currentnode = currentnode.left;
                }
            }
        }
    }
}
