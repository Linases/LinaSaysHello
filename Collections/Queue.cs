using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal static class Queue
    {

        public static int GetMaxValue(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int maxValue = queue.Peek();
            if (queue.Count == 1)
            {
                return maxValue;
            }

            Queue<int> tempQueue = new Queue<int>();
            while (queue.Count > 0)
            {
                int value = queue.Dequeue();
                if (value > maxValue)
                {
                    maxValue = value;
                }
                tempQueue.Enqueue(value);
            }

            while (tempQueue.Count > 0)
            {
                queue.Enqueue(tempQueue.Dequeue());
            }
            return maxValue;
        }

        public static Queue<int> DeleteMaxValue(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int maxValue = GetMaxValue(queue);

            Queue<int> newQueue = new Queue<int>();
            foreach (int value in queue)
            {
                if (value != maxValue)
                {
                    newQueue.Enqueue(value);
                }
            }
            return newQueue;
        }
    }
}

