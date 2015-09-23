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

        //Checks if parameter exists in the tree.
        public bool exists(int number)
        {
            if (this.number == number)
            {
                return true;
            }
            if (left != null)
            {
                if (left.exists(number))
                {
                    return true;
                }
            }
            if (right != null)
            {
                if (right.exists(number))
                {
                    return true;
                }
            }
            return false;
        }

        public int min()
        {
            int lowest = number;
            if (left != null)
            {
                lowest = left.min();
            }
            return lowest;
        }

        public int max()
        {
            int highest = number;
            if (right != null)
            {
                highest = right.max();
            }
            return highest;
        }

        public int depth(BSTNode aNode)
        {
            if(aNode == null)
                return 0;

            int lefth = depth(aNode.left);
            int righth = depth(aNode.right);

            if (lefth > righth)
                return lefth + 1;
            else
                return righth + 1;
        }

        public int count(int amount)
        {
            amount++;
            if (left != null)
            {
                amount = left.count(amount);
            }
            if (right != null)
            {
                amount = right.count(amount);
            }
            return amount;
        }

        public void print()
        {
            if (left != null)
            {
                left.print();
            }
            Console.Write(number + "-");
            if (right != null)
            {
                right.print();
            }
        }

        public void printInRange(int min, int max)
        {
            if (min < number)
            {
                if (left != null)
                {
                    left.printInRange(min,max);
                }
            }
            if (min < number && max > number)
            {
                Console.Write(number + "-");
            }
            if (max > number)
            {
                if (right != null)
                {
                    right.printInRange(min,max);
                }
            }
        }

        public void delete(int number)
        {

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
