using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day3StaticEtc
{
    public static class ArrayExtension<T>
    {
        public static List<T> Intersect(List<T> firstList, List<T> secondList)
        {
            List<T> IntersectedList = new List<T>();
            int n = 0;
            if(firstList.Count <= secondList.Count)
            {
                n = firstList.Count;
                for(int i=0;i< n;i++)
                {
                    if(firstList[i].Equals(secondList[i]))
                    {
                        IntersectedList.Add(firstList[i]);
                    }
                }
            }
            else
            {
                n = secondList.Count;
                for (int i = 0; i < n; i++)
                {
                    if (firstList[i].Equals(secondList[i]))
                    {
                        IntersectedList.Add(firstList[i]);
                    }
                }
            }
            return IntersectedList;
        }
        public static List<T> UnionAll(List<T> firstList , List<T> secondList)
        {
            List<T> unitedList = new List<T>();
            foreach(var el in firstList)
            {
                unitedList.Add(el);
            }
            foreach (var el in secondList)
            {
                unitedList.Add(el);
            }
            unitedList.Sort();
            return unitedList;
        }

        public static List<T> Union(List<T> firstList, List<T> secondList)
        {
            List<T> unitedList = new List<T>();
            foreach(var el in firstList)
            {
                unitedList.Add(el);
            }
            for(int i=0;i<secondList.Count;i++)
            {
                if(!(unitedList.Contains(secondList[i])))
                {
                    unitedList.Add(secondList[i]);
                }
            }
            return unitedList;
        }
        public static string Join(List<string> list)
        {
            string result = "";

            return result;
        }
    }
}
