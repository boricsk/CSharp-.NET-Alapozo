using System.Xml.Serialization;

namespace KomplexPélda_Barataim
{
    public partial class Form1 : Form
    {
        Baratok bk;
        public Form1()
        {
            InitializeComponent();
            bk = new Baratok();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnMegse_Click(object sender, EventArgs e)
        {
            AdatTorles();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Barat b = new Barat();
            b.Nev = tbNev.Text;
            b.Cim = tbCim.Text;
            b.Tel = (int)numericUpDown1.Value;
            bk.BaratokListaja.Add(b);
            AdatTorles();
        }

        private void AdatTorles()
        {
            panel1.Visible = false;
            tbCim.Text = "";
            tbNev.Text = "";
            numericUpDown1.Value = 10000;
        }

        private void btnMent_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Baratok));
                    ser.Serialize(sw, bk);
                }
            }
        }

        private void btnBetolt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(Baratok));
                    bk = (Baratok)ser.Deserialize(sr);
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(bk);
            f2.Show();
        }

        private void btnKeres_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(bk);
            f3.ShowDialog();
        }
    }
}
