namespace Komplex_példa_grafika
{
    public partial class Form1 : Form
    {
        //Limit érték deklarálása statikusként, mert a Formm1 a nyitókép és
        //ebből tuti nem lesz több. Azért kell, mert a Form2-n szeretnék
        //egy csúszkával limitet állítani.
        public static int Limit { get; set; }
        public Form1()
        {
            InitializeComponent();
            Limit = 100000;
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "Normal")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }

            if (sender.ToString() == "Stretch")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            if (sender.ToString() == "Automatic")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            if (sender.ToString() == "Center")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            if (sender.ToString() == "Zoom")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }


        }

        private void btnMent_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void btnSzinezo_Click(object sender, EventArgs e)
        {
            //lemásoljuk a képet, betesszük egy bmp-be és képpontonként módosítunk abeállításokon.
            //a módosított bmp-t visszatesszük a pictureboxba
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            Bitmap ujbmp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    /*
                    Kékre szinezés
                    Az i, j pixelt állítom be úgy, hogy lehérem a i, j helyen lévő eredeti pixelt
                    Az A érték változatlan, Az RGB- ből a G és R kinullázva, a kéket szintén elkérem
                    és visszaállítom ugyanarra ami volt.
                    */

                    //ujbmp.SetPixel(i, j, Color.FromArgb(bmp.GetPixel(i, j).A, 0, 0, bmp.GetPixel(i, j).B));

                    /*
                    Infra hatás
                    Ha fölcseréled az RGB-ből a G-t és a B-t akkor olyan lesz a kép mintha infraszemüvegen néznéd
                    */
                    ujbmp.SetPixel(i, j, Color.FromArgb(bmp.GetPixel(i, j).A, 0, bmp.GetPixel(i, j).B, 0));
                }
            }
            pictureBox1.Image = ujbmp;
        }

        private void btnKonturKeres_Click(object sender, EventArgs e)
        {

            Bitmap bmp = (Bitmap)pictureBox1.Image;

            Form2 f2 = new Form2(new Bitmap(bmp, bmp.Width / 4, bmp.Height / 4), Limit);

            if (f2.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Konturseged.Konturotott((Bitmap)pictureBox1.Image, Limit);
            }

        }//45p

        private void btnVizjel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vizjelhez kérem válasszon egy színt.");
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            { 
                Color c = cd.Color;
                //bitmap a képnek
                Bitmap b = (Bitmap)pictureBox1.Image;
                //grafika létrehozása a bitmapből, mert erre tudunk feliratozni
                Graphics g = Graphics.FromImage(b);
                g.DrawString(textBox1.Text, new Font("Arial", 100), new SolidBrush(c), 1, 1);
                pictureBox1.Image= b;
            }
        }
    }
}
