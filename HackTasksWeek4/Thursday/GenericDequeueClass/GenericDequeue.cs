using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDequeueClass
{
    class GenericDequeue<T>
    {
        private List<T> dequeue = new List<T>();


        public GenericDequeue() { }

        public void Clear()
        {
            dequeue.Clear();
        }
        public bool Contains(T t)
        {
            if (dequeue.Contains(t))
                return true;
            else
                return false;
        }
        public T PeekFromFront()
        {
            T topObj;
            int len = dequeue.Count;
            if (dequeue.Count != 0)
            {
                topObj = dequeue[0];
            }
            else
            {
                topObj = default(T);
            }
            return topObj;
        }
        public T PeekFromBack()
        {
            T topObj;
            int len = dequeue.Count;
            if (dequeue.Count != 0)
            {
                topObj = dequeue[len-1];
            }
            else
            {
                topObj = default(T);
            }
            return topObj;
        }
        public T RemoveFromFront()
        {
            T removedObj;
            if (dequeue.Count != 0)
            {
                removedObj = dequeue[0];
            }
            else
            {
                removedObj = default(T);
                Console.WriteLine("Nothing to remove...The stack is empty");
            }
            dequeue.Remove(removedObj);
            return removedObj;
        }
        public T RemoveFromBack()
        {
            int len = dequeue.Count;
            T removedObj;
            if (dequeue.Count != 0)
            {
                removedObj = dequeue[len-1];
            }
            else
            {
                removedObj = default(T);
                Console.WriteLine("Nothing to remove...The stack is empty");
            }
            dequeue.Remove(removedObj);
            return removedObj;
        }
        public void AddToFront(T t)
        {
            dequeue.Insert(0, t);
        }
        public void AddToBack(T t)
        {
            int len = dequeue.Count;
            dequeue.Insert(len, t);
        }

    }
}
