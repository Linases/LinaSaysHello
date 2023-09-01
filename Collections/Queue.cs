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
            int[] inputs = queue.ToArray();
            int maxValue = inputs[0];

            foreach (int value in inputs)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }

        public static void DeleteMaxValue(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int maxValue = GetMaxValue(queue);

            Queue<int> newQueue = new Queue<int>();
            foreach (int value in queue)
            {
                if (!queue.Contains (maxValue))
                {
                    newQueue.Enqueue(value);
                    Console.WriteLine(newQueue);
                }
               
            }
          
        }
    }
}
    
