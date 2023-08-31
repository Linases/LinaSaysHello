using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class List<T>
    {
        public List()
        {

        }

        public static int SumOfEvenNumbers()
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0) // Check if the number is even
                {
                    sum += number; // Add the even number to the sum
                }
            }

            return sum;
        }




    }
}
