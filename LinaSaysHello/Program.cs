using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinaSaysHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////Task 1//
            //Console.Write("Enter any positive number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;

            //}
            //Console.WriteLine("Result: " + sum);


            ////Task2//

            //int number_3 = 3;
            //int counter = 0;

            //while (counter <= 10)
            //{
            //    Console.WriteLine("3 x " + counter + " = " + (counter * number_3));
            //    counter++;
            //}

            //Task 3//
            //Create an array of numbers[3, 5, 9, 8, 15].Find the product of these numbers and write the result to the console.

            //int[] numArray = { 3, 5, 9, 8, 15 };
            //int value = 1;
            //for (int i = 0; i < numArray.Length; i++)
            //{
            //    value = value * numArray[i];
            //    Console.WriteLine(value);
            //}

            //Task 4//
            //Write a program that calculates how many times 2048 must be divided by 2 to make it less than 10.

            //int number_2048 = 2048;
            //int divisionTimes = 0;
            //int result = number_2048 / 2;
            //while (result > 10)
            //{
            //    Console.WriteLine("Number after division: " + result);
            //    result /= 2;
            //    divisionTimes++;
            //}
            //Console.WriteLine(" It took " + divisionTimes + " times to divite 2048 by 2 till it's less than 10");

            //Task 5//

            //Create an array of strings.Write a program that analyzes a created array and, if there is a string with the value “Hello”, displays the word “Labas!” in console and leaves the loop once it is found.
            // string[] words = { "Hello", "World" };
            //for (int i = 0; i < words.Length; i++)
            //{

            //}

            //Task 6//
            //Create an array of numbers.Write a program that calculates the sum
            //of the first and last element of an array and writes it to the console


            //int[] arrNumbers = { 4, 6, 8, 9, 10, 11 };
            //for (int i = 0; i < arrNumbers.Length; i++)
            //{
            //    Console.Write(arrNumbers[i] + " ");
            //}
            //Console.WriteLine("\nSum of first and last element is: " + (arrNumbers[0] += arrNumbers[arrNumbers.Length - 1]));

            //Task7//????
            // Create an array of numbers.Find the sum of indexes of minimum and maximum array elements.
            //    int[] arrNumbers1 = { 4, -6, 8, 900, 20, 11 };

            //    for (int i = 0; i < arrNumbers1.Length; i++)
            //    {
            //        Console.WriteLine(arrNumbers1[i]);
            //    }
            //    int max = arrNumbers1[0];
            //    int min = arrNumbers1[0];
            //    for (int i = 0; i <= arrNumbers1.Length - 1; i++)
            //    {
            //        if (arrNumbers1[i] > max)
            //        {
            //            max = arrNumbers1[i];
            //        }
            //        if (arrNumbers1[i] < min)
            //        {
            //            min = arrNumbers1[i];
            //        }
            //    }
            //    Console.WriteLine("The sum of indexes of minimum and maximum array elements is: " + (min += max));
            //}
            //Task8//
            //Create an array of numbers and sort its elements in ascending order(without using function Sort).
            int[] arrNumbers2 = { 4, -6, 8, 900, 20, 11 };
            foreach (int value1 in arrNumbers2)
            {
                Console.Write(value1 + " ");
            }
            int temporar;

            // traverse 0 to array length
            for (int i = 0; i < arrNumbers2.Length - 1; i++)

                // traverse i+1 to array length
                for (int j = i + 1; j < arrNumbers2.Length; j++)

                    // compare array element with
                    // all next element
                    if (arrNumbers2[i] > arrNumbers2[j])
                    {

                        temporar = arrNumbers2[i];
                        arrNumbers2[i] = arrNumbers2[j];
                        arrNumbers2[j] = temporar;
                    }
            Console.WriteLine("\nNumbers in asccending order:");
            // print all element of array
            foreach (int value2 in arrNumbers2)
            {
                Console.Write(value2 + " ");
            }
            //    ////Task 9//
            //////Write to the console a multiplication table for numbers from 1 to 10.

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine(i + " * " + j + " = " + (i * j));
        }
    }
}













