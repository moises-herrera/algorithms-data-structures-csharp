using System;

namespace MergeSort
{
    class Program
    {
        private static int[] array = { 20, 10, 30, 5, 15, 25, 35, 2, 8, 12 };

        static void Main(string[] args)
        {
            var sortedArray = MergeSort(array);

            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] MergeSort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int middle = array.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = array[i];
            }

            for (int i = middle; i < array.Length; i++)
            {
                right[i - middle] = array[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int lengthLeft = left.Length;
            int lengthRight = right.Length;
            
            int[] result = new int[lengthLeft + lengthRight];

            int indexLeft = 0;
            int indexRight = 0;
            int indexResult = 0;

            while (indexLeft < lengthLeft && indexRight < lengthRight)
            {
                if (left[indexLeft] < right[indexRight])
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                }
                else
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                }
                indexResult++;
            }

            while (indexLeft < lengthLeft)
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }

            while (indexRight < lengthRight)
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }

            return result;
        }
    }
}
