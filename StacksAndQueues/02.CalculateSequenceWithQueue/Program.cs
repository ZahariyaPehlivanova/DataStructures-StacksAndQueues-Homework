namespace _02.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            var queue = new Queue<int>();

            queue.Enqueue(start);

            int n = 0;
            while (n <= 50)
            {
                queue.Enqueue(start + 1);
                queue.Enqueue(start * 2 + 1);
                queue.Enqueue(start + 2);

                int[] nextStart = queue.ToArray();
                start = nextStart[n + 1];

                n++;
            }

            for (int i = 0; i < queue.Count; i++)
            {
                Console.Write(queue.Dequeue() + ", ");
            }

            Console.WriteLine();
        }
    }
}
