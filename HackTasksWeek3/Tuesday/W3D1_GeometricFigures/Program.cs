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
            Point p1 = new Point(2, 3);
            Point p2 = new Point(2, 1);
            Point p3 = new Point(2, 2);
            Point p4 = new Point(2, 5);
            Point[] p12arr = new Point[2];
            p12arr[0] = p1;
            p12arr[1] = p2;
            Point[] p34arr = new Point[2];
            p34arr[0] = p3;
            p34arr[1] = p4;
            Vector vec1 = new Vector(p12arr);
            Vector vec2 = new Vector(p34arr);
            Vector vec =  vec1 + vec2;
            Console.WriteLine(vec);
            

        }
    }
}
