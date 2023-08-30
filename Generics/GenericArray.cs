using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericArray<T>

    {
        private T[] array;
        private int count;
        private int index;
        public GenericArray(int length)
        {
            array = new T[length];
            count = 0;
            index = 0;
        }

        public void AddObject(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    count++;
                    return;
                }
            }
        }

        public void Delete(T[] array, int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);

            Console.WriteLine(String.Join(", ", array));
        }
        public T GetItemByIndex(int index)
        {
            {
                return array[index];
            }
        }
        public int CountObjects() => count;
    }
}

