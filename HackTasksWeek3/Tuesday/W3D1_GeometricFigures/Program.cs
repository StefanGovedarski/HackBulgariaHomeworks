using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_GeometricFigures
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr1 = new int[5] { 1, 3, 5, 3, 2 };
            int[] arr2 = new int[5] { 3, 3, 4, 7, 2 };
            Vector vec = new Vector(arr1);
            Vector vec2 = new Vector(arr2);
            Vector result = vec + vec2;
            int len = result.VectorLenght();
            for(int i=0;i<len; i++)
            {
                Console.Write(result[i]);
            }
            result = vec + len;
            Console.WriteLine();
            result = vec * 3;
            for (int i = 0; i < len; i++)
            {
                Console.Write(result[i]);
            }



        }
    }
}
