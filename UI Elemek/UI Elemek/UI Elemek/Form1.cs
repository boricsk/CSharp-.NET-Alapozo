namespace UI_Elemek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Peti");
            comboBox1.Items.Add("Kati");
            comboBox1.Items.Add("Laci");

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //color dialog létrehozása futásidõben

            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            
            //azért kel kirakni változóba, mert ha 2x vizsgálom az if ben akkor 2x fog megnyílni az ablak
            DialogResult res = form2.ShowDialog();

            if (res == DialogResult.OK)
            {
                //a gomb típusát a gomb dialog result-ja tartalmazza
                MessageBox.Show("OK-ot nyomtak");
            }
            else if (res == DialogResult.No) {
                MessageBox.Show("Jajj ne-t nyomtak");
            }
            else
            {
                //default visszatérési érték a cancel, ha x el zárod be akkor ez fut
                MessageBox.Show($"Ez meg mi? {res}");
            }
            //form2.Show(); //nincs visszatérés
        }
    }
}
