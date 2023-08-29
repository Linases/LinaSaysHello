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
        public GenericArray(int length)
        {
            array = new T[length];
            count = 0;
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
                else
                {
                    Console.WriteLine("Not possible to add. Array is already full.");
                }
            }
        }
        public void RemoveObject<T>(ref T[] arr, int index)
        {
            for (int i = index; i < arr.Length - 1; i++)
            {

                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
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

