namespace Leszarmazas
{
    interface IHaladas
    {
        public int Y { get; set; }
        public void Haladas(int tav);
    }

    public abstract class Eloleny
    {
        public int X { get; set; }
        public abstract void Mozog(int x);
    }
    public class Ember : Eloleny, IHaladas
    {
        public int eletkor { get; set; }
        public int Y { get ; set ; }

        public override string ToString()
        {
            return "Szeva hülyegyerek";
        }

        public virtual void olvas()
        {
            Console.WriteLine("Én még nem olvasok");
        }

        public override void Mozog(int x)
        {
            X += x;
            Console.WriteLine($"Mentem {x} métert. Hol járok : {X}");
        }

        public void Haladas(int tav)
        {
            Y += tav;
            Console.WriteLine($"Hol járok : {Y}");
        }
    }

    public class Diak : Ember
    {
        public override string ToString()
        {
            return "Ez már nem hülyegyerek, hanem okos diák.";
        }
        public override void olvas()
        {
            Console.WriteLine("Olvasgatok");

        }

    }

    public class Tanar : Ember
    {
        public override void olvas()
        {
            Console.WriteLine("Kurvajól olvasok");

        }
        public void Tanit()
        {
            Console.WriteLine("Tanítok");
        }
    }

    public class Auto : IHaladas
    {
        public int Y { get ; set; }

        public void Halad(int x) { Console.WriteLine($"Hol járok : {x}"); }

        public void Haladas(int tav)
        {
            Y += tav;
            Console.WriteLine($"Hol járok : {Y}");
        }
    }
}
