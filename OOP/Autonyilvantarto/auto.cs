namespace Autonyilvantarto
{
    public class Auto
    {
        static int OsszAllomany;
        public string Rendszam { get; } //Csak lekérdezni lehet, mert mincs settere
        public AutoEnum Típus { get; }
        List<double> Fogyastasok;
        double amortizacio = 100;

        //Statikus konstruktor. Akkor fut le amikor az első példányt
        //létrehozzák, és máskor nem.
        static Auto()
        {
            OsszAllomany = 0;
        }

        public Auto(string rsz, AutoEnum tip)
        {
            //Konstruktor neve = osztálynév, nem lehet visszatérése
            Rendszam = rsz; //Itt lehet a rendszámot beállítani, kívülről nem
            Típus = tip;
            Fogyastasok = new List<double>();
            OsszAllomany++;

        }

        public void Megy(double atlagfogyasztasok)
        {
            //Amikor megy az autó hozzáadom a listához a fogyasztásokat.
            Fogyastasok.Add(atlagfogyasztasok);
        }

        public static int Allomany()
        {
            return OsszAllomany;
        }

        public double Atlagfogy()
        {
            double ossz = 0;
            foreach (double egyfogy in Fogyastasok) { ossz += egyfogy; }
            Amortizálódik();
            return ossz / Fogyastasok.Count;
        }

        private void Amortizálódik()
        {
            amortizacio *= 0.001;
        }
    }
}
