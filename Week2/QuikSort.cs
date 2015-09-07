using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class QuikSort
    {
        int equations = 0;
        int totalEquations;

        public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    //Console.WriteLine("Swapped " + numbers[left]+" "+temp);
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public void sort(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                equations++;
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    sort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    sort(arr, pivot + 1, right);
            }
            
        }

        public void startSort(int[] arr, int left, int right)
        {
            equations =0;
            sort(arr, left, right);
            Console.WriteLine("Finished after : "+equations);
            totalEquations += equations;
        }

        public void sortTimes(int times)
        {
            ArrayGenerator myArrayGenerator = new ArrayGenerator();
            totalEquations = 0;

            for (int i = 0; i < times; i++)
            {
                int[] randomOrder = myArrayGenerator.generateArrayRandom(10000);
                startSort(randomOrder, 200, 400);
                
            }
            Console.WriteLine("Finished average equations: "+(float)(+totalEquations/ times));
        }
    }
}
