using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day3_Task7 :HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"You are given a NxM matrix of integer numbers.
We can drop a bomb at any place in the matrix, which has the following effect:
    All of the 3 to 8 neighbours (depending on where you hit!) of the target are reduced by the value of the target.
    Numbers can be reduced only to 0 - they cannot go to negative.
Implement a function called int MatrixBombing(int[,] m).
The function should return the maximum damage we can inflict by bombing a single cell. The damage in each cell is calculated
as the difference between the old value and value after bombing.");
            Console.WriteLine("\n\n");
            Console.WriteLine("The matrix looks like this:");
            int[,] matrix = new int[5, 5] { { 1, 3, 4, 5, 6 } , { 9 ,7 ,4 ,1, 3 }, { 3, 8, 7, 5, 4 },{9,3,4,1,2 },{8,9,7,5,2 } };
            for(int i = 0; i < matrix.GetLength(0);i++)
            {
                for(int j=0; j <matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ",matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("The maximum damage : ");;
            Console.WriteLine(MatrixBombing(matrix));



        }
        int MatrixBombing(int[,] m)
        {
            int damage = 0;
            int maxDmg = 0;
            int sum = 0;
            int sumDmg = 0;
            for(int i = 1; i < m.GetLength(0) - 1;i++)
            {
                for (int j = 1; j < m.GetLength(1) - 1; j++)
                {
                    sum = m[i - 1, j] + m[i - 1, j + 1] + m[i - 1, j - 1] + m[i, j - 1] + m[i, j + 1] + m[i + 1, j - 1] + m[i + 1, j] + m[i + 1, j + 1];
                    sumDmg = Fixer(m[i - 1, j], m[i, j]) + Fixer(m[i - 1, j + 1], m[i, j]) + Fixer(m[i - 1, j - 1], m[i, j]) + Fixer(m[i, j - 1], m[i, j]) + Fixer(m[i, j + 1], m[i, j]) + Fixer(m[i + 1, j - 1], m[i, j]) + Fixer(m[i + 1, j], m[i, j]) + Fixer(m[i + 1, j+1], m[i, j]);
                    damage = sum - sumDmg;


                    if (damage > maxDmg)
                    {
                        maxDmg = damage;
                    }
                }
            }
            return maxDmg;
        }
        int Fixer(int a , int b)
        {
            int result = a - b;
            if (result < 0)
                result = 1;
            return result;
        }
    }
}
