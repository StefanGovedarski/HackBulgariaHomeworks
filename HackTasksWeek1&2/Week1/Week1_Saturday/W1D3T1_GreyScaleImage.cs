using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day3_Task1 :HackBgExecutable
    {
        /*Grayscale Image

Make a program which loads a bitmap into memory, converts it to a grayscale image and then saves it to a file.

void GreyScaleImage(Bitmap bitmap, string savePath)

What is Grayscale

Basically, you can use any linear combination of the color components:

Gray = x.Red + y.Green + z.Blue, where x+y+z are floating point numbers which sum to 1.*/

        public void Execute()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("../../outputs/bobmarley.bmp");
            for(int i=0; i<bmp.Width; i++)
            {
                for(int j=0;j<bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);
                    Color newPixel = Color.FromArgb(GreyPixelMaker(pixel), GreyPixelMaker(pixel), GreyPixelMaker(pixel));
                    bmp.SetPixel(i, j, newPixel);
                }
            }
            bmp.Save("../../outputs/newBob.bmp");
        }
        int GreyPixelMaker(Color pixel)
        {
            int b = pixel.B;
            int r = pixel.R;
            int g = pixel.G;
            int mid = 0;
            if (b > r && b > g)
                mid = b;
            else if (g >= b && g >= r)
                mid = g;
            else if (r >= b && r > g)
                mid = r;

            return mid;
        }
    }
}
