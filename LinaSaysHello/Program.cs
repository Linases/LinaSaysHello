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

            int[] numArray = { 3, 5, 9, 8, 15 };


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
             string[] words = { "Hello", "World" };
            for (int i = 0; i < words.Length; i++)
            {
               
                {

                }

    
            }
                ////Task 9//
            ////Write to the console a multiplication table for numbers from 1 to 10.

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + (i * j));
                }
            }

        }

    }

}







