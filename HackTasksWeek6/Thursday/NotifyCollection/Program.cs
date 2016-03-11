using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NotifyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            NotifyCollection ntf = new NotifyCollection();
            ntf.PropertyChanged += Ntf_PropertyChanged;
            ntf.Add(55);
            ntf.Add(11);
            ntf.Add(22);
            ntf.Remove(11);
            ntf.Remove(33);
            ntf.Replace(0, 11);
            Console.WriteLine(ntf[0]);

        }

        private static void Ntf_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(e.PropertyName);
        }
    }

}
