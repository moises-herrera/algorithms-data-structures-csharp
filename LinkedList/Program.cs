using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new LinkedList();

            myList.Add(3);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);
            myList.Add(11);
            myList.Add(15);

            myList.Transverse();

            Console.WriteLine(myList[3]);
        }
    }
}
