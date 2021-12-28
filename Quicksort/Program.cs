using System;

namespace Quicksort
{
    class Program
    {
        private static int[] array = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };

        static void Main(string[] args)
        {
            QuickSort(0, array.Length - 1);

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        public static void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static int Split(int start, int end)
        {
            int pivot = 0;
            int indexPivot = 0;
            
            pivot = array[end];

            indexPivot = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    Swap(i, indexPivot);
                    indexPivot++;
                }
            }

            Swap(indexPivot, end);

            return indexPivot;
        }

        public static void QuickSort(int start, int end)
        {
            int indexPivot = 0;

            if (start >= end)
                return;

            indexPivot = Split(start, end);

            QuickSort(start, indexPivot - 1);
            QuickSort(indexPivot + 1, end);
        }
    }
}
