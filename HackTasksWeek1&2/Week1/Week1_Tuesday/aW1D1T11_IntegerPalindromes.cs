using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task11 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("UNDONE!");
            Console.WriteLine(@"
    Check if given integer n is palindrome -> IsIntPalindrome(n)
    Largets palindrome, smaller than given N -> GetLargestPalindrome(N)

For example, 1234321 is an integer palindrome.\n\n");
            Console.WriteLine("Input integer to check if its a palindrome and to print one the nearest smaller palindrome integer: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(IsIntPalindrome(n));
            Console.WriteLine("The smallest nearest palindrome is : " + GetLargestPalindrome(n));
        }
        bool IsIntPalindrome(int n)
        {
            int valueKeeper = n;
            string nString = "";
            while(n>0)
            {
                nString += (n%10);
                n = n / 10;
            }
            if (valueKeeper == Int32.Parse(nString))
            {
                return true;
            }
            else return false;
        }
        int GetLargestPalindrome(int n)
        {
            int largestP = 0;
            string integerString = n.ToString();
            char[] integerChars = integerString.ToCharArray();
            int[] integerInts = new int[integerString.Length];
            int len = integerString.Length;
            for(int i = 0; i< integerInts.Length; i++)
            {
                integerInts[i] = Int32.Parse( integerChars[i].ToString());
            }

            if (IsIntPalindrome(n))
            {
                Console.WriteLine("The input integer is a palindrome.");
                if(integerString.Length % 2 == 1)
                {
                    integerInts[len/2] = integerInts[len/2] - 1;
                    string integerString2 = "";
                    for(int i=0; i<integerInts.Length; i++)
                    {
                        integerString2 += integerInts[i].ToString();
                    }
                    largestP = Int32.Parse(integerString2);
                }
                else
                {
                    integerInts[len / 2] = integerInts[len / 2] - 1;
                    integerInts[len / 2 - 1] = integerInts[len / 2 - 1] - 1;
                    string integerString2 = "";
                    for (int i = 0; i < integerInts.Length; i++)
                    {
                        integerString2 += integerInts[i].ToString();
                    }
                    largestP = Int32.Parse(integerString2);

                }
            }
            else 
            {
                Console.WriteLine("The input integer is not a palindrome");
                List<int> list1 = new List<int>();
                List<int> list2 = new List<int>();
                string temp1 = "";
                string temp2 = "";
                int temp3 = 0;
                int temp4 = 0;
                string temp5 = "";
                if(integerString.Length% 2 == 1)
                {
                    for (int i = 0, j = len / 2 + 1; i < len / 2; i++, j++)
                    {
                        list1.Add(integerInts[i]);
                        list2.Add(integerInts[j]);
                    }
                    for (int i = 0; i < list1.Count; i++)
                    {
                        temp1 += list1[i];
                        temp2 += list2[i];
                    }
                    temp3 = Int32.Parse(temp1);
                    temp4 = Int32.Parse(temp2);


                }
                else
                {
                    for (int i = 0, j = len / 2; i < len / 2; i++,j++)
                    {
                        list1.Add(integerInts[i]);
                        list2.Add(integerInts[j]);
                    }
                    for(int i=0; i < list1.Count; i ++)
                    {
                        temp1 += list1[i];
                        temp2 += list2[i];
                    }
                    temp3 = Int32.Parse(temp1);
                    temp4 = Int32.Parse(temp2);


                    if(temp3 > temp4)
                    {
                        list1[list1.Count - 1] = list1[list1.Count - 1] - 1;
                        list1.Reverse();
                        list2 = list1;
                        for(int i=0; i <list2.Count; i++)
                        {
                            Console.WriteLine(list1[i]);
                        }
                        list1.Reverse();
                        for (int i = 0; i < list1.Count; i++)
                        {
                            temp5 += list1[i];
                        }
                        for (int i = 0; i < list2.Count; i++)
                        {
                            temp5 += list2[i];
                        }
                        largestP = Int32.Parse(temp5);

                    }
                    else if(temp3 < temp4)
                    {
                        list1.Reverse();
                        list2 = list1;
                        list1.Reverse();
                        for (int i = 0; i < list1.Count; i++)
                        {
                            temp5 += list1[i];
                        }
                        for (int i = 0; i < list2.Count; i++)
                        {
                            temp5 += list2[i];
                        }
                        largestP = Int32.Parse(temp5);
                    }
                    else
                    {
                        if(list1[list1.Count - 1] > list1[0])
                        {
                            list1[list1.Count - 1] = list1[0];
                            list2 = list1;
                        }

                        
                        for(int i=0; i < list1.Count; i ++ )
                        {
                            temp5 += list1[i];
                        }
                        for (int i = 0; i < list2.Count; i++)
                        {
                            temp5 += list2[i];
                        }
                        largestP = Int32.Parse(temp5);
                    }


                }


            }




            return largestP;
        }
    }
}
