using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
   



    internal class Program
    {
         static void Main(string[] args)
        {

            BinaryTree binaryTree = new BinaryTree();


            binaryTree.First(10);

            binaryTree.Insert(binaryTree.root, 15);
            binaryTree.Insert(binaryTree.root, 14);
            binaryTree.Insert(binaryTree.root, 8);
            binaryTree.Insert(binaryTree.root, 7);
            binaryTree.Insert(binaryTree.root, 20);
            
            binaryTree.Insert(binaryTree.root, 19);
            binaryTree.Insert(binaryTree.root, 24);

            binaryTree.Show(binaryTree.root, 1);

            Console.WriteLine("");

            binaryTree.Remove(15);

            binaryTree.Show(binaryTree.root, 1);

            Console.WriteLine("");

            binaryTree.Lower(19);
            binaryTree.Higher(19);


        }
    }
}
