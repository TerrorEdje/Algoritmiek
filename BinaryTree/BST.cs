using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BST
    {
        private BSTNode root;

        public void prettyprint()
        {
            if (root != null)
            {
                root.prettyprint("→", " ");
            }
        }

        /**
         * Inserts the value into the binary search tree
         */
        public void insert(int number)
        {
            if (root == null)
            {
                root = new BSTNode(number);
            }
            else
            {
                root.insert(number);
            }
        }

        /**
         * Returns true if the number is present as a node in the tree
         */
        public bool exists(int number)
        {
            return root.exists(number);
        }

        /**
         * Returns the smallest value in the tree (or -1 if tree is empty)
         */
        public int min()
        {
            return root.min();
        }

        /**
         * Returns the largest value in the tree (or -1 if tree is empty)
         */
        public int max()
        {
            return root.max();
        }

        /**
         * Returns how many levels deep the deepest level in the tree is
         * (the empty tree is 0 levels deep, the tree with only one root node is 1 deep)
         * @return
         */
        public int depth()
        {
            return root.depth(root);
        }

        /**
         * Returns the amount of values in the tree
         * @return
         */
        public int count()
        {
            return root.count(0);
        }

        /**
         * Print all the values in the tree in order
         */
        public void print()
        {
            root.print();
        }

        /**
         * Print all values that lie between min and max in order (inclusive)
         */
        public void printInRange(int min, int max)
        {
            root.printInRange(min,max);
        }

        /**
         * Delete a number from the tree (if it exists)
         */
        public void delete(int number)
        {
            root.delete(number);
        }
    }
}
