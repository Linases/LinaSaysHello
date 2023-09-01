using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal static class Dictionary
    {
        public static void SortAndMerge(List<int> list, List<string> stringList)
        {
            list.Sort();
            stringList.Sort();
            stringList.Reverse();
            Dictionary<int, string> mergedDict = new Dictionary<int, string>();

            for (int i = 0; i < list.Count; i++)
            {
                mergedDict[list[i]] = stringList[i];
            }

            foreach (var elements in mergedDict)
            {
                Console.WriteLine($"{elements.Key}: {elements.Value}");
            }
        }
    }
}
