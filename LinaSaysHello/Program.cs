using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
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
            //Task 1//
            Console.Write("Enter any positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;

            }
            Console.WriteLine("Result: " + sum);

            //Task2//

            int number_3 = 3;
            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine("3 x " + counter + " = " + (counter * number_3));
                counter++;
            }

            //Task 3//

            int[] numArray = { 3, 5, 9, 8, 15 };
            int value = 1;
            for (int i = 0; i < numArray.Length; i++)
            {
                value *=numArray[i];
               
            } Console.WriteLine(value);

            // Task 4//

            int divisionTimes = 0;
            int result = 2048;

            do
            {
                divisionTimes++;
                result /= 2;
                Console.WriteLine("Number after division: " + result);
            }
            while (result > 10);

            Console.WriteLine(" It took " + divisionTimes + " times to divite 2048 by 2 till it's less than 10");

            //  Task 5//
            string[] words = { "yes", "Hello", "Other", "Words" };

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");

            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Hello")
                {
                    Console.Write("\nLabas! ");
                    continue;
                }
            }
            // Task 6//
            int[] arrNumbers = { 4, 6, 8, 9, 10, 11 };
            for (int i = 0; i < arrNumbers.Length; i++)
            {
                Console.Write("\n " + arrNumbers[i] + " ");
            }
            Console.WriteLine("\nSum of first and last element is: " + (arrNumbers[0] += arrNumbers[arrNumbers.Length - 1]));

            //   Task7//
            int[] arrNumbers1 = { -10, 20, 100, 1000 };

            for (int i = 0; i < arrNumbers1.Length; i++)
            {
                Console.Write(arrNumbers1[i] + " ");
            }
            int max = arrNumbers1[0];
            int min = arrNumbers1[0];
            for (int i = 0; i < arrNumbers1.Length; i++)
            {
                if (arrNumbers1[i] > max)
                {
                    max = arrNumbers1[i];
                }
                if (arrNumbers1[i] < min)
                {
                    min = arrNumbers1[i];
                }
            }
            int indexSum=0;
            for (int i = 0; i < arrNumbers1.Length; i++)
            {
                if (arrNumbers1[i] == min)
                {
                    Console.WriteLine($"\nMinumum element index : {i}");
                    indexSum+=i;
                    continue;
                }
                if (arrNumbers1[i] == max)
                {
                    Console.WriteLine($"Maximum element index : {i}");
                    indexSum += i;
                }
            }
            Console.WriteLine($"Sum of Min and Max indexes: {indexSum}");

            //Task8//
            int[] arrNumbers2 = { 4, -6, 8, 900, 20, 11 };
            foreach (int value1 in arrNumbers2)
            {
                Console.Write(value1 + " ");
            }

            int temporar;

            for (int i = 0; i < arrNumbers2.Length - 1; i++)
            {
                for (int j = i + 1; j < arrNumbers2.Length; j++)
                {
                    if (arrNumbers2[i] > arrNumbers2[j])
                    {

                        temporar = arrNumbers2[i];
                        arrNumbers2[i] = arrNumbers2[j];
                        arrNumbers2[j] = temporar;
                    }
                }

            }

            Console.WriteLine("\nNumbers in asccending order:");
            foreach (int value2 in arrNumbers2)
            {
                Console.Write(value2 + " ");
            }
            Console.WriteLine();

            //Task 9//

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }

            //Task10//

            int[,] array2d = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.Write(array2d[0, 0] + " ");
            Console.Write(array2d[0, 1] + " ");
            Console.WriteLine(array2d[0, 2] + " ");
            Console.Write(array2d[1, 0] + " ");
            Console.Write(array2d[1, 1] + " ");
            Console.WriteLine(array2d[1, 2] + " ");
            Console.Write(array2d[2, 0] + " ");
            Console.Write(array2d[2, 1] + " ");
            Console.WriteLine(array2d[2, 2] + " ");

            // Task 11//
            int[] array1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Resize(ref array1, array1.Length + 1);
            array1[array1.Length - 1] = 11;

            int[] newArray1 = new int[] { -1 };
            array1 = newArray1.Concat(array1).ToArray();

            int[] newArray2 = new int[] { 12 };
            array1 = array1.Take(4).Concat(newArray2).Concat(array1.Skip(4)).ToArray();

            array1 = array1.Skip(1).ToArray();

            int[] array2 = { 100, 200, 300 };
            int[] combinedAarray = array1.Concat(array2).ToArray();
            foreach (var item in combinedAarray)
            {
                Console.Write("{0} ", item);
            }
        }

    }
}



















