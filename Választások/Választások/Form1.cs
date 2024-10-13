using System.Xml.Serialization;

namespace Választások
{
    public partial class Form1 : Form
    {
        //local field dekralálás a választói listának
        Valasztok nevsor;
        public Form1()
        {
            InitializeComponent();
            //itt a konstruktorban inicializáljuk az üres névsort.
            nevsor = new Valasztok();
        }

        private void btnÚj_Click(object sender, EventArgs e)
        {
            //Valaszto osztály példányosítása
            Valaszto v = new Valaszto();
            //adatok kiolvasása Valaszto objektumba
            v.Nev = tbNév.Text;
            v.Varos = tbVáros.Text;
            v.IsNo = checkBox1.Checked;
            //kasztolni kell int-re, mert a numeric updown value típusa az decimal.
            v.Szev = (int)numericUpDown1.Value;
            //A névsorban található listához adjuk az új választót.
            nevsor.ValasztoLista.Add(v);
            Frissit();
        }
        //ez frissíti a listát a listboxban
        private void Frissit()
        {
            listBox1.Items.Clear();
            foreach (Valaszto va in nevsor.ValasztoLista)
            {
                listBox1.Items.Add(va);
            }
        }

        private void btnMentés_Click(object sender, EventArgs e)
        {
            using (StreamWriter ws = new StreamWriter("adatok.xml"))
            {
                //serializer
                //a szerializer initje
                XmlSerializer xser = new XmlSerializer(typeof(Valasztok));
                //kiirás a file-ba
                xser.Serialize(ws, nevsor);
            }
        }

        private void btnetöltés_Click(object sender, EventArgs e)
        {
            //ez a using erőforrásokat tudunk menedzselni
            using (StreamReader sr = new StreamReader("adatok.xml"))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Valasztok));
                nevsor = (Valasztok)xser.Deserialize(sr);
                Frissit();
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            //Azt az elemet, amelyett kijelölünk kiolvas a v változóba
            Valaszto v = (Valaszto)((ListBox)sender).SelectedItem;
            tbNév.Text = v.Nev;
            tbVáros.Text = v.Varos;
            numericUpDown1.Value = (decimal)v.Szev;
            checkBox1.Checked = v.IsNo;

        }
    }
}
