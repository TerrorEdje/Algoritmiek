using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBalancingBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            Random r = new Random();
            for (int i = 1; i <= 100; i++)
            {                
                tree.insertAVL(r.Next(1000));
            }
            Console.WriteLine(tree.root.isAVLBalanced());
            tree.prettyprint();
            Console.ReadLine();
        }
    }
}
