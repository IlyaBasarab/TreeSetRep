using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int v)
        {
            value = v;
            left = null;
            right = null;
        }

    }


    class BinaryTree
    {
        public Node root;

        

        public Node First(int value)
        {
            return root = new Node(value);
        }

        public Node Insert(Node root, int value)
        {
            Node curNode = root;
            Node nextNode = null;
            bool found = false;

            while (curNode != null && !found)
            {
                nextNode = curNode;

                if (value == curNode.value)
                {
                    found = true;
                }
                else if (value < curNode.value)
                {
                    curNode = curNode.left;
                }
                else
                {
                    curNode = curNode.right;
                }
            }
            if (found)
            {
                return curNode;
            }

            Node newNode = new Node(value);

            if (value < nextNode.value)
            {
                nextNode.left = newNode;
            }
            else
            {
                nextNode.right = newNode;
            }

            return newNode;

        }


        public void Show(Node root, int level)
        {
            if (root == null)
            {
                return;
            }

            Show(root.left, level + 1);
            for (int i = 0; i < level; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine(root.value);
            Show(root.right, level + 1);
        }

        public void Remove(int value)
        {
            Node curNode = root;
            Node prevNode = null;
            Node nextNode = null;
            bool found = false;

            while (curNode != null && !found)
            {
                prevNode = nextNode;
                nextNode = curNode;

                if (value == curNode.value)
                {
                    found = true;
                }
                else if (value < curNode.value)
                {
                    curNode = curNode.left; 
                }
                else
                {
                    curNode = curNode.right;
                }

            }
            if (found)
            {
                if (prevNode.value < value)
                {
                    prevNode.right = nextNode.right;
                    Insert(prevNode.left, nextNode.left.value);
                    nextNode = null;
                }
                else
                {
                    prevNode.left = nextNode.left;
                    Insert(prevNode.right, nextNode.right.value);
                    nextNode = null;
                }


            }
        }


        public void Lower(int value)
        {
            
        }

        public void Higher(int value)
        {

        }
        public void headSet(int value)
        {

        }
        public void tailSet(int value)
        {

        }
        public void subSet(int value)
        {

        }

    }
}
