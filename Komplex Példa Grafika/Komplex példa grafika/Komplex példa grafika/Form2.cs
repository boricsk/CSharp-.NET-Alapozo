using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplex_példa_grafika
{
    public partial class Form2 : Form
    {
        int localLimit;
        Bitmap localBmp;
        public Form2(Bitmap bmp, int LimitStart)
        {
            InitializeComponent();
            localLimit = LimitStart;
            localBmp = bmp;
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //a számítási terhelés csökkentése érdekében csak akkor kezjük el a számítást,
            //ha aa user befejezte a scrollozást. Ezt a scrolleventsarg-ból lehet kiszedni.
            if (e.Type == ScrollEventType.EndScroll)
            {
                localLimit = hScrollBar1.Value;
                pictureBox1.Image = Konturseged.Konturotott(localBmp, localLimit);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form1.Limit = localLimit;
        }
    }
}
