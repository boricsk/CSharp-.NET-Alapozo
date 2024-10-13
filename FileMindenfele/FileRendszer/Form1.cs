namespace FileRendszer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                listBox1.Items.Add(d.Name);
                //listBox1.Items.Add(d.Name);
                //listBox1.Items.Add(d.AvailableFreeSpace);
            }

            //DriveInfo.GetDrives();
            //DriveInfo di = new DriveInfo("C:");

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //listBox2.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(((ListBox)sender).SelectedItem.ToString());
            listBox2.Items.Clear();
            foreach (DirectoryInfo item in di.GetDirectories())
            {
                listBox2.Items.Add(item);
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(((ListBox)sender).SelectedItem.ToString());
            foreach (FileInfo fi in di.GetFiles())
            {
                listBox3.Items.Add(fi);
            }

            listBox1_Click(sender, e);
            //mivel ugyanazt csinálom mint a listbox1-ben ezért csak más senderrel hívom meg.
        }

        private void listBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
