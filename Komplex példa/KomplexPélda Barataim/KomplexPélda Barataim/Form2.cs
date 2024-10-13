using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KomplexPélda_Barataim
{
    public partial class Form2 : Form
    {
        //A form2 paraméterként kapja a barátok listát. A kiir fogja végezni a kiirást
        //és a listát a konstruktor adja át a metódusnak
        public Form2(Baratok bk)
        {
            InitializeComponent();
            Kiir(bk);
        }

        private void Kiir(Baratok bk)
        {
            //Labeleket hozunk létre a kiiráshoz futásidőben
            int poz = 20;
            foreach (Barat b in bk.BaratokListaja) {
                Label l = new Label();
                l.Top = poz;
                l.Left = 40;
                l.Width = 500;
                l.Text = b.ToString();
                Controls.Add(l);
                poz += 40;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
