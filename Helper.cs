using System;

namespace QueueArray
{
    internal static class Helper
    {
        /// <summary>
        /// Print queue contents
        /// </summary>
        public static void Display(QueueArray queue)
        {
            Console.WriteLine($"Queue Size: {queue.Lenght()}");
            Console.WriteLine($"Front: {queue.Front}, Rear: {queue.Rear}");
            for (int i = queue.Front; i < queue.Rear; i++)
            {
                Console.Write($"{queue[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
