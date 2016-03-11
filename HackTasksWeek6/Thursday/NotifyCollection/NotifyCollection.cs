using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NotifyCollection
{
    class NotifyCollection : ArrayList, INotifyPropertyChanged
    {

        private enum Changes { AddedItem, RemovedItem, ReplacedItem, ChangedItem, ItemDoesNotExist };
        public event PropertyChangedEventHandler PropertyChanged;

        public override int Add(object value)
        {
            int temp = base.Add(value);
            this.ChangesNotificationMethod(Changes.AddedItem);
            return temp;
        }

        public override void Remove(object obj)
        {
            if (base.Contains(obj))
            {
                this.ChangesNotificationMethod(Changes.RemovedItem);
                base.Remove(obj);
            }
            else
            {
                this.ChangesNotificationMethod(Changes.ItemDoesNotExist);
            }

        }

        public void Replace(int index, object value)
        {
            if (base.Count > index)
            {
                this.ChangesNotificationMethod(Changes.ReplacedItem);
                base.RemoveAt(index);
                base.Insert(index, value);
            }
            else
            {
                this.ChangesNotificationMethod(Changes.ItemDoesNotExist);
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
                ChangesNotificationMethod(Changes.ChangedItem);
                base[index] = value;
            }
        }


        private void ChangesNotificationMethod(Changes option)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(option.ToString()));
            }
        }
    }
}
