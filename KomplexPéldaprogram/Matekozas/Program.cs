//Véletlenszám
//A lenti módon példányosítani kell
Random r = new Random();

Console.WriteLine("Matek gyakorló program");

char valasz = 'N'; //Figyelj arra, hogy mi a változó scope. pl ha a do ban deklarálod akkor nem tudod használni a kiértékelésben!!

Dictionary<string, int> topLista = new Dictionary<string, int>();

do
{
    Console.WriteLine("Add meg a neved");
    string nev = Console.ReadLine();

    if (!topLista.ContainsKey(nev))
    {
        topLista.Add(nev, 0);
    }

    int mit = r.Next(3); //A 3 exkluzív érték, azaz már nem lesz benne a generált számok között
    int x1, y1, z1;

    x1 = r.Next(1, 11);
    y1 = r.Next(1, 11);
    z1 = 0; // Azétrt, mert a default ág a swichben nem biztos, hogy lefut, ha lefut akkor nem lesz z1. A tipp == z1 nél ezért hisztizett.
    switch (mit)
    {
        case 0:
            Osszead(x1, y1, out z1); break;
        case 1:
            Kivon(x1, y1, out z1); break;
        case 2:
            Szoroz(x1, y1, out z1); break;
        default:
            break;

    }

    int tipp;

    Console.WriteLine("Kérem az eredményt");
    while (!int.TryParse(Console.ReadLine(), out tipp))
    {
        Console.WriteLine("A tipp csak szám lehet!");
    }

    if (tipp == z1)
    {
        Console.WriteLine("Helyes");
        topLista[nev] ++;
    }
    else { Console.WriteLine($"Hibás! A helyes megoldás a {z1}"); }

    Console.WriteLine("Más is próbálkozik");
    valasz = Console.ReadLine()[0]; //Csak a válasz 1. karakterét tárolja

} while (char.ToUpper(valasz) == 'I');

Console.WriteLine("Végeredmény");
foreach (KeyValuePair<string,int> item in topLista)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}

static void Osszead(int x, int y, out int z)
{
    Console.WriteLine("Add össze a számokat : {0}, {1}", x, y);
    z = x + y;
}

static void Kivon(int x, int y, out int z)
{
    if (y > x)
    {
        int temp = x; x = y; y = temp;
    }

    Console.WriteLine("Vond ki a számokat : {0}, {1}", x, y);
    z = x - y;
}

static void Szoroz(int x, int y, out int z)
{
    Console.WriteLine("Szorozd össze a számokat : {0}, {1}", x, y);
    z = x * y;
}