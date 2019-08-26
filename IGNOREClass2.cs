using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class IGNOREClass2
    {
    }
}


//using System;
//using Tracker;

namespace Sorting
{
    public class QuickSort<T> //: 
        where T : IComparable<T>
    {
        protected void Swap(T[] items, int left, int right)
        {
            if (left != right)
            {
               // Interlocked.Increment(ref _swaps);

                T temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        protected int Compare(T lhs, T rhs)
        {
            //Interlocked.Increment(ref _comparisons);

            return lhs.CompareTo(rhs);
        }
        public void Sort(T[] items)
        {
            quicksort(items, 0, items.Length - 1);
        }

        private void quicksort(T[] items, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);
                int newPivot = partition(items, left, right, pivotIndex);

                quicksort(items, left, newPivot - 1);
                quicksort(items, newPivot + 1, right);
            }
        }

        private int partition(T[] items, int left, int right, int pivotIndex)
        {
            T pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (Compare(items[i], pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }

        Random _pivotRng = new Random();
    }
}
