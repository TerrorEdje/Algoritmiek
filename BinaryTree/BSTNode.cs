using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BSTNode
    {
        private int number;

        private BSTNode left;
        private BSTNode right;

        public BSTNode(int number)
        {
            this.number = number;
        }

        public bool exists(int number)
        {
            if (this.number == number)
            {
                return true;
            }
            if (left != null)
            if (left.exists(number))
            {
                return true;
            }
            if (right.exists(number))
            {
                return true;
            }
        }

        /**
         * Add a number in the subtree of this node
         */
        public void insert(int number)
        {
            if (number < this.number)
            {
                // Smaller value, insert it into the left subtree
                if (this.left == null)
                {
                    this.left = new BSTNode(number);
                }
                else
                {
                    this.left.insert(number);
                }
            }
            else
            {
                // Larger value, insert it in the right subtree
                if (this.right == null)
                {
                    this.right = new BSTNode(number);
                }
                else
                {
                    this.right.insert(number);
                }
            }
        }

        public void prettyprint(String firstPrefix, String prefix) 
        {
		    Console.WriteLine(firstPrefix + number);

		    if (right == null) {
			    Console.WriteLine(prefix + "├── .");
		    } else {
			    right.prettyprint(prefix + "├── ", prefix + "|   ");
		    }

		    if (left == null) {
                Console.WriteLine(prefix + "└── .");
		    } else {
			    left.prettyprint(prefix + "└── ", prefix + "    ");
		    }
	    }
    }
}
