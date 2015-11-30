using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackTask
{
    class Week1_Day3_Task2 :HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Make a program which loads a bitmap into memory, then rescales it into a 
new bitmap using the nearest neighbour interpolation.\n\n");
            string savePath = "../../outputs/BiggerBob.bmp";
            Bitmap bmp = (Bitmap)Image.FromFile("../../outputs/newBob.bmp");
            Size bmpSize = bmp.Size;
            Console.WriteLine("The new image should be twice as big");
            ResampleImage(bmp,savePath);

        }
        void ResampleImage(Bitmap bmp, string savePath)
        {
            Bitmap BiggerBmp = new Bitmap(2 * bmp.Width, 2 * bmp.Height);
            for (int i = 0; i < BiggerBmp.Width-1; i++)
            {
                for (int j = 0; j < BiggerBmp.Height-1; j++)
                {
                    Color pixel = BiggerBmp.GetPixel(i, j);
                    Color newPixel = bmp.GetPixel((int)Math.Round(i / (double)2), (int)Math.Round( j /(double)2));
                    BiggerBmp.SetPixel(i,j,newPixel);
                }
            }
            BiggerBmp.Save(savePath);


        }
    }
}
