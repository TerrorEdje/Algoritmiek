using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBinaryTree
{
    public class Program
    {

        public static void Main(string[] args) 
        {
		    Number vier = new Number(4);
		    Number vijf = new Number(5);
		    Operand vier_plus_vijf = new Operand('+', vier, vijf);
		
		    Number zeven = new Number(7);
		    Operand dat_keer_zeven = new Operand('*', vier_plus_vijf, zeven);
		
		    Console.WriteLine(dat_keer_zeven.toString()); // Should print "((4+5)*7)"
		    Console.WriteLine(dat_keer_zeven.evaluate()); // Should print "63"
            Console.ReadLine();
		
	    }
    }
}
