﻿using System;

namespace Tree
{
    class Program
    {
        public static void Main(String[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            tree.inorder();
        }
    }

}
