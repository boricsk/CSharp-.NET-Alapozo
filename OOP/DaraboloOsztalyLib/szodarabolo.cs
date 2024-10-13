
namespace DaraboloOsztalyLib

{
    public class Szodarabolo
    {
        //fieldek
        int meret;
        string s;
        string[] darabok;

        //property
        public bool sikeres { get; set; }

        public void Kiiras()
        {
            if (sikeres)
            {
                foreach (string darab in darabok) { Console.WriteLine(darab); }
            }
        }

        public bool Adatbekers()
        {
            Bekeres(out s, out meret);
            darabok = Meretezes(s, meret);
            Darabolas(s, meret, darabok);
            sikeres = true;
            return true;
        }

        private void Bekeres(out string sparam, out int meretparam)
        {
            Console.WriteLine("Kérem a szöveget");
            sparam = Console.ReadLine();
            Console.WriteLine("Mérete");

            while (!int.TryParse(Console.ReadLine(), out meretparam))
            {
                Console.WriteLine("Nem jó a méret");
            }
        }

        private string[] Meretezes(string s, int meret)
        {
            string[] darabok2;
            if (s.Length % meret == 0)
            {
                darabok2 = new string[s.Length / meret];
            }
            else
            {
                darabok2 = new string[s.Length / meret + 1];
            }

            return darabok2;
        }

         void Darabolas(string s, int meret, string[] darabok2)
        {
            int counter = 0;
            while (s.Length > 0)
            {
                if (s.Length <= meret)
                {
                    darabok2[counter] = s;
                    s = string.Empty;
                }
                else
                {
                    darabok2[counter] = s.Substring(0, meret);
                    s = s.Substring(meret);
                }
                counter++;
            }
        }
    }
}
