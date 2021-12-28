using System;

namespace DataStructures
{
    class Node
    {
        private int data;
        private Node next;

        public int Data { get => data; set => data = value; }
        internal Node Next { get => next; set => next = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", data);
        }
    }
}