using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBinaryTree
{
    public class Operand : Expression 
    {
        private char operand { get; set; }
        private Expression Left { get; set; }
        private Expression Right { get; set; }

	    public Operand(char operand, Expression left, Expression right) 
        {
            this.operand = operand;
            Left = left;
            Right = right;
	    }

        
	    public override int evaluate() 
        {
            switch (operand)
            {
                case '*': 
                    return Left.evaluate() * Right.evaluate();
                case '/':
                    return Left.evaluate() / Right.evaluate();
                case '+':
                    return Left.evaluate() + Right.evaluate();
                case '-':
                    return Left.evaluate() - Right.evaluate();
                default:
                    return 0;
            }

	    }

        public override string toString()
        {
            return "(" + Left.toString() +  operand.ToString() + Right.toString() + ")";
        }

        
    }
}
