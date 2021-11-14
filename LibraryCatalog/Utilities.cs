using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryCatalog
{
    public class Utilities
    {
        public static void FillPictureBox(PictureBox pictBox,Bitmap bmp)
        {
            pictBox.SizeMode = PictureBoxSizeMode.Normal;
            double W = pictBox.Width;
            double H = pictBox.Height;
            double w = bmp.Width;
            double h = bmp.Height;
            double rh = h / H;
            double rw = w / W;
            double rate = Math.Max(rh, rw);
            if (rate > 0)
            {
                h = h / rate;
                w = w / rate;
            }

            Bitmap resized = new Bitmap(bmp, new Size((int)w, (int)h));
            pictBox.Image = resized;
            pictBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
