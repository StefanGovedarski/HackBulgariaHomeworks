using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2DynamicArray
{
    class DynamicArray<T>
    {
        private int capacity;
        private T[] array;
        private int count;

        public DynamicArray(int size)
        {
            if (size > 2048)
            {
                size = 256;
            }
            array = new T[size];
            capacity = size;
            count = 0;
        }
        public DynamicArray()
        {
            array = new T[10];
            capacity = 10;
            count = 0;
        }
        public int Capacity { get { return capacity; } }
        public int Count { get { return count; } }

        private bool Checker()
        {
            if (array.Length >= 1024)
            {
                return false;
            }
            else return true;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(T value)
        {
            int index = -1;
            if (!(Contains(value)))
            {
                return index;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Equals(value))
                    {
                        index = i;
                    }
                }
                return index;
            }
        }
        public void Add(T value)
        {
            if (capacity <= 0 && Checker())
            {
                T[] temp = array;
                array = new T[array.Length * 2];
                for (int i = 0; i < temp.Length; i++)
                {
                    array[i] = temp[i];
                }
                count = temp.Length;
                capacity = array.Length - temp.Length;
            }
            else if (capacity <= 0 && Checker() == false)
            {
                T[] temp = array;
                array = new T[array.Length + 256];
                for (int i = 0; i < temp.Length; i++)
                {
                    array[i] = temp[i];
                }
                count = temp.Length;
                capacity = array.Length - temp.Length;
            }
            else
            {
                array[count] = value;
                count++;
                capacity--;
            }
        }
        public void InsertAt(int index , T value)
        {
            if (capacity<= 0 && Checker())
            {
                T[] temp = array;
                array = new T[array.Length * 2];
                for (int i = 0; i < temp.Length; i++)
                {
                    array[i] = temp[i];
                }
                count = temp.Length;
                capacity = array.Length - temp.Length;
            }
            else if(capacity <= 0 && Checker()==false)
            {
                T[] temp = array;
                array = new T[array.Length + 256];
                for (int i = 0; i < temp.Length; i++)
                {
                    array[i] = temp[i];
                }
                count = temp.Length;
                capacity = array.Length - temp.Length;
            }
            else
            {
                array.ToList<T>().Insert(index, value);
                array.ToArray<T>();
                count++;
                capacity--;
            }
        }
        public void Remove(T value)
        {
            array.ToList<T>().Remove(value);
            array.ToArray<T>();
        }
        public void RemoveAt(int index)
        {
            array.ToList<T>().RemoveAt(index);
            array.ToArray<T>();
        }
        public void Clear()
        {
            array = new T[10];
        }
        public T this[int i]
        {
            get
            { return array[i]; }
            set
            { array[i] = value; }
        }
        public T[] ToArray()
        {
            T[] newArr = new T[array.Length];
            newArr = array;
            return newArr;
        }
        public void Print()
        {
            for(int i=0; i< array.Length;i++)
            {
                Console.WriteLine("{0} -> {1}",i,array[i]);
            }
        }
    }
}
