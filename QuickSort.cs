using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SortingAlgorithms
    {
        //public static void Main(string[]args)
        //{
        //    int[] array = { 3, 6, 8, 5, 9, 1, 2, 4 };

        //    SortingAlgorithms clsSortingAlgorithms = new SortingAlgorithms();

        //    clsSortingAlgorithms.QuickSort(array,0,array.Length-1);

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }

        //    Console.ReadLine();
        //}
        

        public void QuickSort(int[] array, int left, int right){
            int index = Partition(array, left, right);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        public int Partition(int[] array, int left, int right)
        {
            int pivot = array[(left + right) /2];

            while (left <= right)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }

            return left;
        }

    }
}
