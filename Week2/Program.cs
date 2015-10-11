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
            QuikSort3 quikSorter = new QuikSort3();

            quikSorter.sortTimes(1);
        
            int times = 100;
            Console.WriteLine(times);

            //QuikSort quikSorter = new QuikSort();
            //quikSorter.sortTimes(times);

            MergeSort bubbleSorter = new MergeSort();
            bubbleSorter.sortTimes(times);

            Console.ReadLine();

        }


    }
}
