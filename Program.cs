using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            QueueArray q = new QueueArray(10);

            Console.WriteLine($"Add elements 1,2,3");
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Helper.Display(q);
            Console.WriteLine($"First :{q.First()}");
            Console.WriteLine();

            Console.WriteLine($"Dequeue two elements");
            q.Dequeue();
            q.Dequeue();
            Helper.Display(q);
            Console.WriteLine($"First :{q.First()}");

            Console.ReadLine();
        }
    }
}
