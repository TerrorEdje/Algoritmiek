using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args) 
        {
            BST tree = new BST();
            tree.insert(50);
            tree.insert(2);
            tree.insert(7);
            tree.insert(94);
            tree.insert(24);
            tree.insert(24);
            tree.insert(71);
            tree.insert(30);
            tree.insert(49);
            //Console.WriteLine("Count: " + tree.count()); // Should be 9
            //Console.WriteLine("Min: " + tree.min()); // Should be 2
            //Console.WriteLine("Max: " + tree.max()); // Should be 94
            //Console.WriteLine("Depth: " + tree.depth()); // Should be 7
            tree.prettyprint(); // Prints the values in order
            Console.WriteLine();
            tree.delete(50);
            tree.prettyprint(); // Prints the values in order
            Console.WriteLine();
            tree.printInRange(5,80);
            Console.ReadLine();

            /*tree.delete(49); // test for value not in tree
            tree.delete(51); // test for value not in tree
            tree.delete(50);
            tree.delete(2);
            tree.delete(7);
            tree.delete(94);
            tree.delete(24);
            tree.delete(24);
            tree.delete(71);
            tree.delete(30);
            tree.delete(49);*/
            //Console.WriteLine("Count: " + tree.count()); // Should be 0
            //Console.WriteLine("Min: " + tree.min()); // Should be -1
            //Console.WriteLine("Max: " + tree.max()); // Should be -1
            //Console.WriteLine("Depth: " + tree.depth()); // Should be 0
            //tree.prettyprint(); // Prints the values in order
        }
    }
}
