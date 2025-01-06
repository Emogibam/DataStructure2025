using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class SinglyLinkedList<T>
    {
        private Node<T>? head;

        public void Insert(T data)
        {
            var newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Delete(T data)
        {
            if (head == null) return;

            if (head.Data!.Equals(data))
            {
                head = head.Next;
                return;
            }

            var current = head;
            while (current.Next != null && !current.Next.Data!.Equals(data))
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
        }

        public bool Search(T data)
        {
            var current = head;
            while (current != null)
            {
                if (current.Data!.Equals(data)) return true;
                current = current.Next;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Reverse()
        {
            Node<T>? prev = null;
            var current = head;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public void Display()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

}
