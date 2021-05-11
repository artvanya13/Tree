using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree(4);
            t.Add(1);
            t.Add(2);
            t.Add(4);
            t.PostOrderTraversal(t.root);
        }
    }
}
