using System.Diagnostics.Metrics;
using System.Numerics;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace AqaLabHomeworkFilesStorage.Task8
{
    public class ExceptionsHandling
    {
        public static void ShowArrayElement()
        {
            var array = new int[] { 8, 7, 1, 4, 2 };
            while (true)
            {
                Console.WriteLine("Input index of element in array:");
                var inputedValue = Console.ReadLine();
                try
                {
                    var elementIndex = inputedValue.Equals(string.Empty) ? null : inputedValue;

                    if (int.Parse(elementIndex) < 0)
                    {
                        throw new NegativeIndexException("Negative number is not allowed. Please enter a positive integer index.");
                    }

                    int parsedElementIndex = int.Parse(elementIndex);
                    int elementOfarrayByIndex = array[parsedElementIndex];
                    Console.WriteLine($"Array element that has index {inputedValue} has value {elementOfarrayByIndex}");
                    return;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error!:" + ex.Message + "Please enter a valid integer index");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Error!: Input can not be empty. Please enter a valid integer index");
                }
                catch (NegativeIndexException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

}

