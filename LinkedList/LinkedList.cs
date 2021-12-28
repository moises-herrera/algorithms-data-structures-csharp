using System;

namespace DataStructures
{
    class LinkedList
    {
        private Node head;
        private Node current;
        private Node aux;

        public LinkedList()
        {
            head = new Node();
            head.Next = null;
        }

        public void Transverse()
        {
            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                int data = current.Data;

                Console.Write($"{data}, ");
            }

            Console.WriteLine("\n");
        }

        public void Add(int data)
        {
            current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            var temp = new Node();

            temp.Data = data;
            temp.Next = null;
            current.Next = temp;
        }

        public void Clear()
        {
            head.Next = null;
        }

        public bool IsEmpty()
        {
            if (head.Next == null)
                return true;

            return false;
        }

        public Node Search(int data)
        {
            if (IsEmpty())
                return null;

            aux = head;

            while (aux.Next != null)
            {
                aux = aux.Next;

                if (aux.Data == data)
                    return aux;
            }

            return null;
        }

        public int SearchIndex(int data)
        {
            int index = -1;

            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                index++;

                if (current.Data == data)
                    return index;
            }

            return -1;
        }

        public Node SearchPrevious(int data)
        {
            aux = head;

            while (aux.Next != null && aux.Next.Data != data)
                aux = aux.Next;

            return aux;
        }

        public void Delete(int data)
        {
            if (IsEmpty())
                return;

            Node previous = SearchPrevious(data);
            Node found = Search(data);

            if (found == null)
                return;

            previous.Next = found.Next;
            found.Next = null;
        }

        public void Insert(int position, int value)
        {
            current = Search(position);

            if (current == null)
                return;

            var temp = new Node();
            temp.Data = value;
            temp.Next = current.Next;

            current.Next = temp;
        }

        public void InsertAtFirst(int value)
        {
            var temp = new Node();
            temp.Data = value;

            temp.Next = head.Next;
            head.Next = temp;
        }

        public Node GetByIndex(int position)
        {
            Node result = null;
            int index = -1;

            current = head;

            while (current.Next != null)
            {
                current = current.Next;
                index++;

                if (index == position)
                    result = current;
            }

            return result;
        }

        public int this[int index]
        {
            get
            {
                current = GetByIndex(index);

                if (current != null)
                {
                    return current.Data;
                }

                return -1;
            }

            set
            {
                current = GetByIndex(index);

                if (current != null)
                {
                    current.Data = value;
                }
            }
        }

        public int Count()
        {
            current = head;
            int counter = 0;

            while (current.Next != null)
            {
                current = current.Next;
                counter++;
            }

            return counter;
        }
    }
}