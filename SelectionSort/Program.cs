using System;

namespace SelectionSort
{
    class Program
    {
        private static int[] array = { 20, 10, 30, 5, 15, 25, 35, 2, 8, 12 };

        static void Main(string[] args)
        {
            int length = array.Length;
            int leastIndex = 0;

            for (int i = 0; i < length - 1; i++)
            {
                leastIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] < array[leastIndex])
                        leastIndex = j;
                }

                Swap(i, leastIndex);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static void Swap(int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
