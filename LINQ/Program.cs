using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //1//
        List<int> ints = new List<int>() { 0, 4, 8, 12, 16 };
        for (int i = 0; i < ints.Count; i++)
        {
            ints[i] /= 2;

        }
        var devidedByTwo = from s in ints
                           where s % 2 == 0
                           select s;
        foreach (var s in devidedByTwo)
        {
            Console.Write(s + " ");

        }
        Console.WriteLine();

        //2//
        List<int> ints2 = new List<int>() { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
        var positiveNumbers = from s in ints2
                              where s > 0
                              where s < 12
                              select s;
        foreach (var s in positiveNumbers)
        {
            Console.Write(s + " ");
        }
        //3//
        int[] array = new int[4] { 9, 8, 6, 5 };
        Console.WriteLine();
        //4//
        int[] array2 = new int[6] { 5, 5, 5, 9, 9, 1 };

        var totalFives = array2.Count(s => s == 5);
        var totalNines = array2.Count(s => s == 9);
        var totalOnes = array2.Count(s =>s == 1);

        Console.WriteLine("The number and the Frequency are: ");
        Console.WriteLine("Number 5 appeares {0} times ", totalFives);
        Console.WriteLine("Number 9 appeares {0} times ", totalNines);
        Console.WriteLine("Number 1 appeares {0} times ", totalOnes);

        List<string> cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
        var startsA = cities.FirstOrDefault(s => s.Contains('A'));
        //var endsM = cities.LastOrDefault(s => s.Contains('M'));

       Console.WriteLine("Cities starts with 'A' and ends with 'M':{0}", startsA);

      

    }
}