using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArray
{
    public class QueueArray
    {
        private readonly int[] data;
        private int front;
        private int rear;
        private int size;

        public int Front => front;
        public int Rear => rear;

        /// <summary>
        /// Gets an element at the specified index in the data array
        /// </summary>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= data.Length)
                    throw new IndexOutOfRangeException($"Index {index} is out of range.");
                return data[index];
            }
        }

        public QueueArray(int n) 
        {
            data = new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }


        /// <summary>
        /// Get Queue lenght
        /// </summary>
        /// <returns></returns>
        public int Lenght() => size;


        /// <summary>
        /// Get Queue size
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => size == 0;


        /// <summary>
        /// Check wether queue is full or not
        /// </summary>
        /// <returns></returns>
        public bool IsFull() => size == data.Length;


        /// <summary>
        /// Add element to rear of Queue
        /// </summary>
        /// <param name="e"></param>
        public void Enqueue(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                data[rear] = e;
                rear++;
                size++;
            }
        }


        /// <summary>
        /// Remove element from front of queue
        /// </summary>
        /// <returns></returns>
        public int Dequeue() 
        {
            if (IsEmpty()) 
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int e = data[front];
                front++;
                size--;
                return e;
            }
        }


        /// <summary>
        /// Get first element from queue without
        /// removing it
        /// </summary>
        /// <returns></returns>
        public int First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else 
            { 
                return data[front]; 
            }    
        }

        }
}
