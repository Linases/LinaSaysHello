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
            //Task1//
            int num = 20;
            num += 5;

            Console.WriteLine("Variable:" + num);

            //Task2//

            Console.Write("Enter a 4 digit number of days: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int years = number / 365;
            int months = (number - years * 365) / 30;
            int days = (number - years * 365) - months * 30;

            Console.WriteLine("This number represents: " + years + " years " + months + " months " + days + " days");

            //Task3//
            
            Console.Write("Enter a random number: ");
            int randomNumber = Convert.ToInt32(Console.ReadLine());
            int result = (randomNumber + randomNumber * 2);
            Console.WriteLine("{0} + {1}*2 = {2}", randomNumber, randomNumber, result);

            // Task 4//
            /*
            //every variable can be named by var type
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
            int randomNumber1 = Convert.ToInt32(Console.ReadLine());
            if (randomNumber1 % 2 == 0)
            {
                Console.WriteLine(randomNumber1 + " is an even number");
            }
            else
            {
                Console.WriteLine(randomNumber1 + " is an odd number ");
            }
            Console.ReadLine();
        }
    }
}
