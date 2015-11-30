using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackTask
{
    class Week1_Day3_Task3 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Make a program which loads a bitmap into memory,
then rescales it into a new bitmap using the nearest neighbour interpolation.\n\n");
            string savePath = "../../outputs/BlurredBob.bmp";
            Bitmap bmp = (Bitmap)Image.FromFile("../../outputs/bobmarley.bmp");
            Size bmpSize = bmp.Size;
            ResampleImage(bmp, bmpSize, savePath);
        }
        void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int redSum = 0;
                    int greenSum = 0;
                    int blueSum = 0;
                    Color newPixel = new Color();
                    if (i > 0 && i<bitmap.Width-1 && j > 0 && j < bitmap.Height-1)
                    {
                        newPixel = bitmap.GetPixel(i, j);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i + 1, j);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i - 1, j);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i + 1, j + 1);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i, j+1);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i, j-1);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i + 1, j-1);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        newPixel = bitmap.GetPixel(i -1, j+1);
                        blueSum += newPixel.B;
                        redSum += newPixel.R;
                        greenSum += newPixel.G;
                        bitmap.SetPixel(i, j, newPixel);
                        Color pixel = Color.FromArgb(redSum / 9, greenSum / 9, blueSum / 9);
                        bitmap.SetPixel(i, j, pixel);
                    }
                }
            }

            bitmap.Save(savePath);
        }

    }
}
