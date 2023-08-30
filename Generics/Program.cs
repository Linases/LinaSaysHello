using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

internal class Program
{
    private static void Main(string[] args)
    {
        GenericArray<string> array = new GenericArray<string>(5);
        array.AddObject("one");
        array.AddObject("two");
        array.AddObject("three");

        array.CountObjects();
        Console.WriteLine(array.CountObjects());
        Console.WriteLine(array.GetItemByIndex(0));

       array.Delete (array,0);


    }
}