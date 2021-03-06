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
            if(root==null)
            {
                return ;
            }
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
                if(curNode.left==null&& curNode.right==null)
                {
                    if (prevNode.value < value)
                    {
                        prevNode.right = null;
                    }
                    else
                    {
                        prevNode.left = null;
                    }
                }
                else if(curNode.left == null)
                {
                    if (prevNode.value < value)
                    {
                        prevNode.right = curNode.right;
                    }
                    else
                    {
                        prevNode.left = curNode.right;
                    }
                }
                else if (curNode.right == null)
                {
                    if (prevNode.value < value)
                    {
                        prevNode.right = curNode.left;
                    }
                    else
                    {
                        prevNode.left = curNode.left;
                    }
                }
                else
                {
                        Node buff = FindMinLeftNode(curNode.right);
                        Remove(FindMinLeftNode(curNode.right).value);
                        curNode.value = buff.value;

                }



            }
        }

        private Node FindByValue(int value)
        {
            if (root == null)
            {
                return null;
            }
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
                return curNode;
            }
            return null;
        }

        private Node FindMinLeftNode(Node node)
        {
            if(node.left==null)
                return node;
            return FindMinLeftNode(node.left);
        }
        private Node FindMinRightNode(Node node)
        {
            if (node.right == null)
                return node;
            return FindMinRightNode(node.right);
        }


        public void Lower(int value)
        {
            Console.WriteLine(FindMinRightNode(FindByValue(value).left).value);
             
            
        }

        public void Higher(int value)
        {
            Console.WriteLine(FindMinLeftNode(FindByValue(value).right).value);
        }
        public void headSet(int value)
        {
            Node buff = FindByValue(value);
            Show(buff.left,1);

        }
        public void tailSet(int value)
        {
            Node buff = FindByValue(value);
            Show(buff.right, 1);
        }
        public void subSet(int value)
        {

        }

    }
}
