namespace Betuszam
{
    public partial class Form1 : Form
    {
        Dictionary<char, int> statisztika = new Dictionary<char, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(openFileDialog1.FileName);
                string sor;
                while ((sor = reader.ReadLine()) != null)
                {
                    foreach (char betu in sor)
                    {
                        if (statisztika.ContainsKey(char.ToUpper(betu)))
                        {
                            statisztika[char.ToUpper(betu)] += 1;
                        }
                        else { 
                            statisztika.Add(char.ToUpper(betu), 1);
                        }
                    }
                }
                statisztika = statisztika.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                
                foreach (KeyValuePair<char, int> adat in statisztika)
                {
                    listBox1.Items.Add($"{adat.Key}  :  {adat.Value}");
                }
            }
        }
    }
}
