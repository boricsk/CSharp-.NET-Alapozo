using Leszarmazas;

Ember ujember = new Ember();
ujember.Mozog(12);

Console.WriteLine(ujember.ToString());

Diak d1 = new Diak();

Console.WriteLine(d1.ToString());

Tanar t1 = new Tanar();

Console.WriteLine(t1.ToString());

d1.eletkor = 11;
t1.eletkor = 33;
ujember.eletkor = 1;
ujember.olvas();
d1.olvas();
d1.Haladas(35);
d1.Haladas(42);

d1.Mozog(33);
d1.Mozog(66);
t1.olvas();
t1.Mozog(56);
t1.Haladas(3);
t1.Haladas(7);

Auto a = new Auto();
Console.WriteLine(a.ToString());
a.Halad(123);
a.Haladas(256);
a.Haladas(25);

t1.Tanit();

Ember kiserletiember = t1;

List<Ember> emberek = new List<Ember>();
emberek.Add(kiserletiember);
emberek.Add(ujember);
emberek.Add(t1);
emberek.Add(d1);

foreach (Ember ember in emberek)
{
    ember.olvas();
    //embernek nincs tanít tulajdonsága.
}
//SHIFT + ALT télalap szöveg kijelölés.

List<IHaladas> haladok = new List<IHaladas>();
haladok.Add(kiserletiember);
haladok.Add(ujember);
haladok.Add(t1);
haladok.Add(d1);
haladok.Add(a);

foreach (IHaladas h in haladok)
{
    h.Haladas(66);
}