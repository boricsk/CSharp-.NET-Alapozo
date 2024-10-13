using System.Linq;
//1 számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk (pl. 1->8; 5->4; 0->9...)
//CTRL K C - komment készítése
string f1 = "Alma4fa7dolog987";

//készíts megoldási metódust
M1(f1);
Console.WriteLine();
M2(f1);
Console.WriteLine();
M3(f1);
static void M1(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i])
        {
            case '0': Console.Write("9"); break;
            case '1': Console.Write("8"); break;
            case '2': Console.Write("7"); break;
            case '3': Console.Write("6"); break;
            case '4': Console.Write("5"); break;
            case '5': Console.Write("4"); break;
            case '6': Console.Write("3"); break;
            case '7': Console.Write("2"); break;
            case '8': Console.Write("1"); break;
            case '9': Console.Write("0"); break;
            default:
                Console.Write(s[i]); break;

        }
    }
}

static void M2(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i])
        {
            case '0': //ASCII 48
            case '1': 
            case '2':
            case '3':
            case '4': 
            case '5': 
            case '6': 
            case '7': 
            case '8': 
            case '9': Console.Write((char)57 - s[i]); break;
            default:
                Console.Write(s[i]); break;

        }
    }
}

static void M3(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if ((char)s[i] >= 48 & (char)s[i] <= 57)
        {
            Console.Write((char)57 - s[i]);
        }
        else
        {
            Console.Write(s[i]);
        }
    }
}


//2 ó, ió, ció, áció

string f2 = "vakáció";

Console.WriteLine();
M4(f2);
static void M4(string s)
{
    for(int i = s.Length; i>0; i--)
    {
        Console.WriteLine(s.Substring(s.Length - i));
    }

    for (int i = 0 ; i <= s.Length ; i++)
    {
        Console.WriteLine(s.Substring(s.Length - i));
    }
}
Console.WriteLine("----");
//3 minden magánhangzó megduplázása

string f3 = "magánhanzó duplázás";

M31(f3);
Console.WriteLine();
M32(f3);

static void M31(string s)
{
    string maganhangzó = "aáeéiíoóöőuúüű";
    for(int i = 0; i < s.Length; i++)
    {
        for (int j = 0; j < maganhangzó.Length; j++)
        {
            if (s[i] == maganhangzó[j])
            {
                Console.Write(s[i]);
            } else {  }
        }
        Console.Write(s[i]);
    }
}

static void M32(string s)
{
    char[] maganhangzó = { 'a','á','e','é','i','í','o','ó','ö','ő','u','ú','ü','ű' };
    for (int i = 0; i < s.Length; i++)
    {
        if (maganhangzó.Contains(s[i])) {
            Console.Write($"{s[i]}{s[i]}"); } else { Console.Write(s[i]); }
    }
}
Console.WriteLine("----");

//4 magánhangzók cseréje *karakterre

string f4 = "magánhanzó duplázás";

M41(f4);
static void M41(string s)
{
    char[] maganhangzó = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
    for (int i = 0; i < s.Length; i++)
    {
        if (maganhangzó.Contains(s[i]))
        {
            Console.Write("*");
        }
        else { Console.Write(s[i]); }
    }
}
Console.WriteLine("----");

//5 tetszőleges szövegrészlet kivágása (X.helytől Y hosszon) saját eljárással, hibás x és y esetén hibaüzenettel
string f5 = "tetszőleges szövegrészlet kivágása";

M5(f5, 10, 9);
static void M5(string s, int start, int end)
{
    if (start > s.Length) { Console.WriteLine("A kezdő pozíció nagyobb mint a string hossza"); }
    else if (start + end > s.Length) { Console.WriteLine("Hibás hossz"); }
    else
    {
        for (int i = start; i < start + end; i++)
        {
            Console.Write(s[i]);
        }
    }

}
Console.WriteLine("----");

//6 szöveg titkosítása: minden karakterhez hozzá adunk ASCII szerint X értéket (X=1 - nél a helyett b, b helyett c stb.)

string f6 = "Supertitkos szövegABC";

M6(f6, 3);
static void M6(string s, int eltolas)
{
    for (int i = 0; i < s.Length; i++){
        Console.Write((char)(s[i] + eltolas));
    }
}

Console.WriteLine("----");

//7 minden 2.és 3.betű új szövegbe
string f7 = "minden 2.és 3.betű új szövegbe";

M7(f7);
static void M7(string s)
{
    Console.WriteLine(s);
    string newText = string.Empty;
    
    for (int i = 0; i < s.Length; i++)
    {
        if (((i + 1) % 2 == 0) | ((i + 1) % 3 == 0)) { newText += s[i]; } 
    }
    Console.WriteLine(newText);
}
Console.WriteLine("----");

//8 szóközök kicserélés _ jelre
string f8 = "8 szóközök kicserélés _ jelre";

M8(f8);
static void M8(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if ((char)s[i] == 32) { Console.Write("_"); } else { Console.Write(s[i]); }
    }
}
Console.WriteLine("----");

//9 minden karakter megkettőzése: abc->aabbcc
string f9 = "9 minden karakter megkettőzése: abc->aabbcc";

M9(f9);
static void M9(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        Console.Write($"{s[i]}{s[i]}");
    }
}
Console.WriteLine("----");

//10 minden 3.és 5.betű cseréje * -ra
string f10 = "Supertitkos szövegABC";

M10(f10);
static void M10(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (((i+1) % 3 == 0) | ((i+1) % 5 == 0)) { Console.Write("*"); } else { Console.Write(s[i]); }
    }
}
Console.WriteLine("----");

//11 kisbetűből nagybetű és nagybetűből kisbetű(pl.AbC->aBc)


//12 hullámos szöveg (pl. alma -> AlMa)
string f12 = "wfhvnssufgkmfndezrbghu";
M12(f12);
static void M12(string s)
{
    for(int i = 0;i < s.Length; i++)
    {
        if (i % 2 == 0) { Console.Write(char.ToUpper(s[i]));} else { Console.Write(s[i]);}
    }
}
Console.WriteLine("----");

//13 páros és páratlan betűk cseréje(abcd->badc)
string f13 = "13 páros és páratlan betűk cseréje(abcd->badc)";
M13(f13);
static void M13(string s)
{
    Console.Write($"{s[0]}{s[1]}");

    for (int i = 2; i < s.Length; i+=2)
    {
        Console.Write($"{s[i + 1]}{s[i]}");
    } 
}
Console.WriteLine("---------------");

//14 minden számjegy megduplázása
string f14 = "M1nden 5zámjegy megdup1ázása";
M14(f14);
static void M14(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (char.IsDigit(s[i]))
        {
            Console.Write($"{s[i]}{s[i]}");
        }
        else
        {
            {
                Console.Write(s[i]);
            }
        }
    }
}
Console.WriteLine("---------------");

//15 magánhangzók cseréje nagybetűsre(pl.abcde->AbcdE)
string f15 = "magánhanzó csere nagybetűsre";

M15(f15);
static void M15(string s)
{
    char[] maganhangzó = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
    for (int i = 0; i < s.Length; i++)
    {
        if (maganhangzó.Contains(s[i]))
        {
            Console.Write(char.ToUpper(s[i]));
        }
        else { Console.Write(s[i]); }
    }
}
Console.WriteLine("---------------");

//16 Ékezettelenítő (á->a ö, ő->o)
string f16 = "Ékezettelenítés űber ökör kóborol a mezŐn";

M16(f16);
static void M16(string s)
{
    char[] ekezet = { 'á', 'Á', 'é', 'É', 'ő', 'Ő', 'ó', 'Ó', 'ü', 'Ü', 'ú', 'Ú', 'ű', 'Ű', 'í', 'Í', 'ö', 'Ö' };
    char[] sima = { 'a', 'A', 'e', 'e', 'o', 'O', 'o', 'O', 'u', 'U', 'u', 'U', 'u', 'U', 'i', 'I', 'o', 'O' };
    int position = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (ekezet.Contains(s[i]))
        {
            position = 0;
            foreach (char c in ekezet)
            {
                if (c == s[i])
                { 
                    Console.Write(sima[position]);
                }
                position++;
            }
        } else
        {
            Console.Write(s[i]);
        }
    }
}
Console.WriteLine("---------------");

//17 számok cseréje betűre 1->a, 2->b stb.

//18 magánhangzók megszámlálása (angol abc)
string f18 = "magánhangzók megszámlálása angol abc";
M18(f18);
static void M18(string s)
{ 
    char[] maganhangzok = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (maganhangzok.Contains(s[i]))
        {
            count++;
        }
    }
    Console.WriteLine($"A magánhangzók száma : {count} a következő szövegben : {s}");
}
Console.WriteLine("---------------");


//19 szöveg visszafelé

string f19 = "Szöveg visszafelé";
M19(f19);
static void M19(string s)
{
    for (int i = s.Length - 1; i >= 0; i--)
    {
        Console.Write(s[i]);
    }
}
Console.WriteLine("---------------");

//20 minden mássalhangzó megduplázása
string f20 = "minden massalhangzo megduplazasa";
M20(f20);
static void M20(string s)
{
    char[] maganhangzok = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
    for (int i = 0; i < s.Length; i++)
    {
        if (maganhangzok.Contains(s[i]))
        {
            Console.Write(s[i]);
        }
        else
        {
            Console.Write($"{s[i]}{s[i]}");
        }
    }
}
Console.WriteLine("---------------");

//21 számok kiválogatása szövegből(pl.a1b2c3-> 123)
string f21 = "a szamok1 levalogatasa2 a3 stringbol4";
M21(f21);
static void M21(string s)
{
    string result = "";
    for (int i = 0; i < s.Length; i++)
    { 
        if (char.IsDigit(s[i]))
        {
            result += s[i];
        }
    }
    Console.WriteLine(result);
}