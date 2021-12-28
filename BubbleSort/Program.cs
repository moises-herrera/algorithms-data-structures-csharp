using System;

namespace BubbleSort
{
    class Program
    {
        private static int[] array = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

        static void Main(string[] args)
        {
            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
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
