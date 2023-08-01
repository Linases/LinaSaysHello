using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LinaSaysHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1//
            Console.Write("Enter first number: ");
            var enteredNr1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter second number: ");
            var enteredNr2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter one aritmetic operation: +, -, *, /");
            char aritmeticOperation = Convert.ToChar(Console.ReadLine());

            switch (aritmeticOperation)
            {
                case '+':
                    {
                        var result = enteredNr1 + enteredNr2;
                        Console.WriteLine("{0} + {1} = {2}", enteredNr1, enteredNr2, result);
                    }
                    break;
                case '-':
                    {
                        var result = enteredNr1 - enteredNr2;
                        Console.WriteLine("{0} - {1} = {2}", enteredNr1, enteredNr2, result);
                    }
                    break;
                case '*':
                    {
                        var result = enteredNr1 * enteredNr2;
                        Console.WriteLine("{0} * {1} = {2}", enteredNr1, enteredNr2, result);
                    }
                    break;
                case '/':
                    {
                        var result = enteredNr1 / enteredNr2;
                        Console.WriteLine("{0} / {1} = {2}", enteredNr1, enteredNr2, result);
                    }
                    break;
                default:
                    Console.WriteLine("Operation is not present in the list of allowed operations");
                    break;
            }

            //Task 2//

            Console.Write("Enter a random number: ");
            var a = Convert.ToDecimal(Console.ReadLine());
            if (a == 0 || a == 15)
            {
                Console.WriteLine("Partly working!");
            }
            else if (a < 50 && a != 37 && a >= 32)
            {
                Console.WriteLine("Working!");
            }
            else
            {
                Console.WriteLine("Does’t work");
            }

            // Task 3//
            Console.Write("Enter a random number: ");
            var randomNumber1 = Convert.ToDecimal(Console.ReadLine());
            String result1 = (randomNumber1 % 2 == 0) ? "even number" : "odd number";
            Console.WriteLine("{0} is {1}", randomNumber1, result1);

            Console.ReadLine();
        }
    }
}
