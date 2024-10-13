using System.Security.Cryptography;

namespace Grafika_alapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rajzolás a gombra
            //Graphics gr = button1.CreateGraphics();
            //gr.DrawEllipse(Pens.Red, 1, 1, 100, 55);
            //ha lehúzod az egeret eltûnik az elipszis, mert a gombnak animációja van
            //ha elhúzod az egeret felette. A Graphics minden változáskor újra generálódik.

        }

        //mindíg a paintbe célszerû tenni a rajzolást
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Red, 1, 1, 100, 55);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.DrawEllipse(Pens.Blue, 1, 1, 100, 100);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Green, 10, 10, 110, 110);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //@ escape karakterek figyemen kívül hagyása

            pictureBox1.Image = new Bitmap(@"D:\doc\learn\C#\Bevezetés a C és .NET alapjaiba\Week 03\Materials\valami.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //a mentésen nemlesz raja a kör és a négyzet mert külön kezeli a képet és a rajokat

            pictureBox1.Image.Save(@"D:\doc\learn\C#\Bevezetés a C és .NET alapjaiba\Week 03\Materials\valami_1.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ahhoz, hogy a mûvészi rajzomat is mentsük elsõ lépésben a képet egy változóba kell tárolni
            Bitmap bmp = (Bitmap)Image.FromFile(@"D:\doc\learn\C#\Bevezetés a C és .NET alapjaiba\Week 03\Materials\valami.jpg");
            //A bitmap garphics-re kell rajzolni.
            Graphics gr = Graphics.FromImage(bmp);
            Font f = new Font("Arial", 80);

            //rajzolás a képre
            gr.DrawString("Tirol viztározó",f, Brushes.Yellow, 1,1);

            pictureBox1.Image = bmp;
            pictureBox1.Image.Save(@"D:\doc\learn\C#\Bevezetés a C és .NET alapjaiba\Week 03\Materials\valami_3.jpg");
        }
    }
}
