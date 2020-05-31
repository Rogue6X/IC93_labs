using System;
using System.Collections;
using System.Collections.Generic;

namespace oop7sh
{
    public class LinkedList<T> : IEnumerable<T> 
    {
        Node<T> head;
        Node<T> tail;
        static private int count = 0 ;
        
        private class Node<T>
        {
            public Node(T data)
            {
                Data = data;
            }
            public T Data { get; set; }
            public Node<T> Next { get; set; }
        }
        public int Count { get { return count; } }
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public void Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    count--;
                    break;
                }

                previous = current;
                current = current.Next;
            }
        }
        public int FindPi(LinkedList<float> list)
        {
            int numb = 0;
            foreach (float item in list)
            {
                if (item > Math.PI)
                {
                    numb+=1;
                }
            }
            return numb;

        }
        
        public void BiggerAverageDelete(LinkedList<float> list)
        {
            float avr = 0;
            foreach (float item in list)
            {
                avr += item;
            }
            avr /= count;
            Console.WriteLine("Average is "+avr+"\n");
            foreach (float item in list)
            {
                if (item > avr)
                {
                    list.Remove(item);
                }
            }
        }
        public void AppendSecond(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tmp = head.Next;
            head.Next = node;
            node.Next = tmp;
            count++;
        }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        
    }
    class Program
    {
        static void Main()
        {
            LinkedList<float> linkedList = new LinkedList<float>();
            linkedList.Add(2);
            linkedList.Add(12);
            linkedList.Add(6);
            linkedList.Add(8);
            Console.WriteLine("Added 2, 12, 6, 8");
            Out(linkedList);

            Console.WriteLine("Removing 6");
            linkedList.Remove(6);
            Out(linkedList);
            Console.WriteLine("Adding 10 as the second element");
            linkedList.AppendSecond(10);
            Out(linkedList);

            Console.WriteLine("Number of elements > 3.14 - " + linkedList.FindPi(linkedList));
            Console.WriteLine("Delete elements bigger than average");
            linkedList.BiggerAverageDelete(linkedList);
            Out(linkedList);
        }
        static public void Out(LinkedList<float> name)
        {
            foreach (float item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}