namespace Jatek
{
    public partial class Form1 : Form
    {
        int counter = 0;
        int pont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            if (counter > 10)
            { 
                timer1.Enabled = false;
                MessageBox.Show($"Game Over! Pontod : {pont}");
            }
            
            //Gomb futás közbeni létrehozása
            Button b = new Button();
            b.Width = 100;
            b.Height = 25;
            b.Top = r.Next(600);
            b.Left = r.Next(1000);
            //esemény hozzáadáshoz a += kell használni
            b.Click += Leszed;
            Controls.Add(b);
            counter++;

        }

        //a gomb eltüntetéséhez egy általános eseményt hozunk létre
        //a sender és az event args kötelezõ
        private void Leszed(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
            counter--;
            pont++;
        }
    }
}
