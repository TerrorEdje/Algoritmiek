using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfBalancingBinaryTree
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

        public BSTNode rotateLeft()
        {
            BSTNode rightNode = right;
            right = rightNode.left;
            rightNode.left = this;
            return rightNode;
        }

        public BSTNode rotateRight()
        {
            BSTNode leftNode = left;
            left = leftNode.right;
            leftNode.right = this;
            return leftNode;
        }

        public bool isAVLBalanced()
        {
            if (Math.Abs(depth(left) - depth(right)) <= 1)
            {
                if (left.isAVLBalanced())
                {
                    return left.isAVLBalanced();
                }
                if (right.isAVLBalanced())
                {
                    return right.isAVLBalanced();
                }
            }
            return false;
        }

        public BSTNode insertAVL(int number)
        {
            if (number < this.number)
            {
                // Smaller value, insert it into the left subtree
                if (this.left == null)
                {
                    this.left = new BSTNode(number);
                    return this.left;
                }
                else
                {
                    return this.left.insertAVL(number);
                }
            }
            else
            {
                // Larger value, insert it in the right subtree
                if (this.right == null)
                {
                    this.right = new BSTNode(number);
                    return this.right;
                }
                else
                {
                    return this.right.insertAVL(number);
                }
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

        public int depth(BSTNode aNode)
        {
            if (aNode == null)
                return 0;

            int lefth = depth(aNode.left);
            int righth = depth(aNode.right);

            if (lefth > righth)
                return lefth + 1;
            else
                return righth + 1;
        }

        public void prettyprint(String firstPrefix, String prefix)
        {
            Console.WriteLine(firstPrefix + number);

            if (right == null)
            {
                Console.WriteLine(prefix + "├── .");
            }
            else
            {
                right.prettyprint(prefix + "├── ", prefix + "|   ");
            }

            if (left == null)
            {
                Console.WriteLine(prefix + "└── .");
            }
            else
            {
                left.prettyprint(prefix + "└── ", prefix + "    ");
            }
        }
    }
}
