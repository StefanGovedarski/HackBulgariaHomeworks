using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day2Map
{
    class Map<K,U>
    {
        private DynamicArray<K> keys;
        private DynamicArray<U> values;
        public Map()
        {
            this.keys = new DynamicArray<K>();
            this.values = new DynamicArray<U>();
        }
        public void Add(K key, U value)
        {
            if (key.Equals(0) || key.Equals(null))
            {
                throw new ArgumentException("The key cant be zero!");
            }
            if (keys.Contains(key))
            {
                throw new ArgumentException("An element with the same key already exists in the Dictionary");
            }

            keys.Add(key);
            values.Add(value);
        }

        public bool ContainsKey(K key)
        {
            return keys.Contains(key);
        }

        public bool ContainsValue(U value)
        {
            return values.Contains(value);
        }

        public void Remove(K key)
        {
            if (keys.Contains(key))
            {
                var value = this[key];
                this.keys.Remove(key);
                this.values.Remove(value);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }

        public U this[K key]
        {
            get
            {
                if (keys.Contains(key))
                {
                    var index = keys.IndexOf(key);

                    return values[index];
                }
                throw new KeyNotFoundException();
            }
            set
            {
                if (key.Equals(0))
                {
                    throw new Exception("The key cant be zero!");
                }
                if (keys.Contains(key))
                {
                    var index = keys.IndexOf(key);
                    values[index] = value;
                }
                else
                {
                    keys.Add(key);
                    values.Add(value);
                }
            }
        }


        //copy of the dynamic array class
        private class DynamicArray<T>
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
            public void InsertAt(int index, T value)
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
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("{0} -> {1}", i, array[i]);
                }
            }
        }
    }
}
