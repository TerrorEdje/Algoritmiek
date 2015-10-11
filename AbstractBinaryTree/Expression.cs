using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBinaryTree
{
    public abstract class Expression
    {
        public abstract int evaluate();
        public abstract string toString();
    }
}
