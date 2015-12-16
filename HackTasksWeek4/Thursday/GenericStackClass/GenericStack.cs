using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackClass
{
    class GenericStack<T>
    {
        private List<T> stack = new List<T>();

        public GenericStack(){}

        
        public T Peek()
        {
            T topObj;
            int len = stack.Count;
            if (stack.Count != 0)
            {
                topObj = stack[0];
            }
            else
            {
                topObj = default(T);
            }
            return topObj;
        }
        public T Pop()
        {
            T removedObj;
            if (stack.Count != 0)
            {
                removedObj = stack[0];
            }
            else
            {
                removedObj = default(T);
                Console.WriteLine("Nothing to remove...The stack is empty");
            }
            stack.Remove(removedObj);
            return removedObj;
        }
        public void Push(T objectToInsert)
        {
            stack.Insert(0, objectToInsert);
        }
        public void Clear()
        {
            stack.Clear();
        }
        public bool Contains(T objectToFind)
        {
            if(stack.Contains(objectToFind))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
