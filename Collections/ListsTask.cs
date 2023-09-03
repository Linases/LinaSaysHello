using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal static class ListsTask
    {
   
        public static int SumOfEvenNumbers(List <int> intList)
        {
            int sum = 0;

            foreach (int number in intList)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        public static void OutputWords(List<string> list, int length)
        {
            try
            {

                foreach (string word in list)
                {
                    if (word.Length == length)
                    {
                        Console.WriteLine(word);
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

    }
}



