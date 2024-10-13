
Console.WriteLine("Kérem a kör sugarát (Egész számot kérek) :");
int r = 0;

//r = int.Parse(Console.ReadLine());
//A beolvasott adat string tipus lesz. A (cast)ReadLine kasztolás itt nem lesz jó.
//Parse átalakít számme gy szöveges reprezentciót

//A tryPars-nak van bool visszatérése, ami mutatja hogy sikeres vagy nem a parszolás.
//Az out r az out result, azaz az r kapja meg a bevitt értéket. Azért kell mert az in value tipus
//Ha egy value type-ot paraméterként átadok akor a változás nem jelenk meg a visszatérési ponton.

//if ( int.TryParse(Console.ReadLine(), out r))
//{
//    Console.WriteLine("Sikeres számolok");
//}
//else
//{
//    Console.WriteLine("Nem jó bevitel");
//}

while (!int.TryParse(Console.ReadLine(), out r))
{
    Console.WriteLine("Nem jó érték!");
}

double ker = 2 * r * Math.PI;
double ter = Math.Pow(r,2) * Math.PI;
Console.WriteLine(ker);
Console.WriteLine(ter);

Console.ReadLine();