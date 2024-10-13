//Tömbök
//Egész számokat tartalmazó 4 elemű tömb xek névvel (Index 0-tól kezd)
//CTRL K D -> Kódformázás
using System.Text;

int[] xek = new int[4] { 22, 55, 23, 9 };
//xek[0] = 0;

foreach (int i in xek)
{
    Console.WriteLine(i);
}
Console.WriteLine("---");

//Listák (Generikus)
//Nem kell előre meghatározni az elemek számát, mint a tömbnél.
List<int> xek2 = new List<int>();

xek2.Add(22);
xek2.Add(55);
xek2.Add(9);

foreach (int i in xek2)
{
    Console.WriteLine(i);
}
Console.WriteLine("---");


//Dictionary
Dictionary<string, string> engHun = new Dictionary<string, string>();

engHun.Add("Dog", "Kutya");
engHun.Add("Cat", "Macska");

foreach (KeyValuePair<string, string> szo in engHun)
{
    Console.WriteLine($"{szo.Key} - {szo.Value}");
}

Dictionary<string, List<string>> realEngHun = new Dictionary<string, List<string>>();
List<string> forditasok = new List<string>();

forditasok.Add("Wait");
forditasok.Add("Castle");

realEngHun.Add("Vár", forditasok);

//String builder (CTRL . al lehet külső könytárat úgy hozzáadni, hogy az adott kifejezésen áll a kurzor, ilyenkor automatikusan ajánlja a kapcsolódó könyvtárnevet
//Szöveg összefűzésre való
StringBuilder stringbuilder = new StringBuilder();

string ak = string.Empty;
for (int i = 0; i < 100; i++)
{
    ak += 'a';
}
Console.WriteLine("Done String");

//A string inmutable (Nem megváltozttható). Ha hozzá adok egy karaktert az ak-hoz akkor újra létre kell hozni egy új
//pépdányt, ami időbe kerül.

for (int i = 0; i < 100000; i++)
{
    stringbuilder.Append('a');
}

Console.WriteLine("Done StringBuilder");
//Console.WriteLine(stringbuilder.ToString());

//A string builder az egyszer létrejön, és az appendnél nem kell új példányokat készíteni

//Változók min, max értékei
Console.WriteLine("Int minimum : {0}", int.MinValue);
Console.WriteLine("Int maximum : {0}", int.MaxValue);
Console.WriteLine("Double minimum : {0}", double.MinValue);
Console.WriteLine("Double maximum : {0}", double.MaxValue);
Console.ReadKey();