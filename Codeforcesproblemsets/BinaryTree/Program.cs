using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int value;
        public Node leftNode;
        public Node rightNode;
    }

    public class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public void Insert(int val)
        {
            Node newNode = new Node();
            newNode.value = val;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(current.value < newNode.value)
                    {
                        current = current.rightNode;
                        if(current == null)
                        {
                            parent.rightNode = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.leftNode;
                        if(current == null)
                        {
                            parent.leftNode = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public int getLenghtRecur(Node n)
        {
            int result = 0;
            if (n == null)
                return result;
            else
                result = Math.Max(getLenghtRecur(n.leftNode), getLenghtRecur(n.rightNode)) + 1;
            return result;
        }

        public void DFSinOrder(Node n)
        {
            if (n != null)
            {
                DFSinOrder(n.leftNode);
                Console.WriteLine(n.value + " ");
                DFSinOrder(n.rightNode);
            }
        }

        public void DFSpostOrder(Node n)
        {
            if(n != null)
            {
                DFSinOrder(n.leftNode);
                DFSinOrder(n.rightNode);
                Console.WriteLine(n.value + " ");
            }
        }

        public void DFSpreOrder(Node n)
        {
            if(n != null)
            {
                Console.WriteLine(n.value + " ");
                DFSinOrder(n.leftNode);
                DFSinOrder(n.rightNode);
            }
        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(20);
            tree.Insert(25);
            tree.Insert(15);
            tree.Insert(22);
            tree.Insert(21);
            tree.Insert(17);
            tree.Insert(10);
            Console.WriteLine("Tree length: " + tree.getLenghtRecur(tree.root));
            Console.ReadLine();
            
        }
    }
}
