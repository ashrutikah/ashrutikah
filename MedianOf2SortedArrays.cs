using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MedianOf2SortedArrays
    {
        public class Solution
        {
            public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {

                //Create a new merged array
                double median = 0;
                int i = 0; int ptrNums1 = 0; int ptrNums2 = 0;
                int cnt1 = nums1.Length;
                int cnt2 = nums2.Length; int[] finalArray = new int[cnt1 + cnt2];
                //If count of array is odd then median = array[count/2]
                while (cnt1 > 0 || cnt2 > 0)
                {
                    if (ptrNums1 < nums1.Length && ptrNums2 < nums2.Length)
                    {
                        if (nums1[ptrNums1] < nums2[ptrNums2])
                        {
                            finalArray[i] = nums1[ptrNums1];
                            ptrNums1++;
                            cnt1--;
                        }
                        else if (nums1[ptrNums1] > nums2[ptrNums2])
                        {
                            finalArray[i] = nums2[ptrNums2];
                            ptrNums2++;
                            cnt2--;
                        }
                    }
                    else
                    {
                        if (ptrNums1 < nums1.Length)
                        {
                            for (int k = 0; k < nums1.Length; k++)
                            {
                                finalArray[i] = nums1[k];
                                ptrNums1++;
                                cnt1--; i++;
                            }
                        }

                        if (ptrNums2 < nums2.Length)
                        {
                            for (int k = 0; k < nums2.Length; k++)
                            {
                                finalArray[i] = nums2[k];
                                ptrNums2++;
                                cnt2--; i++;
                            }
                        }
                    }
                    i++;

                }

                int cnt3 = finalArray.Length; int medianIndex = 0; int medianIndex1 = 0;
                //If count is even then median = array[count/2] + array[(count/2)+1]
                if (cnt3 % 2 == 0)
                {
                    medianIndex = cnt3 / 2;
                    medianIndex1 = medianIndex - 1;
                    median = (double)(finalArray[medianIndex] + finalArray[medianIndex1])/2;

                }
                else
                {
                    medianIndex = cnt3 / 2;
                    median = finalArray[medianIndex];
                }

                return median;
            }

            //public static void Main(string[] args)
            //{
            //    Console.WriteLine("Hello Substring Problem Started");
            //    int[] array1 = { 1, 2,3,4 };
            //    int[] array2 = { 5,6,7,8 };

            //    Console.WriteLine(FindMedianSortedArrays(array1, array2));

            //}
        }


    }
}
