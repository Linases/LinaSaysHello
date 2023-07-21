using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaSaysHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What’s your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
            Console.ReadLine();
        }
    }
} 
