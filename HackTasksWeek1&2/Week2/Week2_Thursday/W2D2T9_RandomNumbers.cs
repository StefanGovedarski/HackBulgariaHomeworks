using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HackTask
{
    class Week2_Day2_Task9 : HackBgExecutable
    {
        public void Execute()
        {
            /*Write a method which outputs a matrix of random floating point numbers to a file. The dimensions of the matrix are given as arguments.
            The numbers should be in the range 0-1000 and should be printed with exactly two digits after the decimal point. The numbers should be separated
            by at least one space and should be right aligned to the size of their column 
            (which you can consider to be fixed at 8 characters).
void GenerateRandomMatrix(int rows, int columns, string fileName)
3x3:
   13.37  545.87   75.64
  184.37 1000.00  684.64
    1.00    9.67  378.68
Hint: Use File.WriteAllText to output the result.*/

            Console.WriteLine("Checking if the file exists");
            string filename = "../../outputs/randomnumbers.txt";
            Console.WriteLine(File.Exists(filename) ? "file exists" : "file doesent exist");
            Console.WriteLine("Input number of rows for the matrix:");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input colomns:");
            int col = Int32.Parse(Console.ReadLine());
            if(File.Exists(filename))
            {
                GenerateRandomMatrix(row, col, filename);
            }
            else
            {
                Console.WriteLine("fix your filename");
            }

        }
        public void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            float[,] matrix = new float[rows, columns];
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {

                    matrix[i,j] =(float)rand.Next(0, 1000)/100;
                    sb.Append(matrix[i,j]);
                    sb.Append(" ");
                }
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(fileName, sb.ToString());
        }
    }
}
