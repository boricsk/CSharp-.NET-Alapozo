bool b = true;
int x = 123;
string s = "alma";
int[] xek = new int[3] {1, 2, 3};

Console.WriteLine(b);
Console.WriteLine(s);
Console.WriteLine(x);
Console.WriteLine(xek[0]);
Console.WriteLine(xek[1]);
Console.WriteLine(xek[2]);


Valtoztato(b, x, s, xek);

Console.WriteLine(b);
Console.WriteLine(s);
Console.WriteLine(x);
Console.WriteLine(xek[0]);
Console.WriteLine(xek[1]);
Console.WriteLine(xek[2]);


static void Valtoztato(bool b1, int x1, string s1, int[] xek)
{
    b1 = false;
    x1 = 321;
    s1 = "Körte";
    xek[1] = 88;
}

//A fenti esetben mindn marad, kikéve a lista 1. eleme. A lista referencia tipus, azaz referenciaként
//adtam át az értéket, ha ezt beküldöm egy változtató algoritmusba, akkor ez az eredeti helyen is változni
//fog, -mert nem értéket, hanem referenciát adok át- mint minden reference type, kivéve a string.
//Az int és a bool value type. Ha ezt a típust átküldöm egy változtatáson az érték megváltozik ugyan, de
//azért marad látszólag ugyanaz, mert ez a típus a változtatás (hívás) utáni ponton a változtatás előtti értékkel
//fog visszatérni.
//A string a kakukktojás,mert igaz, hogy reference type, de value type-ként viselkedik.