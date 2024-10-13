using DaraboloOsztalyLib;



//példányosítás
Szodarabolo sd1 = new Szodarabolo();
Szodarabolo sd2 = new Szodarabolo();

if (sd1.Adatbekers())
{
    sd1.Kiiras();
}


sd2.Adatbekers();

sd1.Kiiras();
sd2.Kiiras();
sd1.Kiiras();
//Statikus osztálytnem lehet példányosítani, a metódusokból is ki kell szedni a static-ot és így példányszintű metódusok lesznek

Console.WriteLine(sd2.sikeres); //A propertyk kintről elérhetőek, lehetőség van egy korábbi művelet elvégzését ellenőrizni, mit itt