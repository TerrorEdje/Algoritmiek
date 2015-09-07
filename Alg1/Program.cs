using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg1
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopw = new Stopwatch();


            NeiaardmoGnirts neig = new NeiaardmoGnirts();


            neig.runMe("lol");
            Console.Out.WriteLine(neig.testMe("lol"));
            Console.Out.WriteLine(neig.testMe("regenneger"));
            
            Console.ReadLine();



            Fibonacci fib = new Fibonacci();

            stopw.Restart();
            Console.Out.WriteLine("Total " + fib.calcLoop(40));
            Console.Out.WriteLine("Time " + stopw.ElapsedMilliseconds);
            Console.ReadLine();

            stopw.Restart();
            Console.Out.WriteLine("Total "+ fib.calcRecursive(40) );
            Console.Out.WriteLine("Time " + stopw.ElapsedMilliseconds);
            Console.ReadLine();


            
        }


       
    }
}
