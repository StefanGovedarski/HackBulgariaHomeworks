using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NotifyCollection
{
    class NotifyCollection : ArrayList
    {
        delegate  int MyDel (int x);
        delegate void MyRemoveDel(int x);
        delegate void MyReplaceDel(int x, int y);


        public override int Add(object value)
        {
            MyDel del1 = x => base.Add(x);
            return del1((int)value);
        }

        public override void Remove(object obj)
        {
            MyRemoveDel del2 = x => base.Remove(x);
            if (base.Contains(obj))
            {
                del2((int)obj);
            }
            else
            {
                Console.WriteLine("item does not exist");
            }

        }

        public void Replace(int index, object value)
        {
            MyReplaceDel del3 = (x,y) =>
            {
                base.Remove(x);
                base.Insert(x, y);
            };
            if (base.Count > index)
            {
                del3(index,(int)value);
            }
            else
            {
                Console.WriteLine("item does not exist");
            }
        }

        public override object this[int index]
        {
            get
            {
                return base[index];
            }

            set
            {
                base[index] = value;
            }
        }
    }
}

