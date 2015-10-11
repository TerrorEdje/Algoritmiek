using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBinaryTree
{
    public class Number : Expression 
    {

        private int number { get; set; }

	    public Number(int number)
	    {
            this.number = number;
	    }

	    public override int evaluate() 
        {
            return number;
	    }

        public override string toString()
        {
            return "" + number;
        }
    }
}
