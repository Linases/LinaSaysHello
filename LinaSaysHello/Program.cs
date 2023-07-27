using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
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
            ////Task 1//
            Console.Write("Enter any positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;

            }
            Console.WriteLine("Result: " + sum);


            //Task2//
            // Using a while loop write the multiplication table for the number 3 to the console.


            int number_3 = 3;
            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine("3 x " + counter + " = " + (counter * number_3));
                counter++;
            }
        }

    }

}







