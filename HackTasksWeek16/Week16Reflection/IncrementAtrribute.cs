using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Week16Reflection
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class IncrementableAtrribute : Attribute
    {
    }



    public enum Conditions {byClass , byProperty , None}; 
    public static class ExtensionMethod
    {
        public static void IncrementExtensionMethod(this object obj)
        {
          if(IsIncrementable(obj)==Conditions.byClass)
            {
                PropertyInfo[] props = obj.GetType().GetProperties();
                foreach(var p in props)
                {
                    var type = p.PropertyType;
                    if(type==typeof(int))
                    {
                        int val = (int)p.GetValue(obj) + 1;
                        p.SetValue(obj, val);
                    }
                }
            }
          if(IsIncrementable(obj) == Conditions.byProperty)
            {
                PropertyInfo[] props = obj.GetType().GetProperties();
                foreach (var p in props)
                {
                    var type = p.PropertyType;
                    var type2 = p.IsDefined(typeof(IncrementableAtrribute), false);
                    if (type == typeof(int))
                    {
                        int val = (int)p.GetValue(obj) + 1;
                        p.SetValue(obj, val);
                    }
                    else
                    {
                        throw new ArgumentException("Property is not int");
                    }
                }
            }
        }


        private static Conditions IsIncrementable(object obj)
        { 
            if(obj==null)
            {
                return Conditions.None;
            }
            var type = obj.GetType();
            PropertyInfo[] props = type.GetProperties();

            if (type.IsDefined(typeof(IncrementableAtrribute), false))
            {
                return Conditions.byClass;
            }
            else if (props.Any(p => p.IsDefined(typeof(IncrementableAtrribute), false)))
            {
                return Conditions.byProperty;
            }
            else
            {
                return Conditions.None;
            }
        }
    }

    [IncrementableAtrribute]
    public class test1
    {
        public int MyProperty { get; set; }
        public int MyProperty2 { get; set; }
        public string MyProperty3 { get; set; }
    }
}
