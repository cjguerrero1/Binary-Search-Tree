using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBinaryTree tree = new MyBinaryTree();
            Node rootNode = tree.AddNode(10);

            tree.Insert(tree.root, rootNode);
            tree.Insert(tree.root, tree.AddNode(7));
            tree.Insert(tree.root, tree.AddNode(12));
            tree.Insert(tree.root, tree.AddNode(3));
            tree.Insert(tree.root, tree.AddNode(16));
            tree.Insert(tree.root, tree.AddNode(5));
            tree.Insert(tree.root, tree.AddNode(14));
            tree.DisplayTree(tree.root);
            Console.ReadLine();
        }
    }
}
