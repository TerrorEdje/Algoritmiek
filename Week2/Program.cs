using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {            
            QuikSort quikSorter = new QuikSort();
            quikSorter.sortTimes(1000);
            Console.ReadLine();
        }
    }
}
