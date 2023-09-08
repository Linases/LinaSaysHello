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
       
        public GenericArray()
        {
            array = new T[0];
        }

        public void AddObject(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
            
        }

        public void Delete(int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }
        public T GetItemByIndex(int index)
        {
            {
                return array[index];
            }
        }
        public int CountObjects() => array.Length;

        public override string ToString()
        {
            return String.Join(", ", array);
        }
    }
}

