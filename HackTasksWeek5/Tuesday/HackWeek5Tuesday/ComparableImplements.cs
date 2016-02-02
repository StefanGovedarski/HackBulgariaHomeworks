using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek5Tuesday
{
    public class ReverseComparer<T> : IComparer<T>
    {
        public int Compare(T firstNum, T secondNum)
        {
            return Comparer<T>.Default.Compare(secondNum, firstNum);
        }

        public class MyIntComparer : IComparer<int>
        {
            public int Compare(int firstNum, int secondNum)
            {
                return firstNum - secondNum;
            }
        }
        public class StringLengthComparer : IComparer<string>
        {
            public int Compare(string firstString, string secondString)
            {
                if (firstString == null && secondString == null)
                    return 0;

                else if (firstString == null)
                    return 0 - secondString.Length;

                else if (secondString == null)
                    return firstString.Length - 0;

                else
                    return firstString.Length - secondString.Length;
            }
        }

        public class OddEvenComparer : IComparer<int?>
        {
            public int Compare(int? firstNum, int? secondNum)
            {
                if (firstNum % 2 == 0 && secondNum % 2 == 1)
                    return -1;
                else if (firstNum % 2 == 1 && secondNum % 2 == 0)
                    return 1;
                else if (firstNum % 2 == 1 && secondNum % 2 == 1)
                    return firstNum.Value - secondNum.Value;
                else if (firstNum % 2 == 0 && secondNum == 0)
                    return secondNum.Value - firstNum.Value;
                else
                {
                    if (firstNum == null && secondNum == null)
                        return 0;
                    else if (firstNum == null)
                        return -1;
                    else
                        return 1;
                }
            }
        }
        public class LastDigitComparer : IComparer<int>
        {
            public int Compare(int firstNum, int secondNum)
            {
                return (firstNum % 10) - (secondNum% 10);
            }
        }
    }
}
