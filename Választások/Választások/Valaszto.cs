using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Választások
{
    //választó adatai
    public class Valaszto
    {
        //a valaszto személy edatainak definiálása propertyként
        public string Nev { get; set; }
        public bool IsNo { get; set; }
        public int Szev { get; set; }
        public string Varos { get; set; }

        //Azért kell overridolni, mert alapértelmezésben az obj neve fog a listába bekerülni.
        //Itt tudom megadni azt, hogy hogy nézzen ki a listboxban az adat
        public override string ToString()
        {
            return $"{Nev} ({Szev}) _ {Varos}";
        }
    }

}
