namespace Ciklusok_win_char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 65535; i++)
            {
                listBox1.Items.Add($"{i} - {(char)i}");
            }
        }
    }
}
