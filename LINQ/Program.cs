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
        Console.WriteLine();
        //3//
        int[] array = new int[4] { 9, 8, 6, 5 };
        var sqrNumbers = from s in array
                         select "{ Number = " + s + ", SqrNo = " + (s * s) + " }";
        foreach (var s in sqrNumbers)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        //4//
        int[] array2 = new int[6] { 5, 5, 5, 9, 9, 1 };

        var totalFives = array2.Count(s => s == 5);
        var totalNines = array2.Count(s => s == 9);
        var totalOnes = array2.Count(s => s == 1);

        Console.WriteLine("The number and the Frequency are: ");
        Console.WriteLine("Number 5 appeares {0} times ", totalFives);
        Console.WriteLine("Number 9 appeares {0} times ", totalNines);
        Console.WriteLine("Number 1 appeares {0} times ", totalOnes);

        //5//
        List<string> cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        var startsAEndsM = cities.FirstOrDefault(s => s.StartsWith('A') && s.EndsWith('M'));
        

        Console.WriteLine("Cities starts with 'A' and ends with 'M':{0}", startsAEndsM);
        //6//

        Console.WriteLine();
        //7// 
        List<string> cities2 = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        var orderedList = from c in cities2
                          orderby c.Count(), c
                          select c;

        foreach (string s in orderedList)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine();
        //8//
        List<string> foods = new List<string>() { "Honey", "Butter", "Butter", "Butter", "Honey", "Brade", "Biscuit", "Biscuit" };
        var orderByAscending = from s in foods.Distinct()
                               orderby s
                               select s;
        foreach (string s in orderByAscending)
        {
            Console.WriteLine(s);
        }


    }
}