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
            
            //Gomb fut�s k�zbeni l�trehoz�sa
            Button b = new Button();
            b.Width = 100;
            b.Height = 25;
            b.Top = r.Next(600);
            b.Left = r.Next(1000);
            //esem�ny hozz�ad�shoz a += kell haszn�lni
            b.Click += Leszed;
            Controls.Add(b);
            counter++;

        }

        //a gomb elt�ntet�s�hez egy �ltal�nos esem�nyt hozunk l�tre
        //a sender �s az event args k�telez�
        private void Leszed(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
            counter--;
            pont++;
        }
    }
}
