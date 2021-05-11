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

        public Node(int element)
        {
            this.element = element;
            left = null;
            right = null;
        }

    }
}
