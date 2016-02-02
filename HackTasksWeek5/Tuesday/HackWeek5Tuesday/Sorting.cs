using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek5Tuesday
{
    public static class BubbleAndSelectionSort
    {
        public static IList<T> BubbleSortin<T>(this IList<T> ListToBeSorted)
        {
            return BubbleAndSelectionSort.BubbleSortin(ListToBeSorted,Comparer<T>.Default);
        }
        private static IList<T> BubbleSortin<T>(IList<T> list ,IComparer<T> comparer)
        {
            for(int i=0;i<list.Count - 1;i++)
            {
                for(int j=0;j<list.Count-i-1;j++)
                {
                    if(comparer.Compare(list[j] ,list[j + 1])>0)
                    {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
   
        public static IList<T> SelectionSortin<T>(this IList<T> listToBeSorted)
        {
            return BubbleAndSelectionSort.SelectionSortin<T>(listToBeSorted, Comparer<T>.Default);
        }
        private static IList<T> SelectionSortin<T>(IList<T> list , IComparer<T> comparer)
        {
            for(int i=0;i<list.Count -1;i++)
            {
                int min = i;
                for(int j=i+1;j<list.Count;j++ )
                {
                    if(comparer.Compare(list[j],list[min])<0)
                    {
                        min = j;
                    }
                    if(min!=i)
                    {
                        T temp = list[j];
                        list[j] = list[min];
                        list[min] = temp;
                    }
                }
            }
            return list;
        }



    }
}
