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
            //rajzol�s a gombra
            //Graphics gr = button1.CreateGraphics();
            //gr.DrawEllipse(Pens.Red, 1, 1, 100, 55);
            //ha leh�zod az egeret elt�nik az elipszis, mert a gombnak anim�ci�ja van
            //ha elh�zod az egeret felette. A Graphics minden v�ltoz�skor �jra gener�l�dik.

        }

        //mind�g a paintbe c�lszer� tenni a rajzol�st
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
            //@ escape karakterek figyemen k�v�l hagy�sa

            pictureBox1.Image = new Bitmap(@"D:\doc\learn\C#\Bevezet�s a C �s .NET alapjaiba\Week 03\Materials\valami.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //a ment�sen nemlesz raja a k�r �s a n�gyzet mert k�l�n kezeli a k�pet �s a rajokat

            pictureBox1.Image.Save(@"D:\doc\learn\C#\Bevezet�s a C �s .NET alapjaiba\Week 03\Materials\valami_1.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Ahhoz, hogy a m�v�szi rajzomat is ments�k els� l�p�sben a k�pet egy v�ltoz�ba kell t�rolni
            Bitmap bmp = (Bitmap)Image.FromFile(@"D:\doc\learn\C#\Bevezet�s a C �s .NET alapjaiba\Week 03\Materials\valami.jpg");
            //A bitmap garphics-re kell rajzolni.
            Graphics gr = Graphics.FromImage(bmp);
            Font f = new Font("Arial", 80);

            //rajzol�s a k�pre
            gr.DrawString("Tirol vizt�roz�",f, Brushes.Yellow, 1,1);

            pictureBox1.Image = bmp;
            pictureBox1.Image.Save(@"D:\doc\learn\C#\Bevezet�s a C �s .NET alapjaiba\Week 03\Materials\valami_3.jpg");
        }
    }
}
