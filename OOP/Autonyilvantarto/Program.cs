
using Autonyilvantarto;

Auto a1 = new Auto("JZS039", AutoEnum.Ford);
Auto a2 = new Auto("XXX123", AutoEnum.Ferrari);

//Az átlagfogyasztás adatainak a használata.
a1.Megy(2.1);
a1.Megy(3.5);
a1.Megy(2.5);
a1.Megy(3.5);
a1.Megy(3.45);

a2.Megy(36);
a2.Megy(26);
a2.Megy(46);
a2.Megy(136);
a2.Megy(22);

Console.WriteLine($"Ford fogyasztása : {a1.Atlagfogy()}");
Console.WriteLine($"Ferrari fogyasztása : {a2.Atlagfogy()}");
//Mivel statikus metódus az osztályon kell használni.
Console.WriteLine($"A gépjárműpark száma : {Auto.Allomany()}");