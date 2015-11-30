using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task6 : HackBgExecutable
    {
        /*A hack number is an integer, that matches the following criteria:

    The number, represented in binary, is a palindrome
    The number, represented in binary, has an odd number of 1's in it

Example of hack numbers:

    1 is 1 in binary
    7 is 111 in binary
    7919 is 1111011101111 in binary

Implement the following functions:

    isHack(n) -> checks if n is a hack number
    nextHack(n) -> returns the next hack number, that is bigger than n
*/
        public void Execute()
        {
            Console.WriteLine("Hack Number are number that have an odd number of ones and is a palindrome in binary\n\n");
            Console.WriteLine("Enter the number you want to check");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(IsHack(n));
            Console.WriteLine("the next hack number is:");
            Console.WriteLine(NextHack(n));
        }
        static bool IsHack(int n)
        {
            string bin = turnToBinary(n);

            if (Palindrome(bin )&& CountOnes(bin))
                return true;
            else
                return false;
        }





        static string turnToBinary(int n)
        {
            int value = n;
            string binary = Convert.ToString(value, 2);
            return binary;
        }




        static bool Palindrome(string input)
        {
            bool palindrome = true;
            if(input != ReverseMe(input))
            {
                palindrome = false;
            }
            return palindrome;
        }



        static bool CountOnes(string input)
        {

            bool oddNumberOfOnes = false;
            
            int numberOfOnes = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] =='1')
                {
                    numberOfOnes++;
                }
            }
            if (numberOfOnes % 2 == 1)
                oddNumberOfOnes = true;
            return oddNumberOfOnes;
        }
        static string ReverseMe(string s)
        {
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
        static int NextHack(int n)
        {
            do
            {
                n++;
            }
            while (Palindrome(turnToBinary(n)) == false);
            if ((Palindrome(turnToBinary(n))&&CountOnes(turnToBinary(n))))
            {
                return n;
            }
            else
            {
                return NextHack(n);
            }



        }
    }
}
