using Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class LinkedListTask
    {
        public static List<int> MergeCommonElements(List<int> list1, List<int> list2)
        {
            List<int> result = new List<int>();

            foreach (int num in list1)
            {
                if (list2.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result;
        }
    }
}
