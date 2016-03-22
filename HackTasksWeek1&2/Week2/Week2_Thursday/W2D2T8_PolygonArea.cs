using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackTask
{
    class Week2_Day2_Task8 : HackBgExecutable
    {
        public void Execute()
        {
            /*Write a method which calculates the area of a given polygon.
float CalcArea(PointF[] points)
The polygon is given as an array of PointFs which represents a point with a floating point coordinates (from System.Drawing).
The 0 index of the array contains the bottom-most point, and the next points are sorted counter-clockwise according to the point at 0.*/
            PointF[] p = new PointF[]
            {
                new PointF(1,2),
                new PointF(2,3),
                new PointF(4,7),
                new PointF(-3,7),
                new PointF(-4,-11)
            };
            Console.WriteLine(CalcArea(p));


        }
        static float CalcArea(PointF[] points)
        {
            int numberOfSides = points.Length - 1;
            float area = 0;
            int j = numberOfSides;
            for(int i=0; i<numberOfSides;i++)
            {
                area += ((points[j].X + points[i].X) * (points[j].Y - points[i].Y));
            }
            return area;
        }
    }
}
