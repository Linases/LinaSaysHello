using Microsoft.VisualBasic;
using System.ComponentModel;
using Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //List//
        //List<int> intList = new List<int>() { 5, 10, 12, 8, 7, 9, 45, 96, 36, 15 };
        //Console.WriteLine(ListsTask.SumOfEvenNumbers(intList));

        //List<string> strings = new List<string>() { "I", "am", "happy", "to code" };
        //ListsTask.OutputWords(strings, 5);
        //Console.WriteLine("Enter the length of a search term");
        //int enteredNr = int.Parse(Console.ReadLine());
        //ListsTask.OutputWords(strings, enteredNr);
        //Console.WriteLine();

        //// LinkedList// 

        //LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5, 3 });
        //int firstItem = 3;
        //int secondItem = 10;

        //LinkedListNode<int> currentNode = linkedList.First;
        //while (currentNode != null)
        //{
        //    if (currentNode.Value == firstItem)
        //    {
        //        linkedList.AddAfter(currentNode, secondItem);
        //    }
        //    currentNode = currentNode.Next;
        //}

        //foreach (int str in linkedList)
        //{
        //    Console.Write(str + " ");
        //}

        //List<int> list1 = new List<int> { 1, 3, 4, 7, 12 };
        //List<int> list2 = new List<int> { 1, 5, 7, 9 };

        //List<int> mergedList = LinkedListTask.MergeCommonElements(list1, list2);
        //Console.WriteLine("\nMerged list with common elements: " + string.Join(" ", mergedList));

        //Queue//
        //    Queue<int> numbers = new Queue<int>();

        //    Console.Write("Enter several numbers to the queue. Write 'OK' to finish queue:");

        //    try
        //    {
        //        while (true)
        //        {
        //            string input = Console.ReadLine();

        //            if (input.ToLower() == "ok")
        //                break;

        //            if (int.TryParse(input, out int value))
        //            {
        //                numbers.Enqueue(value);
        //            }
        //        }
        //    }
        //    catch (FormatException ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }

        //    Console.WriteLine("Max value in the queue: " + Queue.GetMaxValue(numbers));
        //    Console.WriteLine("Deleting max value from the queue...");
        //    Queue.DeleteMaxValue(numbers);
        //    Console.WriteLine("Max value after deletion: " + Queue.GetMaxValue(numbers));
        //}





        ///Stack//
        //Stack<char> stack = new Stack<char>();

        //Console.Write("Enter the first letter: ");
        //char letter1 = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine();

        //Console.Write("Enter the second letter: ");
        //char letter2 = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine();

        //Console.Write("Enter the third letter: ");
        //char letter3 = Convert.ToChar(Console.ReadLine());
        //Console.WriteLine();

        //stack.Push(letter1);
        //stack.Push(letter2);
        //stack.Push(letter3);

        //Console.Write("Letters in reverse order: ");
        //while (stack.Count > 0)
        //{
        //    Console.Write(stack.Pop());
        //}
        //Console.WriteLine();

        ////Dictionary//
        ////1//
        //Dictionary<string, int> person = new Dictionary<string, int>();

        //person.Add("Lina", 39);
        //person["Name"] = 25;
        //foreach (var items in person)
        //{
        //    Console.WriteLine($"{items.Key} {items.Value}");
        //}
        //var first = person.First();
        //Console.WriteLine($"{first.Key} {first.Value}");
        ////2//
        List<int> integerList = new List<int>() { 5, 10, 12, 8, 7, 9, 45, 96, 36, 15 };
        List<string> stringList = new List<string>() { "g", "gg", "f", "fr", "gfff", "hj", "idfh", "d", "gff", "da" };
        Dictionary.SortAndMerge(integerList, stringList);


        //3//
        Dictionary<string, City> cityDictionary = new Dictionary<string, City>();
        cityDictionary["Vilnius"] = new City(593436, 2.530);
        cityDictionary["Kaunas"] = new City(304459, 1.653);
        cityDictionary["Klaipeda"] = new City(158420, 98.2);
        cityDictionary["Siauliai"] = new City(108000, 81.13);
        cityDictionary["Panevezys"] = new City(89100, 50.1);

        var sortedCityDictionary = cityDictionary.OrderBy(kvp => kvp.Value.Area);


        foreach (var kvp in sortedCityDictionary)
        {
            Console.WriteLine($"City: {kvp.Key}");
            Console.WriteLine($"Area: {kvp.Value.Area} km²");
            Console.WriteLine();
        }
        var cityDictionarybyPopulation = cityDictionary.OrderByDescending(kvp => kvp.Value.Population);
        foreach (var kvp in cityDictionarybyPopulation)
        {
            Console.WriteLine($"City: {kvp.Key}");
            Console.WriteLine($"Area: {kvp.Value.Population} ");
            Console.WriteLine();
        }
        int totalPopulation = 0;
        foreach (var kvp in cityDictionary)
        {
            totalPopulation += kvp.Value.Population;
        }
        Console.WriteLine("Total Population of All Cities: " + totalPopulation);
            
    }
}







