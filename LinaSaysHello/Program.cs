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
            //Task1//
            var num = 20;
            num += 5;

            Console.WriteLine($"Variable: {num}");

            //Task2//

            Console.Write("Enter a 4 digit number of days: ");
            var number = Convert.ToInt32(Console.ReadLine());
            var daysInYear = 365;
            var daysInMonth = 30;

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
            var years = number / daysInYear;
            var months = (number - years * daysInYear) / daysInMonth;
            var days = (number - years * daysInYear) - months * daysInMonth;

            Console.WriteLine($"This number represents: {years} years {months} months {days} days");

            //Task3//
            // Task 3//
            Console.Write("Enter a random number: ");
            var randomNumber1 = Convert.ToDecimal(Console.ReadLine());
            String result1 = (randomNumber1 % 2 == 0) ? "even number" : "odd number";
            Console.WriteLine("{0} is {1}", randomNumber1, result1);

            Console.Write("Enter a random number: ");
            var randomNumber = Convert.ToDecimal(Console.ReadLine());
            var result = (randomNumber + randomNumber * 2);
            Console.WriteLine("{0} + {1} * 2 = {2}", randomNumber, randomNumber, result);

            //Task 4//

            /*every variable can be named by var type
            sbyte num1 = -34; //small number
            int num2 = 4; // integer type number
            string word = "Hello";// word
            char chacacter = 'R'; // one symbol
            decimal num3 = 23.093433222m;// most precise;
            int num4 = 40000;
            bool statement = true;// represents statement
            int num5 = 0; //integer type number
            */

            //Task 5//
            Console.Write("Enter a random number: ");
            var randomNumber1 = Convert.ToDecimal(Console.ReadLine());
            if (randomNumber1 % 2 == 0)
            {
                Console.WriteLine(randomNumber1 + " is an even number");
            }
            else
            {
                Console.WriteLine(randomNumber1 + " is an odd number ");
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
