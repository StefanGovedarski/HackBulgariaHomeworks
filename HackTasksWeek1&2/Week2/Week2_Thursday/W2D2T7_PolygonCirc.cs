using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackTask
{
    class Week2_Day2_Task7 : HackBgExecutable
    {
        public void Execute()
        {
            /*Write a method which calculates the circumference of a given polygon.
float CalcCircumference(PointF[] points)
The polygon is given as an array of PointFs which represents a point with a floating point coordinates (from System.Drawing).
The 0 index of the array contains the bottom-most point, and the next points are sorted counter-clockwise according to the point at 0.*/
            PointF[] p = new PointF[]
                {
                    new PointF(0,0),
                    new PointF(2,0),
                    new PointF(2,2),
                    new PointF(0,2),
                };

            Console.WriteLine(CalcCircumference(p));

        }
        static float CalcCircumference(PointF[] point)
        {
            float circ = 0;
            for (int i = 0; i < point.Length; i++)
            {
                if (i != point.Length - 1)
                {
                    circ += GetSide(point[i+1],point[i]);
                }
                else
                {
                    circ += GetSide(point[0],point[i]);
                }
            }
            return circ;
        }
        static float GetSide(PointF a , PointF b)
        {
            float lenghtA = a.X - b.X;
            float lenghtB = a.Y - b.Y;
            float side = (float)Math.Sqrt((lenghtA * lenghtA) + (lenghtB * lenghtB));

            return side;
        }
    }
    }

