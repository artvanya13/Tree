using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Node
    {
        public Node left;
        public Node right;
        public int element;

        public Node(int n)
        {
            left = null;
            right = null;
            element = n;

        }
    }
}
