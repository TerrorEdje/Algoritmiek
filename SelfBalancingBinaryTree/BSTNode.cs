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
            if (right == null)
            {
                return this;
            }
            BSTNode rightNode = right;
            right = rightNode.left;
            rightNode.left = this;
            return rightNode;
        }

        public BSTNode rotateRight()
        {
            if (left == null)
            {
                return this;
            }
            BSTNode leftNode = left;
            left = leftNode.right;
            leftNode.right = this;
            return leftNode;
        }

        public bool isAVLBalanced()
        {
            if (Math.Abs(depth(left) - depth(right)) <= 1)
            {
                int count = 0;
                if (left != null)
                {
                    if (left.isAVLBalanced())
                    {
                        count++;
                    }
                }
                else
                {
                    count++;
                }
                if (right != null)
                {
                    if (right.isAVLBalanced())
                    {
                        count++;
                    }
                }
                else
                {
                    count++;
                }
                if (count == 2)
                    return true;            
            }
            else
            {
                return false;
            }
            return true;
        }

        public BSTNode insertAVL(int number)
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
                    this.left = this.left.insertAVL(number);
                }
                if (!isAVLBalanced())
                {
                    if (depth(left.right) > depth(left.left))
                    {
                        left = this.left.rotateLeft();
                    }
                    return rotateRight();
                }
            }
            else
            {
                // Larger value, insert it in the right subtree
                if (this.right == null)
                {
                    right = new BSTNode(number);
                }
                else
                {
                    this.right = this.right.insertAVL(number);
                }
                if (!isAVLBalanced())
                {
                    if (depth(right.right) < depth(right.left))
                    {
                        right = this.right.rotateRight();
                    }
                    return rotateLeft();
                }
            }
            return this;
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
