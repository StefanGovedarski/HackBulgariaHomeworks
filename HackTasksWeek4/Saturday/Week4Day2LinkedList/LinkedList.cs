using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day2LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList()
        {
            var firstnode = new Node();
            firstnode.Value = 0;
            firstnode.Next = null;
            Head = firstnode;
        }

        public class Node
        {

            public object Value { get; set; }
            public Node Next { get; set; }


        }

        public Node Head { get; set; }

        public void Add(object content)
        {
            if(Head == null)
            {
                var node = new Node();
                node.Next = null;
                node.Value = 0;
                Head = node;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.Value = content;
                Node currentTemp = Head;
                while(currentTemp.Next != null)
                {
                    currentTemp = currentTemp.Next;
                }
                currentTemp.Next = toAdd;
            }
        }
        public void InsertAfter(object key , object value)
        {
            if (Head == null)
            {
                var node = new Node();
                node.Next = null;
                node.Value = value;
                Head = node;
            }
            else
            {
                var toAdd = new Node();
                toAdd.Value = value;
                Node current = Head;
                while (current.Value != key)
                {
                    current = current.Next;
                }
                Node nextone = current.Next;
                toAdd.Next = nextone;
                current.Next = toAdd;
            }
        }

        public void InsertBefore(object key, object value)
        {
            if (Head == null)
            {
                var node = new Node();
                node.Next = null;
                node.Value = value;
                Head = node;
            }
            else
            {
                Node current = Head;
                while (current.Next.Value != key)
                {
                    current = current.Next;
                }
                InsertAfter(current.Value, value);

            }
        }

        public int Count()
        {
            var currentNode = Head;
            int count = 0;
            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }
            return count;
        }

        public void Remove(object value)
        {
            var currentNode = Head;
            while(currentNode.Next.Value != value)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = currentNode.Next.Next;
        }
        public void InsertAt(int index,object value)
        {
            var node = new Node();
            node.Value = value;

            var count = 0;
            var currentNode = this.Head;
            if (index > this.Count() || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index == 0)
            {
                node.Next = this.Head;
                this.Head = node;
            }
            else
            {
                while (count < index - 1)
                {
                    currentNode = currentNode.Next;
                    count++;
                }
                var next = currentNode.Next;
                node.Next = next;
                currentNode.Next = node;
            }
        }
        public T this[int index]
        {
            get
            {
                var currentNode = this.Head;
                var count = 0;
                while (count <= index - 1)
                {
                    currentNode = currentNode.Next;
                    count++;
                }
                return (T)currentNode.Value;
            }
            set
            {
                var currentNode = this.Head;
                var count = 0;
                while (count <= index - 1)
                {
                    currentNode = currentNode.Next;
                    count++;
                }
                currentNode.Value = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.Head;

            while (current != null)
            {
                yield return (T)current.Value;
                current = current.Next;
            }

        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
