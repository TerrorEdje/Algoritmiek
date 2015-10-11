using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBalancingBinaryTree
{
    public class BST
    {
        public BSTNode root;

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
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Returns the smallest value in the tree (or -1 if tree is empty)
         */
        public int min()
        {
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Returns the largest value in the tree (or -1 if tree is empty)
         */
        public int max()
        {
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Returns how many levels deep the deepest level in the tree is
         * (the empty tree is 0 levels deep, the tree with only one root node is 1 deep)
         * @return
         */
        public int depth()
        {
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Returns the amount of values in the tree
         * @return
         */
        public int count()
        {
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Print all the values in the tree in order
         */
        public void print()
        {
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Print all values that lie between min and max in order (inclusive)
         */
        public void printInRange(int min, int max)
        {
            throw new NotImplementedException("Not implemented, yet");
        }

        /**
         * Delete a number from the tree (if it exists)
         */
        public void delete(int number)
        {
            throw new NotImplementedException("Not implemented, yet");
        }
    }
}
