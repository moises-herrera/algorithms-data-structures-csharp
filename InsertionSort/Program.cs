using System;

namespace InsertionSort
{
    class Program
    {
        private static int[] array = { 5, 2, 4, 6, 1, 3 };

        static void Main(string[] args)
        {
            int itemIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                itemIndex = i;

                while (itemIndex > 0 && array[itemIndex] < array[itemIndex - 1])
                {
                    Swap(itemIndex, itemIndex - 1);
                    itemIndex = itemIndex - 1;
                }
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
