
Console.WriteLine("Kérem a szöveget");
string s = Console.ReadLine();
Console.WriteLine("Mérete");
int meret;

while (!int.TryParse(Console.ReadLine(), out meret))
{
    Console.WriteLine("Nem jó a méret");
}

string[] darabok;

//Tesztesetek
//asdasd  3 > asd asd
//asda 3 > asd a
//a 3 > a
//aaa 3 > aaa

if (s.Length % meret == 0)
{
    darabok = new string[s.Length / meret];
} else
{
    darabok = new string[s.Length / meret + 1];
}

//Darabolás
//Amig van a beneeti sztringben szöveg addig megy a darabolás

int counter = 0;
while (s.Length > 0)
{
    if (s.Length <= meret)
    {
        darabok[counter] = s;
        s = string.Empty;
    }
    else
    {
        darabok[counter] = s.Substring(0,meret);
        s = s.Substring(meret);
    }
    counter++;
}

foreach (string darab in darabok) {  Console.WriteLine(darab); }