using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryTree
    {
        public Node root;
        static int count;

        public MyBinaryTree()
        {
            root = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            if (root==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Node AddNode(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            count++;
            return newNode;
        }

        public void Insert(Node root, Node newNode)
        {
            if(IsEmpty())
            {
                root = newNode;
            }
            else if(newNode.value < root.value)
            {
                if(root.left == null)
                {
                    root.left = newNode;
                }
                else
                {
                    root = root.left;
                    Insert(root, newNode);
                }
            }
            else if(newNode.value > root.value)
            {
                if (root.right == null)
                {
                    root.right = newNode;
                }
                else
                {
                    root = root.right;
                    Insert(root, newNode);
                }
            }
        }

        public void DisplayTree(Node root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                DisplayTree(root.left);
                Console.Write("{0} ", root.value);
                DisplayTree(root.right);
            }
        }       
    }
}
