using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplex_példa_grafika
{
    public static class Konturseged
    {
        public static Bitmap Konturotott(Bitmap bmp, int Limit)
        {
            /*
            Szinek átmeneténél ha nagy eltérés van ott találjuk a kontúrt. A képet felülről lefelé és jobbról balra szkenelem
            és ha a két pixel között egy meghatározott értéknél nagyobb az eltérés oda rajzolunk.
             */
            //ezt csak az onclick esebényben használtuk, most jön paraméterből
            //Bitmap bmp = (Bitmap)pictureBox1.Image;
            
            
            Bitmap ujbmp = new Bitmap(bmp.Width, bmp.Height);

            //a ciklusokat mos 1 től kezdem, hogy össze lehessen hasonlítani a pixeleket
            for (int i = 1; i < bmp.Width; i++)
            {
                for (int j = 1; j < bmp.Height; j++)
                {
                    //abban az esetben ha az i-1 , j RGB érékéből kivonom a i,j RGB értékét és a különbség nagyobb 100000-nél 
                    //akkor az újbmp koordinátáját beállítom fekete fehérre
                    //visszintesen
                    if (Math.Abs(bmp.GetPixel(i - 1, j).ToArgb() - bmp.GetPixel(i, j).ToArgb()) > Limit)
                    {
                        ujbmp.SetPixel(i, j, Color.Black);
                    }
                    //függőlegesen
                    if (Math.Abs(bmp.GetPixel(i, j - 1).ToArgb() - bmp.GetPixel(i, j).ToArgb()) > Limit)
                    {
                        ujbmp.SetPixel(i, j, Color.Black);
                    }

                }
            }
            return ujbmp;
        }
    }
}
